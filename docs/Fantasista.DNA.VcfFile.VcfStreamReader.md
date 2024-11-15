#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.VcfFile](Fantasista.DNA.VcfFile.md 'Fantasista.DNA.VcfFile')

## VcfStreamReader Class

A class for reading Variant Call Format (VCF)  
Implements IDisposable.

```csharp
public class VcfStreamReader :
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; VcfStreamReader

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')

| Constructors | |
| :--- | :--- |
| [VcfStreamReader(string)](Fantasista.DNA.VcfFile.VcfStreamReader.VcfStreamReader(string).md 'Fantasista.DNA.VcfFile.VcfStreamReader.VcfStreamReader(string)') | Reading the file directly from a string. Use the constructor with stream if you need to. |
| [VcfStreamReader(Stream)](Fantasista.DNA.VcfFile.VcfStreamReader.VcfStreamReader(System.IO.Stream).md 'Fantasista.DNA.VcfFile.VcfStreamReader.VcfStreamReader(System.IO.Stream)') | Reading the file from a stream. Use the constructor with string if you need to. This one uses far less memory. |

| Properties | |
| :--- | :--- |
| [Columns](Fantasista.DNA.VcfFile.VcfStreamReader.Columns.md 'Fantasista.DNA.VcfFile.VcfStreamReader.Columns') | Information about the columns in the vcf file. |
| [MetaData](Fantasista.DNA.VcfFile.VcfStreamReader.MetaData.md 'Fantasista.DNA.VcfFile.VcfStreamReader.MetaData') | Contains metadata about the vcf file |

| Methods | |
| :--- | :--- |
| [Dispose()](Fantasista.DNA.VcfFile.VcfStreamReader.Dispose().md 'Fantasista.DNA.VcfFile.VcfStreamReader.Dispose()') | Disposes the reader _and_ the stream |
| [Read()](Fantasista.DNA.VcfFile.VcfStreamReader.Read().md 'Fantasista.DNA.VcfFile.VcfStreamReader.Read()') | Lazy reads the file as an IEnumerable. It will read one row after another, as the function is enumerated. |
