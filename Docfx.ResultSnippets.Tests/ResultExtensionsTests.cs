namespace Docfx.ResultSnippets.Tests;

public static class ResultExtensionsTests
{
    [Fact(DisplayName = "Example usage of SaveResults")]
    public static void Case1()
    {
        #region SaveResultsExample1

        // some return value
        const string result = "Some result to save";
        // now it can be saved as an example
        result.SaveResults();
        // we can also add a part to the name
        "Some other result".SaveResults(partName: "part2");
        #endregion

        Assert.Equal("Some result to save", result);
    }

    [Fact(DisplayName = "Example usage of FenceResult")]
    public static async Task Case2()
    {
        #region FenceResultExample1

        // some result that should be fenced
        const string result = "sh ./run-script --some-param a";
        string fencedResult = result.ToFencedResult("shell");

        #endregion

        fencedResult.SaveResults();

        await Verify(fencedResult).UseDirectory("__snapshots__");
    }

    [Fact(DisplayName = "Example usage of TabResult")]
    public static async Task Case3()
    {
        #region TabResultExample1

        // some result that should be placed into a tab
        const string result1 = "sh ./run-script --some-param a";
        const string result2 = "sh ./run-script --some-other-param b";
        string tabResult = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            ["Result 1"] = result1.ToFencedResult("shell"),
            ["Result 2"] = result2.ToFencedResult("shell"),
        }.ToTabResult();

        #endregion

        tabResult.SaveResults();

        await Verify(tabResult).UseDirectory("__snapshots__");
    }

    [Fact(DisplayName = "Example usage of TableResult for a simple type")]
    public static async Task Case4()
    {
        #region TableResultExample1

        // some simple data which will convert to a table
        IEnumerable<int?> data = Enumerable.Range(1, 3).OfType<int?>().Append(element: null);
        string tableResult = data.ToTableResult(defaultWhenNull: " - ");

        #endregion

        tableResult.SaveResults();

        await Verify(tableResult).UseDirectory("__snapshots__");
    }

    [Fact(DisplayName = "Example usage of TableResult for a complex type")]
    public static async Task Case5()
    {
        #region TableResultExample2

        // some complex data which will convert to a table
        var data = Enumerable
            .Range(1, 3)
            .Select(i => new
            {
                Name = $"Name {i}",
                Id = i,
                Nested = new { ChildId = i + 1 },
            });
        string tableResult = data.ToTableResult();

        #endregion

        tableResult.SaveResults();

        await Verify(tableResult).UseDirectory("__snapshots__");
    }

    [Fact(DisplayName = "Example usage of JsonResult")]
    public static async Task Case6()
    {
        #region JsonResultExample1

        // some complex data which will convert to a fenced JSON
        var data = new
        {
            Name = "Steve",
            Id = 1,
            Interests = new[]
            {
                new { Id = 1, Name = "Coding" },
                new { Id = 2, Name = "Football" },
            },
        };
        var jsonResult = data.ToJsonResult();

        #endregion

        jsonResult.SaveResults();

        await Verify(jsonResult).UseDirectory("__snapshots__");
    }

    [Fact(DisplayName = "null value can have SaveResult called on it")]
    public static void Case7()
    {
        const string? value = null;
        value.SaveResults();
        Assert.Null(value);
    }

    [Fact(DisplayName = "AsFenced result without a language works")]
    public static void Case8()
    {
        var value = "this is a test".ToFencedResult();
        Assert.Equal("```\nthis is a test\n```", value);
    }

    [Fact(DisplayName = "Save results skip files if they already exist")]
    public static void Case9()
    {
        #region SaveResultsExample2

        // some non-deterministic value
        Guid result = Guid.NewGuid();
        // now it can be saved as an example the first time only
        result.SaveResults(replaceExisting: false);
        #endregion

        Assert.NotEqual(Guid.Empty, result);
    }
}
