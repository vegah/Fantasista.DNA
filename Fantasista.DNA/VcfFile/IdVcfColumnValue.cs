namespace Fantasista.DNA.VcfFile;
/// <summary>
/// Contains the id value of a row
/// </summary>
public class IdVcfColumnValue : VcfColumnValue<List<string>>
{
    internal IdVcfColumnValue(string name, string type, string rawValue) : base(name,type, [])
    {
        if (!string.IsNullOrEmpty(rawValue))
            Value.AddRange(rawValue.Split(';',StringSplitOptions.RemoveEmptyEntries));
    }
}