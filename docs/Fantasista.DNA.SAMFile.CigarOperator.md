#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile')

## CigarOperator Enum

Represents the operations possible in a CIGAR string used for DNA sequence alignment.

```csharp
public enum CigarOperator
```
### Fields

<a name='Fantasista.DNA.SAMFile.CigarOperator.Deletion'></a>

`Deletion` 2

Represents a deletion operation in a CIGAR string, indicating that nucleotides are  
present in the reference sequence but absent in the query sequence. This operation  
signifies a gap in the alignment where the reference has additional nucleotides.

<a name='Fantasista.DNA.SAMFile.CigarOperator.Gap'></a>

`Gap` 3

Represents a gap in the alignment between the query sequence and the reference sequence in  
a CIGAR string. This operation indicates a region where the alignment is not continuous  
and there is no corresponding sequence in the query or reference.

<a name='Fantasista.DNA.SAMFile.CigarOperator.HardClipping'></a>

`HardClipping` 5

Represents hard clipping of nucleotides in the query sequence in a CIGAR string.  
This operation signifies that the clipped bases are not present in the read data,  
but are known to exist based on prior information.

<a name='Fantasista.DNA.SAMFile.CigarOperator.Insertion'></a>

`Insertion` 1

Represents an insertion of nucleotides in the query sequence relative to the reference sequence  
in a CIGAR string. This operation indicates that additional nucleotides are present in the query  
sequence that do not align with the reference sequence.

<a name='Fantasista.DNA.SAMFile.CigarOperator.Match'></a>

`Match` 0

Represents a matching of nucleotides between the query sequence and the reference sequence in  
a CIGAR string. This operation signifies that the corresponding nucleotides in the aligned  
sequences are identical.

<a name='Fantasista.DNA.SAMFile.CigarOperator.Mismatch'></a>

`Mismatch` 8

Represents a mismatch of nucleotides between the query sequence and the reference sequence in  
a CIGAR string. This operation indicates that the corresponding nucleotides in the aligned  
sequences are different.

<a name='Fantasista.DNA.SAMFile.CigarOperator.Padding'></a>

`Padding` 6

Represents the padding operation in a CIGAR string used for DNA sequence alignment.  
This operation accounts for padding in the alignment, often used to indicate space  
needed in the alignment without affecting the sequence itself.

<a name='Fantasista.DNA.SAMFile.CigarOperator.SequenceMatch'></a>

`SequenceMatch` 7

Denotes a matching operation in a CIGAR string where the nucleotides in the query sequence  
align perfectly with those in the reference sequence.

<a name='Fantasista.DNA.SAMFile.CigarOperator.SoftClipping'></a>

`SoftClipping` 4

Represents a soft clipping operation in a CIGAR string for DNA sequence alignment. This operation  
indicates that the associated nucleotides in the query sequence are not aligned to the reference  
sequence but are still present in the read outside the aligned portion.