#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[RawSequenceAlignment](Fantasista.DNA.SAMFile.RawSequenceAlignment.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment')

## RawSequenceAlignment.MappingQuality Property

Gets or sets the mapping quality score for the sequence alignment record.

```csharp
public int MappingQuality { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

### Remarks
The `MappingQuality` property represents the quality of the mapping of the sequence to the reference genome,  
typically indicated by a non-negative integer. Higher values indicate better alignment confidence. This is  
generally used in bioinformatics to assess the accuracy of the alignment in sequence analysis.