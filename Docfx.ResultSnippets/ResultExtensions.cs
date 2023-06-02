using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using static System.Text.Encoding;

namespace Docfx.ResultSnippets;

/// <summary>
/// Result extensions
/// </summary>
public static class ResultExtensions
{
    /// <summary>
    /// Saves the result to an example file that can be included in documentation
    /// </summary>
    /// <remarks>
    /// <para>The generated file name format is `{sourceFilePath}.{memberName}.({partName}.).{extension}`</para>
    /// <para>This is saved under the `folder`, __examples__ by default relative to the executing code in `sourceFilePath`</para>
    /// </remarks>
    /// <param name="result">some result to save</param>
    /// <param name="folder">folder to save it under, default is `__examples__`</param>
    /// <param name="extension">extension to use for the example file, default is `md`</param>
    /// <param name="partName">optional part name</param>
    /// <param name="sourceFilePath">source file path of the calling code</param>
    /// <param name="memberName">member name of the calling code</param>
    /// <typeparam name="T">some T to `ToString` and save</typeparam>
    public static void SaveResults<T>(
        this T result,
        string folder = "__examples__",
        string extension = "md",
        string partName = "",
        [CallerFilePath] string sourceFilePath = "",
        [CallerMemberName] string memberName = ""
    )
    {
        var data = result?.ToString();
        if (data == null)
            return;
        var root = Path.GetDirectoryName(sourceFilePath);
        var name = Path.GetFileNameWithoutExtension(sourceFilePath);
        var path = $"{root}/{folder}";
        Directory.CreateDirectory(path);
        File.WriteAllText(
            $"{path}/{name}.{memberName}{(string.IsNullOrWhiteSpace(partName) ? string.Empty : $".{partName}")}.{extension}",
            data
        );
    }

    /// <summary>
    /// Fences the result, with an optional language applied
    /// </summary>
    /// <param name="result">result to fence</param>
    /// <param name="language">optional language to designate the fenced result as</param>
    /// <typeparam name="T">some result T</typeparam>
    /// <returns>fenced result of calling ToString on T</returns>
    [Pure]
    public static string AsFencedResult<T>(this T result, string? language = null) =>
        $"```{language ?? string.Empty}\n{result}\n```";

    [Pure]
    private static string JoinBy<T>(this IEnumerable<T> items, string sep) =>
        items.Aggregate(string.Empty, (s, v) => s != string.Empty ? $"{s}{sep}{v}" : $"{v}");

    /// <summary>
    /// Creates tabs out of the results provided
    /// </summary>
    /// <param name="results">any type that extends from an enumerable of KeyValuePair</param>
    /// <returns>tabs</returns>
    [Pure]
    public static string AsTabResult<T>(this IEnumerable<KeyValuePair<string, T>> results) =>
        results
            .Select(
                x =>
                    $"# [{x.Key}](#tab/{x.Key.ToLowerInvariant().Replace(' ', '-')})\n\n{x.Value}\n"
            )
            .JoinBy("\n");

    [Pure]
    private static IEnumerable<string> ExtractHeaders<T>()
    {
        var type = typeof(T);
        if (type.IsClass)
        {
            return type.GetProperties()
                .Concat(type.GetFields().OfType<MemberInfo>())
                .Select(x => x.Name);
        }

        return new[] { "x" };
    }

    [Pure]
    private static IEnumerable<(object? value, Type type)> ExtractValues<T>(T value)
    {
        var type = typeof(T);
        if (type.IsClass)
        {
            return type.GetProperties()
                .Select(x => (value: (object?)x.GetValue(value), type: x.PropertyType));
        }

        return new[] { (value: (object?)value, type) };
    }

    [Pure]
    private static string SerializeValue(
        object? value,
        Type type,
        JsonSerializerOptions options,
        string? defaultWhenNull
    )
    {
        if (value == null)
            return defaultWhenNull ?? string.Empty;
        if (type.IsAssignableFrom(typeof(string)))
            return (string)value;
        var bytes = JsonSerializer.SerializeToUtf8Bytes(value, type, options);
        return UTF8.GetString(bytes);
    }

    [Pure]
    private static string CreatePipeTable(
        IEnumerable<string> headers,
        IEnumerable<IEnumerable<(object? value, Type type)>> data,
        JsonSerializerOptions options,
        string? defaultWhenNull
    )
    {
        var hList = headers.ToList();
        var dataString = data.Select(
                row =>
                    $"|{row.Select(column => SerializeValue(column.value, column.type, options, defaultWhenNull)).JoinBy("|")}|"
            )
            .JoinBy("\n");
        return $"|{hList.JoinBy("|")}|\n|{hList.Select(_ => "-").JoinBy("|")}|\n{dataString}";
    }

    /// <summary>
    /// Converts an enumerable to a pipe table result
    /// </summary>
    /// <param name="result">some enumerable</param>
    /// <param name="options">optional json serializer options</param>
    /// <param name="defaultWhenNull">default to use when a value is null</param>
    /// <typeparam name="T">some T, if its a class, each field/property becomes a column in the row</typeparam>
    /// <returns>pipe table</returns>
    [Pure]
    public static string AsTableResult<T>(
        this IEnumerable<T> result,
        JsonSerializerOptions? options = null,
        string? defaultWhenNull = null
    )
    {
        var headers = ExtractHeaders<T>();
        var values = result.Select(ExtractValues);
        return CreatePipeTable(
            headers,
            values,
            options ?? JsonSerializerOptions.Default,
            defaultWhenNull
        );
    }

    /// <summary>
    /// Converts the value to a fenced block of JSON
    /// </summary>
    /// <param name="value">value to write out as JSON</param>
    /// <param name="options">optional json serializer options</param>
    /// <typeparam name="T">some T</typeparam>
    /// <returns>fenced block of JSON</returns>
    public static string AsJsonResult<T>(this T value, JsonSerializerOptions? options = null)
    {
        var opts = new JsonSerializerOptions(options ?? JsonSerializerOptions.Default)
        {
            WriteIndented = true
        };
        var bytes = JsonSerializer.SerializeToUtf8Bytes(value, opts);
        return UTF8.GetString(bytes).AsFencedResult("json");
    }
}
