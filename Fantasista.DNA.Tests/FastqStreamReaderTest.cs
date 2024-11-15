using Fantasista.DNA.FastaFile;
using Fantasista.DNA.FastaFile.Inspectors;
using Fantasista.DNA.Sequence;
using Moq;

namespace Fantasista.DNA.Tests;

public class FastqStreamReaderTest
{
    [Fact]
    public void Example_of_fastq_file_reads_correctly()
    {
        var text =
            "@ab\nNGA\n+qual\n#ab";
        var reader = new FastqStreamReader(text);
        var result = reader.Read().ToArray();
        Assert.Equal("ab",result[0].Identifier);
        Assert.Equal("qual",result[0].QualityIdentifier);
        Assert.Equal("NGA",result[0].RawSequence);
        Assert.Equal("#ab",result[0].RawQuality);
    }

    [Fact]
    public void Example_of_fastq_file_reads_correctly_with_multiple_newlines()
    {
        var text =
            "@ab\n\nNGA\n+qual\n#ab";
        var reader = new FastqStreamReader(text);
        var result = reader.Read().ToArray();
        Assert.Equal("ab",result[0].Identifier);
        Assert.Equal("qual",result[0].QualityIdentifier);
        Assert.Equal("NGA",result[0].RawSequence);
        Assert.Equal("#ab",result[0].RawQuality);
    }

    [Fact]
    public void Inspector_is_called_when_using_inspectedd_reads()
    {
        var text =
            "@ab\n\nNGA\n+qual\n#ab";
        var reader = new FastqStreamReader(text);
        var inspector = new Mock<ISequenceInspector<BasicSequence>>();
        var result = reader.ReadInspected(inspector.Object).ToArray();
        inspector.Verify(x=>x.InspectSequence(It.IsAny<BasicSequence>()), Times.Once);        
    }
    
    
}