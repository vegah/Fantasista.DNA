#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile')

## RawSequenceAlignment Class

Represents a raw sequence alignment entry parsed from a SAM file.

```csharp
public class RawSequenceAlignment
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; RawSequenceAlignment

| Constructors | |
| :--- | :--- |
| [RawSequenceAlignment(int)](Fantasista.DNA.SAMFile.RawSequenceAlignment.RawSequenceAlignment(int).md 'Fantasista.DNA.SAMFile.RawSequenceAlignment.RawSequenceAlignment(int)') | Represents a raw sequence alignment entry parsed from a SAM file. |

| Properties | |
| :--- | :--- |
| [AlignmentInformationFlag](Fantasista.DNA.SAMFile.RawSequenceAlignment.AlignmentInformationFlag.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment.AlignmentInformationFlag') | Gets or sets the alignment information flags for the sequence alignment record. |
| [CIGAR](Fantasista.DNA.SAMFile.RawSequenceAlignment.CIGAR.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment.CIGAR') | Gets or sets the CIGAR string for the sequence alignment record. |
| [MappingQuality](Fantasista.DNA.SAMFile.RawSequenceAlignment.MappingQuality.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment.MappingQuality') | Gets or sets the mapping quality score for the sequence alignment record. |
| [OptionalValueCollection](Fantasista.DNA.SAMFile.RawSequenceAlignment.OptionalValueCollection.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment.OptionalValueCollection') | Gets or sets a collection of optional values for the sequence alignment record. |
| [PNext](Fantasista.DNA.SAMFile.RawSequenceAlignment.PNext.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment.PNext') | Gets or sets the position of the next segment in the template for the sequence alignment. |
| [Position](Fantasista.DNA.SAMFile.RawSequenceAlignment.Position.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment.Position') | Gets or sets the position of the first base in the alignment within the reference sequence. |
| [Quality](Fantasista.DNA.SAMFile.RawSequenceAlignment.Quality.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment.Quality') | Gets or sets the quality scores of the read sequence in the sequence alignment record. |
| [QueryTemplateName](Fantasista.DNA.SAMFile.RawSequenceAlignment.QueryTemplateName.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment.QueryTemplateName') | Gets or sets the query template name of the sequence alignment. |
| [ReadSequence](Fantasista.DNA.SAMFile.RawSequenceAlignment.ReadSequence.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment.ReadSequence') | Gets or sets the read sequence for the sequence alignment record. |
| [ReferenceSequence](Fantasista.DNA.SAMFile.RawSequenceAlignment.ReferenceSequence.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment.ReferenceSequence') | Gets or sets the reference sequence name for the sequence alignment record. |
| [RNext](Fantasista.DNA.SAMFile.RawSequenceAlignment.RNext.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment.RNext') | Gets or sets the reference sequence field indicating the reference for the next read in the template. |
| [TLen](Fantasista.DNA.SAMFile.RawSequenceAlignment.TLen.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment.TLen') | Gets or sets the observed Template Length for the alignment. |

| Methods | |
| :--- | :--- |
| [Parse(int, string)](Fantasista.DNA.SAMFile.RawSequenceAlignment.Parse(int,string).md 'Fantasista.DNA.SAMFile.RawSequenceAlignment.Parse(int, string)') | Parses a string representing a SAM file line into a RawSequenceAlignment object. |
