#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.GtfFile](Fantasista.DNA.GtfFile.md 'Fantasista.DNA.GtfFile').[GenomicFeature](Fantasista.DNA.GtfFile.GenomicFeature.md 'Fantasista.DNA.GtfFile.GenomicFeature')

## GenomicFeature.Phase Property

Gets or sets the phase of the feature, indicating the frame of the feature’s sequence.

```csharp
public System.Nullable<int> Phase { get; set; }
```

#### Property Value
[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

### Remarks
The phase specifies the reading frame of a feature that is a coding exon.  
Its value can be 0, 1, 2, or null if not applicable. This property corresponds  
to the eighth column in GFF3 files.