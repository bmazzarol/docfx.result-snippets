namespace Docfx.ResultSnippets;

/// <summary>
/// Relationship type
/// </summary>
/// <param name="FromType">from type</param>
/// <param name="ToType">to type</param>
/// <param name="Type">relationship type</param>
/// <param name="Cardinality">optional cardinality type</param>
/// <param name="Label">optional label</param>
public record RelationshipModel(
    string FromType,
    string ToType,
    RelationshipType Type,
    CardinalityType? Cardinality = null,
    string? Label = null
);
