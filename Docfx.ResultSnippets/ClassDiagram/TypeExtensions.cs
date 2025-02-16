using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using TypeNameFormatter;

namespace Docfx.ResultSnippets;

internal static class TypeExtensions
{
    private static string AsFormattedName(this Type type)
    {
        return type.GetFormattedName().Replace("<", "&lt");
    }

    private static ParameterModel AsParameterModel(this ParameterInfo info)
    {
        return new ParameterModel(info.Name, info.ParameterType.AsFormattedName());
    }

    private static Type GetUnderlyingType(this MemberInfo member)
    {
#pragma warning disable CS8509
        return member.MemberType switch
#pragma warning restore CS8509
        {
            MemberTypes.Event => ((EventInfo)member).EventHandlerType,
            MemberTypes.Field => ((FieldInfo)member).FieldType,
            MemberTypes.Method => ((MethodInfo)member).ReturnType,
            MemberTypes.Property => ((PropertyInfo)member).PropertyType,
        };
    }

    private static MemberModel AsMemberModel(
        this MemberInfo info,
        MemberVisibility visibility,
        bool isInstance
    )
    {
        return new MemberModel(
            info.Name,
            visibility,
            (isInstance, info) switch
            {
                (isInstance: true, info: PropertyInfo pi)
                    when pi.GetSetMethod()?.IsAbstract == true => MemberModifier.Abstract,
                (isInstance: true, info: MethodInfo { IsAbstract: true }) =>
                    MemberModifier.Abstract,
                (isInstance: false, _) => MemberModifier.Static,
                _ => null,
            },
            info.GetUnderlyingType().AsFormattedName(),
            info is MethodInfo mip ? mip.GetParameters().Select(x => x.AsParameterModel()) : null
        );
    }

    private static bool IsSupportedMember(this MemberInfo? mi)
    {
        return mi?.MemberType
                is MemberTypes.Event
                    or MemberTypes.Field
                    or MemberTypes.Property
                    or MemberTypes.Method
            && mi.GetCustomAttribute<CompilerGeneratedAttribute>() == null
            && mi
                is ((not PropertyInfo) or PropertyInfo { IsSpecialName: false })
                    and ((not MethodInfo) or MethodInfo { IsSpecialName: false });
    }

    internal static ClassModel AsClassModel(this Type type)
    {
        IEnumerable<MemberModel> GetMembers(MemberVisibility visibility, bool isInstance) =>
            type.GetMembers(
                    (visibility, isInstance) switch
                    {
#pragma warning disable S3011
                        (MemberVisibility.Private, isInstance: true) => BindingFlags.NonPublic
                            | BindingFlags.Instance,
                        (MemberVisibility.Private, isInstance: false) => BindingFlags.NonPublic
                            | BindingFlags.Static,
#pragma warning restore S3011
                        (MemberVisibility.Public, isInstance: false) => BindingFlags.Public
                            | BindingFlags.Static,
                        _ => BindingFlags.Public | BindingFlags.Instance,
                    }
                )
                .Where(IsSupportedMember)
                .Select(x => x.AsMemberModel(visibility, isInstance));

        IEnumerable<MemberModel>? members = null;
        IEnumerable<string>? values = null;

        if (type.IsEnum)
        {
            values = Enum.GetNames(type);
        }
        else
        {
            members = GetMembers(MemberVisibility.Public, isInstance: true)
                .Concat(GetMembers(MemberVisibility.Public, isInstance: false))
                .Concat(GetMembers(MemberVisibility.Private, isInstance: true))
                .Concat(GetMembers(MemberVisibility.Private, isInstance: false))
                .OrderBy(x => x.Parameters != null)
                .ThenBy(x => x.Name, StringComparer.OrdinalIgnoreCase);
        }

        return new ClassModel(
            type.AsFormattedName(),
            type switch
            {
                { IsValueType: true } => ClassModifier.Struct,
                { IsAbstract: true, IsInterface: false } => ClassModifier.Abstract,
                { IsInterface: true } => ClassModifier.Interface,
                _ => null,
            },
            members,
            values
        );
    }

    internal static IEnumerable<RelationshipModel> AsInheritanceRelationships(
        this IEnumerable<Type> types
    )
    {
        var relationshipModels = new List<RelationshipModel>();
        var typesList = types.Where(x => !x.IsEnum).ToList();
        var interfaces = typesList.Where(x => x.IsInterface).ToList();
        foreach (var type in typesList)
        {
            // add links to interfaces for other supported types
            relationshipModels.AddRange(
                from @interface in interfaces
                where
                    // 1. interface needs to be inherited
                    // 2. the base type need to be,
                    //   a. null or
                    //   b. not inheriting from the same interface
                    // 3. interface has no other child interfaces the type also inherits from
                    (type.GetInterfaces().Contains(@interface) && type.BaseType == null)
                    || (
                        type.BaseType?.GetInterfaces().Contains(@interface) == false
                        && !type.GetInterfaces()
                            .Intersect(interfaces)
                            .Any(x => x != @interface && x.GetInterfaces().Contains(@interface))
                    )
                select new RelationshipModel(
                    type.AsFormattedName(),
                    @interface.AsFormattedName(),
                    RelationshipType.Inheritence
                )
            );

            if (type.IsInterface)
                continue;

            // for non-interfaces use the base type for inheritance link
            if (type.BaseType != null && typesList.Contains(type.BaseType))
            {
                relationshipModels.Add(
                    new RelationshipModel(
                        type.AsFormattedName(),
                        type.BaseType.AsFormattedName(),
                        RelationshipType.Inheritence
                    )
                );
            }
        }

        return relationshipModels;
    }

    private static bool IsEnumerable(this Type type, out Type? nestedType)
    {
        var enumerableInterface = Array.Find(
            type.GetInterfaces(),
            x =>
                x.IsGenericType
                && typeof(IEnumerable).IsAssignableFrom(x)
                && x.GenericTypeArguments.Length == 1
        );

        enumerableInterface =
            enumerableInterface == null && typeof(IEnumerable).IsAssignableFrom(type)
                ? type
                : enumerableInterface;

        if (enumerableInterface == null || enumerableInterface.GenericTypeArguments.Length == 0)
        {
            nestedType = null;
            return false;
        }

        nestedType = enumerableInterface.GenericTypeArguments[0];
        return true;
    }

    internal static IEnumerable<RelationshipModel> AsMemberRelationships(
        this IEnumerable<Type> types
    )
    {
        var tl = types.ToList();
        return from type in tl
            from model in type.GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .Where(IsSupportedMember)
                .Aggregate(
                    new List<RelationshipModel>(),
                    (lst, x) =>
                    {
                        var ut = x.GetUnderlyingType();

                        if (ut.IsEnumerable(out var it) && it != null && tl.Contains(it))
                        {
                            lst.Add(
                                new RelationshipModel(
                                    type.AsFormattedName(),
                                    it.AsFormattedName(),
                                    RelationshipType.Association,
                                    CardinalityType.ManyToOne,
                                    x.Name
                                )
                            );
                        }
                        else if (
                            Nullable.GetUnderlyingType(ut) is { } innerType
                            && tl.Contains(innerType)
                        )
                        {
                            lst.Add(
                                new RelationshipModel(
                                    type.AsFormattedName(),
                                    innerType.AsFormattedName(),
                                    RelationshipType.Dependency,
                                    CardinalityType.OneToOne,
                                    x.Name
                                )
                            );
                        }
                        else if (tl.Contains(ut))
                        {
                            lst.Add(
                                new RelationshipModel(
                                    type.AsFormattedName(),
                                    ut.AsFormattedName(),
                                    RelationshipType.Association,
                                    CardinalityType.OneToOne,
                                    x.Name
                                )
                            );
                        }

                        return lst;
                    }
                )
            select model;
    }
}
