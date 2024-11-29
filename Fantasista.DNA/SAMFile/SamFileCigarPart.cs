namespace Fantasista.DNA.SAMFile;

/// <summary>
///     Represents a part of a CIGAR string which is used to describe the alignment
///     of a DNA sequence. A CIGAR string is composed of multiple parts, each
///     defining an operation and the number of nucleotides it affects.
/// </summary>
public class SamFileCigarPart(CigarOperator cigarOperator, int numberOfAlignedNucelotides)
{
    /// <summary>
    ///     Gets or sets the operator for this part of the CIGAR string. The operator
    ///     represents the type of operation (e.g., match, mismatch, insertion, deletion)
    ///     to be performed on the corresponding nucleotides in a DNA sequence alignment.
    /// </summary>
    public CigarOperator Operator { get; set; } = cigarOperator;

    /// <summary>
    ///     Gets or sets the number of nucleotides affected by this part of the CIGAR string.
    ///     This value indicates how many nucleotides are aligned according to the specified operator in a DNA sequence
    ///     alignment.
    /// </summary>
    public int NumberOfAlignedNucelotides { get; set; } = numberOfAlignedNucelotides;
}