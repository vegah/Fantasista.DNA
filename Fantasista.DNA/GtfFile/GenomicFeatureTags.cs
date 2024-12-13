namespace Fantasista.DNA.GtfFile;

/// <summary>
///     Represents tags associated with a genomic feature.
/// </summary>
/// <remarks>
///     GenomicFeatureTags provides optional metadata about a genomic feature, such as its ID, name, parent relationship,
///     aliases, and other annotations. These tags are often used for linking genomic features with external references
///     or providing additional descriptive information.
/// </remarks>
public class GenomicFeatureTags
{
    public string? Id { get; set; }
    public string? Parent { get; set; }
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Note { get; set; }
    public string? Dbxref { get; set; }
    public string? OntologyTerm { get; set; }
    public string? Target { get; set; }
    public string? Gap { get; set; }
    public string? DerivesFrom { get; set; }
}