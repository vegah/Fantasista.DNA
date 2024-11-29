#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[RawSequenceAlignment](Fantasista.DNA.SAMFile.RawSequenceAlignment.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment')

## RawSequenceAlignment.PNext Property

Gets or sets the position of the next segment in the template for the sequence alignment.

```csharp
public int PNext { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

### Remarks
The `PNext` property indicates the 1-based position of the next segment in the template for paired-end  
or mate pair sequencing reads, relative to the `ReferenceSequence`. If no next segment exists, it is usually set  
to zero. This information is utilized for determining the layout of paired read alignments in genomic coordinates.