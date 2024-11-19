using System.Text;
using Fantasista.DNA.SAMFile.SamFileMetadataExceptions;

namespace Fantasista.DNA.SAMFile;

/// <summary>
///     Class for reading SAM (Sequence Alignment / Map) files.
/// </summary>
public class SamStreamReader : IDisposable
{
    private readonly StreamReader _reader;

    /// <summary>
    ///     Instansiate class with a string.
    /// </summary>
    /// <param name="content">The content of the file as a string</param>
    public SamStreamReader(string content) : this(new MemoryStream(Encoding.UTF8.GetBytes(content)))
    {
    }

    /// <summary>
    ///     Instansiate the class with a stream
    /// </summary>
    /// <param name="stream">A readable stream containing the SAM file</param>
    public SamStreamReader(Stream stream)
    {
        _reader = new StreamReader(stream);
        Metadata = new SamFileLevelMetadata();
        ReferenceSequenceDictionary = new SamFileReferenceSequenceDictionary();
        ReadGroups = new List<SamFileReadGroup>();
    }

    public List<SamFileReadGroup> ReadGroups { get; set; }

    /// <summary>
    ///     Gets the metadata associated with the SAM file.
    /// </summary>
    /// <remarks>
    ///     The Metadata property provides access to various metadata information
    ///     extracted from the SAM file header, such as version, sorting order of
    ///     alignments, grouping of alignments, and sub-sorting.
    /// </remarks>
    public SamFileLevelMetadata Metadata { get; }

    /// <summary>
    ///     Gets or sets the dictionary of reference sequences in the SAM file.
    /// </summary>
    /// <remarks>
    ///     The ReferenceSequenceDictionary property provides access to the collection of reference sequences
    ///     extracted from the SAM file header. This includes information such as the reference sequence names,
    ///     lengths, descriptions, and other relevant metadata.
    /// </remarks>
    public SamFileReferenceSequenceDictionary ReferenceSequenceDictionary { get; set; }


    /// <summary>
    ///     Releases all resources used by the SamStreamReader instance.
    /// </summary>
    public void Dispose()
    {
        _reader.Dispose();
    }

    /// <summary>
    ///     Reads sequence alignments from a SAM file stream.
    /// </summary>
    /// <returns>An enumerable collection of SequenceAlignment instances.</returns>
    public IEnumerable<SequenceAlignment> Read()
    {
        while (_reader.ReadLine() is { } line)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            if (line[0] == '@') ParseHeader(line[1..]);
            yield return new SequenceAlignment();
        }
    }

    private void ParseHeader(string header)
    {
        if (header.StartsWith("HD"))
        {
            Metadata.Parse(header[2..]);
        }
        else if (header.StartsWith("SQ"))
        {
            var newReferenceSequenceDictionary = new SamFileReferenceSequenceDictionaryElement();
            newReferenceSequenceDictionary.Parse(header[2..]);
            ReferenceSequenceDictionary.Add(newReferenceSequenceDictionary);
        }
        else if (header.StartsWith("RG"))
        {
            var readGroup = new SamFileReadGroup();
            readGroup.Parse(header[2..]);
            ReadGroups.Add(readGroup);
        }
    }
}