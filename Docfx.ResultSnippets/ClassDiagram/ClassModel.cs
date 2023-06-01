using System.Collections.Generic;

namespace Docfx.ResultSnippets;

/// <summary>
/// Model of a class in the class diagram
/// </summary>
/// <param name="Name">class name</param>
/// <param name="Modifier">optional modifier</param>
/// <param name="Members">optional members, if provided the member is a method</param>
/// <param name="Values">optional values, if set the class is an enum</param>
/// <param name="Notes">optional notes against the class</param>
public record ClassModel(
    string Name,
    ClassModifier? Modifier = default,
    IEnumerable<MemberModel>? Members = default,
    IEnumerable<string>? Values = default,
    string? Notes = null
);
