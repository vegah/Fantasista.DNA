namespace Fantasista.DNA.SAMFile;

/// <summary>
///     Represents a program record in a SAM file. This class is used to parse and store information related to
///     a program that has been used during the processing of a SAM file.
/// </summary>
public class SamFileProgram(int lineNo)
{
    /// <summary>
    ///     Gets or sets the version of the program used during the processing of the SAM file.
    /// </summary>
    public string Version { get; set; }

    /// <summary>
    ///     Gets or sets the description of the program used during the processing of the SAM file.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    ///     Gets or sets the identifier of the previous program in the sequence of programs used to process the SAM file.
    /// </summary>
    public string PreviousProgramId { get; set; }

    /// <summary>
    ///     Gets or sets the command line string that was used to invoke the program during the processing of the SAM file.
    /// </summary>
    public string CommandLine { get; set; }

    /// <summary>
    ///     Gets or sets the name of the program used during the processing of the SAM file.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     Gets or sets the identifier for the program.
    /// </summary>
    public string Identifier { get; set; }

    /// <summary>
    ///     Parses a single line from a SAM file's program header.
    /// </summary>
    /// <param name="line">The line to parse, typically a program header from a SAM file.</param>
    public void Parse(string line)
    {
        var datafields = line.Split(['\t'], StringSplitOptions.RemoveEmptyEntries);
        foreach (var datafield in datafields) SplitAndSetProgramHeaders(datafield);
    }

    private void SplitAndSetProgramHeaders(string datafield)
    {
        var fieldParts = datafield.Split(':', 2);
        var tag = fieldParts[0];
        var value = fieldParts[1];
        switch (tag)
        {
            case "ID":
                Identifier = value;
                break;
            case "PN":
                Name = value;
                break;
            case "CL":
                CommandLine = value;
                break;
            case "PP":
                PreviousProgramId = value;
                break;
            case "DS":
                Description = value;
                break;
            case "VN":
                Version = value;
                break;
        }
    }
}