#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile')

## SamFileProgram Class

Represents a program record in a SAM file. This class is used to parse and store information related to  
a program that has been used during the processing of a SAM file.

```csharp
public class SamFileProgram
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SamFileProgram

| Constructors | |
| :--- | :--- |
| [SamFileProgram(int)](Fantasista.DNA.SAMFile.SamFileProgram.SamFileProgram(int).md 'Fantasista.DNA.SAMFile.SamFileProgram.SamFileProgram(int)') | Represents a program record in a SAM file. This class is used to parse and store information related to<br/>a program that has been used during the processing of a SAM file. |

| Properties | |
| :--- | :--- |
| [CommandLine](Fantasista.DNA.SAMFile.SamFileProgram.CommandLine.md 'Fantasista.DNA.SAMFile.SamFileProgram.CommandLine') | Gets or sets the command line string that was used to invoke the program during the processing of the SAM file. |
| [Description](Fantasista.DNA.SAMFile.SamFileProgram.Description.md 'Fantasista.DNA.SAMFile.SamFileProgram.Description') | Gets or sets the description of the program used during the processing of the SAM file. |
| [Identifier](Fantasista.DNA.SAMFile.SamFileProgram.Identifier.md 'Fantasista.DNA.SAMFile.SamFileProgram.Identifier') | Gets or sets the identifier for the program. |
| [Name](Fantasista.DNA.SAMFile.SamFileProgram.Name.md 'Fantasista.DNA.SAMFile.SamFileProgram.Name') | Gets or sets the name of the program used during the processing of the SAM file. |
| [PreviousProgramId](Fantasista.DNA.SAMFile.SamFileProgram.PreviousProgramId.md 'Fantasista.DNA.SAMFile.SamFileProgram.PreviousProgramId') | Gets or sets the identifier of the previous program in the sequence of programs used to process the SAM file. |
| [Version](Fantasista.DNA.SAMFile.SamFileProgram.Version.md 'Fantasista.DNA.SAMFile.SamFileProgram.Version') | Gets or sets the version of the program used during the processing of the SAM file. |

| Methods | |
| :--- | :--- |
| [Parse(string)](Fantasista.DNA.SAMFile.SamFileProgram.Parse(string).md 'Fantasista.DNA.SAMFile.SamFileProgram.Parse(string)') | Parses a single line from a SAM file's program header. |
