namespace Fantasista.DNA.VcfFile;

/// <summary>
/// Class that describes the info metadata from a vcf file.
/// An instance of this class will describe one info field, and is contained in the MetaData of the StreanReader.
/// </summary>
public class VcfFileMetaDataInfo
{
    /// <summary>
    /// Parses one info line from the metadata
    /// </summary>
    /// <param name="substring">The line excluding the ## </param>
    /// <returns>A VcfFileMetaDataInfo instance</returns>
    public static VcfFileMetaDataInfo Parse(string substring)
    {
        var parsedFields = VcfFieldParser.Parse(substring);
        return new VcfFileMetaDataInfo
        {
            Description = parsedFields.GetValueOrDefault("Description"),
            Number = parsedFields.GetValueOrDefault("Number"),
            Id = parsedFields.GetValueOrDefault("ID"),
            Type = parsedFields.GetValueOrDefault("Type")
        };
    }

    /// <summary>
    /// Description of the info field
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// The type of the info field
    /// </summary>
    public string? Type { get; set; }
    /// <summary>
    /// The number of elements expected in the info field
    /// </summary>
    public string? Number { get; set; }
    /// <summary>
    /// The id of the info field
    /// </summary>
    public string? Id { get; set; }

}