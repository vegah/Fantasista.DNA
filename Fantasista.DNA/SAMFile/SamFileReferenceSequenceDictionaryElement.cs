using Fantasista.DNA.SAMFile.Exceptions;

namespace Fantasista.DNA.SAMFile;

/// <summary>
///     Represents a molecule with a linear topology.
///     Linear molecules are typically characterized by having a direct, non-circular structure.
/// </summary>
public enum MoleculeTopology
{
    /// <summary>
    ///     Represents a molecule with a linear topology.
    ///     Linear molecules are typically characterized by having a direct, non-circular structure.
    /// </summary>
    Linear,

    /// <summary>
    ///     Represents a molecule with a circular topology.
    ///     Circular molecules are typically characterized by having a looped, non-linear structure.
    /// </summary>
    Circular
}

/// <summary>
///     Represents an element in the reference sequence dictionary within a SAM file.
/// </summary>
public class SamFileReferenceSequenceDictionaryElement
{
    /// <summary>
    ///     Parameterless constructor
    /// </summary>
    /// <param name="lineNo"></param>
    public SamFileReferenceSequenceDictionaryElement(int lineNo)
    {
        AlternateLocus = "";
        ReferenceSequenceName = "";
        Description = "";
        GenomeAssemblyIdentifier = "";
        Species = "";
        Md5Checksum = "";
        SequenceUri = "";
        AlternateReferenceSequenceNames = [];
    }

    /// <summary>
    ///     Gets or sets the alternative reference sequence names as an array of strings.
    /// </summary>
    public string[] AlternateReferenceSequenceNames { get; set; }

    /// <summary>
    ///     Gets or sets the alternate locus as a string.
    /// </summary>
    public string AlternateLocus { get; set; }

    /// <summary>
    ///     Gets or sets the length of the reference sequence.
    /// </summary>
    public int ReferenceSequenceLength { get; set; }

    /// <summary>
    ///     Gets or sets the name of the reference sequence.
    /// </summary>
    public string ReferenceSequenceName { get; set; }


    /// <summary>
    ///     Gets or sets the description of the reference sequence.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    ///     Gets or sets the genome assembly identifier.
    /// </summary>

    public string GenomeAssemblyIdentifier { get; set; }

    /// <summary>
    ///     Gets or sets the species for the reference sequence.
    /// </summary>
    public string Species { get; set; }

    /// <summary>
    ///     Gets or sets the MD5 checksum of the reference sequence.
    /// </summary>
    public string Md5Checksum { get; set; }

    /// <summary>
    ///     Gets or sets the URI associated with the reference sequence.
    /// </summary>
    public string SequenceUri { get; set; }

    /// <summary>
    ///     Gets or sets the topology of the molecule, indicating whether it is linear or circular.
    ///     MoleculeTopology.Linear represents a molecule with a linear structure.
    ///     MoleculeTopology.Circular represents a molecule with a circular structure.
    /// </summary>
    public MoleculeTopology MoleculeTopology { get; set; }


    /// <summary>
    ///     Parses the provided reference sequence dictionary header and splits it into key-value pairs
    ///     to populate the appropriate properties of the
    ///     <see cref="SamFileReferenceSequenceDictionaryElement" /> instance.
    /// </summary>
    /// <param name="referenceSequenceDictionaryHeader">
    ///     The reference sequence dictionary header string
    ///     containing key-value pairs separated by tabs or spaces.
    /// </param>
    public void Parse(string referenceSequenceDictionaryHeader)
    {
        var datafields = referenceSequenceDictionaryHeader.Split(['\t'], StringSplitOptions.RemoveEmptyEntries);
        foreach (var datafield in datafields) SplitAndSetReferenceSequenceDictionary(datafield);
    }

    private void SplitAndSetReferenceSequenceDictionary(string datafield)
    {
        var fieldParts = datafield.Split(':', 2);
        var tag = fieldParts[0];
        var value = fieldParts[1];
        switch (tag)
        {
            case "SN":
                SetReferenceSequenceName(value);
                break;
            case "LN":
                SetReferenceSequenceLength(value);
                break;
            case "AH":
                SetAlternateLocus(value);
                break;
            case "AN":
                SetAlternativeReferenceSequenceNames(value);
                break;
            case "AS":
                GenomeAssemblyIdentifier = value;
                break;
            case "DS":
                Description = value;
                break;
            case "M5":
                Md5Checksum = value;
                break;
            case "SP":
                Species = value;
                break;
            case "TP":
                SetMoleculeTopology(value);
                break;
            case "UR":
                SequenceUri = value;
                break;
        }
    }

    private void SetMoleculeTopology(string value)
    {
        if (!Enum.TryParse(typeof(MoleculeTopology), value, true, out var sortingOrderOfAlignment))
            throw new SamFileFormatException($"Invalid molecule topology : {value}");
        MoleculeTopology = (MoleculeTopology)sortingOrderOfAlignment;
    }


    private void SetAlternativeReferenceSequenceNames(string value)
    {
        AlternateReferenceSequenceNames = value.Split(',', StringSplitOptions.RemoveEmptyEntries);
    }

    private void SetAlternateLocus(string value)
    {
        AlternateLocus = value;
    }

    private void SetReferenceSequenceLength(string value)
    {
        var length = int.Parse(value);
        ReferenceSequenceLength = length;
    }

    private void SetReferenceSequenceName(string value)
    {
        ReferenceSequenceName = value;
    }
}