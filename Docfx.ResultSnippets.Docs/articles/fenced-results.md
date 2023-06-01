# Fenced Results

The @Docfx.ResultSnippets.ResultExtensions.AsFencedResult* extension method
will produce a fenced result with the provided language.

For example,

[!code-csharp[](../../Docfx.ResultSnippets.Tests/ResultExtensionsTests.cs#FenceResultExample1)]

Which produces the fenced `shell` result,

[!INCLUDE[FenceResultExample1](../../Docfx.ResultSnippets.Tests/__examples__/ResultExtensionsTests.Case2.md)]

A special `JSON` fenced result can also be created using
@Docfx.ResultSnippets.ResultExtensions.AsJsonResult*,

[!code-csharp[](../../Docfx.ResultSnippets.Tests/ResultExtensionsTests.cs#JsonResultExample1)]

[!INCLUDE[JsonResultExample1](../../Docfx.ResultSnippets.Tests/__examples__/ResultExtensionsTests.Case6.md)]

This can work well for displaying object results.
