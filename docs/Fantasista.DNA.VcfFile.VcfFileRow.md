#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.VcfFile](Fantasista.DNA.VcfFile.md 'Fantasista.DNA.VcfFile')

## VcfFileRow Class

Contains data for one row of a vcf file

```csharp
public class VcfFileRow : System.Collections.Generic.Dictionary<string, Fantasista.DNA.VcfFile.IVcfColumnValue>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[IVcfColumnValue](Fantasista.DNA.VcfFile.IVcfColumnValue.md 'Fantasista.DNA.VcfFile.IVcfColumnValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2') &#129106; VcfFileRow

| Properties | |
| :--- | :--- |
| [Alt](Fantasista.DNA.VcfFile.VcfFileRow.Alt.md 'Fantasista.DNA.VcfFile.VcfFileRow.Alt') | The standard Alt field |
| [Chrom](Fantasista.DNA.VcfFile.VcfFileRow.Chrom.md 'Fantasista.DNA.VcfFile.VcfFileRow.Chrom') | The standard Chrom field - it is a string because some files contains characters instead of numbers here. |
| [Filter](Fantasista.DNA.VcfFile.VcfFileRow.Filter.md 'Fantasista.DNA.VcfFile.VcfFileRow.Filter') | The standard Filter field |
| [Id](Fantasista.DNA.VcfFile.VcfFileRow.Id.md 'Fantasista.DNA.VcfFile.VcfFileRow.Id') | The standard id field |
| [Info](Fantasista.DNA.VcfFile.VcfFileRow.Info.md 'Fantasista.DNA.VcfFile.VcfFileRow.Info') | The standard Info field. The info field will contain subinfo field under it's [""]<br/>For example will Info["ALLELEID"].GetValue{int}() return the int stored in the ALLELEID field, if it exists and is an int. |
| [Pos](Fantasista.DNA.VcfFile.VcfFileRow.Pos.md 'Fantasista.DNA.VcfFile.VcfFileRow.Pos') | The standard Pos field |
| [Qual](Fantasista.DNA.VcfFile.VcfFileRow.Qual.md 'Fantasista.DNA.VcfFile.VcfFileRow.Qual') | The standard Qual field |
| [Ref](Fantasista.DNA.VcfFile.VcfFileRow.Ref.md 'Fantasista.DNA.VcfFile.VcfFileRow.Ref') | The standard Ref field |

| Methods | |
| :--- | :--- |
| [AddColumn(VcfFileColumn, string, VcfFileMetaData)](Fantasista.DNA.VcfFile.VcfFileRow.AddColumn(Fantasista.DNA.VcfFile.VcfFileColumn,string,Fantasista.DNA.VcfFile.VcfFileMetaData).md 'Fantasista.DNA.VcfFile.VcfFileRow.AddColumn(Fantasista.DNA.VcfFile.VcfFileColumn, string, Fantasista.DNA.VcfFile.VcfFileMetaData)') | Adds a column to the row. |
