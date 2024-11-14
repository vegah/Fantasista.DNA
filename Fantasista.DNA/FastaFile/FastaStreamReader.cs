using System.Text;

namespace Fantasista.DNA.FastaFile;

/// <summary>
/// Class for reading FASTA files
/// </summary>
public class FastaStreamReader : IDisposable
{
    private readonly StreamReader _reader;

    /// <summary>
    /// Construct with a string. Use the stream constructor unless you have a small string.
    /// </summary>
    /// <param name="s">A string containing the FASTA file</param>
    public FastaStreamReader(string s) : this(new MemoryStream(Encoding.UTF8.GetBytes(s)))
    {
        
    }
    
    /// <summary>
    /// Stream constructor
    /// </summary>
    /// <param name="stream">A stream continaing the FASTA file</param>
    public FastaStreamReader(Stream stream)
    {
        _reader = new StreamReader(stream);
    }
    
    /// <summary>
    /// Reads sequences from the file.
    /// </summary>
    /// <returns>An IEnumerable containing Sequence elements</returns>
    public IEnumerable<Sequence> Read()
    {
        var currentSequenceDescription = "";
        var currentSequence = new StringBuilder();
        var allowedChars = Sequence.ValidCharsNucleicAcids.Union(Sequence.ValidAminoAcids).ToArray();
        while (_reader.ReadLine() is { } line)
        {
            if (line.Length == 0) continue;
            if (line[0]=='>')
            {
                if (currentSequence.Length>0)
                {
                    yield return new Sequence(currentSequenceDescription, currentSequence.ToString());
                    currentSequenceDescription = "";
                    currentSequence.Clear();
                }
                currentSequenceDescription = line[1..];
            }
            else if (allowedChars.Contains(line[0]))
                currentSequence.Append(line);
        }
        yield return new Sequence(currentSequenceDescription, currentSequence.ToString());
    }

    public void Dispose()
    {
        _reader.Dispose();
    }
}