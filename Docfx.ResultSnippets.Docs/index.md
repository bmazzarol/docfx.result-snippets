<!-- markdownlint-disable MD033 MD041 -->
<div align="center">

<img src="images/downloadable-logo.png" alt="Docfx.ResultSnippets" width="150px"/>

# Docfx Result Snippets

---

[![Nuget](https://img.shields.io/nuget/v/docfx.result-snippets)](https://www.nuget.org/packages/docfx.result-snippets/)
[![Coverage Status](https://coveralls.io/repos/github/bmazzarol/docfx.result-snippets/badge.svg?branch=main)](https://coveralls.io/github/bmazzarol/docfx.result-snippets?branch=main)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=bmazzarol_docfx.result-snippets&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=bmazzarol_docfx.result-snippets)
[![CD Build](https://github.com/bmazzarol/docfx.result-snippets/actions/workflows/cd-build.yml/badge.svg)](https://github.com/bmazzarol/docfx.result-snippets/actions/workflows/cd-build.yml)
[![Check Markdown](https://github.com/bmazzarol/docfx.result-snippets/actions/workflows/check-markdown.yml/badge.svg)](https://github.com/bmazzarol/docfx.result-snippets/actions/workflows/check-markdown.yml)
[![CodeQL](https://github.com/bmazzarol/docfx.result-snippets/actions/workflows/codeql.yml/badge.svg)](https://github.com/bmazzarol/docfx.result-snippets/actions/workflows/codeql.yml)

Include the executed results **_from code_** in your Docfx documentation!

---

</div>
<!-- markdownlint-enable MD033 MD041 -->

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
