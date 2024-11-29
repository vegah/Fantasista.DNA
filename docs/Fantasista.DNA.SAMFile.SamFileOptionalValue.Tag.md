#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[SamFileOptionalValue](Fantasista.DNA.SAMFile.SamFileOptionalValue.md 'Fantasista.DNA.SAMFile.SamFileOptionalValue')

## SamFileOptionalValue.Tag Property

Gets or sets the tag identifier for an optional field in a SAM file.

```csharp
public string Tag { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

### Remarks
This property holds the tag identifier which precedes an optional value in a SAM file entry.  
It serves as a key to identify the specific optional data associated with a SAM entry,  
allowing for better interpretation and manipulation of additional information beyond  
the standard SAM fields.