#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[RawSequenceAlignment](Fantasista.DNA.SAMFile.RawSequenceAlignment.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment')

## RawSequenceAlignment.Quality Property

Gets or sets the quality scores of the read sequence in the sequence alignment record.

```csharp
public string Quality { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

### Remarks
The `Quality` property represents the ASCII-encoded quality scores for each base in the read sequence.  
In the SAM format, these scores indicate the probability of a sequencing error at each base position.