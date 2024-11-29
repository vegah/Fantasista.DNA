namespace Fantasista.DNA.SAMFile;

/// <summary>
///     Describes the different flags for SAM file alignment information.
/// </summary>
[Flags]
public enum SamFileAlignmentInformationFlag
{
    /// <summary>
    ///     template having multiple segments in sequencing
    /// </summary>
    TemplateHavingMultipleSegments = 1,

    /// <summary>
    ///     each segment properly aligned according to the aligner
    /// </summary>
    EachSegmentProperlyAligned = 2,

    /// <summary>
    ///     segment unmapped in sequencing
    /// </summary>
    SegmentUnmapped = 4,

    /// <summary>
    ///     next segment in the template unmapped
    /// </summary>
    NextSegmentUnmapped = 8,

    /// <summary>
    ///     SEQ being reverse complemented
    /// </summary>
    SeqBeingReverseComplemented = 16,

    /// <summary>
    ///     SEQ of the next segment in the template being reverse complemented
    /// </summary>
    SeqOfNextSegmentInTemplateBeingReverseComplemented = 32,

    /// <summary>
    ///     the first segment in the template
    /// </summary>
    TheFirstSegmentInTemplate = 64,

    /// <summary>
    ///     the last segment in the template
    /// </summary>
    TheLastSegmentInTemplate = 128,

    /// <summary>
    ///     secondary alignment
    /// </summary>
    SecondaryAlignment = 256,

    /// <summary>
    ///     not passing filters, such as platform/vendor quality controls
    /// </summary>
    NotPassingFilters = 512,

    /// <summary>
    ///     PCR or optical duplicate
    /// </summary>
    PcrOrOpticalDuplicate = 1024,

    /// <summary>
    ///     supplementary alignment
    /// </summary>
    SupplementaryAlignment = 2048
}