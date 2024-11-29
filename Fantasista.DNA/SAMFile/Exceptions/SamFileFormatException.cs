namespace Fantasista.DNA.SAMFile.Exceptions;

/// <summary>
///     Represents errors that occur when processing a SAM (Sequence Alignment/Map) file due to format issues.
/// </summary>
/// <param name="message">The message that describes the error.</param>
public class SamFileFormatException(string message) : Exception(message);