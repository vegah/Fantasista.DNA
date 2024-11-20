#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile')

## SamFileAlignmentInformationFlag Enum

Describes the different flags for SAM file alignment information.

```csharp
public enum SamFileAlignmentInformationFlag
```
### Fields

<a name='Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag.EachSegmentProperlyAligned'></a>

`EachSegmentProperlyAligned` 2

each segment properly aligned according to the aligner

<a name='Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag.NextSegmentUnmapped'></a>

`NextSegmentUnmapped` 8

next segment in the template unmapped

<a name='Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag.NotPassingFilters'></a>

`NotPassingFilters` 512

not passing filters, such as platform/vendor quality controls

<a name='Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag.PcrOrOpticalDuplicate'></a>

`PcrOrOpticalDuplicate` 1024

PCR or optical duplicate

<a name='Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag.SecondaryAlignment'></a>

`SecondaryAlignment` 256

secondary alignment

<a name='Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag.SegmentUnmapped'></a>

`SegmentUnmapped` 4

segment unmapped in sequencing

<a name='Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag.SeqBeingReverseComplemented'></a>

`SeqBeingReverseComplemented` 16

SEQ being reverse complemented

<a name='Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag.SeqOfNextSegmentInTemplateBeingReverseComplemented'></a>

`SeqOfNextSegmentInTemplateBeingReverseComplemented` 32

SEQ of the next segment in the template being reverse complemented

<a name='Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag.SupplementaryAlignment'></a>

`SupplementaryAlignment` 2048

supplementary alignment

<a name='Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag.TemplateHavingMultipleSegments'></a>

`TemplateHavingMultipleSegments` 1

template having multiple segments in sequencing

<a name='Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag.TheFirstSegmentInTemplate'></a>

`TheFirstSegmentInTemplate` 64

the first segment in the template

<a name='Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag.TheLastSegmentInTemplate'></a>

`TheLastSegmentInTemplate` 128

the last segment in the template