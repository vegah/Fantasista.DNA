namespace Fantasista.DNA.SAMFile.Exceptions;

/// <summary>
///     Represents an exception that is thrown when an error related to CIGAR string parsing occurs in a SAM file.
/// </summary>
public class SamFileCigarException(string message) : Exception(message);