#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile')

## SamFileLevelMetadata Class

Represents metadata at the file level for a SAM (Sequence Alignment/Map) file.  
Provides properties and methods to parse and handle file-level metadata such as version and sorting order of  
alignments.

```csharp
public class SamFileLevelMetadata
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SamFileLevelMetadata

| Constructors | |
| :--- | :--- |
| [SamFileLevelMetadata()](Fantasista.DNA.SAMFile.SamFileLevelMetadata.SamFileLevelMetadata().md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata.SamFileLevelMetadata()') | Represents metadata at the file level for a SAM file. |

| Properties | |
| :--- | :--- |
| [GroupingOfAlignment](Fantasista.DNA.SAMFile.SamFileLevelMetadata.GroupingOfAlignment.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata.GroupingOfAlignment') | Gets or sets the grouping of the alignments within the SAM (Sequence Alignment/Map) file.<br/>This property indicates how the alignments are grouped, which can be one of the values specified<br/>in the [GroupingOfAlignments](Fantasista.DNA.SAMFile.SamFileLevelMetadata.GroupingOfAlignments.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata.GroupingOfAlignments') enum. |
| [SortingOrderOfAlignment](Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignment.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignment') | Gets or sets the sorting order of the alignments within the SAM (Sequence Alignment/Map) file.<br/>This property indicates how the alignments are ordered, which can be one of the values specified<br/>in the [SortingOrderOfAlignments](Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments') enum. |
| [SubSorting](Fantasista.DNA.SAMFile.SamFileLevelMetadata.SubSorting.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata.SubSorting') | Gets or sets the sub-sorting criteria for the SAM (Sequence Alignment/Map) file.<br/>This property specifies detailed sorting information beyond the primary sorting order defined<br/>by [SortingOrderOfAlignments](Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments'). |
| [Version](Fantasista.DNA.SAMFile.SamFileLevelMetadata.Version.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata.Version') | Gets or sets the version of the SAM (Sequence Alignment/Map) file format.<br/>This property must adhere to the format "major.minor", where both major and minor are integers. |

| Methods | |
| :--- | :--- |
| [Parse(string)](Fantasista.DNA.SAMFile.SamFileLevelMetadata.Parse(string).md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata.Parse(string)') | Parses the provided SAM file header and sets the metadata properties accordingly. |
