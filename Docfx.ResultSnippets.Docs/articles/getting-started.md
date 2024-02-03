# Getting Started

To use this library, simply include `Docfx.ResultSnippets.dll` in your project
or grab it from [NuGet](https://www.nuget.org/packages/Docfx.ResultSnippets/),
and add this to the top of each `.cs` file that needs it:

```C#
using Docfx.ResultSnippets;
```

Then you can use it in a project like this,

[!code-csharp[](../../Docfx.ResultSnippets.Tests/ResultExtensionsTests.cs#SaveResultsExample1)]

Which generates a Markdown file that can be added via
the [include file](https://dotnet.github.io/docfx/docs/markdown.html?tabs=linux%2Cdotnet#include-markdown-files)
like so,

```markdown
[!INCLUDE[SomeExample](some/path/to/code/__examples__/ClassName.MethodName.{Optional-PartName}.md)]
```

See <xref:Docfx.ResultSnippets.ResultExtensions.SaveResults*> for more details
about the file name format.
