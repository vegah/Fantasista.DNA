#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.FastaFile](Fantasista.DNA.FastaFile.md 'Fantasista.DNA.FastaFile').[FastaStreamReader](Fantasista.DNA.FastaFile.FastaStreamReader.md 'Fantasista.DNA.FastaFile.FastaStreamReader')

## FastaStreamReader.Read() Method

Reads sequences from the file.

```csharp
public System.Collections.Generic.IEnumerable<Fantasista.DNA.Sequence.BasicSequence> Read();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[BasicSequence](Fantasista.DNA.Sequence.BasicSequence.md 'Fantasista.DNA.Sequence.BasicSequence')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An IEnumerable containing Sequence elements

### Example
var fastafile = File.OpenRead("file.fasta");  
var fastareader = new FastaStreamReader(fastafile);  
 foreach (var sequence in fastareader.Read())  
 {  
   Console.WriteLine(sequence.RawSequence);  
 }