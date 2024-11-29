#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[SamFileReferenceSequenceDictionaryElement](Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.md 'Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement')

## SamFileReferenceSequenceDictionaryElement.Parse(string) Method

Parses the provided reference sequence dictionary header and splits it into key-value pairs  
to populate the appropriate properties of the  
[SamFileReferenceSequenceDictionaryElement](Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.md 'Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement') instance.

```csharp
public void Parse(string referenceSequenceDictionaryHeader);
```
#### Parameters

<a name='Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.Parse(string).referenceSequenceDictionaryHeader'></a>

`referenceSequenceDictionaryHeader` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The reference sequence dictionary header string  
containing key-value pairs separated by tabs or spaces.