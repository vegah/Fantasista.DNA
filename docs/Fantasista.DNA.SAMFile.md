#### [Fantasista.DNA](index.md 'index')

## Fantasista.DNA.SAMFile Namespace

| Classes | |
| :--- | :--- |
| [BamFileMissingHeaderException](Fantasista.DNA.SAMFile.BamFileMissingHeaderException.md 'Fantasista.DNA.SAMFile.BamFileMissingHeaderException') | Represents an exception that is thrown when a BAM file is missing the required header. |
| [BamStreamReader](Fantasista.DNA.SAMFile.BamStreamReader.md 'Fantasista.DNA.SAMFile.BamStreamReader') | A class responsible for reading BAM (Binary Alignment/Map) file format data from a stream. |
| [RawSequenceAlignment](Fantasista.DNA.SAMFile.RawSequenceAlignment.md 'Fantasista.DNA.SAMFile.RawSequenceAlignment') | Represents a raw sequence alignment entry parsed from a SAM file. |
| [SamFileCigarPart](Fantasista.DNA.SAMFile.SamFileCigarPart.md 'Fantasista.DNA.SAMFile.SamFileCigarPart') | Represents a part of a CIGAR string which is used to describe the alignment<br/>of a DNA sequence. A CIGAR string is composed of multiple parts, each<br/>defining an operation and the number of nucleotides it affects. |
| [SamFileLevelMetadata](Fantasista.DNA.SAMFile.SamFileLevelMetadata.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata') | Represents metadata at the file level for a SAM (Sequence Alignment/Map) file.<br/>Provides properties and methods to parse and handle file-level metadata such as version and sorting order of<br/>alignments. |
| [SamFileOptionalValue](Fantasista.DNA.SAMFile.SamFileOptionalValue.md 'Fantasista.DNA.SAMFile.SamFileOptionalValue') | Represents an optional value in a SAM file. Each optional value consists of a<br/>tag, a type, and a value, which correspond to the key-value pairs in the SAM<br/>file format used for various annotations and metadata. |
| [SamFileOptionalValueCollection](Fantasista.DNA.SAMFile.SamFileOptionalValueCollection.md 'Fantasista.DNA.SAMFile.SamFileOptionalValueCollection') | |
| [SamFileProgram](Fantasista.DNA.SAMFile.SamFileProgram.md 'Fantasista.DNA.SAMFile.SamFileProgram') | Represents a program record in a SAM file. This class is used to parse and store information related to<br/>a program that has been used during the processing of a SAM file. |
| [SamFileReadGroup](Fantasista.DNA.SAMFile.SamFileReadGroup.md 'Fantasista.DNA.SAMFile.SamFileReadGroup') | Represents a read group in a SAM file, encapsulating metadata such as identifier, platform unit,<br/>description, and additional attributes relevant to sequencing data. |
| [SamFileReferenceSequenceDictionaryElement](Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement.md 'Fantasista.DNA.SAMFile.SamFileReferenceSequenceDictionaryElement') | Represents an element in the reference sequence dictionary within a SAM file. |
| [SamStreamReader](Fantasista.DNA.SAMFile.SamStreamReader.md 'Fantasista.DNA.SAMFile.SamStreamReader') | Class for reading SAM (Sequence Alignment / Map) files. |

| Enums | |
| :--- | :--- |
| [CigarOperator](Fantasista.DNA.SAMFile.CigarOperator.md 'Fantasista.DNA.SAMFile.CigarOperator') | Represents the operations possible in a CIGAR string used for DNA sequence alignment. |
| [MoleculeTopology](Fantasista.DNA.SAMFile.MoleculeTopology.md 'Fantasista.DNA.SAMFile.MoleculeTopology') | Represents a molecule with a linear topology.<br/>Linear molecules are typically characterized by having a direct, non-circular structure. |
| [SamFileAlignmentInformationFlag](Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag.md 'Fantasista.DNA.SAMFile.SamFileAlignmentInformationFlag') | Describes the different flags for SAM file alignment information. |
| [SamFileLevelMetadata.GroupingOfAlignments](Fantasista.DNA.SAMFile.SamFileLevelMetadata.GroupingOfAlignments.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata.GroupingOfAlignments') | Defines the possible grouping options for alignments within a SAM (Sequence Alignment/Map) file.<br/>Indicates how alignments are grouped, whether by query, reference, or if no specific grouping is applied. |
| [SamFileLevelMetadata.SortingOrderOfAlignments](Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata.SortingOrderOfAlignments') | Represents the different possible sorting orders for alignments within a SAM (Sequence Alignment/Map) file. |
| [SamFileReadGroup.PlatformTechnologyType](Fantasista.DNA.SAMFile.SamFileReadGroup.PlatformTechnologyType.md 'Fantasista.DNA.SAMFile.SamFileReadGroup.PlatformTechnologyType') | Represents the platform/technology type used in sequencing. |
