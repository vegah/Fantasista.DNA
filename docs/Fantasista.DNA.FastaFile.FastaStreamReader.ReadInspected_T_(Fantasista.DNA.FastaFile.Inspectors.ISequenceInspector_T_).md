#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.FastaFile](Fantasista.DNA.FastaFile.md 'Fantasista.DNA.FastaFile').[FastaStreamReader](Fantasista.DNA.FastaFile.FastaStreamReader.md 'Fantasista.DNA.FastaFile.FastaStreamReader')

## FastaStreamReader.ReadInspected<T>(ISequenceInspector<T>) Method

Reads the data and passes it to an inspector that returns an inspected sequence

```csharp
public System.Collections.Generic.IEnumerable<T> ReadInspected<T>(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector<T> sequenceInspector)
    where T : Fantasista.DNA.Sequence.BasicSequence;
```
#### Type parameters

<a name='Fantasista.DNA.FastaFile.FastaStreamReader.ReadInspected_T_(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_).T'></a>

`T`

The return value of the sequence inspector
#### Parameters

<a name='Fantasista.DNA.FastaFile.FastaStreamReader.ReadInspected_T_(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_).sequenceInspector'></a>

`sequenceInspector` [Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector&lt;](Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_.md 'Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector<T>')[T](Fantasista.DNA.FastaFile.FastaStreamReader.ReadInspected_T_(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_).md#Fantasista.DNA.FastaFile.FastaStreamReader.ReadInspected_T_(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_).T 'Fantasista.DNA.FastaFile.FastaStreamReader.ReadInspected<T>(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector<T>).T')[&gt;](Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_.md 'Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector<T>')

A sequence inspector that implements ISequenceInspector

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Fantasista.DNA.FastaFile.FastaStreamReader.ReadInspected_T_(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_).md#Fantasista.DNA.FastaFile.FastaStreamReader.ReadInspected_T_(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_).T 'Fantasista.DNA.FastaFile.FastaStreamReader.ReadInspected<T>(Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An IEnumerable of the SequenceInspector return value

### Example
var fastafile = File.OpenRead("file.fasta");  
var fastareader = new FastaStreamReader(fastafile);  
var inspector = new SimpleSequenceInspector();  
foreach (var sequence in fastareader.ReadInspected(inspector).Take(5))  
{  
       Console.WriteLine(sequence.GuessedType);  
}