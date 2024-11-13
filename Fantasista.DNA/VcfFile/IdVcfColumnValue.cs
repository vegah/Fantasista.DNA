namespace Fantasista.DNA.VcfFile;

public class IdVcfColumnValue : VcfColumnValue<List<string>>
{
    public IdVcfColumnValue(string name, string type, string rawValue) : base(name,type, [])
    {
        if (!string.IsNullOrEmpty(rawValue))
            Value.AddRange(rawValue.Split(';',StringSplitOptions.RemoveEmptyEntries));
    }
}