using Fantasista.DNA.SAMFile.Exceptions;

namespace Fantasista.DNA.SAMFile;

/// <summary>
///     Represents a raw sequence alignment entry parsed from a SAM file.
/// </summary>
public class RawSequenceAlignment(int lineNo)
{
    /// <summary>
    ///     Gets or sets the alignment information flags for the sequence alignment record.
    /// </summary>
    /// <remarks>
    ///     The <c>AlignmentInformationFlag</c> property represents a set of flags indicating various properties
    ///     of the sequence alignment according to the SAM (Sequence Alignment/Map) format specification.
    ///     These flags can denote characteristics such as whether a segment is unmapped, if it is part of
    ///     multiple segments, if it is reverse complemented, among others.
    /// </remarks>
    public SamFileAlignmentInformationFlag AlignmentInformationFlag { get; init; }

    /// <summary>
    ///     Gets or sets the mapping quality score for the sequence alignment record.
    /// </summary>
    /// <remarks>
    ///     The <c>MappingQuality</c> property represents the quality of the mapping of the sequence to the reference genome,
    ///     typically indicated by a non-negative integer. Higher values indicate better alignment confidence. This is
    ///     generally used in bioinformatics to assess the accuracy of the alignment in sequence analysis.
    /// </remarks>
    public int MappingQuality { get; init; }

    /// <summary>
    ///     Gets or sets the position of the first base in the alignment within the reference sequence.
    /// </summary>
    /// <remarks>
    ///     The <c>Position</c> property indicates the coordinate of the first base of the query sequence
    ///     as it aligns to the reference sequence. This position is 1-based, following the SAM
    ///     (Sequence Alignment/Map) format specification, which is commonly used in sequencing data processing.
    /// </remarks>
    public int Position { get; init; }

    /// <summary>
    ///     Gets or sets the reference sequence name for the sequence alignment record.
    /// </summary>
    /// <remarks>
    ///     The <c>ReferenceSequence</c> property represents the name of the reference sequence that the
    ///     given sequence has been aligned to, according to the SAM (Sequence Alignment/Map) file format.
    ///     It typically corresponds to the query or subject sequence in genomic data analysis.
    /// </remarks>
    public required string ReferenceSequence { get; init; }

    /// <summary>
    ///     Gets or sets the query template name of the sequence alignment.
    /// </summary>
    /// <remarks>
    ///     The <c>QueryTemplateName</c> property represents the identifier of the query template from the SAM (Sequence
    ///     Alignment/Map) file.
    ///     It typically corresponds to the query name or read identifier that is used to denote the sequence in the alignment
    ///     process.
    /// </remarks>
    public required string QueryTemplateName { get; init; }

    /// <summary>
    ///     Gets or sets the CIGAR string for the sequence alignment record.
    /// </summary>
    /// <remarks>
    ///     The <c>CIGAR</c> property represents the CIGAR (Compact Idiosyncratic Gapped Alignment Report) string,
    ///     which describes the alignment between the read and the reference sequence. It contains information about
    ///     the length and type of each alignment operation, such as matches, insertions, deletions, and skips, following
    ///     the SAM (Sequence Alignment/Map) format specification.
    /// </remarks>
    public required SamFileCigar CIGAR { get; init; }

    /// <summary>
    ///     Gets or sets a collection of optional values for the sequence alignment record.
    /// </summary>
    /// <remarks>
    ///     The <c>OptionalValueCollection</c> property represents a collection of optional values associated with
    ///     the sequence alignment as specified in the SAM (Sequence Alignment/Map) format. These optional fields
    ///     provide additional information, which may include tags, types, and values that are not part of the core
    ///     alignment data but offer further insights into the alignment process or characteristics of the read.
    /// </remarks>
    public required SamFileOptionalValueCollection OptionalValueCollection { get; init; }

    /// <summary>
    ///     Gets or sets the read sequence for the sequence alignment record.
    /// </summary>
    /// <remarks>
    ///     The <c>ReadSequence</c> property represents the actual sequence of nucleotides
    ///     or amino acids from the read that is being aligned. This is a critical component
    ///     of sequence alignment as it provides the basis for matching against a reference
    ///     sequence to determine alignment position and quality.
    /// </remarks>
    public required string ReadSequence { get; init; }

    /// <summary>
    ///     Gets or sets the observed Template Length for the alignment.
    /// </summary>
    /// <remarks>
    ///     The <c>TLen</c> property represents the signed observed length of the template in sequence alignment.
    ///     It indicates the distance between the mapped positions of the primary segment and the next segment.
    /// </remarks>
    public required int TLen { get; init; }

    /// <summary>
    ///     Gets or sets the position of the next segment in the template for the sequence alignment.
    /// </summary>
    /// <remarks>
    ///     The <c>PNext</c> property indicates the 1-based position of the next segment in the template for paired-end
    ///     or mate pair sequencing reads, relative to the `ReferenceSequence`. If no next segment exists, it is usually set
    ///     to zero. This information is utilized for determining the layout of paired read alignments in genomic coordinates.
    /// </remarks>
    public required int PNext { get; init; }

    /// <summary>
    ///     Gets or sets the reference sequence field indicating the reference for the next read in the template.
    /// </summary>
    /// <remarks>
    ///     The <c>RNext</c> property specifies the reference sequence name of the next read in the template.
    ///     It is commonly used in paired-end sequencing to denote the reference name of the mate/next read.
    ///     Valid values include a specific reference sequence name or the special symbol "=" which denotes
    ///     that the reference sequence is the same as the current read's reference sequence.
    /// </remarks>
    public required string RNext { get; init; }

    /// <summary>
    ///     Gets or sets the quality scores of the read sequence in the sequence alignment record.
    /// </summary>
    /// <remarks>
    ///     The <c>Quality</c> property represents the ASCII-encoded quality scores for each base in the read sequence.
    ///     In the SAM format, these scores indicate the probability of a sequencing error at each base position.
    /// </remarks>
    public required string Quality { get; init; }


    /// <summary>
    ///     Parses a string representing a SAM file line into a RawSequenceAlignment object.
    /// </summary>
    /// <param name="lineNo">The line number in the SAM file, used for error reporting.</param>
    /// <param name="line">The raw line of text from a SAM file to be parsed.</param>
    /// <returns>A RawSequenceAlignment object populated with data parsed from the SAM file line.</returns>
    public static RawSequenceAlignment Parse(int lineNo, string line)
    {
        var splitLine = line.Split('\t');
        return new RawSequenceAlignment(lineNo)
        {
            QueryTemplateName = splitLine[0],
            AlignmentInformationFlag = (SamFileAlignmentInformationFlag)GetInt(lineNo, splitLine[1]),
            ReferenceSequence = splitLine[2],
            Position = GetInt(lineNo, splitLine[3]),
            MappingQuality = GetInt(lineNo, splitLine[4]),
            CIGAR = SamFileCigar.GetCIGAR(splitLine[5]),
            RNext = splitLine[6],
            PNext = GetInt(lineNo, splitLine[7]),
            TLen = GetInt(lineNo, splitLine[8]),
            ReadSequence = splitLine[9],
            Quality = splitLine[10],
            OptionalValueCollection =
                SamFileOptionalValueCollection.GetOptionalValues(splitLine[11..])
        };
    }

    private static int GetInt(int lineNo, string s)
    {
        if (!int.TryParse(s, out var result)) throw new SamFileExpectedIntegerException(lineNo, s);
        return result;
    }
}