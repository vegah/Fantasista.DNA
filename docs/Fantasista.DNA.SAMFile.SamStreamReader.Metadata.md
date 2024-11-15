#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[SamStreamReader](Fantasista.DNA.SAMFile.SamStreamReader.md 'Fantasista.DNA.SAMFile.SamStreamReader')

## SamStreamReader.Metadata Property

Gets the metadata associated with the SAM file.

```csharp
public Fantasista.DNA.SAMFile.SamFileLevelMetadata Metadata { get; }
```

#### Property Value
[SamFileLevelMetadata](Fantasista.DNA.SAMFile.SamFileLevelMetadata.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata')

### Remarks
The Metadata property provides access to various metadata information  
extracted from the SAM file header, such as version, sorting order of  
alignments, grouping of alignments, and sub-sorting.