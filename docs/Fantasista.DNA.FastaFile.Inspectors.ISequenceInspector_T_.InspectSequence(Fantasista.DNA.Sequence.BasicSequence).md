#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.FastaFile.Inspectors](Fantasista.DNA.FastaFile.Inspectors.md 'Fantasista.DNA.FastaFile.Inspectors').[ISequenceInspector&lt;T&gt;](Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_.md 'Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector<T>')

## ISequenceInspector<T>.InspectSequence(BasicSequence) Method

Inspects a sequence and returns a subclass of BasicSequence which is set as Type T of the implementation class

```csharp
T InspectSequence(Fantasista.DNA.Sequence.BasicSequence sequence);
```
#### Parameters

<a name='Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_.InspectSequence(Fantasista.DNA.Sequence.BasicSequence).sequence'></a>

`sequence` [BasicSequence](Fantasista.DNA.Sequence.BasicSequence.md 'Fantasista.DNA.Sequence.BasicSequence')

The basic sequence to inspect

#### Returns
[T](Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_.md#Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_.T 'Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector<T>.T')  
A type T that inherits from BasicSequence