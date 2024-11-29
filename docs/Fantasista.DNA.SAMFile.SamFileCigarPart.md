#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile')

## SamFileCigarPart Class

Represents a part of a CIGAR string which is used to describe the alignment  
of a DNA sequence. A CIGAR string is composed of multiple parts, each  
defining an operation and the number of nucleotides it affects.

```csharp
public class SamFileCigarPart
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SamFileCigarPart

| Constructors | |
| :--- | :--- |
| [SamFileCigarPart(CigarOperator, int)](Fantasista.DNA.SAMFile.SamFileCigarPart.SamFileCigarPart(Fantasista.DNA.SAMFile.CigarOperator,int).md 'Fantasista.DNA.SAMFile.SamFileCigarPart.SamFileCigarPart(Fantasista.DNA.SAMFile.CigarOperator, int)') | Represents a part of a CIGAR string which is used to describe the alignment<br/>of a DNA sequence. A CIGAR string is composed of multiple parts, each<br/>defining an operation and the number of nucleotides it affects. |

| Properties | |
| :--- | :--- |
| [NumberOfAlignedNucelotides](Fantasista.DNA.SAMFile.SamFileCigarPart.NumberOfAlignedNucelotides.md 'Fantasista.DNA.SAMFile.SamFileCigarPart.NumberOfAlignedNucelotides') | Gets or sets the number of nucleotides affected by this part of the CIGAR string.<br/>This value indicates how many nucleotides are aligned according to the specified operator in a DNA sequence<br/>alignment. |
| [Operator](Fantasista.DNA.SAMFile.SamFileCigarPart.Operator.md 'Fantasista.DNA.SAMFile.SamFileCigarPart.Operator') | Gets or sets the operator for this part of the CIGAR string. The operator<br/>represents the type of operation (e.g., match, mismatch, insertion, deletion)<br/>to be performed on the corresponding nucleotides in a DNA sequence alignment. |
