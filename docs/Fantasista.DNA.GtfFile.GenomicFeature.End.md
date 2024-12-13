#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.GtfFile](Fantasista.DNA.GtfFile.md 'Fantasista.DNA.GtfFile').[GenomicFeature](Fantasista.DNA.GtfFile.GenomicFeature.md 'Fantasista.DNA.GtfFile.GenomicFeature')

## GenomicFeature.End Property

Gets or sets the end position of the genomic feature in the sequence.

```csharp
public int End { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

### Remarks
The end position represents the 1-based inclusive end coordinate on the sequence  
where the genomic feature terminates. This property corresponds to the fifth column  
in GTF or GFF3 files and should always be greater than or equal to the start position.