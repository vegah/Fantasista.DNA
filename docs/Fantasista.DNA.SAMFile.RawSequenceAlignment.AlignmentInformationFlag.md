#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[RawSequenceAlignment](Fantasista.DNA.SAMFile.RawSequenceAlignment.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment')

## RawSequenceAlignment.AlignmentInformationFlag Property

Gets or sets the alignment information flags for the sequence alignment record.

```csharp
public Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag AlignmentInformationFlag { get; set; }
```

#### Property Value
[SamFileAlignmentInformationFlag](Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag.md 'Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag')

### Remarks
The `AlignmentInformationFlag` property represents a set of flags indicating various properties  
of the sequence alignment according to the SAM (Sequence Alignment/Map) format specification.  
These flags can denote characteristics such as whether a segment is unmapped, if it is part of  
multiple segments, if it is reverse complemented, among others.