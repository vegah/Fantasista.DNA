namespace Fantasista.DNA.SAMFile.Exceptions;

/// <summary>
///     Represents an exception that is thrown when a SAM file optional value does not conform
///     to the expected format. This exception is typically raised during the parsing process
///     when the data structure does not contain exactly three components: a tag, a type, and
///     a value.
/// </summary>
public class SamFileOptionalValueException(string message) : Exception(message);