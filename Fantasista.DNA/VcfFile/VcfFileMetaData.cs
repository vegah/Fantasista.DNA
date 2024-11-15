using System.Text.RegularExpressions;

namespace Fantasista.DNA.VcfFile;
/// <summary>
/// A class used to describe the metadata of a vcf file.
/// </summary>
public partial class VcfFileMetaData
{
    /// <summary>
    /// File format - ##fileformat=VCFv4.3 will give VCFv4.3 
    /// </summary>
    public string? FileFormat { get; private set; }
    /// <summary>
    /// DateTimeOffset - null if not parsable or not existing
    /// </summary>
    public DateTimeOffset? FileDate { get; private set; }
    /// <summary>
    /// Source of the data - ##source=myImputationProgramV3.1
    /// </summary>
    public string? Source { get; private set; }
    /// <summary>
    /// Reference - from ##reference=file:///seq/references/1000GenomesPilot-NCBI36.fasta
    /// </summary>
    public string? Reference { get; private set; }
    /// <summary>
    /// Describes the ID field
    /// </summary>
    public VcfFileMetaDataId? Id { get; private set; }
    /// <summary>
    /// A list of descriptions of INFO fields later used.
    /// ##INFO=&lt;ID=NS,Number=1,Type=Integer,Description="Number of Samples With Data"&gt;
    /// ##INFO=&lt;ID=DP,Number=1,Type=Integer,Description="Total Depth"&gt;
    /// will give two rows here.
    /// </summary>
    public List<VcfFileMetaDataInfo> Info {get; } = new();

    /// <summary>
    /// Parses and add one line of metadata
    /// </summary>
    /// <param name="s">The line containing the metadata</param>
    public void AddMetaData(string s)
    {
        if (s.StartsWith("##fileformat")) FileFormat = s[(s.IndexOf('=') + 1)..];
        if (s.StartsWith("##fileDate")) FileDate = ConvertToDateTimeOffset(s[(s.IndexOf('=') + 1)..]);
        if (s.StartsWith("##source")) Source = s[(s.IndexOf('=') + 1)..];
        if (s.StartsWith("##reference")) Reference = s[(s.IndexOf('=') + 1)..];
        if (s.StartsWith("##ID")) Id = VcfFileMetaDataId.Parse(s[(s.IndexOf('=') + 1)..]);
        if (s.StartsWith("##INFO"))
        {
            var info = VcfFileMetaDataInfo.Parse(s.Substring(s.IndexOf('=') + 1));
            Info.Add(info);
        }
    }

    private static DateTimeOffset? ConvertToDateTimeOffset(string substring)
    {
        var regex = MyRegex();
        var match = regex.Match(substring);
        if (!match.Success)
        {
            return null;
        }
        var year = int.Parse(match.Groups[1].Value);
        var month = int.Parse(match.Groups[2].Value);
        var day = int.Parse(match.Groups[3].Value);
        return new DateTimeOffset(year, month, day,0,0,0, TimeSpan.Zero);
    }

    [GeneratedRegex(@"(\d\d\d\d)[-]?(\d\d)[-]?(\d\d)")]
    private static partial Regex MyRegex();
}