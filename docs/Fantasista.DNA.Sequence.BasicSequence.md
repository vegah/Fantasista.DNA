#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.Sequence](Fantasista.DNA.Sequence.md 'Fantasista.DNA.Sequence')

## BasicSequence Class

Describes a sequence - for example from FASTA or FASTQ files

```csharp
public class BasicSequence
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; BasicSequence

Derived  
&#8627; [SimpleInspectedSequence](Fantasista.DNA.Sequence.SimpleInspectedSequence.md 'Fantasista.DNA.Sequence.SimpleInspectedSequence')

| Constructors | |
| :--- | :--- |
| [BasicSequence(string, string, string, string)](Fantasista.DNA.Sequence.BasicSequence.BasicSequence(string,string,string,string).md 'Fantasista.DNA.Sequence.BasicSequence.BasicSequence(string, string, string, string)') | A basic sequence constructor. |

| Properties | |
| :--- | :--- |
| [CharacterFrequency](Fantasista.DNA.Sequence.BasicSequence.CharacterFrequency.md 'Fantasista.DNA.Sequence.BasicSequence.CharacterFrequency') | The frequency of the characters in the sequence |
| [Identifier](Fantasista.DNA.Sequence.BasicSequence.Identifier.md 'Fantasista.DNA.Sequence.BasicSequence.Identifier') | Identifier field - in FASTA everything after lower than sign, in FASTQ everything after @ |
| [QualityFrequency](Fantasista.DNA.Sequence.BasicSequence.QualityFrequency.md 'Fantasista.DNA.Sequence.BasicSequence.QualityFrequency') | The frequency of the characters in the quality sequence |
| [QualityIdentifier](Fantasista.DNA.Sequence.BasicSequence.QualityIdentifier.md 'Fantasista.DNA.Sequence.BasicSequence.QualityIdentifier') | The identifier of the quality - everything after + - often the same as Identifier |
| [QualityLength](Fantasista.DNA.Sequence.BasicSequence.QualityLength.md 'Fantasista.DNA.Sequence.BasicSequence.QualityLength') | Length of the quality information - number of chars |
| [RawQuality](Fantasista.DNA.Sequence.BasicSequence.RawQuality.md 'Fantasista.DNA.Sequence.BasicSequence.RawQuality') | The raw quality as a string. This is always NULL in FASTA |
| [RawSequence](Fantasista.DNA.Sequence.BasicSequence.RawSequence.md 'Fantasista.DNA.Sequence.BasicSequence.RawSequence') | The sequence as a string |
| [SequenceLength](Fantasista.DNA.Sequence.BasicSequence.SequenceLength.md 'Fantasista.DNA.Sequence.BasicSequence.SequenceLength') | Length of the sequence - number of chars |
| [UniqueCharacters](Fantasista.DNA.Sequence.BasicSequence.UniqueCharacters.md 'Fantasista.DNA.Sequence.BasicSequence.UniqueCharacters') | Distinct characters in sequence |
| [UniqueQualityCharacters](Fantasista.DNA.Sequence.BasicSequence.UniqueQualityCharacters.md 'Fantasista.DNA.Sequence.BasicSequence.UniqueQualityCharacters') | Distinct characters in the quality sequence |
