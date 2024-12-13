#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.GtfFile](Fantasista.DNA.GtfFile.md 'Fantasista.DNA.GtfFile').[Gff3StreamReader](Fantasista.DNA.GtfFile.Gff3StreamReader.md 'Fantasista.DNA.GtfFile.Gff3StreamReader')

## Gff3StreamReader.Read() Method

Reads and parses lines from the underlying data stream, extracting genomic features.

```csharp
public System.Collections.Generic.IEnumerable<Fantasista.DNA.GtfFile.GenomicFeature> Read();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[GenomicFeature](Fantasista.DNA.GtfFile.GenomicFeature.md 'Fantasista.DNA.GtfFile.GenomicFeature')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An enumerable collection of [GenomicFeature](Fantasista.DNA.GtfFile.GenomicFeature.md 'Fantasista.DNA.GtfFile.GenomicFeature') objects representing parsed genomic features  
from the input data stream. Comments encountered during parsing are stored in the [Comments](Fantasista.DNA.GtfFile.Gff3StreamReader.Comments.md 'Fantasista.DNA.GtfFile.Gff3StreamReader.Comments') property.