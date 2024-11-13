namespace Fantasista.DNA.FastaFile;

public class FastaSequence
{
    public string Description { get; }
    public string RawSequence { get; }

    public FastaSequence(string description, string rawSequence)
    {
        Description = description;
        RawSequence = rawSequence;
    }
    
}