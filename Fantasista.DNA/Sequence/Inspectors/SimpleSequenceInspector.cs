using Fantasista.DNA.FastaFile;
using Fantasista.DNA.FastaFile.Inspectors;

namespace Fantasista.DNA.Sequence.Inspectors;

/// <summary>
/// Very simple and dumb type inspector that will try to guess the type based on characters and distribution
/// </summary>
public class SimpleSequenceInspector : ISequenceInspector<SimpleInspectedSequence>
{
    HashSet<char> _dnaChars = new HashSet<char> { 'A', 'T', 'G', 'C', 'N' };
    HashSet<char> _rnaChars = new HashSet<char> { 'A', 'U', 'G', 'C', 'N' };
    HashSet<char> _proteinChars = new HashSet<char> {
        'A', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'K', 'L',
        'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'Y', 'X', '*'
    };
    
    /// <summary>
    /// A simple example on how to create a simple extension to inspect a sequence.
    /// </summary>
    /// <param name="sequence">The BasicSequence to inspect</param>
    /// <returns>SimpleInspectedSequence which adds a guessed type of the sequence</returns>
    public SimpleInspectedSequence InspectSequence(BasicSequence sequence)
    {
        if (string.IsNullOrEmpty(sequence.RawSequence))
            return new SimpleInspectedSequence(sequence)
            {
                GuessedType = SequenceType.Unknown
            };
        var couldBeDNA = sequence.RawSequence.All(c => _dnaChars.Contains(c));
        var couldBeRNA = sequence.RawSequence.All(c => _rnaChars.Contains(c));
        var couldBeProtein = sequence.RawSequence.All(c => _proteinChars.Contains(c));
        if (couldBeRNA && !couldBeDNA && !couldBeProtein)
            return new SimpleInspectedSequence(sequence)
            {
                GuessedType = SequenceType.RNA
            };
        if (couldBeProtein && !couldBeDNA && !couldBeRNA)
            return new SimpleInspectedSequence(sequence)
            {
                GuessedType = SequenceType.Protein
            };

        if (couldBeProtein && couldBeDNA)
        {
            if (sequence.RawSequence.Length % 3 == 0 && sequence.RawSequence.Length >= 30)
                return new SimpleInspectedSequence(sequence)
                {
                    GuessedType = SequenceType.Protein
                };

            if (sequence.RawSequence.Contains('T'))
                return new SimpleInspectedSequence(sequence)
                    { GuessedType = SequenceType.DNA };
        }
        return new SimpleInspectedSequence(sequence) {GuessedType = SequenceType.Unknown};
    }
}