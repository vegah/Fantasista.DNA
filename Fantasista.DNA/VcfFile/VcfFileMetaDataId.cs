namespace Fantasista.DNA.VcfFile;

public class VcfFileMetaDataId 
{
    public static VcfFileMetaDataId Parse(string substring)
    {
        var parsedFields = VcfFieldParser.Parse(substring);
        return new VcfFileMetaDataId
        {
            Description = parsedFields.GetValueOrDefault("Description")
        };
    }

    public string? Description { get; set; }
}