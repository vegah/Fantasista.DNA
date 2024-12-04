using Fantasista.DNA.SAMFile.Exceptions;

namespace Fantasista.DNA.SAMFile;

/// <summary>
///     A class responsible for reading BAM (Binary Alignment/Map) file format data from a stream.
/// </summary>
public class BamStreamReader : IDisposable
{
    private readonly BinaryReader _reader;

    /// <summary>
    ///     A class responsible for reading BAM (Binary Alignment/Map) file format data from a stream.
    /// </summary>
    public BamStreamReader(Stream stream)
    {
        _reader = new BinaryReader(stream);
        HeaderString = "";
        ReferenceSequenceDictionary = new SamFileReferenceSequenceDictionary();
    }

    public SamFileReferenceSequenceDictionary ReferenceSequenceDictionary { get; set; }

    /// <summary>
    ///     HeaderString if it is set.
    /// </summary>
    public string HeaderString { get; set; }

    public int NumberOfReferences { get; set; }

    /// <summary>
    ///     Releases all resources used by the BamStreamReader instance.
    /// </summary>
    public void Dispose()
    {
        _reader.Dispose();
    }

    public IEnumerable<RawSequenceAlignment> Read()
    {
        ReadHeaders();
        yield return null;
    }

    private void ReadHeaders()
    {
        var header = new string(_reader.ReadChars(3));
        if (header != "BAM")
            throw new BamFileMissingHeaderException("BAM header missing");
        var magicByte = _reader.ReadByte();
        if (magicByte != 1)
            throw new BamFileMissingHeaderException("BAM header should be followed by a 0x01 byte.");
        var headerStringLength = _reader.ReadInt32();
        HeaderString = new string(_reader.ReadChars(headerStringLength));
        NumberOfReferences = _reader.ReadInt32();
        for (var r = 0; r < NumberOfReferences; r++)
        {
            var refLength = _reader.ReadInt32();
            var referenceName = new string(_reader.ReadChars(refLength));
            var referenceSequenceLength = _reader.ReadUInt32();
            for (var sequence = 0; sequence < referenceSequenceLength; sequence++)
            {
                var blockSize = _reader.ReadUInt32();
                var bytes = _reader.ReadBytes((int)blockSize);
            }
        }
    }
}