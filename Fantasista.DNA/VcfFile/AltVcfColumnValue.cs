namespace Fantasista.DNA.VcfFile;

public class AltVcfColumnValue : VcfColumnValue<List<string>>
{
    public AltVcfColumnValue(string name, string type, string rawValue) : base(name,type, [])
    {
        if (!string.IsNullOrEmpty(rawValue))
            Value.AddRange(rawValue.Split(',',StringSplitOptions.RemoveEmptyEntries));
    }
}