using Fantasista.DNA.FastaFile;

namespace Fantasista.DNA.Tests.BioinformaticsNotebookTests;

public class FastqStreamReaderTests
{
    [Fact]
    public void Example_of_fastq_file_reads_correctly()
    {
        var text =
            "@SRR8933535.1 1 length=75\nNAGGAAACAAAGGCTTACCCGTTATCATTTCCGCAAGAATGCACCCACACGACCATATATCAATGGATGTGGAGT\n+SRR8933535.1 1 length=75\n#AAAAEEEEEEEEEEEEEEEEEEEEEAEEEEEAEEEEEEEAEAEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEAE\n@SRR8933535.2 2 length=75\nNGAGGAGTGGTGGTAGTGTTGCTTGGTGGCAAAGATGTAGTTGGTGGGAAAGCTGAAGTGGTACCGTTGGTTGGA\n+SRR8933535.2 2 length=75\n#AAAAEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEAAEEEE";
        var reader = new FastqStreamReader(text);
        var result = reader.Read().ToArray();
        Assert.Equal("SRR8933535.1 1 length=75",result[0].Identifier);
        Assert.Equal("SRR8933535.1 1 length=75",result[0].QualityIdentifier);
        Assert.Equal("NAGGAAACAAAGGCTTACCCGTTATCATTTCCGCAAGAATGCACCCACACGACCATATATCAATGGATGTGGAGT",result[0].RawSequence);
        Assert.Equal("#AAAAEEEEEEEEEEEEEEEEEEEEEAEEEEEAEEEEEEEAEAEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEAE",result[0].RawQuality);

        Assert.Equal("SRR8933535.2 2 length=75",result[1].Identifier);
        Assert.Equal("SRR8933535.2 2 length=75",result[1].QualityIdentifier);
        Assert.Equal("NGAGGAGTGGTGGTAGTGTTGCTTGGTGGCAAAGATGTAGTTGGTGGGAAAGCTGAAGTGGTACCGTTGGTTGGA",result[1].RawSequence);
        Assert.Equal("#AAAAEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEAAEEEE",result[1].RawQuality);
        
        
    }
    
}