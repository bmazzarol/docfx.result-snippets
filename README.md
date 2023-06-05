<!-- markdownlint-disable MD033 MD041 -->
<div align="center">

<img src="downloadable-logo.png" alt="Docfx.ResultSnippets" width="150px"/>

# Docfx Result Snippets

[:running: **_Getting Started_**](https://bmazzarol.github.io/docfx.result-snippets/articles/getting-started.html)
[:books: **_Documentation_**](https://bmazzarol.github.io/docfx.result-snippets)

[![Nuget](https://img.shields.io/nuget/v/Docfx.ResultSnippets)](https://www.nuget.org/packages/docfx.result-snippets/)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=bmazzarol_docfx.result-snippets&metric=coverage)](https://sonarcloud.io/summary/new_code?id=bmazzarol_docfx.result-snippets)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=bmazzarol_docfx.result-snippets&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=bmazzarol_docfx.result-snippets)
[![CD Build](https://github.com/bmazzarol/docfx.result-snippets/actions/workflows/cd-build.yml/badge.svg)](https://github.com/bmazzarol/docfx.result-snippets/actions/workflows/cd-build.yml)
[![Check Markdown](https://github.com/bmazzarol/docfx.result-snippets/actions/workflows/check-markdown.yml/badge.svg)](https://github.com/bmazzarol/docfx.result-snippets/actions/workflows/check-markdown.yml)
[![CodeQL](https://github.com/bmazzarol/docfx.result-snippets/actions/workflows/codeql.yml/badge.svg)](https://github.com/bmazzarol/docfx.result-snippets/actions/workflows/codeql.yml)

Include the executed results **_from code_** in your Docfx documentation!

</div>

## Features

* Export results
  to [tables](https://bmazzarol.github.io/docfx.result-snippets/articles/table-results.html)
* Convert `Types`
  to [class diagrams](https://bmazzarol.github.io/docfx.result-snippets/articles/class-diagram-results.html)
* Export results
  to [any format supported by markdig](https://bmazzarol.github.io/docfx.result-snippets/articles/chart-results.html)

```c#
using Docfx.ResultSnippets;

...

// some return value
const string result = "Some result to save";
// now it can be saved as an example
result.SaveResults();
// we can also add a part to the name
"Some other result".SaveResults(partName: "part2");

```

Which generates a Markdown file that can be added via the include file like so,

```markdown
[!INCLUDE[SomeExample](some/path/to/code/__examples__/ClassName.MethodName.{Optional-PartName}.md)]
```

## Getting Started

To use this library, simply include `Docfx.ResultSnippets.dll` in your project
or grab it from [NuGet](https://www.nuget.org/packages/Docfx.ResultSnippets/),
and add this to the top of each `.cs` file that needs it:

```C#
using Docfx.ResultSnippets;
```

## Why?

Docfx has amazing tools for including code snippets in your documentation but
not the results from executing that code.

For some code examples the formatted result of executing that code is as
important as the code itself.

For example code that returns an IEnumerable, the most natural way to show the
result would be a table. This library provides the tools to make it happen and
more.

This code,

```csharp
// some complex data which will convert to a table
var data = Enumerable
    .Range(1, 3)
    .Select(
        i =>
            new
            {
                Name = $"Name {i}",
                Id = i,
                Nested = new { ChildId = i + 1 }
            }
    );
var tableResult = data.AsTableResult();
```

Results in this,

| Name   | Id | Nested        |
|--------|----|---------------|
| Name 1 | 1  | {"ChildId":2} |
| Name 2 | 2  | {"ChildId":3} |
| Name 3 | 3  | {"ChildId":4} |

The aim of this library is to support Markdown friendly code results so
the readers of your documentation can get a complete picture of
what the code will produce. Think of it as serverside rendering of code results,
like a pre executed Jupyter notebook.

For more details/information have a look the documentation, test project or
create an issue.

## Attributions

[Icons created by juicy_fish](https://www.flaticon.com/free-icons)
