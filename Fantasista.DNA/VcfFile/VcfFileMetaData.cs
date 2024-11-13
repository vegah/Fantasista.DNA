using System.Text.RegularExpressions;

namespace Fantasista.DNA.VcfFile;

public partial class VcfFileMetaData
{
    public string? FileFormat { get; private set; }
    public DateTimeOffset? FileDate { get; private set; }
    public string? Source { get; private set; }
    public string? Reference { get; private set; }
    public VcfFileMetaDataId? Id { get; private set; }
    
    public List<VcfFileMetaDataInfo> Info {get; } = new();

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