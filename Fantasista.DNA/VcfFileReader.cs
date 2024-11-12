using System.Linq.Expressions;

namespace Fantasista.DNA;

public class VcfFileReader : IDisposable
{
    private readonly StreamReader _reader;

    public VcfFileReader(Stream s)
    {
        _reader = new StreamReader(s);
        MetaData = new VcfFileMetaData();
        Columns = new VcfFileColumns();
    }

    public VcfFileColumns Columns { get; set; }

    public VcfFileMetaData MetaData { get; set; }

    public void Read()
    {
        string? line;
        while ((line = _reader.ReadLine()) is not null)
        {
            if (line.StartsWith("##"))
            {
                MetaData.AddMetaData(line);
            }
            else if (line.StartsWith("#"))
            {
                Columns.Parse(line);
            }
        }
    }

    
    public void Dispose()
    {
        _reader.Dispose();
    }
}