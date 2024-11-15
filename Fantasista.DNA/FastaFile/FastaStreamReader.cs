using System.Text;
using Fantasista.DNA.FastaFile.Inspectors;
using Fantasista.DNA.Sequence;

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
    /// <example>
    /// var fastafile = File.OpenRead("file.fasta");
    /// var fastareader = new FastaStreamReader(fastafile);
    ///  foreach (var sequence in fastareader.Read())
    ///  {
    ///    Console.WriteLine(sequence.RawSequence);
    ///  }
    /// </example>
    public IEnumerable<BasicSequence> Read()
    {
        var currentSequenceDescription = "";
        var currentSequence = new StringBuilder();
        var allowedChars = BasicSequence.ValidCharsNucleicAcids.Union(BasicSequence.ValidAminoAcids).ToArray();
        while (_reader.ReadLine() is { } line)
        {
            if (line.Length == 0) continue;
            if (line[0]=='>')
            {
                if (currentSequence.Length>0)
                {
                    yield return new BasicSequence(currentSequenceDescription, currentSequence.ToString());
                    currentSequence.Clear();
                }
                currentSequenceDescription = line[1..];
            }
            else if (allowedChars.Contains(line[0]))
                currentSequence.Append(line);
        }
        yield return new BasicSequence(currentSequenceDescription, currentSequence.ToString());
    }

    /// <summary>
    /// Reads the data and passes it to an inspector that returns an inspected sequence
    /// </summary>
    /// <param name="sequenceInspector">A sequence inspector that implements ISequenceInspector</param>
    /// <typeparam name="T">The return value of the sequence inspector</typeparam>
    /// <returns>An IEnumerable of the SequenceInspector return value</returns>
    /// <example>
    /// var fastafile = File.OpenRead("file.fasta");
    /// var fastareader = new FastaStreamReader(fastafile);
    /// var inspector = new SimpleSequenceInspector();
    /// foreach (var sequence in fastareader.ReadInspected(inspector).Take(5))
    /// {
    ///        Console.WriteLine(sequence.GuessedType);
    /// }
    /// </example>
    public IEnumerable<T> ReadInspected<T>(ISequenceInspector<T> sequenceInspector) where T : BasicSequence
    {
        return Read().Select(sequenceInspector.InspectSequence);
    }

    /// <summary>
    /// Disposes the object and the stream 
    /// </summary>
    public void Dispose()
    {
        _reader.Dispose();
    }
}