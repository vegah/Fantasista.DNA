#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.FastaFile](Fantasista.DNA.FastaFile.md 'Fantasista.DNA.FastaFile')

## FastqStreamReader Class

Class for reading FASTQ files

```csharp
public class FastqStreamReader
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FastqStreamReader

| Constructors | |
| :--- | :--- |
| [FastqStreamReader(string)](Fantasista.DNA.FastaFile.FastqStreamReader.FastqStreamReader(string).md 'Fantasista.DNA.FastaFile.FastqStreamReader.FastqStreamReader(string)') | Construct with a string. Use the stream constructor unless you have a small string. |
| [FastqStreamReader(Stream)](Fantasista.DNA.FastaFile.FastqStreamReader.FastqStreamReader(System.IO.Stream).md 'Fantasista.DNA.FastaFile.FastqStreamReader.FastqStreamReader(System.IO.Stream)') | Stream constructor |

| Methods | |
| :--- | :--- |
| [Read()](Fantasista.DNA.FastaFile.FastqStreamReader.Read().md 'Fantasista.DNA.FastaFile.FastqStreamReader.Read()') | Reads sequences from the file. |
| [ReadInspected&lt;T&gt;(ISequenceInspector&lt;T&gt;)](Fantasista.DNA.FastaFile.FastqStreamReader.ReadInspected_T_(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_).md 'Fantasista.DNA.FastaFile.FastqStreamReader.ReadInspected<T>(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector<T>)') | Reads the data and passes it to an inspector that returns an inspected sequence |
