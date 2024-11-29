#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[RawSequenceAlignment](Fantasista.DNA.SAMFile.RawSequenceAlignment.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment')

## RawSequenceAlignment.CIGAR Property

Gets or sets the CIGAR string for the sequence alignment record.

```csharp
public Fantasista.DNA.SAMFile.SamFileCigar CIGAR { get; set; }
```

#### Property Value
[Fantasista.DNA.SAMFile.SamFileCigar](https://docs.microsoft.com/en-us/dotnet/api/Fantasista.DNA.SAMFile.SamFileCigar 'Fantasista.DNA.SAMFile.SamFileCigar')

### Remarks
The `CIGAR` property represents the CIGAR (Compact Idiosyncratic Gapped Alignment Report) string,  
which describes the alignment between the read and the reference sequence. It contains information about  
the length and type of each alignment operation, such as matches, insertions, deletions, and skips, following  
the SAM (Sequence Alignment/Map) format specification.