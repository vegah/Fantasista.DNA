using System.Text.RegularExpressions;
using Fantasista.DNA.SAMFile.Exceptions;

namespace Fantasista.DNA.SAMFile;

/// <summary>
///     Represents a read group in a SAM file, encapsulating metadata such as identifier, platform unit,
///     description, and additional attributes relevant to sequencing data.
/// </summary>
public class SamFileReadGroup(int lineNo)
{
    /// <summary>
    ///     Represents the platform/technology type used in sequencing.
    /// </summary>
    public enum PlatformTechnologyType
    {
        /// <summary>
        ///     Sequencing technology that uses capillary electrophoresis.
        /// </summary>
        Capillary,

        /// <summary>
        ///     Sequencing technology developed by MGI using patterned DNA nanoarrays.
        /// </summary>
        Dnbseq,

        /// <summary>
        ///     Advanced nanopore-based sequencing technology providing single-molecule accuracy.
        /// </summary>
        Element,

        /// <summary>
        ///     Sequencing technology that employs single-molecule fluorescence sequencing.
        /// </summary>
        Helicos,

        /// <summary>
        ///     Sequencing technology developed by Illumina, Inc., known for its high-throughput capabilities.
        /// </summary>
        Illumina,

        /// <summary>
        ///     Sequencing technology that utilizes semiconductor sequencing.
        /// </summary>
        Iontorrent,

        /// <summary>
        ///     Sequencing technology developed by 454 Life Sciences, known for its early contributions to high-throughput
        ///     sequencing.
        /// </summary>
        Ls454,

        /// <summary>
        ///     Sequencing technology developed by Oxford Nanopore Technologies.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        ONT,

        /// <summary>
        ///     Sequencing technology developed by Pacific Biosciences.
        /// </summary>
        PacBio,

        /// <summary>
        ///     Sequencing technology provided by Singular Genomics, known for its innovative approach to DNA sequencing.
        /// </summary>
        Singular,

        /// <summary>
        ///     Sequencing technology developed by Life Technologies, also known as Supported Oligonucleotide Ligation and
        ///     Detection.
        /// </summary>
        Solid,

        /// <summary>
        ///     Sequencing technology developed by Ultima Genomics.
        /// </summary>
        Ultima
    }

    /// <summary>
    ///     Gets the identifier of the SAM file read group.
    /// </summary>
    public string? Identifier { get; private set; }


    /// <summary>
    ///     Gets or sets the platform unit information for the SAM file read group.
    ///     Platform Unit typically contains the unique identifier of the run or the specific sequencing instrument.
    /// </summary>
    public string? PlatformUnit { get; set; }

    /// <summary>
    ///     Gets or sets the description of the SAM file read group.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    ///     Gets or sets the library identifier associated with the SAM file read group.
    /// </summary>
    public string? Library { get; set; }

    /// <summary>
    ///     Gets or sets the sample name associated with the SAM file read group.
    /// </summary>
    public string? Sample { get; set; }

    /// <summary>
    ///     Gets or sets the platform model of the sequencing instrument.
    /// </summary>
    public string PlatformModel { get; set; }

    /// <summary>
    ///     Gets or sets the predicted median insert size for the read group.
    /// </summary>
    public int? PredictedMedianInsertSize { get; set; }

    /// <summary>
    ///     Gets or sets the name of the sequencing center where the read group was generated.
    /// </summary>
    public string? SequencingCenterName { get; set; }

    /// <summary>
    ///     Gets or sets the sequence of barcodes used in the SAM file read group.
    ///     This can be used to identify and track samples through the sequencing process.
    /// </summary>
    public string? BarcodeSequence { get; set; }

    /// <summary>
    ///     Gets or sets the run date when sequencing was performed.
    /// </summary>
    public DateTimeOffset? RunDate { get; set; }

    /// <summary>
    ///     Gets or sets the programs used in data processing.
    /// </summary>
    public string? Programs { get; set; }

    /// <summary>
    ///     Gets or sets the array of nucleotide bases that dictate the order of incorporation
    ///     during sequencing, primarily used by platforms such as Ion Torrent.
    /// </summary>
    public string? FlowOrder { get; set; }

    /// <summary>
    ///     Gets or sets the platform or technology type used in sequencing and represented by the PlatformTechnologyType enum.
    /// </summary>
    public PlatformTechnologyType? PlatformTechnology { get; set; }

    /// <summary>
    ///     Parses a single line of SAM read group headers input and sets the relevant properties of the SamFileReadGroup
    ///     instance.
    /// </summary>
    /// <param name="line">
    ///     The input string representing a line from a SAM file which contains various fields separated by tab
    ///     characters.
    /// </param>
    public void Parse(string line)
    {
        var datafields = line.Split(['\t'], StringSplitOptions.RemoveEmptyEntries);
        foreach (var datafield in datafields) SplitAndSetReferenceReadGroup(datafield);
    }

    private void SplitAndSetReferenceReadGroup(string datafield)
    {
        var fieldParts = datafield.Split(':', 2);
        var tag = fieldParts[0];
        var value = fieldParts[1];
        switch (tag)
        {
            case "ID":
                Identifier = value;
                break;
            case "SM":
                Sample = value;
                break;
            case "LB":
                Library = value;
                break;
            case "DS":
                Description = value;
                break;
            case "PU":
                PlatformUnit = value;
                break;
            case "PI":
                PredictedMedianInsertSize = int.Parse(value);
                break;
            case "PM":
                PlatformModel = value;
                break;
            case "DT":
                RunDate = DateTimeOffset.Parse(value);
                break;
            case "BC":
                BarcodeSequence = value;
                break;
            case "CN":
                SequencingCenterName = value;
                break;
            case "FO":
                SetFlowOrder(value);
                break;
            case "PG":
                Programs = value;
                break;
            case "PL":
                SetPlatformTechnology(value);
                break;
        }
    }

    private void SetPlatformTechnology(string value)
    {
        if (Enum.TryParse(value, true, out PlatformTechnologyType technology)) PlatformTechnology = technology;
        else
            throw new SamFileFormatException(
                $"The platform technology value {value} is not defined in the standard for SAM files");
    }

    private void SetFlowOrder(string value)
    {
        var regex = new Regex(@"\*|[ACMGRSVTWYHKDBN]+");
        var match = regex.Match(value);
        if (!match.Success)
            throw new SamFileFormatException("FlowOrder (RG:FO) should be in format *[ACMGRSVTWYHKDBN]");
        FlowOrder = value;
    }
}