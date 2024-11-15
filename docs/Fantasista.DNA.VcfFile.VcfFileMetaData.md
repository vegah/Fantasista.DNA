#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.VcfFile](Fantasista.DNA.VcfFile.md 'Fantasista.DNA.VcfFile')

## VcfFileMetaData Class

A class used to describe the metadata of a vcf file.

```csharp
public class VcfFileMetaData
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; VcfFileMetaData

| Properties | |
| :--- | :--- |
| [FileDate](Fantasista.DNA.VcfFile.VcfFileMetaData.FileDate.md 'Fantasista.DNA.VcfFile.VcfFileMetaData.FileDate') | DateTimeOffset - null if not parsable or not existing |
| [FileFormat](Fantasista.DNA.VcfFile.VcfFileMetaData.FileFormat.md 'Fantasista.DNA.VcfFile.VcfFileMetaData.FileFormat') | File format - ##fileformat=VCFv4.3 will give VCFv4.3 |
| [Id](Fantasista.DNA.VcfFile.VcfFileMetaData.Id.md 'Fantasista.DNA.VcfFile.VcfFileMetaData.Id') | Describes the ID field |
| [Info](Fantasista.DNA.VcfFile.VcfFileMetaData.Info.md 'Fantasista.DNA.VcfFile.VcfFileMetaData.Info') | A list of descriptions of INFO fields later used.<br/>##INFO=<ID=NS,Number=1,Type=Integer,Description="Number of Samples With Data"><br/>##INFO=<ID=DP,Number=1,Type=Integer,Description="Total Depth"><br/>will give two rows here. |
| [Reference](Fantasista.DNA.VcfFile.VcfFileMetaData.Reference.md 'Fantasista.DNA.VcfFile.VcfFileMetaData.Reference') | Reference - from ##reference=file:///seq/references/1000GenomesPilot-NCBI36.fasta |
| [Source](Fantasista.DNA.VcfFile.VcfFileMetaData.Source.md 'Fantasista.DNA.VcfFile.VcfFileMetaData.Source') | Source of the data - ##source=myImputationProgramV3.1 |

| Methods | |
| :--- | :--- |
| [AddMetaData(string)](Fantasista.DNA.VcfFile.VcfFileMetaData.AddMetaData(string).md 'Fantasista.DNA.VcfFile.VcfFileMetaData.AddMetaData(string)') | Parses and add one line of metadata |
| [MyRegex()](Fantasista.DNA.VcfFile.VcfFileMetaData.MyRegex().md 'Fantasista.DNA.VcfFile.VcfFileMetaData.MyRegex()') | |
