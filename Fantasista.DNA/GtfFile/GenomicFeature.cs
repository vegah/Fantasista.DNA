namespace Fantasista.DNA.GtfFile;

/// <summary>
///     Represents a genomic feature parsed from a GTF (General Transfer Format) file.
/// </summary>
/// <remarks>
///     A genomic feature contains essential information about a genomic element such as its location,
///     type, source, strand, and additional associated metadata. This class is designed to be used
///     with GTF file processing and provides properties to store details of the feature.
/// </remarks>
public class GenomicFeature
{
    /// <summary>
    ///     Gets or sets the sequence identifier for the genomic feature.
    /// </summary>
    /// <remarks>
    ///     The sequence identifier represents the name of the sequence (e.g., chromosome, scaffold, or contig)
    ///     where the genomic feature is located. This property corresponds to the first column in GTF or GFF3 files.
    /// </remarks>
    public required string SequenceId { get; set; }

    /// <summary>
    ///     Gets or sets the source of the genomic feature.
    /// </summary>
    /// <remarks>
    ///     The source indicates the origin or generating program of the genomic annotation,
    ///     for example, a specific tool, database, or algorithm. This property corresponds
    ///     to the second column in GTF or GFF3 files.
    /// </remarks>
    public required string Source { get; set; }

    /// <summary>
    ///     Gets or sets the type of the genomic feature.
    /// </summary>
    /// <remarks>
    ///     The feature type specifies the nature or category of the genomic element,
    ///     such as "gene," "exon," or "CDS." This property corresponds to the third
    ///     column in GTF or GFF3 files and provides contextual information about the
    ///     feature being described.
    /// </remarks>
    public required string FeatureType { get; set; }

    /// <summary>
    ///     Gets or sets the start position of the genomic feature on the sequence.
    /// </summary>
    /// <remarks>
    ///     The start position specifies the first base position of the genomic feature on the sequence,
    ///     with a 1-based coordinate system. This property corresponds to the fourth column in GTF or GFF3 files.
    /// </remarks>
    public required int Start { get; set; }


    /// <summary>
    ///     Gets or sets the end position of the genomic feature in the sequence.
    /// </summary>
    /// <remarks>
    ///     The end position represents the 1-based inclusive end coordinate on the sequence
    ///     where the genomic feature terminates. This property corresponds to the fifth column
    ///     in GTF or GFF3 files and should always be greater than or equal to the start position.
    /// </remarks>
    public required int End { get; set; }

    /// <summary>
    ///     Gets or sets the score of the genomic feature.
    /// </summary>
    /// <remarks>
    ///     The score represents a floating-point value which may indicate the level of confidence
    ///     or significance of the feature. This property corresponds to the sixth column in GTF or GFF3 files.
    ///     A null value indicates the absence of a score, which is often represented as '.' in the source file.
    /// </remarks>
    public decimal? Score { get; set; }

    /// <summary>
    ///     Gets or sets the strand of the genomic feature.
    /// </summary>
    /// <remarks>
    ///     The strand indicates the directionality of the genomic feature on the DNA strand.
    ///     It is typically represented by '+' for the positive strand, '-' for the negative strand,
    ///     or '.' for a feature with no strand specificity. This information is commonly found in
    ///     the strand column of GTF or GFF3 files.
    /// </remarks>
    public char Strand { get; set; }

    /// <summary>
    ///     Gets or sets the phase of the feature, indicating the frame of the feature’s sequence.
    /// </summary>
    /// <remarks>
    ///     The phase specifies the reading frame of a feature that is a coding exon.
    ///     Its value can be 0, 1, 2, or null if not applicable. This property corresponds
    ///     to the eighth column in GFF3 files.
    /// </remarks>
    public int? Phase { get; set; }

    /// <summary>
    ///     Gets or sets the collection of attributes associated with the genomic feature.
    /// </summary>
    /// <remarks>
    ///     Attributes represent metadata for the genomic feature in the form of key-value pairs
    ///     as specified in the GTF or GFF3 file. These may include additional informational fields such as
    ///     gene name, transcript ID, or other feature-specific data.
    /// </remarks>
    public required GenomicFeatureAttributes Attributes { get; set; }

    /// <summary>
    ///     Gets or sets the tags associated with the genomic feature.
    /// </summary>
    /// <remarks>
    ///     The tags provide additional descriptive information about the genomic feature,
    ///     such as identifiers, parent relationships, names, and notes. These tags align
    ///     with GFF3 specifications and can include attributes like ID, Parent, Name, Alias,
    ///     and other metadata commonly used in genomic annotations.
    /// </remarks>
    public required GenomicFeatureTags Tags { get; set; }
}