using Fantasista.DNA.SAMFile;
using Fantasista.DNA.SAMFile.SamFileMetadataExceptions;

namespace Fantasista.DNA.Tests;

public class SamStreamReaderTests
{
    [Fact]
    public void Metadata_is_parsed_correctly()
    {
        var text = "@HD VN:1.6 SO:coordinate GO:query SS:unsorted:MI:coordinate\n@SQ SN:ref LN:45";
        var reader = new SamStreamReader(text);
        var read = reader.Read().ToArray();
        Assert.Equal("1.6", reader.Metadata.Version);
        Assert.Equal(SamFileLevelMetadata.SortingOrderOfAlignments.Coordinate, reader.Metadata.SortingOrderOfAlignment);
        Assert.Equal(SamFileLevelMetadata.GroupingOfAlignments.Query, reader.Metadata.GroupingOfAlignment);
        Assert.Equal("unsorted:MI:coordinate", reader.Metadata.SubSorting);
    }

    [Fact]
    public void Metadata_throws_exception_when_version_is_unparseable()
    {
        var text = "@HD VN:X.6 SO:coordinate GO:query SS:unsorted:MI:coordinate\n@SQ SN:ref LN:45";
        var reader = new SamStreamReader(text);
        var e = Assert.Throws<SamFileFormatException>(() =>
        {
            var a = reader.Read().ToArray();
        });
        Assert.Equal("Invalid file version : X.6", e.Message);
    }

    [Fact]
    public void Metadata_throws_exception_when_grouping_of_alignment_is_unparseable()
    {
        var text = "@HD VN:1.6 SO:coordinate GO:nonallowedvalue SS:unsorted:MI:coordinate\n@SQ SN:ref LN:45";
        var reader = new SamStreamReader(text);
        var e = Assert.Throws<SamFileFormatException>(() =>
        {
            var a = reader.Read().ToArray();
        });
        Assert.Equal("Invalid grouping of alignment value : nonallowedvalue", e.Message);
    }

    [Fact]
    public void Metadata_throws_exception_when_sorting_order_is_unparseable()
    {
        var text = "@HD VN:1.6 SO:nonallowedvalue GO:query SS:unsorted:MI:coordinate\n@SQ SN:ref LN:45";
        var reader = new SamStreamReader(text);
        var e = Assert.Throws<SamFileFormatException>(() =>
        {
            var a = reader.Read().ToArray();
        });
        Assert.Equal("Invalid sorting order : nonallowedvalue", e.Message);
    }

    [Fact]
    public void Metadata_throws_exception_when_subsorting_is_unparseable()
    {
        var text = "@HD VN:1.6 SO:coordinate GO:query SS:unallowed:MI:coordinate\n@SQ SN:ref LN:45";
        var reader = new SamStreamReader(text);
        var e = Assert.Throws<SamFileFormatException>(() =>
        {
            var a = reader.Read().ToArray();
        });
        Assert.Equal("Invalid sub sorting order : unallowed:MI:coordinate", e.Message);
    }


    [Fact]
    public void Reference_sequence_header_is_parsed_correctly()
    {
        var text =
            "@HD VN:1.3  SO:coordinate\n@SQ SN:ref  LN:45\n@SQ SN:ref2 LN:40\n@SQ\tSN:1\tLN:249250621\tAS:NCBI37\tUR:file:/data/local/ref/GATK/human_g1k_v37.fasta\tM5:1b22b98cdeb4a9304cb5d48026a85128\tAH:*\tAN:a,b,c\tDS:test\tSP:testspecies\tTP:circular\n@SQ\tSN:2\tLN:243199373\tAS:NCBI37\tUR:file:/data/local/ref/GATK/human_g1k_v37.fasta\tM5:a0d9851da00400dec1098a9255ac712e\n@SQ\tSN:3\tLN:198022430\tAS:NCBI37\tUR:file:/data/local/ref/GATK/human_g1k_v37.fasta\tM5:fdfd811849cc2fadebc929bb925902e5";
        var reader = new SamStreamReader(text);
        var read = reader.Read().ToArray();
        Assert.Equal(5, reader.ReferenceSequenceDictionary.Count);
        Assert.Equal("ref", reader.ReferenceSequenceDictionary["ref"].ReferenceSequenceName);
        Assert.Equal(45, reader.ReferenceSequenceDictionary["ref"].ReferenceSequenceLength);
        Assert.Equal("ref2", reader.ReferenceSequenceDictionary["ref2"].ReferenceSequenceName);
        Assert.Equal(40, reader.ReferenceSequenceDictionary["ref2"].ReferenceSequenceLength);
        Assert.Equal("1", reader.ReferenceSequenceDictionary["1"].ReferenceSequenceName);
        Assert.Equal(249250621, reader.ReferenceSequenceDictionary["1"].ReferenceSequenceLength);
        Assert.Equal("1b22b98cdeb4a9304cb5d48026a85128", reader.ReferenceSequenceDictionary["1"].Md5Checksum);
        Assert.Equal("file:/data/local/ref/GATK/human_g1k_v37.fasta",
            reader.ReferenceSequenceDictionary["1"].SequenceUri);
        Assert.Equal("NCBI37", reader.ReferenceSequenceDictionary["1"].GenomeAssemblyIdentifier);
        Assert.Equal("testspecies", reader.ReferenceSequenceDictionary["1"].Species);
        Assert.Equal("test", reader.ReferenceSequenceDictionary["1"].Description);
        Assert.Equal(MoleculeTopology.Circular, reader.ReferenceSequenceDictionary["1"].MoleculeTopology);
        Assert.Equal("*", reader.ReferenceSequenceDictionary["1"].AlternateLocus);
        Assert.Equal("a", reader.ReferenceSequenceDictionary["1"].AlternateReferenceSequenceNames[0]);
        Assert.Equal("b", reader.ReferenceSequenceDictionary["1"].AlternateReferenceSequenceNames[1]);
        Assert.Equal("c", reader.ReferenceSequenceDictionary["1"].AlternateReferenceSequenceNames[2]);
    }

    [Fact]
    public void Reference_sequence_header_throws_exception_when_illegal_values()
    {
        var text =
            "@HD VN:1.3  SO:coordinate\n@SQ SN:ref  LN:45\n@SQ SN:ref2 LN:40\n@SQ\tSN:1\tLN:249250621\tAS:NCBI37\tUR:file:/data/local/ref/GATK/human_g1k_v37.fasta\tM5:1b22b98cdeb4a9304cb5d48026a85128\tAH:*\tAN:a,b,c\tDS:test\tSP:testspecies\tTP:nonallowedvalue\n@SQ\tSN:2\tLN:243199373\tAS:NCBI37\tUR:file:/data/local/ref/GATK/human_g1k_v37.fasta\tM5:a0d9851da00400dec1098a9255ac712e\n@SQ\tSN:3\tLN:198022430\tAS:NCBI37\tUR:file:/data/local/ref/GATK/human_g1k_v37.fasta\tM5:fdfd811849cc2fadebc929bb925902e5";
        var reader = new SamStreamReader(text);
        var exception = Assert.Throws<SamFileFormatException>(() =>
        {
            var read = reader.Read().ToArray();
        });
        Assert.Equal("Invalid molecule topology : nonallowedvalue", exception.Message);
    }
}