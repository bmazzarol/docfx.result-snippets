using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Docfx.ResultSnippets;

/// <summary>
/// Methods for building mermaid class diagrams
/// </summary>
public static class ClassDiagramBuilder
{
    [Pure]
    private static IEnumerable<Type> AsTypes(
        this IEnumerable<Assembly> assemblies,
        Func<Type, bool>? typeFilter
    ) =>
        from assembly in assemblies
        from type in assembly.GetTypes()
        where typeFilter == null || typeFilter(type)
        select type;

    /// <summary>
    /// Creates a class diagram from a type including all related types
    /// </summary>
    /// <param name="type">type</param>
    /// <param name="assemblyTransformer">optional assembly transformer, can be used to add assemblies other than the current types assembly</param>
    /// <param name="typeFilter">optional type filter</param>
    /// <param name="classModelTransformer">optional class model transformer</param>
    /// <param name="relationshipModelTransformer">optional relationship model transformer</param>
    /// <returns>class model</returns>
    /// <exception cref="ArgumentException">if no types are provided</exception>
    public static string Create(
        Type type,
        ModelTransformer<Assembly>? assemblyTransformer = default,
        Func<Type, bool>? typeFilter = default,
        ModelTransformer<ClassModel>? classModelTransformer = default,
        ModelTransformer<RelationshipModel>? relationshipModelTransformer = default
    )
    {
        var at = assemblyTransformer ?? (_ => _);
        return Create(
            new[] { type }
                .Concat(type.GetInterfaces())
                .Concat(
                    at(new[] { type.Assembly })
                        .AsTypes(typeFilter)
                        .Where(x => x != type && type.IsAssignableFrom(x))
                ),
            classModelTransformer,
            relationshipModelTransformer
        );
    }

    /// <summary>
    /// Creates a class diagram from a provided set of assemblies
    /// </summary>
    /// <param name="assemblies">assemblies</param>
    /// <param name="typeFilter">optional type filter</param>
    /// <param name="classModelTransformer">optional class model transformer</param>
    /// <param name="relationshipModelTransformer">optional relationship model transformer</param>
    /// <returns>class model</returns>
    /// <exception cref="ArgumentException">if no types are provided</exception>
    public static string Create(
        IEnumerable<Assembly> assemblies,
        Func<Type, bool>? typeFilter = default,
        ModelTransformer<ClassModel>? classModelTransformer = default,
        ModelTransformer<RelationshipModel>? relationshipModelTransformer = default
    ) =>
        Create(assemblies.AsTypes(typeFilter), classModelTransformer, relationshipModelTransformer);

    /// <summary>
    /// Creates a class diagram from a provided set of types
    /// </summary>
    /// <param name="types">types</param>
    /// <param name="classModelTransformer">optional class model transformer</param>
    /// <param name="relationshipModelTransformer">optional relationship model transformer</param>
    /// <returns>class model</returns>
    /// <exception cref="ArgumentException">if no types are provided</exception>
    public static string Create(
        IEnumerable<Type> types,
        ModelTransformer<ClassModel>? classModelTransformer = default,
        ModelTransformer<RelationshipModel>? relationshipModelTransformer = default
    )
    {
        var distinctTypes = types.Distinct().ToList();
        if (!distinctTypes.Any())
            throw new ArgumentException("At least 1 type needs to be provided", nameof(types));

        var classModels = distinctTypes.Select(x => x.AsClassModel());
        if (classModelTransformer != null)
            classModels = classModelTransformer(classModels);

        var (ir, mr) = (
            distinctTypes.AsInheritanceRelationships(),
            distinctTypes.AsMemberRelationships()
        );
        var relationshipModels = mr.Concat(ir);
        if (relationshipModelTransformer != null)
            relationshipModels = relationshipModelTransformer(relationshipModels);

        return Create(classModels, relationshipModels);
    }

    /// <summary>
    /// Creates a class diagram from a provided set of models
    /// </summary>
    /// <param name="classModels">class models</param>
    /// <param name="relationshipModels">relationship models</param>
    /// <returns>class diagram</returns>
    public static string Create(
        IEnumerable<ClassModel> classModels,
        IEnumerable<RelationshipModel> relationshipModels
    )
    {
        var sb = new StringBuilder();

        sb.AppendLine("```mermaid").AppendLine("classDiagram");

        foreach (
            var relationshipModel in relationshipModels
                .OrderBy(x => x.Type)
                .ThenBy(x => x.FromType, StringComparer.OrdinalIgnoreCase)
                .ThenBy(x => x.ToType, StringComparer.OrdinalIgnoreCase)
        )
        {
            WriteRelationshipModel(relationshipModel, sb);
        }

        foreach (
            var classModel in classModels.OrderBy(x => x.Name, StringComparer.OrdinalIgnoreCase)
        )
        {
            WriteClassDefinition(classModel, sb);
        }

        sb.AppendLine("```");

        return sb.ToString();
    }

    private static void WriteMemberModel(string className, MemberModel model, in StringBuilder sb)
    {
        sb.Append(className)
            .Append(" : ")
            .Append(
#pragma warning disable CS8524
                model.Visibility switch
#pragma warning restore CS8524
                {
                    MemberVisibility.Public => '+',
                    MemberVisibility.Private => '-',
                    MemberVisibility.Protected => '#',
                    MemberVisibility.Internal => '~',
                }
            );

        if (model.Parameters == null)
        {
            sb.Append(model.TypeName).Append(' ').Append(model.Name);
        }

        if (model.Parameters != null)
        {
            sb.Append(model.Name).Append('(');

            foreach (var (param, i) in model.Parameters.Select((x, i) => (x, i)))
            {
                if (i > 0)
                    sb.Append(", ");
                sb.Append(param.TypeName).Append(' ').Append(param.Name);
            }

            sb.Append(") ").Append(model.TypeName);
        }

        switch (model.Modifier)
        {
            case MemberModifier.Static:
                sb.Append('$');
                break;
            case MemberModifier.Abstract:
                sb.Append('*');
                break;
        }

        sb.AppendLine();
    }

    private static void WriteClassDefinition(ClassModel model, in StringBuilder sb)
    {
        var name = $"`{model.Name}`";

        if (!string.IsNullOrWhiteSpace(model.Notes))
        {
            sb.Append("note for ")
                .Append(name)
                .Append(' ')
                .Append('"')
                .Append(model.Notes)
                .Append('"')
                .AppendLine();
        }

        sb.Append("class ").AppendLine(name);

        if (model.Values?.Any() == true)
        {
            sb.Append("<<enumeration>> ").AppendLine(name);
            foreach (var enumName in model.Values.OrderBy(_ => _, StringComparer.OrdinalIgnoreCase))
                sb.Append(name).Append(": ").AppendLine(enumName);
            return;
        }

        switch (model.Modifier)
        {
            case ClassModifier.Abstract:
                sb.Append("<<abstract>> ").AppendLine(name);
                break;
            case ClassModifier.Interface:
                sb.Append("<<interface>> ").AppendLine(name);
                break;
            case ClassModifier.Struct:
                sb.Append("<<struct>> ").AppendLine(name);
                break;
        }

        if (model.Members == null)
            return;

        foreach (var member in model.Members)
            WriteMemberModel(name, member, sb);
    }

    private static void WriteRelationshipModel(RelationshipModel model, in StringBuilder sb)
    {
        sb.Append('`').Append(model.ToType).Append('`');

        if (model.Cardinality != null)
        {
#pragma warning disable CS8524
            sb.Append(
                model.Cardinality switch
                {
                    CardinalityType.OneToOne => " \"1\" ",
                    CardinalityType.ManyToOne => " \"*\" ",
                    CardinalityType.OneToMany => " \"1\" ",
                    CardinalityType.ManyToMany => " \"*\" ",
                }
            );
        }

        sb.Append(
            model.Type switch
            {
                RelationshipType.Inheritence => " <|-- ",
                RelationshipType.Association => " <-- ",
                RelationshipType.Composition => " *-- ",
                RelationshipType.Aggregation => " o-- ",
                RelationshipType.LinkSolid => " -- ",
                RelationshipType.Dependency => " <.. ",
                RelationshipType.Realization => " <|.. ",
                RelationshipType.LinkDashed => " .. ",
            }
        );

        if (model.Cardinality != null)
        {
#pragma warning disable CS8524
            sb.Append(
                model.Cardinality switch
                {
                    CardinalityType.OneToOne => " \"1\" ",
                    CardinalityType.ManyToOne => " \"1\" ",
                    CardinalityType.OneToMany => " \"*\" ",
                    CardinalityType.ManyToMany => " \"*\" ",
                }
            );
        }

#pragma warning restore CS8524
        sb.Append('`').Append(model.FromType).Append('`');

        if (model.Label != null)
        {
            sb.Append(" : ").AppendLine(model.Label ?? string.Empty);
        }
        else
        {
            sb.AppendLine();
        }
    }
}
