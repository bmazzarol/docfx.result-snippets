namespace Docfx.ResultSnippets;

/// <summary>
/// Cardinality type
/// </summary>
public enum CardinalityType
{
    /// <summary>
    /// One to one 1 -> 1
    /// </summary>
    OneToOne,

    /// <summary>
    /// Many to one * -> 1
    /// </summary>
    ManyToOne,

    /// <summary>
    /// One to many 1 -> *
    /// </summary>
    OneToMany,

    /// <summary>
    /// Many to many * -> *
    /// </summary>
    ManyToMany
}
