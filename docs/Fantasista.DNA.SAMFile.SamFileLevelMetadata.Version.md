#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[SamFileLevelMetadata](Fantasista.DNA.SAMFile.SamFileLevelMetadata.md 'Fantasista.DNA.SAMFile.SamFileLevelMetadata')

## SamFileLevelMetadata.Version Property

Gets or sets the version of the SAM (Sequence Alignment/Map) file format.  
This property must adhere to the format "major.minor", where both major and minor are integers.

```csharp
public string Version { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Exceptions

[SamFileFormatException](Fantasista.DNA.SAMFile.SamFileHeaderExceptions.SamFileFormatException.md 'Fantasista.DNA.SAMFile.SamFileHeaderExceptions.SamFileFormatException')  
Thrown when an invalid version format is set.