---
uid: Docfx.ResultSnippets.ResultExtensions.SaveResults``1(``0,System.String,System.String,System.String,System.String)
example:
- Example `SaveResults` usage,

  [!code-csharp[](../../Docfx.ResultSnippets.Tests/ResultExtensionsTests.cs#SaveResultsExample1)]

  Results in,

  [!INCLUDE[SaveResultsExample1](../../Docfx.ResultSnippets.Tests/__examples__/ResultExtensionsTests.Case1.md)]
---

---
uid: Docfx.ResultSnippets.ResultExtensions.AsFencedResult``1(``0,System.String)
example:
- Example `AsFencedResult` usage,

  [!code-csharp[](../../Docfx.ResultSnippets.Tests/ResultExtensionsTests.cs#FenceResultExample1)]

  Results in,

  [!INCLUDE[FenceResultExample1](../../Docfx.ResultSnippets.Tests/__examples__/ResultExtensionsTests.Case2.md)]
---

---
uid: Docfx.ResultSnippets.ResultExtensions.AsTabResult``1(System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{System.String,``0}})
example:
- Example `AsTabResult` usage,

  [!code-csharp[](../../Docfx.ResultSnippets.Tests/ResultExtensionsTests.cs#TabResultExample1)]

  Results in,

  [!INCLUDE[TabResultExample1](../../Docfx.ResultSnippets.Tests/__examples__/ResultExtensionsTests.Case3.md)]
---

---
uid: Docfx.ResultSnippets.ResultExtensions.AsTableResult``1(System.Collections.Generic.IEnumerable{``0},System.Text.Json.JsonSerializerOptions,System.String)
example:
- Example `AsTableResult` usage for simple types,

  [!code-csharp[](../../Docfx.ResultSnippets.Tests/ResultExtensionsTests.cs#TableResultExample1)]

  Results in,

  [!INCLUDE[TabResultExample1](../../Docfx.ResultSnippets.Tests/__examples__/ResultExtensionsTests.Case4.md)]

- Example `AsTableResult` usage for complex types where the properties/fields become columns,

  [!code-csharp[](../../Docfx.ResultSnippets.Tests/ResultExtensionsTests.cs#TableResultExample2)]

  Results in,

  [!INCLUDE[TabResultExample2](../../Docfx.ResultSnippets.Tests/__examples__/ResultExtensionsTests.Case5.md)]

---

---
uid: Docfx.ResultSnippets.ResultExtensions.AsJsonResult``1(``0,System.Text.Json.JsonSerializerOptions)
example:
- Example `AsJsonResult` usage,

  [!code-csharp[](../../Docfx.ResultSnippets.Tests/ResultExtensionsTests.cs#JsonResultExample1)]

  Results in,

  [!INCLUDE[JsonResultExample1](../../Docfx.ResultSnippets.Tests/__examples__/ResultExtensionsTests.Case6.md)]
---