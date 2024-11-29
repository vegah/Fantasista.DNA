#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[SamFileLevelMetadata](Fantasista.DNA.SAMFile.SamFileLevelMetadata.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata')

## SamFileLevelMetadata.SortingOrderOfAlignment Property

Gets or sets the sorting order of the alignments within the SAM (Sequence Alignment/Map) file.  
This property indicates how the alignments are ordered, which can be one of the values specified  
in the [SortingOrderOfAlignments](Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments') enum.

```csharp
public Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments SortingOrderOfAlignment { get; set; }
```

#### Property Value
[SortingOrderOfAlignments](Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments')

#### Exceptions

[SamFileFormatException](Fantasista.DNA.SAMFile.Exceptions.SamFileFormatException.md 'Fantasista.DNA.SAMFile.Exceptions.SamFileFormatException')  
Thrown when an invalid sorting order value is set.