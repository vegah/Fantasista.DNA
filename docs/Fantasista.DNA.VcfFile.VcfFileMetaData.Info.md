#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.VcfFile](Fantasista.DNA.VcfFile.md 'Fantasista.DNA.VcfFile').[VcfFileMetaData](Fantasista.DNA.VcfFile.VcfFileMetaData.md 'Fantasista.DNA.VcfFile.VcfFileMetaData')

## VcfFileMetaData.Info Property

A list of descriptions of INFO fields later used.  
##INFO=<ID=NS,Number=1,Type=Integer,Description="Number of Samples With Data">  
##INFO=<ID=DP,Number=1,Type=Integer,Description="Total Depth">  
will give two rows here.

```csharp
public System.Collections.Generic.List<Fantasista.DNA.VcfFile.VcfFileMetaDataInfo> Info { get; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[VcfFileMetaDataInfo](Fantasista.DNA.VcfFile.VcfFileMetaDataInfo.md 'Fantasista.DNA.VcfFile.VcfFileMetaDataInfo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')