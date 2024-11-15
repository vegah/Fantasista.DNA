using Fantasista.DNA.VcfFile.Exceptions;

namespace Fantasista.DNA.VcfFile;

/// <summary>
/// Contains columns for a vcf file
/// </summary>
public class VcfFileColumns : List<VcfFileColumn>
{
    /// <summary>
    /// Parses the column description line - gives name of all columns 
    /// </summary>
    /// <param name="line">The column string excluding #</param>
    public void Parse(string line)
    {
        var columns = line.Substring(1).Split(new []{" ","\t"}, StringSplitOptions.RemoveEmptyEntries);
        AddRange(columns.Select((x,i)=>new VcfFileColumn(x,i)));
    }

    /// <summary>
    /// Parses a row based on the metadatainformation
    /// </summary>
    /// <param name="line">The data line</param>
    /// <param name="metaData">A instance of VcfFileMetaData that contains metadata for the file</param>
    /// <returns>A VfcFileRow containing the data</returns>
    /// <exception cref="ColumnMismatchException">Thrown if number of values does not match the number of expected values</exception>
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