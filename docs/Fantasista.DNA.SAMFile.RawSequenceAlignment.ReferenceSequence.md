#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[RawSequenceAlignment](Fantasista.DNA.SAMFile.RawSequenceAlignment.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment')

## RawSequenceAlignment.ReferenceSequence Property

Gets or sets the reference sequence name for the sequence alignment record.

```csharp
public string ReferenceSequence { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

### Remarks
The `ReferenceSequence` property represents the name of the reference sequence that the  
given sequence has been aligned to, according to the SAM (Sequence Alignment/Map) file format.  
It typically corresponds to the query or subject sequence in genomic data analysis.