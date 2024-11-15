#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[SamStreamReader](Fantasista.DNA.SAMFile.SamStreamReader.md 'Fantasista.DNA.SAMFile.SamStreamReader')

## SamStreamReader.ReferenceSequenceDictionary Property

Gets or sets the dictionary of reference sequences in the SAM file.

```csharp
public Fantasista.DNA.SAMFile.SamFileMetadataExceptions.SamFileReferenceSequenceDictionary ReferenceSequenceDictionary { get; set; }
```

#### Property Value
[SamFileReferenceSequenceDictionary](Fantasista.DNA.SAMFile.SamFileMetadataExceptions.SamFileReferenceSequenceDictionary.md 'Fantasista.DNA.SAMFile.SamFileMetadataExceptions.SamFileReferenceSequenceDictionary')

### Remarks
The ReferenceSequenceDictionary property provides access to the collection of reference sequences  
extracted from the SAM file header. This includes information such as the reference sequence names,  
lengths, descriptions, and other relevant metadata.