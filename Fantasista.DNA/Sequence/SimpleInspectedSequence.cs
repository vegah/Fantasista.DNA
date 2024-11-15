using Fantasista.DNA.FastaFile;

namespace Fantasista.DNA.Sequence;

/// <summary>
/// A class for providing basic information about a sequence.
/// </summary>
public class SimpleInspectedSequence : BasicSequence
{
    public SimpleInspectedSequence(BasicSequence original) : base(original.Identifier,original.RawSequence,original.QualityIdentifier,original.RawQuality)
    {
        
    }
    
    /// <summary>
    /// The guessed type of the sequence
    /// </summary>
    public SequenceType GuessedType { get; set; }
}