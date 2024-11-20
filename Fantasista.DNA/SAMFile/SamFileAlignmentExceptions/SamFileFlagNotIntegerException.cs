namespace Fantasista.DNA.SAMFile.SamFileAlignmentExceptions;

public class SamFileFlagNotIntegerException : Exception
{
    public SamFileFlagNotIntegerException(int lineNo, string value) : base(
        $"On line {lineNo}Flag is supposed to be a number, but got {value}")

    {
    }
}