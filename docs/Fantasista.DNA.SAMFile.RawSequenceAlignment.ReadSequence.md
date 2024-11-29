#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[RawSequenceAlignment](Fantasista.DNA.SAMFile.RawSequenceAlignment.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment')

## RawSequenceAlignment.ReadSequence Property

Gets or sets the read sequence for the sequence alignment record.

```csharp
public string ReadSequence { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

### Remarks
The `ReadSequence` property represents the actual sequence of nucleotides  
or amino acids from the read that is being aligned. This is a critical component  
of sequence alignment as it provides the basis for matching against a reference  
sequence to determine alignment position and quality.