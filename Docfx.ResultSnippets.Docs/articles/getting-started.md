# Getting Started

Add the package, then use it in the test that produces the result,

```shell
dotnet add package Docfx.ResultSnippets
```

```c#
using Docfx.ResultSnippets;
```

The result of a call is written to a markdown file, which a docfx page can then
include,

[!code-csharp[](../../Docfx.ResultSnippets.Tests/ResultExtensionsTests.cs#SaveResultsExample1)]

Which generates a Markdown file that can be added via
the [include file](https://dotnet.github.io/docfx/docs/markdown.html?tabs=linux%2Cdotnet#include-markdown-files)
like so,

```markdown
[!INCLUDE[SomeExample](some/path/to/code/__examples__/ClassName.MethodName.{Optional-PartName}.md)]
```

See <xref:Docfx.ResultSnippets.ResultExtensions.SaveResults*> for more details
about the file name format.
