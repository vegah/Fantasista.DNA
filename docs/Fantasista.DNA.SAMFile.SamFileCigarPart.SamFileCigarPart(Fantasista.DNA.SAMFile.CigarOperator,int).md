#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[SamFileCigarPart](Fantasista.DNA.SAMFile.SamFileCigarPart.md 'Fantasista.DNA.SAMFile.SamFileCigarPart')

## SamFileCigarPart(CigarOperator, int) Constructor

Represents a part of a CIGAR string which is used to describe the alignment  
of a DNA sequence. A CIGAR string is composed of multiple parts, each  
defining an operation and the number of nucleotides it affects.

```csharp
public SamFileCigarPart(Fantasista.DNA.SAMFile.CigarOperator cigarOperator, int numberOfAlignedNucelotides);
```
#### Parameters

<a name='Fantasista.DNA.SAMFile.SamFileCigarPart.SamFileCigarPart(Fantasista.DNA.SAMFile.CigarOperator,int).cigarOperator'></a>

`cigarOperator` [CigarOperator](Fantasista.DNA.SAMFile.CigarOperator.md 'Fantasista.DNA.SAMFile.CigarOperator')

<a name='Fantasista.DNA.SAMFile.SamFileCigarPart.SamFileCigarPart(Fantasista.DNA.SAMFile.CigarOperator,int).numberOfAlignedNucelotides'></a>

`numberOfAlignedNucelotides` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')