using System.Text;

namespace Fantasista.DNA.FastaFile;

public class FastaStreamReader : IDisposable
{
    private readonly StreamReader _reader;

    private static readonly char[] ValidCharsNucleicAcids = ['A', 'C', 'G', 'T', 'U', 'i', 'R', 'Y', 'K', 'M', 'S', 'W', 'B', 'D', 'H', 'V', 'N', '-'];
    private static readonly char[] ValidAminoAcids = ['A','B', 'C', 'D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S', 'T', 'U', 'V','W','X','*','-'];

    public FastaStreamReader(string s) : this(new MemoryStream(Encoding.UTF8.GetBytes(s)))
    {
        
    }
    
    public FastaStreamReader(Stream stream)
    {
        _reader = new StreamReader(stream);
    }

    public IEnumerable<FastaSequence> Read()
    {
        var currentSequenceDescription = "";
        var currentSequence = new StringBuilder();
        var allowedChars = ValidCharsNucleicAcids.Union(ValidAminoAcids).ToArray();
        while (_reader.ReadLine() is { } line)
        {
            if (line.StartsWith('>'))
            {
                if (currentSequence.Length>0)
                {
                    yield return new FastaSequence(currentSequenceDescription, currentSequence.ToString());
                    currentSequenceDescription = "";
                    currentSequence.Clear();
                }
                currentSequenceDescription = line[1..];
            }
            else if (allowedChars.Contains(line[0]))
                currentSequence.Append(line);
        }
        yield return new FastaSequence(currentSequenceDescription, currentSequence.ToString());
    }

    public void Dispose()
    {
        _reader.Dispose();
    }
}