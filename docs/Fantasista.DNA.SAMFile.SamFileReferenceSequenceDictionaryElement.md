#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile')

## SamFileReferenceSequenceDictionaryElement Class

Represents an element in the reference sequence dictionary within a SAM file.

```csharp
public class SamFileReferenceSequenceDictionaryElement
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SamFileReferenceSequenceDictionaryElement

| Constructors | |
| :--- | :--- |
| [SamFileReferenceSequenceDictionaryElement()](Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.SamFileReferenceSequenceDictionaryElement().md 'Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.SamFileReferenceSequenceDictionaryElement()') | Parameterless constructor |

| Properties | |
| :--- | :--- |
| [AlternateLocus](Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.AlternateLocus.md 'Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.AlternateLocus') | Gets or sets the alternate locus as a string. |
| [AlternateReferenceSequenceNames](Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.AlternateReferenceSequenceNames.md 'Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.AlternateReferenceSequenceNames') | Gets or sets the alternative reference sequence names as an array of strings. |
| [Description](Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.Description.md 'Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.Description') | Gets or sets the description of the reference sequence. |
| [GenomeAssemblyIdentifier](Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.GenomeAssemblyIdentifier.md 'Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.GenomeAssemblyIdentifier') | Gets or sets the genome assembly identifier. |
| [Md5Checksum](Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.Md5Checksum.md 'Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.Md5Checksum') | Gets or sets the MD5 checksum of the reference sequence. |
| [MoleculeTopology](Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.MoleculeTopology.md 'Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.MoleculeTopology') | Gets or sets the topology of the molecule, indicating whether it is linear or circular.<br/>MoleculeTopology.Linear represents a molecule with a linear structure.<br/>MoleculeTopology.Circular represents a molecule with a circular structure. |
| [ReferenceSequenceLength](Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.ReferenceSequenceLength.md 'Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.ReferenceSequenceLength') | Gets or sets the length of the reference sequence. |
| [ReferenceSequenceName](Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.ReferenceSequenceName.md 'Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.ReferenceSequenceName') | Gets or sets the name of the reference sequence. |
| [SequenceUri](Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.SequenceUri.md 'Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.SequenceUri') | Gets or sets the URI associated with the reference sequence. |
| [Species](Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.Species.md 'Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.Species') | Gets or sets the species for the reference sequence. |

| Methods | |
| :--- | :--- |
| [Parse(string)](Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.Parse(string).md 'Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.Parse(string)') | Parses the provided reference sequence dictionary header and splits it into key-value pairs<br/>to populate the appropriate properties of the<br/>[SamFileReferenceSequenceDictionaryElement](Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.md 'Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement') instance. |
