# Class Diagrams

The <xref:Docfx.ResultSnippets.ClassDiagramBuilder.Create*> methods
support
creating [mermaid class diagrams](https://mermaid.js.org/syntax/classDiagram.html)

## Manual

There is a programmatic API that allows for custom class diagrams from code

[!code-csharp[](../../Docfx.ResultSnippets.Tests/ClassDiagramTests.cs#ClassDiagramExample14)]

[!INCLUDE[ClassDiagramExample1](../../Docfx.ResultSnippets.Tests/__examples__/ClassDiagramTests.Case16.md)]

## From Types

Given a set of `Types` it can generate a class diagram and automatic
relationships,

[!code-csharp[](../../Docfx.ResultSnippets.Tests/ClassDiagramTests.cs#ClassDiagramExample6)]

[!INCLUDE[ClassDiagramExample6](../../Docfx.ResultSnippets.Tests/__examples__/ClassDiagramTests.Case6.md)]

## From a single Type

Given a single `Type` it can build a full class diagram for that `Type` and all
related `Types`

[!code-csharp[](../../Docfx.ResultSnippets.Tests/ClassDiagramTests.cs#ClassDiagramExample8)]

[!INCLUDE[ClassDiagramExample8](../../Docfx.ResultSnippets.Tests/__examples__/ClassDiagramTests.Case10.md)]

## From Assemblies

Given a set of `Assemblies` it can build a class diagram from all exposed types

[!code-csharp[](../../Docfx.ResultSnippets.Tests/ClassDiagramTests.cs#ClassDiagramAssembly)]

[!INCLUDE[ClassDiagramAssembly](../../Docfx.ResultSnippets.Tests/__examples__/ClassDiagramTests.Case9.md)]
