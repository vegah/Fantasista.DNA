using System.Text.RegularExpressions;
using Fantasista.DNA.SAMFile.SamFileMetadataExceptions;

namespace Fantasista.DNA.SAMFile;

/// <summary>
///     Represents metadata at the file level for a SAM (Sequence Alignment/Map) file.
///     Provides properties and methods to parse and handle file-level metadata such as version and sorting order of
///     alignments.
/// </summary>
public class SamFileLevelMetadata
{
    /// <summary>
    ///     Defines the possible grouping options for alignments within a SAM (Sequence Alignment/Map) file.
    ///     Indicates how alignments are grouped, whether by query, reference, or if no specific grouping is applied.
    /// </summary>
    public enum GroupingOfAlignments
    {
        /// <summary>
        ///     Indicates that no specific grouping is applied to the alignments within a SAM (Sequence Alignment/Map) file.
        ///     This serves as a default value when alignments are not grouped by any particular criteria.
        /// </summary>
        None,

        /// <summary>
        ///     Indicates that alignments within a SAM (Sequence Alignment/Map) file are grouped according to their query name.
        ///     This grouping allows for easier analysis and retrieval of alignments based on query-specific criteria.
        /// </summary>
        Query,

        /// <summary>
        ///     Indicates that the alignments within a SAM (Sequence Alignment/Map) file are grouped by their reference sequence.
        ///     This grouping is used to organize alignments based on their associated reference sequences within the file.
        /// </summary>
        Reference
    }

    /// <summary>
    ///     Represents the different possible sorting orders for alignments within a SAM (Sequence Alignment/Map) file.
    /// </summary>
    public enum SortingOrderOfAlignments
    {
        /// <summary>
        ///     Indicates an undefined or unrecognized sorting order for alignments within a SAM (Sequence Alignment/Map) file.
        ///     This serves as a default value when the sorting order cannot be determined or is not specified.
        /// </summary>
        Unknown,

        /// <summary>
        ///     Indicates that the alignments within a SAM (Sequence Alignment/Map) file are not sorted in any particular order.
        ///     This option specifies that no sorting order has been applied to the alignments.
        /// </summary>
        Unsorted,

        /// <summary>
        ///     Orders the alignments by query name within a SAM (Sequence Alignment/Map) file.
        ///     This sorting order facilitates grouping of alignments that share the same read name.
        /// </summary>
        Queryname,

        /// <summary>
        ///     Indicates that alignments within a SAM (Sequence Alignment/Map) file are sorted by the reference sequence
        ///     coordinates.
        ///     This sorting method arranges alignments in the order they appear on the reference sequence.
        /// </summary>
        Coordinate
    }

    /// <summary>
    ///     Represents metadata at the file level for a SAM file.
    /// </summary>
    public SamFileLevelMetadata()
    {
        SubSorting = "";
        Version = "";
    }

    /// <summary>
    ///     Gets or sets the sorting order of the alignments within the SAM (Sequence Alignment/Map) file.
    ///     This property indicates how the alignments are ordered, which can be one of the values specified
    ///     in the <see cref="SortingOrderOfAlignments" /> enum.
    /// </summary>
    /// <exception cref="SamFileFormatException">
    ///     Thrown when an invalid sorting order value is set.
    /// </exception>
    public SortingOrderOfAlignments SortingOrderOfAlignment { get; set; }

    /// <summary>
    ///     Gets or sets the version of the SAM (Sequence Alignment/Map) file format.
    ///     This property must adhere to the format "major.minor", where both major and minor are integers.
    /// </summary>
    /// <exception cref="SamFileFormatException">
    ///     Thrown when an invalid version format is set.
    /// </exception>
    public string Version { get; set; }

    /// <summary>
    ///     Gets or sets the grouping of the alignments within the SAM (Sequence Alignment/Map) file.
    ///     This property indicates how the alignments are grouped, which can be one of the values specified
    ///     in the <see cref="GroupingOfAlignments" /> enum.
    /// </summary>
    /// <exception cref="SamFileFormatException">
    ///     Thrown when an invalid grouping value is set.
    /// </exception>
    public GroupingOfAlignments GroupingOfAlignment { get; set; }

    /// <summary>
    ///     Gets or sets the sub-sorting criteria for the SAM (Sequence Alignment/Map) file.
    ///     This property specifies detailed sorting information beyond the primary sorting order defined
    ///     by <see cref="SortingOrderOfAlignments" />.
    /// </summary>
    /// <exception cref="SamFileFormatException">
    ///     Thrown when an invalid sub-sorting value is set.
    /// </exception>
    public string SubSorting { get; set; }

    /// <summary>
    ///     Parses the provided SAM file header and sets the metadata properties accordingly.
    /// </summary>
    /// <param name="header">The SAM file header string to parse.</param>
    public void Parse(string header)
    {
        var datafields = header.Split(['\t', ' '], StringSplitOptions.RemoveEmptyEntries);
        foreach (var datafield in datafields) SplitAndSetMetadataField(datafield);
    }

    private void SplitAndSetMetadataField(string datafield)
    {
        var fieldParts = datafield.Split(':', 2);
        var tag = fieldParts[0];
        var value = fieldParts[1];
        switch (tag)
        {
            case "VN":
                SetVersion(value);
                break;
            case "SO":
                SetSortingOrder(value);
                break;
            case "GO":
                SetGroupingOfAlignments(value);
                break;
            case "SS":
                SetSubSorting(value);
                break;
        }
    }

    private void SetSubSorting(string value)
    {
        var regex = new Regex("(coordinate|queryname|unsorted)(:[A-Za-z0-9_-]+)+");
        var match = regex.Match(value);
        if (!match.Success) throw new SamFileFormatException($"Invalid sub sorting order : {value}");
        SubSorting = value;
    }

    private void SetGroupingOfAlignments(string value)
    {
        if (!Enum.TryParse(typeof(GroupingOfAlignments), value, true, out var sortingOrderOfAlignment))
            throw new SamFileFormatException($"Invalid grouping of alignment value : {value}");
        GroupingOfAlignment = (GroupingOfAlignments)sortingOrderOfAlignment;
    }

    private void SetSortingOrder(string value)
    {
        if (!Enum.TryParse(typeof(SortingOrderOfAlignments), value, true, out var sortingOrderOfAlignment))
            throw new SamFileFormatException($"Invalid sorting order : {value}");
        SortingOrderOfAlignment = (SortingOrderOfAlignments)sortingOrderOfAlignment;
    }

    private void SetVersion(string value)
    {
        var regex = new Regex(@"^[0-9]+\.[0-9]+$");
        var match = regex.Match(value);
        if (!match.Success) throw new SamFileFormatException($"Invalid file version : {value}");
        Version = value;
    }
}