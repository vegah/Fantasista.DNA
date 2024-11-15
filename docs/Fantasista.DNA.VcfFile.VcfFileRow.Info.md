#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.VcfFile](Fantasista.DNA.VcfFile.md 'Fantasista.DNA.VcfFile').[VcfFileRow](Fantasista.DNA.VcfFile.VcfFileRow.md 'Fantasista.DNA.VcfFile.VcfFileRow')

## VcfFileRow.Info Property

The standard Info field. The info field will contain subinfo field under it's [""]  
For example will Info["ALLELEID"].GetValue{int}() return the int stored in the ALLELEID field, if it exists and is an int.

```csharp
public Fantasista.DNA.VcfFile.InfoVcfColumnValue Info { get; }
```

#### Property Value
[InfoVcfColumnValue](Fantasista.DNA.VcfFile.InfoVcfColumnValue.md 'Fantasista.DNA.VcfFile.InfoVcfColumnValue')