#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[SamFileReadGroup](Fantasista.DNA.SAMFile.SamFileReadGroup.md 'Fantasista.DNA.SAMFile.SamFileReadGroup')

## SamFileReadGroup.Parse(string) Method

Parses a single line of SAM read group headers input and sets the relevant properties of the SamFileReadGroup  
instance.

```csharp
public void Parse(string line);
```
#### Parameters

<a name='Fantasista.DNA.SAMFile.SamFileReadGroup.Parse(string).line'></a>

`line` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The input string representing a line from a SAM file which contains various fields separated by tab  
characters.