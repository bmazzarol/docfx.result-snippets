#pragma warning disable CS0414, CS0067

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BunsenBurner;
using VerifyXunit;
using Xunit;

namespace Docfx.ResultSnippets.Tests;

[UsesVerify]
public static class ClassDiagramTests
{
    #region ClassDiagramExample1

    class Person
    {
        public static string TypeName = nameof(Person);
        private static int TypeNameHashCode = nameof(Person).GetHashCode();

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public event Func<int>? SomeEvent;

        public string FullName() => $"{LastName} {LastName}";

        public Person WithFullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            return this;
        }
    }

    [Fact(DisplayName = "Create a ClassDiagram from a simple class")]
    public static async Task Case1()
    {
        var result = ClassDiagramBuilder.Create(
            new[] { typeof(Person) },
            // remove all generated relationships
            relationshipModelTransformer: _ => Enumerable.Empty<RelationshipModel>()
        );
        result.SaveResults();

        await Verifier.Verify(result).UseDirectory("__snapshots__");
    }

    #endregion

    #region ClassDiagramExample2

    enum Colour
    {
        Red,
        Green,
        Blue
    }

    [Fact(DisplayName = "Create a ClassDiagram from an enum")]
    public static async Task Case2()
    {
        var result = ClassDiagramBuilder.Create(new[] { typeof(Colour) });
        result.SaveResults();

        await Verifier.Verify(result).UseDirectory("__snapshots__");
    }

    #endregion

    #region ClassDiagramExample3

    interface IAnimalExample
    {
        void Eat();

        string Call();
    }

    [Fact(DisplayName = "Create a ClassDiagram from an interface")]
    public static async Task Case3()
    {
        var result = ClassDiagramBuilder.Create(new[] { typeof(IAnimalExample) });
        result.SaveResults();

        await Verifier.Verify(result).UseDirectory("__snapshots__");
    }

    #endregion

    #region ClassDiagramExample4

    abstract class BaseAnimal
    {
        protected abstract void Eat();

        protected abstract string Call();
    }

    [Fact(DisplayName = "Create a ClassDiagram from an abstract class")]
    public static async Task Case4()
    {
        var result = ClassDiagramBuilder.Create(new[] { typeof(BaseAnimal) });
        result.SaveResults();

        await Verifier.Verify(result).UseDirectory("__snapshots__");
    }

    #endregion

    #region ClassDiagramExample5

    class GenericClass<T>
    {
        public T? SomeT { get; set; }

        public IEnumerable<T> MoreT() => Enumerable.Empty<T>();
    }

    [Fact(DisplayName = "Create a ClassDiagram from a generic class")]
    public static async Task Case5()
    {
        var result = ClassDiagramBuilder.Create(
            new[]
            {
                typeof(GenericClass<string>),
                typeof(GenericClass<int>),
                typeof(GenericClass<List<Person>>)
            }
        );
        result.SaveResults();

        await Verifier.Verify(result).UseDirectory("__snapshots__");
    }

    #endregion

    #region ClassDiagramExample6

    interface ILifeform
    {
        void Breethe();
    }

    interface IAnimal : ILifeform
    {
        void Eat();

        string Call();
    }

    abstract class Bird : IAnimal
    {
        public void Eat() => throw new System.NotImplementedException();

        public abstract string Call();

        public void Breethe() => throw new System.NotImplementedException();
    }

    class Duck : Bird
    {
        public override string Call() => "Quack Quack";
    }

    class Swan : Bird
    {
        public override string Call() => "Honk Honk";
    }

    class Dog : IAnimal
    {
        public void Eat() => throw new System.NotImplementedException();

        public string Call() => "Woof Woof";

        public void Breethe() => throw new System.NotImplementedException();
    }

    [Fact(DisplayName = "Create a ClassDiagram with inheritance")]
    public static async Task Case6()
    {
        var result = ClassDiagramBuilder.Create(
            new[]
            {
                typeof(ILifeform),
                typeof(IAnimal),
                typeof(Bird),
                typeof(Swan),
                typeof(Duck),
                typeof(Dog)
            }
        );
        result.SaveResults();

        await Verifier.Verify(result).UseDirectory("__snapshots__");
    }

    #endregion

    #region ClassDiagramExample7

    class Teacher
    {
        public IEnumerable<Child> Teaches { get; set; } = null!;
    }

    class Child
    {
        public Teacher Teacher { get; set; } = null!;
    }

    class Classroom
    {
        public Teacher Teacher { get; set; } = null!;
        public IEnumerable<Child> Children { get; set; } = null!;
    }

    class School
    {
        public IEnumerable<Classroom> Classrooms { get; set; } = null!;

        public Teacher Headmaster() => Classrooms.Select(x => x.Teacher).First();
    }

    [Fact(DisplayName = "Create a ClassDiagram with association")]
    public static async Task Case7()
    {
        var result = ClassDiagramBuilder.Create(
            new[] { typeof(Teacher), typeof(Child), typeof(Classroom), typeof(School) }
        );
        result.SaveResults();

        await Verifier.Verify(result).UseDirectory("__snapshots__");
    }

    #endregion

    [Fact(DisplayName = "CreateClassDiagram throws if no types are passed")]
    public static async Task Case8() =>
        await Enumerable
            .Empty<Type>()
            .ArrangeData()
            .Act(empty => ClassDiagramBuilder.Create(empty))
            .AssertFailsWith(
                (ArgumentException e) =>
                    e.ParamName == "types"
                    && e.Message == "At least 1 type needs to be provided (Parameter 'types')"
            );

    [Fact(DisplayName = "Create a ClassDiagram from assembly")]
    public static async Task Case9()
    {
        #region ClassDiagramAssembly

        var result = ClassDiagramBuilder.Create(
            new[] { typeof(ClassDiagramBuilder).Assembly },
            type =>
                type.IsPublic
                && !type.Name.Contains("ClassDiagramBuilder")
                && !type.Name.Contains("ModelTransformer")
                && !type.Name.Contains("ResultExtensions"),
            // filter out all non-public members
            classModelTransformer: classes =>
                classes.Select(
                    @class =>
                        @class with
                        {
                            Members = @class.Members?.Where(
                                member => member.Visibility is MemberVisibility.Public
                            )
                        }
                )
        );
        result.SaveResults();

        #endregion

        await Verifier.Verify(result).UseDirectory("__snapshots__");
    }

    #region ClassDiagramExample8

    public class CustomList : List<int> { }

    [Fact(DisplayName = "Create a ClassDiagram from a type exploded")]
    public static async Task Case10()
    {
        var result = ClassDiagramBuilder.Create(
            typeof(List<int>),
            assemblyTransformer: assemblies => assemblies.Append(typeof(ClassDiagramTests).Assembly)
        );

    #endregion

        result.SaveResults();

        await Verifier.Verify(result).UseDirectory("__snapshots__");
    }

    [Fact(DisplayName = "ClassDiagram supports all relationships")]
    public static async Task Case11()
    {
        #region ClassDiagramExample9

        var result = ClassDiagramBuilder.Create(
            Enumerable.Empty<ClassModel>(),
            new[]
            {
                new RelationshipModel("classA", "classB", RelationshipType.Inheritence),
                new RelationshipModel("classC", "classD", RelationshipType.Composition),
                new RelationshipModel("classE", "classF", RelationshipType.Aggregation),
                new RelationshipModel("classG", "classH", RelationshipType.Association),
                new RelationshipModel("classI", "classJ", RelationshipType.LinkSolid),
                new RelationshipModel("classK", "classL", RelationshipType.Dependency),
                new RelationshipModel("classM", "classN", RelationshipType.Realization),
                new RelationshipModel("classO", "classP", RelationshipType.LinkDashed)
            }
        );

        #endregion

        result.SaveResults();

        await Verifier.Verify(result).UseDirectory("__snapshots__");
    }

    [Fact(DisplayName = "ClassDiagram supports notes")]
    public static async Task Case12()
    {
        #region ClassDiagramExample10

        var result = ClassDiagramBuilder.Create(
            new[] { new ClassModel("test", Notes: "This is a test note") },
            Enumerable.Empty<RelationshipModel>()
        );

        #endregion

        result.SaveResults();

        await Verifier.Verify(result).UseDirectory("__snapshots__");
    }

    [Fact(DisplayName = "ClassDiagram supports all cardinality types")]
    public static async Task Case13()
    {
        #region ClassDiagramExample11

        var result = ClassDiagramBuilder.Create(
            Enumerable.Empty<ClassModel>(),
            new[]
            {
                new RelationshipModel(
                    "classA",
                    "classB",
                    RelationshipType.Association,
                    CardinalityType.OneToOne
                ),
                new RelationshipModel(
                    "classC",
                    "classD",
                    RelationshipType.Association,
                    CardinalityType.OneToMany
                ),
                new RelationshipModel(
                    "classE",
                    "classF",
                    RelationshipType.Association,
                    CardinalityType.ManyToOne
                ),
                new RelationshipModel(
                    "classG",
                    "classH",
                    RelationshipType.Association,
                    CardinalityType.ManyToMany
                )
            }
        );

        #endregion

        result.SaveResults();

        await Verifier.Verify(result).UseDirectory("__snapshots__");
    }

    [Fact(DisplayName = "ClassDiagram supports all member visibility types")]
    public static async Task Case14()
    {
        #region ClassDiagramExample12

        var result = ClassDiagramBuilder.Create(
            new[]
            {
                new ClassModel(
                    "Test",
                    Members: new[]
                    {
                        new MemberModel("Public", MemberVisibility.Public, TypeName: "string"),
                        new MemberModel("Private", MemberVisibility.Private, TypeName: "string"),
                        new MemberModel(
                            "Protected",
                            MemberVisibility.Protected,
                            TypeName: "string"
                        ),
                        new MemberModel("Internal", MemberVisibility.Internal, TypeName: "string"),
                    }
                )
            },
            Enumerable.Empty<RelationshipModel>()
        );

        #endregion

        result.SaveResults();

        await Verifier.Verify(result).UseDirectory("__snapshots__");
    }

    [Fact(DisplayName = "ClassDiagram supports primitive types")]
    public static async Task Case15()
    {
        #region ClassDiagramExample13

        var result = ClassDiagramBuilder.Create(typeof(int));

        #endregion

        result.SaveResults();

        await Verifier.Verify(result).UseDirectory("__snapshots__");
    }

    [Fact(DisplayName = "Re-create the animal example from the mermaid documentation")]
    public static async Task Case16()
    {
        #region ClassDiagramExample14

        var result = ClassDiagramBuilder.Create(
            new[]
            {
                new ClassModel(
                    "Animal",
                    Members: new[]
                    {
                        new MemberModel("age", MemberVisibility.Public, TypeName: "int"),
                        new MemberModel("gender", MemberVisibility.Public, TypeName: "String"),
                        new MemberModel(
                            "isMammal",
                            MemberVisibility.Public,
                            Parameters: Enumerable.Empty<ParameterModel>()
                        ),
                        new MemberModel(
                            "mate",
                            MemberVisibility.Public,
                            Parameters: Enumerable.Empty<ParameterModel>()
                        ),
                    },
                    Notes: "can fly\ncan swim\ncan dive\ncan help in debugging"
                ),
                new ClassModel(
                    "Duck",
                    Members: new[]
                    {
                        new MemberModel("beakColor", MemberVisibility.Public, TypeName: "String"),
                        new MemberModel(
                            "swim",
                            MemberVisibility.Public,
                            Parameters: Enumerable.Empty<ParameterModel>()
                        ),
                        new MemberModel(
                            "quack",
                            MemberVisibility.Public,
                            Parameters: Enumerable.Empty<ParameterModel>()
                        ),
                    }
                ),
                new ClassModel(
                    "Fish",
                    Members: new[]
                    {
                        new MemberModel("sizeInFeet", MemberVisibility.Private, TypeName: "int"),
                        new MemberModel(
                            "canEat",
                            MemberVisibility.Public,
                            Parameters: Enumerable.Empty<ParameterModel>()
                        ),
                    }
                ),
                new ClassModel(
                    "Zebra",
                    Members: new[]
                    {
                        new MemberModel("is_wild", MemberVisibility.Public, TypeName: "bool"),
                        new MemberModel(
                            "run",
                            MemberVisibility.Public,
                            Parameters: Enumerable.Empty<ParameterModel>()
                        )
                    }
                )
            },
            new[]
            {
                new RelationshipModel("Duck", "Animal", RelationshipType.Inheritence),
                new RelationshipModel("Fish", "Animal", RelationshipType.Inheritence),
                new RelationshipModel("Zebra", "Animal", RelationshipType.Inheritence)
            }
        );

        result.SaveResults();

        #endregion


        await Verifier.Verify(result).UseDirectory("__snapshots__");
    }
}
