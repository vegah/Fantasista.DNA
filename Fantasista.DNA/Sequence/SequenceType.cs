namespace Fantasista.DNA.FastaFile;

/// <summary>
/// Describes what type of sequence
/// </summary>
public enum SequenceType
{
    /// <summary>
    /// DNA Sequence
    /// </summary>
    DNA,
    /// <summary>
    /// RNA Sequence
    /// </summary>
    RNA,
    /// <summary>
    /// Protein sequence
    /// </summary>
    Protein,
    /// <summary>
    /// Unknown sequence
    /// </summary>
    Unknown
}