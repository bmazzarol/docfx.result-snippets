# Save Results

This library works by converting a result to a markdown file.

The files are saved alongside the code that produced the result.

This can then be included in the documentation
via [includes](https://dotnet.github.io/docfx/docs/markdown.html?tabs=linux%2Cdotnet#include-markdown-files)

The <xref:Docfx.ResultSnippets.ResultExtensions.SaveResults*> extension
method will call `ToString` on any given `T` and save the result of that to
a file with the following name format relative to the code that produced the
result,

```shell
./__examples__/{ClassName}.{MemberName}(.{PartName}).md
```

## Non Deterministic Examples

If the generated result is non-deterministic
<xref:Docfx.ResultSnippets.ResultExtensions.SaveResults*> can be called with the
`replaceExisting` flag set to `false`.

This will ensure the file is only created the first time and its only replaced
once the file is removed.

[!code-csharp[](../../Docfx.ResultSnippets.Tests/ResultExtensionsTests.cs#SaveResultsExample2)]
