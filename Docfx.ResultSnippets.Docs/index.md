# Docfx Result Snippets

![Docfx Result Snippets](images/downloadable-logo.png)

**Show what the code printed.**

Saves the output of a method call to markdown, which a docfx page can include as a table, chart, class diagram or plain snippet.

```shell
dotnet add package Docfx.ResultSnippets
```

## Why?

docfx can include a code snippet from a test file, but it cannot include the
result of running that snippet. A reader sees the code and has to imagine what
it produced.

This library writes the result next to the code. A test runs, the result is
saved as a markdown file, and the docs page includes that file.

```c#
using Docfx.ResultSnippets;

var data = Enumerable
    .Range(1, 3)
    .Select(i => new
    {
        Name = $"Name {i}",
        Id = i,
        Nested = new { ChildId = i + 1 },
    });

string tableResult = data.ToTableResult();
tableResult.SaveResults();
```

writes a markdown file containing,

```markdown
|Name|Id|Nested|
|-|-|-|
|Name 1|1|{"ChildId":2}|
|Name 2|2|{"ChildId":3}|
|Name 3|3|{"ChildId":4}|
```

The same pattern works for fenced text, tab separated output, tables, class
diagrams and json.

## What it does not do

* It does not run the code. The test that produces the result runs in the test
  project
* It does not render anything in docfx by itself; the generated markdown is
  pulled in with `[!INCLUDE[...] ]`
* It does not track stale results. If the code changes, the test has to run
  again for the docs to change

## See also

* [Getting Started](articles/getting-started.md) - save a result and include it
* [Table Results](articles/table-results.md) - the most common result type
* [Class Diagram Results](articles/class-diagram-results.md) - drawing types
  from the code under test
