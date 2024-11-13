using System.Text.RegularExpressions;

namespace Fantasista.DNA;

public class ReferenceSequenceInfo
{
    public static ReferenceSequenceInfo Parse(string s)
    {
        const string pattern = @"(\w+)_(\w+)\.(\d+)";
        var match = Regex.Match(s, pattern);
        return new ReferenceSequenceInfo
        {
            Prefix = match.Groups[1].Value,
            AccessionNumber = match.Groups[2].Value,
            Version = int.Parse(match.Groups[3].Value)
        };
    }

    public override string ToString()
    {
        return $"{Prefix}_{AccessionNumber}.{Version}";
    }

    public required string Prefix { get; set; }         // NM
    public required string AccessionNumber { get; set; } // 000018
    public required int Version { get; set; }           // 4
}