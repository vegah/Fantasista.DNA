#### [Fantasista.DNA](index.md 'index')

## Fantasista.DNA.VcfFile Namespace

| Classes | |
| :--- | :--- |
| [AltVcfColumnValue](Fantasista.DNA.VcfFile.AltVcfColumnValue.md 'Fantasista.DNA.VcfFile.AltVcfColumnValue') | Contains the value for an Alt column |
| [IdVcfColumnValue](Fantasista.DNA.VcfFile.IdVcfColumnValue.md 'Fantasista.DNA.VcfFile.IdVcfColumnValue') | Contains the id value of a row |
| [InfoVcfColumnValue](Fantasista.DNA.VcfFile.InfoVcfColumnValue.md 'Fantasista.DNA.VcfFile.InfoVcfColumnValue') | A class which contains the value of a Info column, using metadata the data split up.<br/>It inherits from VcfColumnValue but the value is a dictionary. |
| [Token](Fantasista.DNA.VcfFile.Token.md 'Fantasista.DNA.VcfFile.Token') | Describes a token |
| [VcfColumnValue&lt;T&gt;](Fantasista.DNA.VcfFile.VcfColumnValue_T_.md 'Fantasista.DNA.VcfFile.VcfColumnValue<T>') | A generic class for a column value that contains a value of type T |
| [VcfFieldParser](Fantasista.DNA.VcfFile.VcfFieldParser.md 'Fantasista.DNA.VcfFile.VcfFieldParser') | Class for parsing metadata fields containing information between lower than and greater than signs; |
| [VcfFileColumn](Fantasista.DNA.VcfFile.VcfFileColumn.md 'Fantasista.DNA.VcfFile.VcfFileColumn') | Describes a column in Vcf file |
| [VcfFileColumns](Fantasista.DNA.VcfFile.VcfFileColumns.md 'Fantasista.DNA.VcfFile.VcfFileColumns') | Contains columns for a vcf file |
| [VcfFileMetaData](Fantasista.DNA.VcfFile.VcfFileMetaData.md 'Fantasista.DNA.VcfFile.VcfFileMetaData') | A class used to describe the metadata of a vcf file. |
| [VcfFileMetaDataId](Fantasista.DNA.VcfFile.VcfFileMetaDataId.md 'Fantasista.DNA.VcfFile.VcfFileMetaDataId') | A class that contains information about the metadata id field |
| [VcfFileMetaDataInfo](Fantasista.DNA.VcfFile.VcfFileMetaDataInfo.md 'Fantasista.DNA.VcfFile.VcfFileMetaDataInfo') | Class that describes the info metadata from a vcf file.<br/>An instance of this class will describe one info field, and is contained in the MetaData of the StreanReader. |
| [VcfFileRow](Fantasista.DNA.VcfFile.VcfFileRow.md 'Fantasista.DNA.VcfFile.VcfFileRow') | Contains data for one row of a vcf file |
| [VcfStreamReader](Fantasista.DNA.VcfFile.VcfStreamReader.md 'Fantasista.DNA.VcfFile.VcfStreamReader') | A class for reading Variant Call Format (VCF)<br/>Implements IDisposable. |

| Interfaces | |
| :--- | :--- |
| [IVcfColumnValue](Fantasista.DNA.VcfFile.IVcfColumnValue.md 'Fantasista.DNA.VcfFile.IVcfColumnValue') | An interface for a column value |

| Enums | |
| :--- | :--- |
| [TokenType](Fantasista.DNA.VcfFile.TokenType.md 'Fantasista.DNA.VcfFile.TokenType') | Different tokens used in parsing the information in metadata fields |
