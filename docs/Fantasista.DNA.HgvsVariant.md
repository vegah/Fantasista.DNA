#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA](Fantasista.DNA.md 'Fantasista.DNA')

## HgvsVariant Class

Describes a HgvsVariant (Human Genome Variation Society Formatting)

```csharp
public class HgvsVariant
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; HgvsVariant

| Properties | |
| :--- | :--- |
| [GeneSymbol](Fantasista.DNA.HgvsVariant.GeneSymbol.md 'Fantasista.DNA.HgvsVariant.GeneSymbol') | The gene symbol. For example ACADVL |
| [NewBase](Fantasista.DNA.HgvsVariant.NewBase.md 'Fantasista.DNA.HgvsVariant.NewBase') | New base |
| [Offset](Fantasista.DNA.HgvsVariant.Offset.md 'Fantasista.DNA.HgvsVariant.Offset') | The offset - for example +5 |
| [OriginalBase](Fantasista.DNA.HgvsVariant.OriginalBase.md 'Fantasista.DNA.HgvsVariant.OriginalBase') | Original base |
| [Position](Fantasista.DNA.HgvsVariant.Position.md 'Fantasista.DNA.HgvsVariant.Position') | Position |
| [ReferenceSequence](Fantasista.DNA.HgvsVariant.ReferenceSequence.md 'Fantasista.DNA.HgvsVariant.ReferenceSequence') | Descrbes the reference sequence - the first part of the HGVS Format- for example NM_000018.4<br/>This is a ReferenceSequenceInfo object which contains more information |
| [Type](Fantasista.DNA.HgvsVariant.Type.md 'Fantasista.DNA.HgvsVariant.Type') | Type |

| Methods | |
| :--- | :--- |
| [Parse(string)](Fantasista.DNA.HgvsVariant.Parse(string).md 'Fantasista.DNA.HgvsVariant.Parse(string)') | Parses a hgvs string to a HgvsVariant model. The process can be reversed with HgvsVariant.ToString() |
| [ToString()](Fantasista.DNA.HgvsVariant.ToString().md 'Fantasista.DNA.HgvsVariant.ToString()') | Writes the model back in HgvsFormat. |
