using Fantasista.DNA.SAMFile.Exceptions;

namespace Fantasista.DNA.SAMFile;

public class SamFileOptionalValueCollection : List<SamFileOptionalValue>
{
    /// <summary>
    ///     Parses a string of SAM file optional values and returns a collection of SamFileOptionalValue instances.
    /// </summary>
    /// <param name="optionalValues">
    ///     A semicolon-separated string representing the optional values in a SAM file, where each
    ///     value is formatted as "tag:type:value".
    /// </param>
    /// <returns>A SamFileOptionalValueCollection containing all the parsed optional values.</returns>
    /// <exception cref="SamFileOptionalValueException">
    ///     Thrown when the input string does not conform to the expected format of
    ///     "tag:type:value".
    /// </exception>
    public static SamFileOptionalValueCollection GetOptionalValues(string[] optionalValues)
    {
        var samFileOptionalValueCollection = new SamFileOptionalValueCollection();
        foreach (var optionalValue in optionalValues)
        {
            var split = optionalValue.Split(':', StringSplitOptions.RemoveEmptyEntries);
            if (split.Length != 3) throw new SamFileOptionalValueException("Invalid SAM File Optional Value");
            samFileOptionalValueCollection.Add(new SamFileOptionalValue(split[0], split[1], split[2]));
        }

        return samFileOptionalValueCollection;
    }
}