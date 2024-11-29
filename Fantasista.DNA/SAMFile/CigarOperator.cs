namespace Fantasista.DNA.SAMFile;

/// <summary>
///     Represents the operations possible in a CIGAR string used for DNA sequence alignment.
/// </summary>
public enum CigarOperator
{
    /// <summary>
    ///     Represents a matching of nucleotides between the query sequence and the reference sequence in
    ///     a CIGAR string. This operation signifies that the corresponding nucleotides in the aligned
    ///     sequences are identical.
    /// </summary>
    Match = 0,

    /// <summary>
    ///     Represents a mismatch of nucleotides between the query sequence and the reference sequence in
    ///     a CIGAR string. This operation indicates that the corresponding nucleotides in the aligned
    ///     sequences are different.
    /// </summary>
    Mismatch = 8,

    /// <summary>
    ///     Represents a deletion operation in a CIGAR string, indicating that nucleotides are
    ///     present in the reference sequence but absent in the query sequence. This operation
    ///     signifies a gap in the alignment where the reference has additional nucleotides.
    /// </summary>
    Deletion = 2,

    /// <summary>
    ///     Represents an insertion of nucleotides in the query sequence relative to the reference sequence
    ///     in a CIGAR string. This operation indicates that additional nucleotides are present in the query
    ///     sequence that do not align with the reference sequence.
    /// </summary>
    Insertion = 1,

    /// <summary>
    ///     Represents a gap in the alignment between the query sequence and the reference sequence in
    ///     a CIGAR string. This operation indicates a region where the alignment is not continuous
    ///     and there is no corresponding sequence in the query or reference.
    /// </summary>
    Gap = 3,

    /// <summary>
    ///     Represents a soft clipping operation in a CIGAR string for DNA sequence alignment. This operation
    ///     indicates that the associated nucleotides in the query sequence are not aligned to the reference
    ///     sequence but are still present in the read outside the aligned portion.
    /// </summary>
    SoftClipping = 4,

    /// <summary>
    ///     Represents hard clipping of nucleotides in the query sequence in a CIGAR string.
    ///     This operation signifies that the clipped bases are not present in the read data,
    ///     but are known to exist based on prior information.
    /// </summary>
    HardClipping = 5,

    /// <summary>
    ///     Represents the padding operation in a CIGAR string used for DNA sequence alignment.
    ///     This operation accounts for padding in the alignment, often used to indicate space
    ///     needed in the alignment without affecting the sequence itself.
    /// </summary>
    Padding = 6,

    /// <summary>
    ///     Denotes a matching operation in a CIGAR string where the nucleotides in the query sequence
    ///     align perfectly with those in the reference sequence.
    /// </summary>
    SequenceMatch = 7
}