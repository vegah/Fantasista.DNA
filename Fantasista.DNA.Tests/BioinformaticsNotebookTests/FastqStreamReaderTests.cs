using Fantasista.DNA.FastaFile;

namespace Fantasista.DNA.Tests.BioinformaticsNotebookTests;

public class FastqStreamReaderTests
{
    [Fact]
    public void Example_of_fastq_file_reads_correctly()
    {
        var text =
            "@ab\nNGA\n+qual\n#ab";
        var reader = new FastqStreamReader(text);
        var result = reader.Read().ToArray();
        Assert.Equal("ab",result[0].Description);
        Assert.Equal("qual",result[0].QualityComment);
        Assert.Equal("NGA",result[0].RawSequence);
        Assert.Equal("#ab",result[0].RawQuality);
    }
}