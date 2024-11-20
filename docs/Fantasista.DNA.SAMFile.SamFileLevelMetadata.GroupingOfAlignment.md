#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[SamFileLevelMetadata](Fantasista.DNA.SAMFile.SamFileLevelMetadata.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata')

## SamFileLevelMetadata.GroupingOfAlignment Property

Gets or sets the grouping of the alignments within the SAM (Sequence Alignment/Map) file.  
This property indicates how the alignments are grouped, which can be one of the values specified  
in the [GroupingOfAlignments](Fantasista.DNA.SAMFile.SamFileLevelMetadata.GroupingOfAlignments.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata.GroupingOfAlignments') enum.

```csharp
public Fantasista.DNA.SAMFile.SamFileLevelMetadata.GroupingOfAlignments GroupingOfAlignment { get; set; }
```

#### Property Value
[GroupingOfAlignments](Fantasista.DNA.SAMFile.SamFileLevelMetadata.GroupingOfAlignments.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata.GroupingOfAlignments')

#### Exceptions

[SamFileFormatException](Fantasista.DNA.SAMFile.SamFileHeaderExceptions.SamFileFormatException.md 'Fantasista.DNA.SAMFile.SamFileHeaderExceptions.SamFileFormatException')  
Thrown when an invalid grouping value is set.