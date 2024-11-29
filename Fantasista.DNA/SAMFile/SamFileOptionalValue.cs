namespace Fantasista.DNA.SAMFile;

/// <summary>
///     Represents an optional value in a SAM file. Each optional value consists of a
///     tag, a type, and a value, which correspond to the key-value pairs in the SAM
///     file format used for various annotations and metadata.
/// </summary>
public class SamFileOptionalValue
{
    public SamFileOptionalValue(string tag, string type, string value)
    {
        Tag = tag;
        Type = type;
        Value = value;
    }

    /// <summary>
    ///     Gets or sets the tag identifier for an optional field in a SAM file.
    /// </summary>
    /// <remarks>
    ///     This property holds the tag identifier which precedes an optional value in a SAM file entry.
    ///     It serves as a key to identify the specific optional data associated with a SAM entry,
    ///     allowing for better interpretation and manipulation of additional information beyond
    ///     the standard SAM fields.
    /// </remarks>
    public string Tag { get; set; }

    /// <summary>
    ///     Gets or sets the type of data associated with the SAM file optional field.
    /// </summary>
    /// <remarks>
    ///     This property specifies the category or data type of the value contained within an optional field
    ///     in a SAM file. It aids in the interpretation of the field's value and can determine how the value
    ///     should be processed or displayed.
    /// </remarks>
    public string Type { get; set; }

    /// <summary>
    ///     Gets or sets the value associated with the SAM file optional field.
    /// </summary>
    /// <remarks>
    ///     This property represents the data or content of an optional field in a SAM file,
    ///     identified by a specific tag and type. The value is a string that holds the actual
    ///     information conveyed by the optional field.
    /// </remarks>
    public string Value { get; set; }
}