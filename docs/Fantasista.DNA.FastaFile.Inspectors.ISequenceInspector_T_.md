#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.FastaFile.Inspectors](Fantasista.DNA.FastaFile.Inspectors.md 'Fantasista.DNA.FastaFile.Inspectors')

## ISequenceInspector<T> Interface

A interface to create inspectors that can add information to the basic sequence by inspecting it. One example would be to  
add a guessed type, or to add statistics to the sequence.

```csharp
public interface ISequenceInspector<T>
    where T : Fantasista.DNA.Sequence.BasicSequence
```
#### Type parameters

<a name='Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_.T'></a>

`T`

The type of the return value - mist inherit from BasicSequence

Derived  
&#8627; [SimpleSequenceInspector](Fantasista.DNA.Sequence.Inspectors.SimpleSequenceInspector.md 'Fantasista.DNA.Sequence.Inspectors.SimpleSequenceInspector')

| Methods | |
| :--- | :--- |
| [InspectSequence(BasicSequence)](Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector_T_.InspectSequence(Fantasista.DNA.Sequence.BasicSequence).md 'Fantasista.DNA.FastaFile.Inspectors.ISequenceInspector<T>.InspectSequence(Fantasista.DNA.Sequence.BasicSequence)') | Inspects a sequence and returns a subclass of BasicSequence which is set as Type T of the implementation class |
