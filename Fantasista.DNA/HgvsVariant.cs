using System.Text.RegularExpressions;

namespace Fantasista.DNA;

public class HgvsVariant
{
    public required ReferenceSequenceInfo ReferenceSequence { get; set; }  // NM_000018.4
    public required  string GeneSymbol { get; set; }         // ACADVL
    public required  string Type { get; set; }               
    public required  int Position { get; set; }              // 62
    public int? Offset { get; set; }               // +5 (
    public required char OriginalBase { get; set; }         // G
    public required char NewBase { get; set; }              // A


    public static HgvsVariant Parse(string hgvsString)
    {
        var pattern = @"([\w_]+\.\d+)\((\w+)\):([a-z])\.(\d+)(?:\+(\d+))?([A-Z])>([A-Z])";
        var match = Regex.Match(hgvsString, pattern);
    
        if (!match.Success)
            throw new FormatException("Invalid HGVS format");

        return new HgvsVariant
        {
            ReferenceSequence = ReferenceSequenceInfo.Parse(match.Groups[1].Value),  // NM_000018.4
            GeneSymbol = match.Groups[2].Value,         // ACADVL
            Type = match.Groups[3].Value,               // c
            Position = int.Parse(match.Groups[4].Value), // 62
            Offset = match.Groups[5].Success ? int.Parse(match.Groups[5].Value) : null, // 5
            OriginalBase = match.Groups[6].Value[0],    // G
            NewBase = match.Groups[7].Value[0]          // A
        };
    }
    
    public override string ToString()
    {
        return $"{ReferenceSequence}({GeneSymbol}):{Type}.{Position}{(Offset.HasValue ? $"+{Offset}" : "")}{OriginalBase}>{NewBase}";
    }
}