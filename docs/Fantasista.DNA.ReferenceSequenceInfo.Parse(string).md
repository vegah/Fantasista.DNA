#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA](Fantasista.DNA.md 'Fantasista.DNA').[ReferenceSequenceInfo](Fantasista.DNA.ReferenceSequenceInfo.md 'Fantasista.DNA.ReferenceSequenceInfo')

## ReferenceSequenceInfo.Parse(string) Method

Static class that parses a Reference Sequence - part of the HgvsVariant  
This will parse the first part - for example NM_000018.4  
In most cases you want to use HgvsVariant directly, which will use this class

```csharp
public static Fantasista.DNA.ReferenceSequenceInfo Parse(string s);
```
#### Parameters

<a name='Fantasista.DNA.ReferenceSequenceInfo.Parse(string).s'></a>

`s` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

string containting the Reference Sequence part of the HgvsVariant

#### Returns
[ReferenceSequenceInfo](Fantasista.DNA.ReferenceSequenceInfo.md 'Fantasista.DNA.ReferenceSequenceInfo')  
A parsed ReferenceSequenceInfo