#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.VcfFile](Fantasista.DNA.VcfFile.md 'Fantasista.DNA.VcfFile').[VcfFileMetaData](Fantasista.DNA.VcfFile.VcfFileMetaData.md 'Fantasista.DNA.VcfFile.VcfFileMetaData')

## VcfFileMetaData.MyRegex() Method

```csharp
private static System.Text.RegularExpressions.Regex MyRegex();
```

#### Returns
[System.Text.RegularExpressions.Regex](https://docs.microsoft.com/en-us/dotnet/api/System.Text.RegularExpressions.Regex 'System.Text.RegularExpressions.Regex')

### Remarks
Pattern:<br/>  
  
```csharp  
(\\d\\d\\d\\d)[-]?(\\d\\d)[-]?(\\d\\d)  
```<br/>  
Explanation:<br/>  
  
```csharp  
○ 1st capture group.<br/>  
    ○ Match a Unicode digit exactly 4 times.<br/>  
○ Match '-' atomically, optionally.<br/>  
○ 2nd capture group.<br/>  
    ○ Match a Unicode digit exactly 2 times.<br/>  
○ Match '-' atomically, optionally.<br/>  
○ 3rd capture group.<br/>  
    ○ Match a Unicode digit exactly 2 times.<br/>  
```