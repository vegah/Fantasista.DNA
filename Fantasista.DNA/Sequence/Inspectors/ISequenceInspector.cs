using Fantasista.DNA.Sequence;
using Fantasista.DNA.Sequence.Inspectors;

namespace Fantasista.DNA.FastaFile.Inspectors;

/// <summary>
/// A interface to create inspectors that can add information to the basic sequence by inspecting it. One example would be to
/// add a guessed type, or to add statistics to the sequence.
/// </summary>
/// <see cref="SimpleSequenceInspector"/>
/// <typeparam name="T">The type of the return value - mist inherit from BasicSequence</typeparam>
public interface ISequenceInspector<T> where T : BasicSequence
{
    /// <summary>
    /// Inspects a sequence and returns a subclass of BasicSequence which is set as Type T of the implementation class
    /// </summary>
    /// <param name="sequence">The basic sequence to inspect</param>
    /// <returns>A type T that inherits from BasicSequence</returns>
    T InspectSequence(BasicSequence sequence);
}