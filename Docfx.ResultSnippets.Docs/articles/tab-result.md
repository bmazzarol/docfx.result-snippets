# Tab Results

Tabs can be created using the @Docfx.ResultSnippets.ResultExtensions.AsTabResult*
extension method.

Any type that extends `IEnumerable<KeyValuePair<string,T>>` can be used.

For example,

[!code-csharp[](../../Docfx.ResultSnippets.Tests/ResultExtensionsTests.cs#TabResultExample1)]

Results in,

[!INCLUDE[TabResultExample1](../../Docfx.ResultSnippets.Tests/__examples__/ResultExtensionsTests.Case3.md)]
