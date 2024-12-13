#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.GtfFile](Fantasista.DNA.GtfFile.md 'Fantasista.DNA.GtfFile').[GenomicFeature](Fantasista.DNA.GtfFile.GenomicFeature.md 'Fantasista.DNA.GtfFile.GenomicFeature')

## GenomicFeature.Score Property

Gets or sets the score of the genomic feature.

```csharp
public System.Nullable<decimal> Score { get; set; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

### Remarks
The score represents a floating-point value which may indicate the level of confidence  
or significance of the feature. This property corresponds to the sixth column in GTF or GFF3 files.  
A null value indicates the absence of a score, which is often represented as '.' in the source file.