# Table Results

Markdown tables can be created using the @Docfx.ResultSnippets.ResultExtensions.AsTableResult*
extension method.

Any type that extends `IEnumerable<>` can be used.

If the type is a simple type it is rendered in a single column like this,

[!code-csharp[](../../Docfx.ResultSnippets.Tests/ResultExtensionsTests.cs#TableResultExample1)]

Building the following table,

[!INCLUDE[TabResultExample1](../../Docfx.ResultSnippets.Tests/__examples__/ResultExtensionsTests.Case4.md)]

Multi column tables can be created from POCOs and Anonymous types like this,

[!code-csharp[](../../Docfx.ResultSnippets.Tests/ResultExtensionsTests.cs#TableResultExample2)]

Building a table like this,

[!INCLUDE[TabResultExample2](../../Docfx.ResultSnippets.Tests/__examples__/ResultExtensionsTests.Case5.md)]

Nested complex types are serialized using JSON.
