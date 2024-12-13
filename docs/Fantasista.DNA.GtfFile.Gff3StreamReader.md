#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.GtfFile](Fantasista.DNA.GtfFile.md 'Fantasista.DNA.GtfFile')

## Gff3StreamReader Class

Provides functionality to parse GFF3 (General Feature Format version 3) data  
from text-based inputs such as streams or strings.

```csharp
public class Gff3StreamReader :
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Gff3StreamReader

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')

### Remarks
This class is designed to read and process GFF3 format data containing genomic  
feature annotations. It extracts data line-by-line, distinguishing between  
genomic feature entries and comments. Genomic features are returned as objects  
of type [GenomicFeature](Fantasista.DNA.GtfFile.GenomicFeature.md 'Fantasista.DNA.GtfFile.GenomicFeature'), while comments are collected separately  
in the [Comments](Fantasista.DNA.GtfFile.Gff3StreamReader.Comments.md 'Fantasista.DNA.GtfFile.Gff3StreamReader.Comments') list.

| Constructors | |
| :--- | :--- |
| [Gff3StreamReader(string)](Fantasista.DNA.GtfFile.Gff3StreamReader.Gff3StreamReader(string).md 'Fantasista.DNA.GtfFile.Gff3StreamReader.Gff3StreamReader(string)') | Provides a reader to parse GFF3 (General Feature Format version 3) data<br/>from a stream or string input source, extracting genomic features and comments. |
| [Gff3StreamReader(Stream)](Fantasista.DNA.GtfFile.Gff3StreamReader.Gff3StreamReader(System.IO.Stream).md 'Fantasista.DNA.GtfFile.Gff3StreamReader.Gff3StreamReader(System.IO.Stream)') | Provides a reader to parse GFF3 (General Feature Format version 3) data<br/>from a stream or string input source, extracting genomic features and comments. |

| Properties | |
| :--- | :--- |
| [Comments](Fantasista.DNA.GtfFile.Gff3StreamReader.Comments.md 'Fantasista.DNA.GtfFile.Gff3StreamReader.Comments') | Gets or sets a collection of comment lines extracted from the input data stream. |

| Methods | |
| :--- | :--- |
| [Dispose()](Fantasista.DNA.GtfFile.Gff3StreamReader.Dispose().md 'Fantasista.DNA.GtfFile.Gff3StreamReader.Dispose()') | Releases all resources used by the [Gff3StreamReader](Fantasista.DNA.GtfFile.Gff3StreamReader.md 'Fantasista.DNA.GtfFile.Gff3StreamReader') object. |
| [Read()](Fantasista.DNA.GtfFile.Gff3StreamReader.Read().md 'Fantasista.DNA.GtfFile.Gff3StreamReader.Read()') | Reads and parses lines from the underlying data stream, extracting genomic features. |
