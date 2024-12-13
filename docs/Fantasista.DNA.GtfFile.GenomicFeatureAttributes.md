#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.GtfFile](Fantasista.DNA.GtfFile.md 'Fantasista.DNA.GtfFile')

## GenomicFeatureAttributes Class

Represents a collection of attributes associated with a genomic feature parsed from a GTF (General Transfer Format)  
file.

```csharp
public class GenomicFeatureAttributes : System.Collections.Generic.Dictionary<string, string>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2') &#129106; GenomicFeatureAttributes

### Remarks
The class extends the functionality of a dictionary to store key-value pairs of metadata associated with genomic  
features.  
These attributes typically provide additional information about the features, such as gene ID, transcript ID, and  
other relevant annotations.