#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile')

## SamStreamReader Class

Class for reading SAM (Sequence Alignment / Map) files.

```csharp
public class SamStreamReader :
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SamStreamReader

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')

| Constructors | |
| :--- | :--- |
| [SamStreamReader(string)](Fantasista.DNA.SAMFile.SamStreamReader.SamStreamReader(string).md 'Fantasista.DNA.SAMFile.SamStreamReader.SamStreamReader(string)') | Instansiate class with a string. |
| [SamStreamReader(Stream)](Fantasista.DNA.SAMFile.SamStreamReader.SamStreamReader(System.IO.Stream).md 'Fantasista.DNA.SAMFile.SamStreamReader.SamStreamReader(System.IO.Stream)') | Instansiate the class with a stream |

| Properties | |
| :--- | :--- |
| [Metadata](Fantasista.DNA.SAMFile.SamStreamReader.Metadata.md 'Fantasista.DNA.SAMFile.SamStreamReader.Metadata') | Gets the metadata associated with the SAM file. |
| [ProgramHeaders](Fantasista.DNA.SAMFile.SamStreamReader.ProgramHeaders.md 'Fantasista.DNA.SAMFile.SamStreamReader.ProgramHeaders') | Gets or sets the collection of program headers in the SAM file. |
| [ReadGroups](Fantasista.DNA.SAMFile.SamStreamReader.ReadGroups.md 'Fantasista.DNA.SAMFile.SamStreamReader.ReadGroups') | Gets or sets the collection of read groups in the SAM file. |
| [ReferenceSequenceDictionary](Fantasista.DNA.SAMFile.SamStreamReader.ReferenceSequenceDictionary.md 'Fantasista.DNA.SAMFile.SamStreamReader.ReferenceSequenceDictionary') | Gets or sets the dictionary of reference sequences in the SAM file. |

| Methods | |
| :--- | :--- |
| [Dispose()](Fantasista.DNA.SAMFile.SamStreamReader.Dispose().md 'Fantasista.DNA.SAMFile.SamStreamReader.Dispose()') | Releases all resources used by the SamStreamReader instance. |
| [Read()](Fantasista.DNA.SAMFile.SamStreamReader.Read().md 'Fantasista.DNA.SAMFile.SamStreamReader.Read()') | Reads sequence alignments from a SAM file stream. |
