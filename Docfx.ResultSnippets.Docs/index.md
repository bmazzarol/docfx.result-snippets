# Docfx Result Snippets

![Docfx Result Snippets](images/downloadable-logo.png)

**Show what the code actually printed.**

Saves the output of a method call to markdown, which a docfx page can include as a table, chart, class diagram or plain snippet.

```shell
dotnet add package Docfx.ResultSnippets
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

[!code-csharp[](../Docfx.ResultSnippets.Tests/ResultExtensionsTests.cs#TableResultExample2)]

Results in this,

[!INCLUDE[TabResultExample2](../Docfx.ResultSnippets.Tests/__examples__/ResultExtensionsTests.Case5.md)]

The aim of this library is to support Markdown friendly code results so
the readers of your documentation can get a complete picture of
what the code will produce. Think of it as serverside rendering of code results,
like a pre executed Jupyter notebook.
