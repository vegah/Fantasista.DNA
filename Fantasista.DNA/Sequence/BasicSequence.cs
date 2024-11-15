namespace Fantasista.DNA.Sequence;

/// <summary>
///  Describes a sequence - for example from FASTA or FASTQ files
/// </summary>
public class BasicSequence
{
    internal static readonly char[] ValidCharsNucleicAcids = ['A', 'C', 'G', 'T', 'U', 'i', 'R', 'Y', 'K', 'M', 'S', 'W', 'B', 'D', 'H', 'V', 'N', '-'];
    internal static readonly char[] ValidAminoAcids = ['A','B', 'C', 'D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S', 'T', 'U', 'V','W','X','*','-'];


    /// <summary>
    /// A basic sequence constructor.
    /// </summary>
    /// <param name="identifier">The identifier of the sequence</param>
    /// <param name="rawSequence">The raw sequence as a string</param>
    /// <param name="qualityIdentifier">The identifier for the quality</param>
    /// <param name="rawQuality">The raw quality sequence as a string</param>
    public BasicSequence(string identifier, string rawSequence, string? qualityIdentifier = null, string? rawQuality = null)
    {
        Identifier = identifier;
        RawSequence = rawSequence;
        QualityIdentifier = qualityIdentifier;
        RawQuality = rawQuality;
    }

    /// <summary>
    /// Identifier field - in FASTA everything after lower than sign, in FASTQ everything after @
    /// </summary>
    public string Identifier { get; }
    /// <summary>
    /// The sequence as a string
    /// </summary>
    public string RawSequence { get; }
    /// <summary>
    /// The raw quality as a string. This is always NULL in FASTA
    /// </summary>
    public string? RawQuality { get; set; }
    /// <summary>
    /// The identifier of the quality - everything after + - often the same as Identifier   
    /// </summary>
    public string? QualityIdentifier { get; set; }
    /// <summary>
    /// Length of the sequence - number of chars
    /// </summary>
    public int SequenceLength => RawSequence.Length;
    /// <summary>
    /// Length of the quality information - number of chars
    /// </summary>
    public int QualityLength => RawQuality?.Length ?? 0;
    /// <summary>
    /// Distinct characters in sequence
    /// </summary>
    public IEnumerable<char> UniqueCharacters => RawSequence.Distinct();
    /// <summary>
    /// Distinct characters in the quality sequence
    /// </summary>
    public IEnumerable<char> UniqueQualityCharacters => RawQuality?.Distinct() ?? [];
    /// <summary>
    /// The frequency of the characters in the sequence 
    /// </summary>
    public CharacterFrequencyCollection CharacterFrequency => CharacterFrequencyCollection.FromSequence(RawSequence);
    /// <summary>
    /// The frequency of the characters in the quality sequence 
    /// </summary>
    public CharacterFrequencyCollection QualityFrequency => CharacterFrequencyCollection.FromSequence(RawQuality);

}