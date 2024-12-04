namespace Fantasista.DNA.SAMFile;

/// <summary>
///     Represents an exception that is thrown when a BAM file is missing the required header.
/// </summary>
internal class BamFileMissingHeaderException(string message) : Exception(message);