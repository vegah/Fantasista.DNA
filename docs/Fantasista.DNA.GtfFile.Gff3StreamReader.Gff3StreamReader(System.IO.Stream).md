#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.GtfFile](Fantasista.DNA.GtfFile.md 'Fantasista.DNA.GtfFile').[Gff3StreamReader](Fantasista.DNA.GtfFile.Gff3StreamReader.md 'Fantasista.DNA.GtfFile.Gff3StreamReader')

## Gff3StreamReader(Stream) Constructor

Provides a reader to parse GFF3 (General Feature Format version 3) data  
from a stream or string input source, extracting genomic features and comments.

```csharp
public Gff3StreamReader(System.IO.Stream s);
```
#### Parameters

<a name='Fantasista.DNA.GtfFile.Gff3StreamReader.Gff3StreamReader(System.IO.Stream).s'></a>

`s` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')

### Remarks
Gff3StreamReader is designed to process biological data in the GFF3 format. It reads and  
parses the input line-by-line, distinguishing between genomic features and comments.  
Parsed genomic features are returned as instances of [GenomicFeature](Fantasista.DNA.GtfFile.GenomicFeature.md 'Fantasista.DNA.GtfFile.GenomicFeature').  
Comments encountered during the parsing process are stored in the [Comments](Fantasista.DNA.GtfFile.Gff3StreamReader.Comments.md 'Fantasista.DNA.GtfFile.Gff3StreamReader.Comments') list.