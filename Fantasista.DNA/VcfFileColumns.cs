namespace Fantasista.DNA;

public class VcfFileColumns : List<VcfFileColumn>
{
    public void Parse(string line)
    {
        var columns = line.Substring(1).Split(' ', StringSplitOptions.RemoveEmptyEntries);
        AddRange(columns.Select((x,i)=>new VcfFileColumn(x,i)));
    }
}