#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile')

## SamFileReadGroup Class

Represents a read group in a SAM file, encapsulating metadata such as identifier, platform unit,  
description, and additional attributes relevant to sequencing data.

```csharp
public class SamFileReadGroup
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SamFileReadGroup

| Constructors | |
| :--- | :--- |
| [SamFileReadGroup(int)](Fantasista.DNA.SAMFile.SamFileReadGroup.SamFileReadGroup(int).md 'Fantasista.DNA.SAMFile.SamFileReadGroup.SamFileReadGroup(int)') | Represents a read group in a SAM file, encapsulating metadata such as identifier, platform unit,<br/>description, and additional attributes relevant to sequencing data. |

| Properties | |
| :--- | :--- |
| [BarcodeSequence](Fantasista.DNA.SAMFile.SamFileReadGroup.BarcodeSequence.md 'Fantasista.DNA.SAMFile.SamFileReadGroup.BarcodeSequence') | Gets or sets the sequence of barcodes used in the SAM file read group.<br/>This can be used to identify and track samples through the sequencing process. |
| [Description](Fantasista.DNA.SAMFile.SamFileReadGroup.Description.md 'Fantasista.DNA.SAMFile.SamFileReadGroup.Description') | Gets or sets the description of the SAM file read group. |
| [FlowOrder](Fantasista.DNA.SAMFile.SamFileReadGroup.FlowOrder.md 'Fantasista.DNA.SAMFile.SamFileReadGroup.FlowOrder') | Gets or sets the array of nucleotide bases that dictate the order of incorporation<br/>during sequencing, primarily used by platforms such as Ion Torrent. |
| [Identifier](Fantasista.DNA.SAMFile.SamFileReadGroup.Identifier.md 'Fantasista.DNA.SAMFile.SamFileReadGroup.Identifier') | Gets the identifier of the SAM file read group. |
| [Library](Fantasista.DNA.SAMFile.SamFileReadGroup.Library.md 'Fantasista.DNA.SAMFile.SamFileReadGroup.Library') | Gets or sets the library identifier associated with the SAM file read group. |
| [PlatformModel](Fantasista.DNA.SAMFile.SamFileReadGroup.PlatformModel.md 'Fantasista.DNA.SAMFile.SamFileReadGroup.PlatformModel') | Gets or sets the platform model of the sequencing instrument. |
| [PlatformTechnology](Fantasista.DNA.SAMFile.SamFileReadGroup.PlatformTechnology.md 'Fantasista.DNA.SAMFile.SamFileReadGroup.PlatformTechnology') | Gets or sets the platform or technology type used in sequencing and represented by the PlatformTechnologyType enum. |
| [PlatformUnit](Fantasista.DNA.SAMFile.SamFileReadGroup.PlatformUnit.md 'Fantasista.DNA.SAMFile.SamFileReadGroup.PlatformUnit') | Gets or sets the platform unit information for the SAM file read group.<br/>Platform Unit typically contains the unique identifier of the run or the specific sequencing instrument. |
| [PredictedMedianInsertSize](Fantasista.DNA.SAMFile.SamFileReadGroup.PredictedMedianInsertSize.md 'Fantasista.DNA.SAMFile.SamFileReadGroup.PredictedMedianInsertSize') | Gets or sets the predicted median insert size for the read group. |
| [Programs](Fantasista.DNA.SAMFile.SamFileReadGroup.Programs.md 'Fantasista.DNA.SAMFile.SamFileReadGroup.Programs') | Gets or sets the programs used in data processing. |
| [RunDate](Fantasista.DNA.SAMFile.SamFileReadGroup.RunDate.md 'Fantasista.DNA.SAMFile.SamFileReadGroup.RunDate') | Gets or sets the run date when sequencing was performed. |
| [Sample](Fantasista.DNA.SAMFile.SamFileReadGroup.Sample.md 'Fantasista.DNA.SAMFile.SamFileReadGroup.Sample') | Gets or sets the sample name associated with the SAM file read group. |
| [SequencingCenterName](Fantasista.DNA.SAMFile.SamFileReadGroup.SequencingCenterName.md 'Fantasista.DNA.SAMFile.SamFileReadGroup.SequencingCenterName') | Gets or sets the name of the sequencing center where the read group was generated. |

| Methods | |
| :--- | :--- |
| [Parse(string)](Fantasista.DNA.SAMFile.SamFileReadGroup.Parse(string).md 'Fantasista.DNA.SAMFile.SamFileReadGroup.Parse(string)') | Parses a single line of SAM read group headers input and sets the relevant properties of the SamFileReadGroup<br/>instance. |
