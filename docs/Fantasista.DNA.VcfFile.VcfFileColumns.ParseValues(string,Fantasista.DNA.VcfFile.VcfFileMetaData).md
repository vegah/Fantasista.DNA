#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.VcfFile](Fantasista.DNA.VcfFile.md 'Fantasista.DNA.VcfFile').[VcfFileColumns](Fantasista.DNA.VcfFile.VcfFileColumns.md 'Fantasista.DNA.VcfFile.VcfFileColumns')

## VcfFileColumns.ParseValues(string, VcfFileMetaData) Method

Parses a row based on the metadatainformation

```csharp
public Fantasista.DNA.VcfFile.VcfFileRow ParseValues(string line, Fantasista.DNA.VcfFile.VcfFileMetaData metaData);
```
#### Parameters

<a name='Fantasista.DNA.VcfFile.VcfFileColumns.ParseValues(string,Fantasista.DNA.VcfFile.VcfFileMetaData).line'></a>

`line` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The data line

<a name='Fantasista.DNA.VcfFile.VcfFileColumns.ParseValues(string,Fantasista.DNA.VcfFile.VcfFileMetaData).metaData'></a>

`metaData` [VcfFileMetaData](Fantasista.DNA.VcfFile.VcfFileMetaData.md 'Fantasista.DNA.VcfFile.VcfFileMetaData')

A instance of VcfFileMetaData that contains metadata for the file

#### Returns
[VcfFileRow](Fantasista.DNA.VcfFile.VcfFileRow.md 'Fantasista.DNA.VcfFile.VcfFileRow')  
A VfcFileRow containing the data

#### Exceptions

[ColumnMismatchException](Fantasista.DNA.VcfFile.Exceptions.ColumnMismatchException.md 'Fantasista.DNA.VcfFile.Exceptions.ColumnMismatchException')  
Thrown if number of values does not match the number of expected values