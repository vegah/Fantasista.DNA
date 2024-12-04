using Fantasista.DNA.SAMFile;

namespace Fantasista.DNA.Tests.SamFileTests;

public class BamStreamReaderTests
{
    [Fact]
    public void Header_without_references_are_read_correctly()
    {
        var stream = new MemoryStream([0x42, 0x41, 0x4D, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00]);
        using var bamData = new BamStreamReader(stream);
        var data = bamData.Read().ToArray();
        Assert.Equal("", bamData.HeaderString);
        Assert.Equal(0, bamData.NumberOfReferences);
    }

    [Fact]
    public void Header_with_1_reference_without_reference_sequence_are_read_correctly()
    {
        var stream = new MemoryStream([
            0x42, 0x41, 0x4D, 0x01, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00,
            0x05, 0x00, 0x00, 0x00,
            0x63, 0x68, 0x72, 0x31, 0x00,
            0x00, 0x00, 0x00, 0x00
        ]);
        using var bamData = new BamStreamReader(stream);
        var data = bamData.Read().ToArray();
        Assert.Equal("", bamData.HeaderString);
        Assert.Equal(1, bamData.NumberOfReferences);
    }

    [Fact]
    public void Header_with_1_reference_with_one_reference_sequence_are_read_correctly()
    {
        var stream = new MemoryStream([
            0x42, 0x41, 0x4D, 0x01, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00,
            0x05, 0x00, 0x00, 0x00,
            0x63, 0x68, 0x72, 0x31, 0x00,
            0x01, 0x00, 0x00, 0x00
        ]);
        using var bamData = new BamStreamReader(stream);
        var data = bamData.Read().ToArray();
        Assert.Equal("", bamData.HeaderString);
        Assert.Equal(1, bamData.NumberOfReferences);
    }
}