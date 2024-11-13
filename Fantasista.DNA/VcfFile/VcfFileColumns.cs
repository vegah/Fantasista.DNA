using Fantasista.DNA.VcfFile.Exceptions;

namespace Fantasista.DNA.VcfFile;

public class VcfFileColumns : List<VcfFileColumn>
{
    public void Parse(string line)
    {
        var columns = line.Substring(1).Split(new []{" ","\t"}, StringSplitOptions.RemoveEmptyEntries);
        AddRange(columns.Select((x,i)=>new VcfFileColumn(x,i)));
    }

    public VcfFileRow ParseValues(string line,VcfFileMetaData metaData)
    {
        var row = line.Split(new []{" ", "\t"}, StringSplitOptions.RemoveEmptyEntries);
        if (row.Length != Count) throw new ColumnMismatchException($"Column mismatch. Expected {Count} columns, got {row.Length}");
        var retRow = new VcfFileRow();
        for (var i = 0; i < row.Length; i++)
        {
            retRow.AddColumn(this[i], row[i],metaData);
        }
        return retRow;
    }
}