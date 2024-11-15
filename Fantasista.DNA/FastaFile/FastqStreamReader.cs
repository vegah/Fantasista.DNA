using System.Text;
using Fantasista.DNA.FastaFile.Exceptions;
using Fantasista.DNA.FastaFile.Inspectors;
using Fantasista.DNA.Sequence;

namespace Fantasista.DNA.FastaFile;

/// <summary>
/// Class for reading FASTQ files
/// </summary>

public class FastqStreamReader
{
    private readonly StreamReader _reader;

    private class FastqModel
    {
        public string? Description { get; set; }
        public string? RawData { get; set; }
        public string? QualityComment { get; set; }
        public string? RawQuality { get; set; }
    }
    
    /// <summary>
    /// Construct with a string. Use the stream constructor unless you have a small string.
    /// </summary>
    /// <param name="s">A string containing the FASTQ file</param>    
    public FastqStreamReader(string s) : this(new MemoryStream(Encoding.UTF8.GetBytes(s)))
    {
        
    }
    
    /// <summary>
    /// Stream constructor
    /// </summary>
    /// <param name="stream">A stream continaing the FASTQ file</param>    
    public FastqStreamReader(Stream stream)
    {
        _reader = new StreamReader(stream);
    }
    
    /// <summary>
    /// Reads sequences from the file.
    /// </summary>
    /// <returns>An IEnumerable containing Sequence elements</returns>
    /// <example>
    /// var fastqfile = File.OpenRead("file.fastq");
    /// var fastqreader = new FastqStreamReader(fastqfile);
    ///  foreach (var sequence in fastqreader.Read())
    ///  {
    ///    Console.WriteLine(sequence.RawSequence);
    ///  }
    /// </example>
    public IEnumerable<BasicSequence> Read()
    {
        var currentModel = new FastqModel();
        while (_reader.ReadLine() is { } line)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            if (line[0] == '@')
                currentModel.Description = line[1..];
            else if (line[0] == '+')
                currentModel.QualityComment= line[1..];
            else if (!string.IsNullOrWhiteSpace(line) && string.IsNullOrEmpty(currentModel.QualityComment))
                currentModel.RawData = line;
            else if (!string.IsNullOrWhiteSpace(line))
            {
                currentModel.RawQuality = line;
                if (currentModel.Description == null || currentModel.RawData == null || currentModel.QualityComment == null || currentModel.RawQuality == null)
                    throw new FastqParserException("One of description, rawdata, qualitycomment or rawquality found");
                yield return new BasicSequence(currentModel.Description,currentModel.RawData,currentModel.QualityComment,currentModel.RawQuality);
                currentModel = new FastqModel();
            }
                
            
        }
    }
    
    /// <summary>
    /// Reads the data and passes it to an inspector that returns an inspected sequence
    /// </summary>
    /// <param name="sequenceInspector">A sequence inspector that implements ISequenceInspector</param>
    /// <typeparam name="T">The return value of the sequence inspector</typeparam>
    /// <returns>An IEnumerable of the SequenceInspector return value</returns>
    /// <example>
    /// var fastqfile = File.OpenRead("file.fastq");
    /// var fastqreader = new FastaStreamReader(fastqfile);
    /// var inspector = new SimpleSequenceInspector();
    /// foreach (var sequence in fastqreader.ReadInspected(inspector).Take(5))
    /// {
    ///        Console.WriteLine(sequence.GuessedType);
    /// }
    /// </example>
    public IEnumerable<T> ReadInspected<T>(ISequenceInspector<T> sequenceInspector) where T : BasicSequence
    {
        return Read().Select(sequenceInspector.InspectSequence);
    }
}