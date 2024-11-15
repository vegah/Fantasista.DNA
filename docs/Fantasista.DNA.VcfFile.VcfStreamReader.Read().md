#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.VcfFile](Fantasista.DNA.VcfFile.md 'Fantasista.DNA.VcfFile').[VcfStreamReader](Fantasista.DNA.VcfFile.VcfStreamReader.md 'Fantasista.DNA.VcfFile.VcfStreamReader')

## VcfStreamReader.Read() Method

Lazy reads the file as an IEnumerable. It will read one row after another, as the function is enumerated.

```csharp
public System.Collections.Generic.IEnumerable<Fantasista.DNA.VcfFile.VcfFileRow> Read();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[VcfFileRow](Fantasista.DNA.VcfFile.VcfFileRow.md 'Fantasista.DNA.VcfFile.VcfFileRow')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An VcfFileRow per row