#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.GtfFile](Fantasista.DNA.GtfFile.md 'Fantasista.DNA.GtfFile').[GenomicFeature](Fantasista.DNA.GtfFile.GenomicFeature.md 'Fantasista.DNA.GtfFile.GenomicFeature')

## GenomicFeature.Attributes Property

Gets or sets the collection of attributes associated with the genomic feature.

```csharp
public Fantasista.DNA.GtfFile.GenomicFeatureAttributes Attributes { get; set; }
```

#### Property Value
[GenomicFeatureAttributes](Fantasista.DNA.GtfFile.GenomicFeatureAttributes.md 'Fantasista.DNA.GtfFile.GenomicFeatureAttributes')

### Remarks
Attributes represent metadata for the genomic feature in the form of key-value pairs  
as specified in the GTF or GFF3 file. These may include additional informational fields such as  
gene name, transcript ID, or other feature-specific data.