using FluentAssertions;
using ScottPlot;
using Xunit;

namespace Docfx.ResultSnippets.Tests;

public static class GraphExamples
{
    [Fact(DisplayName = "Stacked Bar Graph Example")]
    public static void Case1()
    {
        #region StackedBarExample1

        var plt = new Plot(600, 400);

        // create sample data
        double[] valuesA = { 1, 2, 3, 2, 1, 2, 1 };
        double[] valuesB = { 3, 3, 2, 1, 3, 2, 1 };

        // to simulate stacking B on A, shift B up by A
        var valuesB2 = new double[valuesB.Length];
        for (var i = 0; i < valuesB.Length; i++)
            valuesB2[i] = valuesA[i] + valuesB[i];

        // plot the bar charts in reverse order (highest first)
        plt.AddBar(valuesB2);
        plt.AddBar(valuesA);

        // adjust axis limits so there is no padding below the bar graph
        plt.SetAxisLimits(yMin: 0);

        var result = plt.GetImageHTML();

        result.SaveResults();

        #endregion

        result.Should().NotBeNull();
    }

    [Fact(DisplayName = "Radar Graph Example")]
    public static void Case2()
    {
        #region RadarExample1

        var plt = new Plot(600, 400);

        double[,] values =
        {
            { 78, 83, 84, 76, 43 },
            { 100, 50, 70, 60, 90 }
        };

        plt.AddRadar(values);

        // improve plot styling
        plt.Frameless();
        plt.Grid(enable: false);

        var result = plt.GetImageHTML();

        result.SaveResults();

        #endregion

        result.Should().NotBeNull();
    }

    [Fact(DisplayName = "Gauge Graph Example")]
    public static void Case3()
    {
        #region GaugeExample1

        var plt = new Plot(600, 400);

        double[] values = { 100, 80, 65, 45, 20 };
        plt.AddRadialGauge(values);

        var result = plt.GetImageHTML();

        result.SaveResults();

        #endregion

        result.Should().NotBeNull();
    }

    [Fact(DisplayName = "Signal Graph Example")]
    public static void Case4()
    {
        #region SignalExample1

        var plt = new Plot(600, 400);

        plt.AddSignal(DataGen.Sin(51));
        plt.AddSignal(DataGen.Cos(51));

        plt.AddBracket(0, 1, 0, 0, "Bracket A");
        plt.AddBracket(25, -1, 38, -1, "Bracket B");
        plt.AddBracket(20, .55, 27, -.3, "Bracket C");

        plt.Margins(.2, .2); // zoom out slightly to make room for labels

        var result = plt.GetImageHTML();

        result.SaveResults();

        #endregion

        result.Should().NotBeNull();
    }
}
