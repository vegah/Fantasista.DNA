using System.Text.RegularExpressions;

namespace Fantasista.DNA;

/// <summary>
/// Describes the ReferenceSequence part of Human Genome Variation Society Formatting
/// </summary>
public class ReferenceSequenceInfo
{
    /// <summary>
    /// Static class that parses a Reference Sequence - part of the HgvsVariant
    /// This will parse the first part - for example NM_000018.4
    /// In most cases you want to use HgvsVariant directly, which will use this class
    /// </summary>
    /// <param name="s">string containting the Reference Sequence part of the HgvsVariant</param>
    /// <returns>A parsed ReferenceSequenceInfo</returns>
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
    
    /// <summary>
    /// The reference sequence info part as a string
    /// </summary>
    /// <returns>string prefix_accessionnumber.version</returns>
    public override string ToString()
    {
        return $"{Prefix}_{AccessionNumber}.{Version}";
    }

    /// <summary>
    /// Prefix - What comes before _
    /// </summary>
    public required string Prefix { get; set; }         // NM
    /// <summary>
    /// AccessionNumber as string
    /// </summary>
    public required string AccessionNumber { get; set; } // 000018
    /// <summary>
    /// Version as an int
    /// </summary>
    public required int Version { get; set; }           // 4
}