#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.GtfFile](Fantasista.DNA.GtfFile.md 'Fantasista.DNA.GtfFile').[GenomicFeature](Fantasista.DNA.GtfFile.GenomicFeature.md 'Fantasista.DNA.GtfFile.GenomicFeature')

## GenomicFeature.Strand Property

Gets or sets the strand of the genomic feature.

```csharp
public char Strand { get; set; }
```

#### Property Value
[System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

### Remarks
The strand indicates the directionality of the genomic feature on the DNA strand.  
It is typically represented by '+' for the positive strand, '-' for the negative strand,  
or '.' for a feature with no strand specificity. This information is commonly found in  
the strand column of GTF or GFF3 files.