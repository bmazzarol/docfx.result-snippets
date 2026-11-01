![Docfx Result Snippets](https://raw.githubusercontent.com/bmazzarol/docfx.result-snippets/main/downloadable-small-logo.png)

# Docfx Result Snippets

**Show what the code printed.**

Saves the output of a method call to markdown, which a docfx page can include as a table, chart, class diagram or plain snippet.

[![Nuget](https://img.shields.io/nuget/v/Docfx.ResultSnippets)](https://www.nuget.org/packages/Docfx.ResultSnippets/)

```shell
dotnet add package Docfx.ResultSnippets
```

[Getting started](https://bmazzarol.github.io/docfx.result-snippets/articles/getting-started.html) - [Full documentation](https://bmazzarol.github.io/docfx.result-snippets/)

## Why?

Docfx includes code snippets, but not the result of running that code. For some
examples the output matters as much as the code that produced it.

This library writes the result of a call to a markdown file next to the code that
produced it, which a docfx page pulls in with an include:

```markdown
[!INCLUDE[SomeExample](some/path/to/code/__examples__/ClassName.MethodName.{Optional-PartName}.md)]
```

## First example

```csharp
using Docfx.ResultSnippets;

// some return value
const string result = "Some result to save";
result.SaveResults();

// a part name can be added to the file name
"Some other result".SaveResults(partName: "part2");
```

The file is written relative to the code that produced the result, as
`./__examples__/{ClassName}.{MemberName}.{PartName}.md`.

## Result types

- [Table results](https://bmazzarol.github.io/docfx.result-snippets/articles/table-results.html) -
  a collection rendered as a markdown table
- [Class diagram results](https://bmazzarol.github.io/docfx.result-snippets/articles/class-diagram-results.html) -
  a type drawn as a diagram
- [Fenced results](https://bmazzarol.github.io/docfx.result-snippets/articles/fenced-results.html) -
  any value as a fenced code block
- [Tab results](https://bmazzarol.github.io/docfx.result-snippets/articles/tab-result.html) -
  several results in one tabbed block

## What it does not do

- It does not run the code. The test that produces the result has to run
- It does not render anything in docfx by itself. The generated markdown is
  pulled in with an include
- It does not track stale results. If the code changes, the test has to run
  again for the docs to change

## See also

- [Getting started](https://bmazzarol.github.io/docfx.result-snippets/articles/getting-started.html)
- [Save results](https://bmazzarol.github.io/docfx.result-snippets/articles/save-result.html)

## Attributions

[Icons created by juicy_fish](https://www.flaticon.com/free-icons)
