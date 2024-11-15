namespace Fantasista.DNA.Sequence;
/// <summary>
/// A class for defining Character Frequency in a sequence
/// </summary>
public class CharacterFrequency
{
    /// <summary>
    /// Creating a simple frequency model based on character and frequency 
    /// </summary>
    /// <param name="character">The character which have the frequency</param>
    /// <param name="frequency">The frequency as the number of instances of that character in a sequence</param>
    public CharacterFrequency(char character, int frequency)
    {
        Character = character;
        Frequency = frequency;
    }
    
    /// <summary>
    /// The character of which the frequency is calculated
    /// </summary>
    public char Character { get; }
    /// <summary>
    /// The frequency for the character
    /// </summary>
    public int Frequency { get;  }
}

/// <summary>
/// A class for storing information about frequencies of characters in a sequence
/// </summary>
public class CharacterFrequencyCollection : List<CharacterFrequency>
{

    /// <summary>
    /// Create a frequency collection from a raw string
    /// </summary>
    /// <param name="rawSequence">The raw sequence of characters</param>
    /// <returns>A frequency collection containing the information</returns>
    public static CharacterFrequencyCollection FromSequence(string? rawSequence)
    {
        if (string.IsNullOrWhiteSpace(rawSequence)) return new CharacterFrequencyCollection();
        var characterFrequencyCollection = new CharacterFrequencyCollection();
        characterFrequencyCollection.AddRange(
            rawSequence
                .GroupBy(c=>c)
                .OrderBy(g=>g.Key)
                .Select(g=>new CharacterFrequency(g.Key,g.Count()))
                .OrderByDescending(c=>c.Frequency)
            );
        return characterFrequencyCollection;
    }
}