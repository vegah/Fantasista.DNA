namespace Fantasista.DNA.SAMFile.Exceptions;

/// <summary>
///     Exception thrown when an integer value is expected but not found in a SAM file at a specific line.
/// </summary>
public class SamFileExpectedIntegerException : Exception
{
    /// <summary>
    ///     Exception thrown when an integer value is expected but not found in a SAM file at a specific line.
    /// </summary>
    public SamFileExpectedIntegerException(int lineNo, string value) : base(
        $"On line {lineNo} expected a number, but got {value}")

    {
    }
}