#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.FastaFile](Fantasista.DNA.FastaFile.md 'Fantasista.DNA.FastaFile')

## FastaStreamReader Class

Class for reading FASTA files

```csharp
public class FastaStreamReader :
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FastaStreamReader

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')

| Constructors | |
| :--- | :--- |
| [FastaStreamReader(string)](Fantasista.DNA.FastaFile.FastaStreamReader.FastaStreamReader(string).md 'Fantasista.DNA.FastaFile.FastaStreamReader.FastaStreamReader(string)') | Construct with a string. Use the stream constructor unless you have a small string. |
| [FastaStreamReader(Stream)](Fantasista.DNA.FastaFile.FastaStreamReader.FastaStreamReader(System.IO.Stream).md 'Fantasista.DNA.FastaFile.FastaStreamReader.FastaStreamReader(System.IO.Stream)') | Stream constructor |

| Methods | |
| :--- | :--- |
| [Dispose()](Fantasista.DNA.FastaFile.FastaStreamReader.Dispose().md 'Fantasista.DNA.FastaFile.FastaStreamReader.Dispose()') | Disposes the object and the stream |
| [Read()](Fantasista.DNA.FastaFile.FastaStreamReader.Read().md 'Fantasista.DNA.FastaFile.FastaStreamReader.Read()') | Reads sequences from the file. |
| [ReadInspected&lt;T&gt;(ISequenceInspector&lt;T&gt;)](Fantasista.DNA.FastaFile.FastaStreamReader.ReadInspected_T_(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_).md 'Fantasista.DNA.FastaFile.FastaStreamReader.ReadInspected<T>(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector<T>)') | Reads the data and passes it to an inspector that returns an inspected sequence |
