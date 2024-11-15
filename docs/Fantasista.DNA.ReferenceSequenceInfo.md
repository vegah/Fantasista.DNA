#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA](Fantasista.DNA.md 'Fantasista.DNA')

## ReferenceSequenceInfo Class

Describes the ReferenceSequence part of Human Genome Variation Society Formatting

```csharp
public class ReferenceSequenceInfo
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ReferenceSequenceInfo

| Properties | |
| :--- | :--- |
| [AccessionNumber](Fantasista.DNA.ReferenceSequenceInfo.AccessionNumber.md 'Fantasista.DNA.ReferenceSequenceInfo.AccessionNumber') | AccessionNumber as string |
| [Prefix](Fantasista.DNA.ReferenceSequenceInfo.Prefix.md 'Fantasista.DNA.ReferenceSequenceInfo.Prefix') | Prefix - What comes before _ |
| [Version](Fantasista.DNA.ReferenceSequenceInfo.Version.md 'Fantasista.DNA.ReferenceSequenceInfo.Version') | Version as an int |

| Methods | |
| :--- | :--- |
| [Parse(string)](Fantasista.DNA.ReferenceSequenceInfo.Parse(string).md 'Fantasista.DNA.ReferenceSequenceInfo.Parse(string)') | Static class that parses a Reference Sequence - part of the HgvsVariant<br/>This will parse the first part - for example NM_000018.4<br/>In most cases you want to use HgvsVariant directly, which will use this class |
| [ToString()](Fantasista.DNA.ReferenceSequenceInfo.ToString().md 'Fantasista.DNA.ReferenceSequenceInfo.ToString()') | The reference sequence info part as a string |
