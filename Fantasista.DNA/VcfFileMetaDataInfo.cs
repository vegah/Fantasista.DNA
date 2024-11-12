namespace Fantasista.DNA;

public class VcfFileMetaDataInfo
{
    public static VcfFileMetaDataInfo Parse(string substring)
    {
        var parsedFields = VcfFieldParser.Parse(substring);
        return new VcfFileMetaDataInfo()
        {
            Description = parsedFields.GetValueOrDefault("Description"),
            Number = parsedFields.GetValueOrDefault("Number"),
            Id = parsedFields.GetValueOrDefault("ID"),
            Type = parsedFields.GetValueOrDefault("Type"),
        };
    }

    public string? Description { get; set; }
    public string? Type { get; set; }
    public string? Number { get; set; }
    public string? Id { get; set; }

}