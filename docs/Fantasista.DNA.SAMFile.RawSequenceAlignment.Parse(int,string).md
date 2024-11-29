#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[RawSequenceAlignment](Fantasista.DNA.SAMFile.RawSequenceAlignment.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment')

## RawSequenceAlignment.Parse(int, string) Method

Parses a string representing a SAM file line into a RawSequenceAlignment object.

```csharp
public static Fantasista.DNA.SAMFile.RawSequenceAlignment Parse(int lineNo, string line);
```
#### Parameters

<a name='Fantasista.DNA.SAMFile.RawSequenceAlignment.Parse(int,string).lineNo'></a>

`lineNo` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The line number in the SAM file, used for error reporting.

<a name='Fantasista.DNA.SAMFile.RawSequenceAlignment.Parse(int,string).line'></a>

`line` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The raw line of text from a SAM file to be parsed.

#### Returns
[RawSequenceAlignment](Fantasista.DNA.SAMFile.RawSequenceAlignment.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment')  
A RawSequenceAlignment object populated with data parsed from the SAM file line.