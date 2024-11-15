namespace Fantasista.DNA.VcfFile;

/// <summary>
/// Describes a column in Vcf file
/// </summary>
/// <param name="columnName"></param>
/// <param name="index"></param>
public class VcfFileColumn(string columnName, int index)
{
    /// <summary>
    /// Name of the column
    /// </summary>
    public string ColumnName { get;  } = columnName;
    /// <summary>
    /// The index of the column
    /// </summary>
    public int Index { get; } = index;
}