using System.Text;

namespace Fantasista.DNA.VcfFile;

/// <summary>
/// A class for reading Variant Call Format (VCF)
/// Implements IDisposable.
/// </summary>
public class VcfStreamReader : IDisposable
{
    private readonly StreamReader _reader;
    
    /// <summary>
    /// Reading the file directly from a string. Use the constructor with stream if you need to.
    /// </summary>
    /// <param name="s">A vcf file as a string</param>
    public VcfStreamReader(string s) : this(new MemoryStream(Encoding.UTF8.GetBytes(s)))
    {
        
    }
    
    /// <summary>
    /// Reading the file from a stream. Use the constructor with string if you need to. This one uses far less memory.
    /// </summary>
    /// <param name="s">A readable stream containing the vcf file</param>    
    public VcfStreamReader(Stream s)
    {
        _reader = new StreamReader(s);
        MetaData = new VcfFileMetaData();
        Columns = [];
    }

    /// <summary>
    /// Information about the columns in the vcf file.
    /// </summary>
    public VcfFileColumns Columns { get; }

    /// <summary>
    /// Contains metadata about the vcf file
    /// </summary>
    public VcfFileMetaData MetaData { get; }

    /// <summary>
    /// Lazy reads the file as an IEnumerable. It will read one row after another, as the function is enumerated. 
    /// </summary>
    /// <returns>An VcfFileRow per row </returns>
    public IEnumerable<VcfFileRow> Read()
    {
        while (_reader.ReadLine() is { } line)
        {
            if (line.StartsWith("##"))
            {
                MetaData.AddMetaData(line);
            }
            else if (line.StartsWith('#'))
            {
                Columns.Parse(line);
            }
            else
            {
                yield return Columns.ParseValues(line,MetaData);
            }
        }
    }

    /// <summary>
    /// Disposes the reader _and_ the stream
    /// </summary>
    public void Dispose()
    {
        _reader.Dispose();
    }
}