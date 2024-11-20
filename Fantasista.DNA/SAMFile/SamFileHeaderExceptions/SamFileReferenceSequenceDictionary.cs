namespace Fantasista.DNA.SAMFile.SamFileMetadataExceptions;

/// <summary>
///     Represents a dictionary of reference sequences within a SAM file.
/// </summary>
public class SamFileReferenceSequenceDictionary : Dictionary<string, SamFileReferenceSequenceDictionaryElement>
{
    /// <summary>
    ///     Adds a new element to the SamFileReferenceSequenceDictionary.
    /// </summary>
    /// <param name="element">The SamFileReferenceSequenceDictionaryElement to add to the dictionary.</param>
    public void Add(SamFileReferenceSequenceDictionaryElement element)
    {
        Add(element.ReferenceSequenceName, element);
    }
}