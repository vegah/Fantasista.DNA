#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[RawSequenceAlignment](Fantasista.DNA.SAMFile.RawSequenceAlignment.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment')

## RawSequenceAlignment.Position Property

Gets or sets the position of the first base in the alignment within the reference sequence.

```csharp
public int Position { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

### Remarks
The `Position` property indicates the coordinate of the first base of the query sequence  
as it aligns to the reference sequence. This position is 1-based, following the SAM  
(Sequence Alignment/Map) format specification, which is commonly used in sequencing data processing.