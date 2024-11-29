#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[SamFileLevelMetadata](Fantasista.DNA.SAMFile.SamFileLevelMetadata.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata')

## SamFileLevelMetadata.SortingOrderOfAlignments Enum

Represents the different possible sorting orders for alignments within a SAM (Sequence Alignment/Map) file.

```csharp
public enum SamFileLevelMetadata.SortingOrderOfAlignments
```
### Fields

<a name='Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments.Coordinate'></a>

`Coordinate` 3

Indicates that alignments within a SAM (Sequence Alignment/Map) file are sorted by the reference sequence  
coordinates.  
This sorting method arranges alignments in the order they appear on the reference sequence.

<a name='Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments.Queryname'></a>

`Queryname` 2

Orders the alignments by query name within a SAM (Sequence Alignment/Map) file.  
This sorting order facilitates grouping of alignments that share the same read name.

<a name='Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments.Unknown'></a>

`Unknown` 0

Indicates an undefined or unrecognized sorting order for alignments within a SAM (Sequence Alignment/Map) file.  
This serves as a default value when the sorting order cannot be determined or is not specified.

<a name='Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments.Unsorted'></a>

`Unsorted` 1

Indicates that the alignments within a SAM (Sequence Alignment/Map) file are not sorted in any particular order.  
This option specifies that no sorting order has been applied to the alignments.