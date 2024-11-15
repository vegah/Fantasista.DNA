#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.Sequence.Inspectors](Fantasista.DNA.Sequence.Inspectors.md 'Fantasista.DNA.Sequence.Inspectors').[SimpleSequenceInspector](Fantasista.DNA.Sequence.Inspectors.SimpleSequenceInspector.md 'Fantasista.DNA.Sequence.Inspectors.SimpleSequenceInspector')

## SimpleSequenceInspector.InspectSequence(BasicSequence) Method

A simple example on how to create a simple extension to inspect a sequence.

```csharp
public Fantasista.DNA.Sequence.SimpleInspectedSequence InspectSequence(Fantasista.DNA.Sequence.BasicSequence sequence);
```
#### Parameters

<a name='Fantasista.DNA.Sequence.Inspectors.SimpleSequenceInspector.InspectSequence(Fantasista.DNA.Sequence.BasicSequence).sequence'></a>

`sequence` [BasicSequence](Fantasista.DNA.Sequence.BasicSequence.md 'Fantasista.DNA.Sequence.BasicSequence')

The BasicSequence to inspect

Implements [InspectSequence(BasicSequence)](Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_.InspectSequence(Fantasista.DNA.Sequence.BasicSequence).md 'Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector<T>.InspectSequence(Fantasista.DNA.Sequence.BasicSequence)')

#### Returns
[SimpleInspectedSequence](Fantasista.DNA.Sequence.SimpleInspectedSequence.md 'Fantasista.DNA.Sequence.SimpleInspectedSequence')  
SimpleInspectedSequence which adds a guessed type of the sequence