#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[RawSequenceAlignment](Fantasista.DNA.SAMFile.RawSequenceAlignment.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment')

## RawSequenceAlignment.OptionalValueCollection Property

Gets or sets a collection of optional values for the sequence alignment record.

```csharp
public Fantasista.DNA.SAMFile.SamFileOptionalValueCollection OptionalValueCollection { get; set; }
```

#### Property Value
[SamFileOptionalValueCollection](Fantasista.DNA.SAMFile.SamFileOptionalValueCollection.md 'Fantasista.DNA.SAMFile.SamFileOptionalValueCollection')

### Remarks
The `OptionalValueCollection` property represents a collection of optional values associated with  
the sequence alignment as specified in the SAM (Sequence Alignment/Map) format. These optional fields  
provide additional information, which may include tags, types, and values that are not part of the core  
alignment data but offer further insights into the alignment process or characteristics of the read.