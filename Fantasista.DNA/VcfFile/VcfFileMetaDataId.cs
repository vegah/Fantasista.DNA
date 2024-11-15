namespace Fantasista.DNA.VcfFile;

/// <summary>
/// A class that contains information about the metadata id field
/// </summary>
public class VcfFileMetaDataId 
{
    /// <summary>
    /// Parses a ID metadata field from an VCF file
    /// </summary>
    /// <param name="substring">The string excluding ## </param>
    /// <returns>An object containing VcfFileMetaDataId</returns>
    public static VcfFileMetaDataId Parse(string substring)
    {
        var parsedFields = VcfFieldParser.Parse(substring);
        return new VcfFileMetaDataId
        {
            Description = parsedFields.GetValueOrDefault("Description")
        };
    }

    /// <summary>
    /// Description of the id field
    /// </summary>
    public string? Description { get; set; }
}