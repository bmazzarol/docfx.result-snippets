namespace Docfx.ResultSnippets;

/// <summary>
/// Model of a class in the class diagram
/// </summary>
/// <param name="Name">class name</param>
/// <param name="Modifier">optional modifier</param>
/// <param name="Members">optional members, if provided the member is a method</param>
/// <param name="Values">optional values, if set the class is an enum</param>
/// <param name="Notes">optional notes against the class</param>
public sealed record ClassModel(
    string Name,
    ClassModifier? Modifier = null,
    IEnumerable<MemberModel>? Members = null,
    IEnumerable<string>? Values = null,
    string? Notes = null
);
