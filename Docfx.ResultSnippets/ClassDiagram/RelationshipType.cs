namespace Docfx.ResultSnippets;

/// <summary>
/// Type of relationship
/// </summary>
public enum RelationshipType
{
    /// <summary>
    /// Inheritance type, --|>
    /// </summary>
    Inheritence,

    /// <summary>
    /// Association type, -->
    /// </summary>
    Association,

    /// <summary>
    /// Composition type, --*
    /// </summary>
    Composition,

    /// <summary>
    /// Aggregation type, --o
    /// </summary>
    Aggregation,

    /// <summary>
    /// Link type, --
    /// </summary>
    LinkSolid,

    /// <summary>
    /// Dependency type, ..>
    /// </summary>
    Dependency,

    /// <summary>
    /// Realization type, ..|>
    /// </summary>
    Realization,

    /// <summary>
    /// Link (dashed), ..
    /// </summary>
    LinkDashed,
}
