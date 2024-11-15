#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[SamFileLevelMetadata](Fantasista.DNA.SAMFile.SamFileLevelMetadata.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata')

## SamFileLevelMetadata.GroupingOfAlignments Enum

Defines the possible grouping options for alignments within a SAM (Sequence Alignment/Map) file.  
Indicates how alignments are grouped, whether by query, reference, or if no specific grouping is applied.

```csharp
public enum SamFileLevelMetadata.GroupingOfAlignments
```
### Fields

<a name='Fantasista.DNA.SAMFile.SamFileLevelMetadata.GroupingOfAlignments.None'></a>

`None` 0

Indicates that no specific grouping is applied to the alignments within a SAM (Sequence Alignment/Map) file.  
This serves as a default value when alignments are not grouped by any particular criteria.

<a name='Fantasista.DNA.SAMFile.SamFileLevelMetadata.GroupingOfAlignments.Query'></a>

`Query` 1

Indicates that alignments within a SAM (Sequence Alignment/Map) file are grouped according to their query name.  
This grouping allows for easier analysis and retrieval of alignments based on query-specific criteria.

<a name='Fantasista.DNA.SAMFile.SamFileLevelMetadata.GroupingOfAlignments.Reference'></a>

`Reference` 2

Indicates that the alignments within a SAM (Sequence Alignment/Map) file are grouped by their reference sequence.  
This grouping is used to organize alignments based on their associated reference sequences within the file.