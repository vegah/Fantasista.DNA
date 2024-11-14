namespace Fantasista.DNA.FastaFile;

public class Sequence
{
    public static readonly char[] ValidCharsNucleicAcids = ['A', 'C', 'G', 'T', 'U', 'i', 'R', 'Y', 'K', 'M', 'S', 'W', 'B', 'D', 'H', 'V', 'N', '-'];
    public static readonly char[] ValidAminoAcids = ['A','B', 'C', 'D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S', 'T', 'U', 'V','W','X','*','-'];


    public Sequence(string description, string rawSequence, string? qualityComment = null, string? rawQuality = null)
    {
        Description = description;
        RawSequence = rawSequence;
        QualityComment = qualityComment;
        RawQuality = rawQuality;
    }

    public string Description { get; }
    public string RawSequence { get; }
    public string? RawQuality { get; set; }
    public string? QualityComment { get; set; }
    
    
}