namespace Fantasista.DNA.VcfFile;

public class VcfFileColumn(string columnName, int index)
{
    public string ColumnName { get;  } = columnName;
    public int Index { get; } = index;
}