#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.GtfFile](Fantasista.DNA.GtfFile.md 'Fantasista.DNA.GtfFile').[Gff3StreamReader](Fantasista.DNA.GtfFile.Gff3StreamReader.md 'Fantasista.DNA.GtfFile.Gff3StreamReader')

## Gff3StreamReader.Comments Property

Gets or sets a collection of comment lines extracted from the input data stream.

```csharp
public System.Collections.Generic.List<string> Comments { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

### Remarks
During the parsing process, lines that start with a '#' character are identified as comments  
and stored in this property. These comments may contain metadata or additional information  
relevant to the genomic data being processed.