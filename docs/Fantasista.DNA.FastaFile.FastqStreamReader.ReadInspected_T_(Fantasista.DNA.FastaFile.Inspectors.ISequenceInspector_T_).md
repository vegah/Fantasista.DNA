#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.FastaFile](Fantasista.DNA.FastaFile.md 'Fantasista.DNA.FastaFile').[FastqStreamReader](Fantasista.DNA.FastaFile.FastqStreamReader.md 'Fantasista.DNA.FastaFile.FastqStreamReader')

## FastqStreamReader.ReadInspected<T>(ISequenceInspector<T>) Method

Reads the data and passes it to an inspector that returns an inspected sequence

```csharp
public System.Collections.Generic.IEnumerable<T> ReadInspected<T>(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector<T> sequenceInspector)
    where T : Fantasista.DNA.Sequence.BasicSequence;
```
#### Type parameters

<a name='Fantasista.DNA.FastaFile.FastqStreamReader.ReadInspected_T_(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_).T'></a>

`T`

The return value of the sequence inspector
#### Parameters

<a name='Fantasista.DNA.FastaFile.FastqStreamReader.ReadInspected_T_(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_).sequenceInspector'></a>

`sequenceInspector` [Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector&lt;](Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_.md 'Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector<T>')[T](Fantasista.DNA.FastaFile.FastqStreamReader.ReadInspected_T_(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_).md#Fantasista.DNA.FastaFile.FastqStreamReader.ReadInspected_T_(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_).T 'Fantasista.DNA.FastaFile.FastqStreamReader.ReadInspected<T>(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector<T>).T')[&gt;](Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_.md 'Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector<T>')

A sequence inspector that implements ISequenceInspector

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Fantasista.DNA.FastaFile.FastqStreamReader.ReadInspected_T_(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_).md#Fantasista.DNA.FastaFile.FastqStreamReader.ReadInspected_T_(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_).T 'Fantasista.DNA.FastaFile.FastqStreamReader.ReadInspected<T>(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An IEnumerable of the SequenceInspector return value

### Example
var fastqfile = File.OpenRead("file.fastq");  
var fastqreader = new FastaStreamReader(fastqfile);  
var inspector = new SimpleSequenceInspector();  
foreach (var sequence in fastqreader.ReadInspected(inspector).Take(5))  
{  
       Console.WriteLine(sequence.GuessedType);  
}