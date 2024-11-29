#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[SamStreamReader](Fantasista.DNA.SAMFile.SamStreamReader.md 'Fantasista.DNA.SAMFile.SamStreamReader')

## SamStreamReader.ReadGroups Property

Gets or sets the collection of read groups in the SAM file.

```csharp
public System.Collections.Generic.List<Fantasista.DNA.SAMFile.SamFileReadGroup> ReadGroups { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[SamFileReadGroup](Fantasista.DNA.SAMFile.SamFileReadGroup.md 'Fantasista.DNA.SAMFile.SamFileReadGroup')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

### Remarks
The ReadGroups property contains a list of [SamFileReadGroup](Fantasista.DNA.SAMFile.SamFileReadGroup.md 'Fantasista.DNA.SAMFile.SamFileReadGroup') instances representing various  
read groups present in the SAM file. Each read group provides detailed information about a specific set of  
reads, including identifiers, platform unit, library, sample, and other metadata associated with the read  
group's sequencing run.