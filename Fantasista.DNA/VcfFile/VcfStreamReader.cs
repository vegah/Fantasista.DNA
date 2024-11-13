namespace Fantasista.DNA.VcfFile;

public class VcfStreamReader : IDisposable
{
    private readonly StreamReader _reader;

    public VcfStreamReader(Stream s)
    {
        _reader = new StreamReader(s);
        MetaData = new VcfFileMetaData();
        Columns = [];
    }

    public VcfFileColumns Columns { get; }

    public VcfFileMetaData MetaData { get; }

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

    
    public void Dispose()
    {
        _reader.Dispose();
    }
}