namespace Fantasista.DNA.VcfFile;

/// <summary>
/// Contains the value for an Alt column
/// </summary>
public class AltVcfColumnValue : VcfColumnValue<List<string>>
{
    internal AltVcfColumnValue(string name, string type, string rawValue) : base(name,type, [])
    {
        if (!string.IsNullOrEmpty(rawValue))
            Value.AddRange(rawValue.Split(',',StringSplitOptions.RemoveEmptyEntries));
    }
}