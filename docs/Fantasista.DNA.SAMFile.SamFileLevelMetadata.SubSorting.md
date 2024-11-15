#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[SamFileLevelMetadata](Fantasista.DNA.SAMFile.SamFileLevelMetadata.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata')

## SamFileLevelMetadata.SubSorting Property

Gets or sets the sub-sorting criteria for the SAM (Sequence Alignment/Map) file.  
This property specifies detailed sorting information beyond the primary sorting order defined  
by [SortingOrderOfAlignments](Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments').

```csharp
public string SubSorting { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Exceptions

[SamFileFormatException](Fantasista.DNA.SAMFile.SamFileMetadataExceptions.SamFileFormatException.md 'Fantasista.DNA.SAMFile.SamFileMetadataExceptions.SamFileFormatException')  
Thrown when an invalid sub-sorting value is set.