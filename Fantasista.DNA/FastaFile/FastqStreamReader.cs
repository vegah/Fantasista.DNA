using System.Text;

namespace Fantasista.DNA.FastaFile;

/// <summary>
/// Class for reading FASTQ files
/// </summary>

public class FastqStreamReader
{
    private readonly StreamReader _reader;

    private class FastqModel
    {
        public string Description { get; set; }
        public string RawData { get; set; }
        public string QualityComment { get; set; }
        public string RawQuality { get; set; }
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
    public IEnumerable<Sequence> Read()
    {
        var currentModel = new FastqModel();
        while (_reader.ReadLine() is { } line)
        {
            if (line[0] == '@')
                currentModel.Description = line[1..];
            else if (line[0] == '+')
                currentModel.QualityComment= line[1..];
            else if (!string.IsNullOrWhiteSpace(line) && string.IsNullOrEmpty(currentModel.QualityComment))
                currentModel.RawData = line;
            else if (!string.IsNullOrWhiteSpace(line))
            {
                currentModel.RawQuality = line;
                yield return new Sequence(currentModel.Description,currentModel.RawData,currentModel.QualityComment,currentModel.RawQuality);
                currentModel = new FastqModel();
            }
                
            
        }
    }
    

}