using System.Globalization;
using System.Text;
using Fantasista.DNA.GtfFile.Exceptions;

namespace Fantasista.DNA.GtfFile;

/// <summary>
///     Provides functionality to parse GFF3 (General Feature Format version 3) data
///     from text-based inputs such as streams or strings.
/// </summary>
/// <remarks>
///     This class is designed to read and process GFF3 format data containing genomic
///     feature annotations. It extracts data line-by-line, distinguishing between
///     genomic feature entries and comments. Genomic features are returned as objects
///     of type <see cref="GenomicFeature" />, while comments are collected separately
///     in the <see cref="Comments" /> list.
/// </remarks>
public class Gff3StreamReader : IDisposable
{
    private readonly StreamReader _reader;

    /// <summary>
    ///     Provides a reader to parse GFF3 (General Feature Format version 3) data
    ///     from a stream or string input source, extracting genomic features and comments.
    /// </summary>
    /// <remarks>
    ///     Gff3StreamReader is designed to process biological data in the GFF3 format. It reads and
    ///     parses the input line-by-line, distinguishing between genomic features and comments.
    ///     Parsed genomic features are returned as instances of <see cref="GenomicFeature" />.
    ///     Comments encountered during the parsing process are stored in the <see cref="Comments" /> list.
    /// </remarks>
    public Gff3StreamReader(string contentString) : this(new MemoryStream(Encoding.UTF8.GetBytes(contentString)))
    {
    }

    /// <summary>
    ///     Provides a reader to parse GFF3 (General Feature Format version 3) data
    ///     from a stream or string input source, extracting genomic features and comments.
    /// </summary>
    /// <remarks>
    ///     Gff3StreamReader is designed to process biological data in the GFF3 format. It reads and
    ///     parses the input line-by-line, distinguishing between genomic features and comments.
    ///     Parsed genomic features are returned as instances of <see cref="GenomicFeature" />.
    ///     Comments encountered during the parsing process are stored in the <see cref="Comments" /> list.
    /// </remarks>
    public Gff3StreamReader(Stream s)
    {
        _reader = new StreamReader(s);
        Comments = new List<string>();
    }

    /// <summary>
    ///     Gets or sets a collection of comment lines extracted from the input data stream.
    /// </summary>
    /// <remarks>
    ///     During the parsing process, lines that start with a '#' character are identified as comments
    ///     and stored in this property. These comments may contain metadata or additional information
    ///     relevant to the genomic data being processed.
    /// </remarks>
    public List<string> Comments { get; set; }

    /// <summary>
    ///     Releases all resources used by the <see cref="Gff3StreamReader" /> object.
    /// </summary>
    /// <remarks>
    ///     This method ensures that all resources such as the underlying stream and reader
    ///     utilized by the <see cref="Gff3StreamReader" /> are properly disposed of.
    ///     Once called, the instance cannot be used further and should be discarded.
    /// </remarks>
    public void Dispose()
    {
        _reader.Dispose();
    }

    /// <summary>
    ///     Reads and parses lines from the underlying data stream, extracting genomic features.
    /// </summary>
    /// <returns>
    ///     An enumerable collection of <see cref="GenomicFeature" /> objects representing parsed genomic features
    ///     from the input data stream. Comments encountered during parsing are stored in the <see cref="Comments" /> property.
    /// </returns>
    public IEnumerable<GenomicFeature> Read()
    {
        var lineNo = 0;
        while (_reader.ReadLine() is { } line)
        {
            lineNo++;
            if (line.Length == 0) continue;
            if (line.StartsWith("##"))
                if (line != "##gff-version 3" && lineNo == 1)
                    throw new Gff3FormatException("Expected gff-version 3, but got " + line.Substring(2));

            if (line.StartsWith("#"))
            {
                Comments.Add(line[1..]);
            }
            else
            {
                var split = line.Split('\t');
                yield return ExtractGenomicFeature(split, lineNo);
            }
        }
    }

    private GenomicFeature ExtractGenomicFeature(string[] split, int lineNo)
    {
        var seqid = split[0];
        var source = split[1];
        var type = split[2];
        if (!int.TryParse(split[3], out var start))
            throw new Gff3FormatException($"Expected start to be a number - got {split[3]}");
        if (!int.TryParse(split[4], out var end))
            throw new Gff3FormatException($"Expected end to be a number - got {split[4]}");
        decimal? score = null;
        if (decimal.TryParse(split[5], CultureInfo.InvariantCulture, out var parsedScore))
            score = parsedScore;
        var strand = GetStrand(split[6]);
        var phase = GetPhase(split[7]);
        var attributes = GetAttributes(split[8]);
        var tags = GetTags(attributes);
        return new GenomicFeature
        {
            Attributes = attributes,
            End = end,
            Phase = phase,
            Score = score,
            Source = source,
            Start = start,
            Strand = strand,
            Tags = tags,
            FeatureType = type,
            SequenceId = seqid
        };
    }

    private GenomicFeatureTags GetTags(GenomicFeatureAttributes attributes)
    {
        var tag = new GenomicFeatureTags();
        if (attributes.TryGetValue("ID", out var id))
            tag.Id = id;
        if (attributes.TryGetValue("Name", out var name))
            tag.Name = name;
        if (attributes.TryGetValue("Alias", out var alias))
            tag.Alias = alias;
        if (attributes.TryGetValue("Parent", out var parent))
            tag.Parent = parent;
        if (attributes.TryGetValue("Target", out var target))
            tag.Target = target;
        if (attributes.TryGetValue("Gap", out var gap))
            tag.Gap = gap;
        if (attributes.TryGetValue("Derives_from", out var derivesFrom))
            tag.DerivesFrom = derivesFrom;
        if (attributes.TryGetValue("Note", out var note))
            tag.Note = note;
        if (attributes.TryGetValue("Dbxref", out var dbxref))
            tag.Dbxref = dbxref;
        if (attributes.TryGetValue("Ontology_term", out var ontologyTerm))
            tag.OntologyTerm = ontologyTerm;
        return tag;
    }

    private GenomicFeatureAttributes GetAttributes(string s)
    {
        var genomicFeatureAttributes = new GenomicFeatureAttributes();
        var attributes = s.Split(';');
        foreach (var attribute in attributes)
        {
            var split2 = attribute.Split('=');
            if (split2.Length != 2)
                throw new Gff3FormatException($"Expected attribute to be in the form 'key=value' - got {attribute}");
            genomicFeatureAttributes.Add(split2[0], split2[1]);
        }

        return genomicFeatureAttributes;
    }

    private int? GetPhase(string s)
    {
        if (s == ".") return null;
        if (int.TryParse(s, out var phase) && phase < 3 && phase >= 0) return phase;
        throw new Gff3FormatException($"Expected phase to be a number between 0 and 2, or '.' - got {s}");
    }

    private char GetStrand(string s)
    {
        if (s.Length != 1) throw new Gff3FormatException($"Expected strand to be a single character - got {s}");
        var ch = s[0];
        return ch switch
        {
            '-' => '-',
            '+' => '+',
            '.' => '.',
            '?' => '?',
            _ => throw new Gff3FormatException($"Expected strand to be '+','.','?' or '-' - got {s}")
        };
    }
}