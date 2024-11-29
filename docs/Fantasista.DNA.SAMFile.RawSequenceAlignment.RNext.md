#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[RawSequenceAlignment](Fantasista.DNA.SAMFile.RawSequenceAlignment.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment')

## RawSequenceAlignment.RNext Property

Gets or sets the reference sequence field indicating the reference for the next read in the template.

```csharp
public string RNext { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

### Remarks
The `RNext` property specifies the reference sequence name of the next read in the template.  
It is commonly used in paired-end sequencing to denote the reference name of the mate/next read.  
Valid values include a specific reference sequence name or the special symbol "=" which denotes  
that the reference sequence is the same as the current read's reference sequence.