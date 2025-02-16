namespace Docfx.ResultSnippets;

/// <summary>
/// Model of a member within a class
/// </summary>
/// <param name="Name">member name</param>
/// <param name="Visibility">member visibility</param>
/// <param name="Modifier">optional modifier</param>
/// <param name="TypeName">optional type name</param>
/// <param name="Parameters">optional parameters</param>
public sealed record MemberModel(
    string Name,
    MemberVisibility Visibility,
    MemberModifier? Modifier = null,
    string? TypeName = null,
    IEnumerable<ParameterModel>? Parameters = null
);
