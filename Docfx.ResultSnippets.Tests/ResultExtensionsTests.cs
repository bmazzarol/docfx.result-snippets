﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using VerifyXunit;
using Xunit;

namespace Docfx.ResultSnippets.Tests;

[UsesVerify]
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

        result.Should().Be("Some result to save");
    }

    [Fact(DisplayName = "Example usage of FenceResult")]
    public static async Task Case2()
    {
        #region FenceResultExample1

        // some result that should be fenced
        var result = "sh ./run-script --some-param a";
        var fencedResult = result.ToFencedResult("shell");

        #endregion

        fencedResult.SaveResults();

        await Verifier.Verify(fencedResult).UseDirectory("__snapshots__");
    }

    [Fact(DisplayName = "Example usage of TabResult")]
    public static async Task Case3()
    {
        #region TabResultExample1

        // some result that should be placed into a tab
        var result1 = "sh ./run-script --some-param a";
        var result2 = "sh ./run-script --some-other-param b";
        var tabResult = new Dictionary<string, string>
        {
            ["Result 1"] = result1.ToFencedResult("shell"),
            ["Result 2"] = result2.ToFencedResult("shell"),
        }.ToTabResult();

        #endregion

        tabResult.SaveResults();

        await Verifier.Verify(tabResult).UseDirectory("__snapshots__");
    }

    [Fact(DisplayName = "Example usage of TableResult for a simple type")]
    public static async Task Case4()
    {
        #region TableResultExample1

        // some simple data which will convert to a table
        var data = Enumerable.Range(1, 3).OfType<int?>().Append(null);
        var tableResult = data.ToTableResult(defaultWhenNull: " - ");

        #endregion

        tableResult.SaveResults();

        await Verifier.Verify(tableResult).UseDirectory("__snapshots__");
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
        var tableResult = data.ToTableResult();

        #endregion

        tableResult.SaveResults();

        await Verifier.Verify(tableResult).UseDirectory("__snapshots__");
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

        await Verifier.Verify(jsonResult).UseDirectory("__snapshots__");
    }

    [Fact(DisplayName = "null value can have SaveResult called on it")]
    public static void Case7()
    {
        string? value = null;
        value.SaveResults();
        true.Should().BeTrue();
    }

    [Fact(DisplayName = "AsFenced result without a language works")]
    public static void Case8()
    {
        var value = "this is a test".ToFencedResult();
        value.Should().Be("```\nthis is a test\n```");
    }

    [Fact(DisplayName = "Save results skip files if they already exist")]
    public static void Case9()
    {
        #region SaveResultsExample2

        // some non-deterministic value
        var result = Guid.NewGuid();
        // now it can be saved as an example the first time only
        result.SaveResults(replaceExisting: false);
        #endregion

        result.Should().NotBeEmpty();
    }
}
