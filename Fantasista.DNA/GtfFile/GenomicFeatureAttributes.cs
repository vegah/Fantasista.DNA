namespace Fantasista.DNA.GtfFile;

/// <summary>
///     Represents a collection of attributes associated with a genomic feature parsed from a GTF (General Transfer Format)
///     file.
/// </summary>
/// <remarks>
///     The class extends the functionality of a dictionary to store key-value pairs of metadata associated with genomic
///     features.
///     These attributes typically provide additional information about the features, such as gene ID, transcript ID, and
///     other relevant annotations.
/// </remarks>
public class GenomicFeatureAttributes : Dictionary<string, string>
{
}