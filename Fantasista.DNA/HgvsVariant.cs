using System.Text.RegularExpressions;

namespace Fantasista.DNA;

/// <summary>
/// Describes a HgvsVariant (Human Genome Variation Society Formatting) 
/// </summary>
public class HgvsVariant
{
    /// <summary>
    /// Descrbes the reference sequence - the first part of the HGVS Format- for example NM_000018.4
    /// This is a ReferenceSequenceInfo object which contains more information
    /// </summary>
    public required ReferenceSequenceInfo ReferenceSequence { get; set; }  // NM_000018.4
    /// <summary>
    /// The gene symbol. For example ACADVL
    /// </summary>
    public required  string GeneSymbol { get; set; }         // ACADVL
    /// <summary>
    /// Type
    /// </summary>
    public required  string Type { get; set; }               
    /// <summary>
    /// Position
    /// </summary>
    public required  int Position { get; set; }              // 62
    /// <summary>
    /// The offset - for example +5
    /// </summary>
    public int? Offset { get; set; }               // +5 (
    /// <summary>
    /// Original base
    /// </summary>
    public required char OriginalBase { get; set; }         // G
    /// <summary>
    /// New base
    /// </summary>
    public required char NewBase { get; set; }              // A

    /// <summary>
    /// Parses a hgvs string to a HgvsVariant model. The process can be reversed with HgvsVariant.ToString()
    /// </summary>
    /// <param name="hgvsString">The string to parse</param>
    /// <returns>A HgvsVariant model</returns>
    /// <exception cref="FormatException">Thrown if the input is not in the correct format</exception>
    /// <example>
    /// var str = "NM_000018.4(ACADVL):c.62+5G>A";
    /// var variant = HgvsVariant.Parse(str);
    /// Console.WriteLine(variant.GeneSymbol); // ACADVL
    /// </example>
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
    
    /// <summary>
    /// Writes the model back in HgvsFormat.
    /// </summary>
    /// <returns>string in Hgvs format</returns>
    public override string ToString()
    {
        return $"{ReferenceSequence}({GeneSymbol}):{Type}.{Position}{(Offset.HasValue ? $"+{Offset}" : "")}{OriginalBase}>{NewBase}";
    }
}