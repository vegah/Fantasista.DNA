using Fantasista.DNA.SAMFile;
using Fantasista.DNA.SAMFile.SamFileHeaderExceptions;

namespace Fantasista.DNA.Tests.SamFileTests;

public class SamStreamReaderTests
{
    [Fact]
    public void Metadata_is_parsed_correctly()
    {
        var text = "@HD\tVN:1.6\tSO:coordinate\tGO:query\tSS:unsorted:MI:coordinate\n@SQ SN:ref LN:45";
        using var reader = new SamStreamReader(text);
        var read = reader.Read().ToArray();
        Assert.Equal("1.6", reader.Metadata.Version);
        Assert.Equal(SamFileLevelMetadata.SortingOrderOfAlignments.Coordinate, reader.Metadata.SortingOrderOfAlignment);
        Assert.Equal(SamFileLevelMetadata.GroupingOfAlignments.Query, reader.Metadata.GroupingOfAlignment);
        Assert.Equal("unsorted:MI:coordinate", reader.Metadata.SubSorting);
    }

    [Fact]
    public void Metadata_throws_exception_when_version_is_unparseable()
    {
        var text = "@HD\tVN:X.6\tSO:coordinate\tGO:query\tSS:unsorted:MI:coordinate\n@SQ SN:ref LN:45";
        using var reader = new SamStreamReader(text);
        var e = Assert.Throws<SamFileFormatException>(() =>
        {
            var a = reader.Read().ToArray();
        });
        Assert.Equal("Invalid file version : X.6", e.Message);
    }

    [Fact]
    public void Metadata_throws_exception_when_grouping_of_alignment_is_unparseable()
    {
        var text = "@HD\tVN:1.6\tSO:coordinate\tGO:nonallowedvalue\tSS:unsorted:MI:coordinate\n@SQ SN:ref LN:45";
        using var reader = new SamStreamReader(text);
        var e = Assert.Throws<SamFileFormatException>(() =>
        {
            var a = reader.Read().ToArray();
        });
        Assert.Equal("Invalid grouping of alignment value : nonallowedvalue", e.Message);
    }

    [Fact]
    public void Metadata_throws_exception_when_sorting_order_is_unparseable()
    {
        var text = "@HD\tVN:1.6\tSO:nonallowedvalue\tGO:query\tSS:unsorted:MI:coordinate\n@SQ SN:ref LN:45";
        using var reader = new SamStreamReader(text);
        var e = Assert.Throws<SamFileFormatException>(() =>
        {
            var a = reader.Read().ToArray();
        });
        Assert.Equal("Invalid sorting order : nonallowedvalue", e.Message);
    }

    [Fact]
    public void Metadata_throws_exception_when_subsorting_is_unparseable()
    {
        var text = "@HD\tVN:1.6\tSO:coordinate\tGO:query\tSS:unallowed:MI:coordinate\n@SQ SN:ref LN:45";
        using var reader = new SamStreamReader(text);
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
            "@HD VN:1.3\tSO:coordinate\n@SQ\tSN:ref\tLN:45\n@SQ\tSN:ref2\tLN:40\n@SQ\tSN:1\tLN:249250621\tAS:NCBI37\tUR:file:/data/local/ref/GATK/human_g1k_v37.fasta\tM5:1b22b98cdeb4a9304cb5d48026a85128\tAH:*\tAN:a,b,c\tDS:test\tSP:testspecies\tTP:circular\n@SQ\tSN:2\tLN:243199373\tAS:NCBI37\tUR:file:/data/local/ref/GATK/human_g1k_v37.fasta\tM5:a0d9851da00400dec1098a9255ac712e\n@SQ\tSN:3\tLN:198022430\tAS:NCBI37\tUR:file:/data/local/ref/GATK/human_g1k_v37.fasta\tM5:fdfd811849cc2fadebc929bb925902e5";
        using var reader = new SamStreamReader(text);
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
            "@HD VN:1.3\tSO:coordinate\n@SQ\tSN:ref\tLN:45\n@SQ\tSN:ref2\tLN:40\n@SQ\tSN:1\tLN:249250621\tAS:NCBI37\tUR:file:/data/local/ref/GATK/human_g1k_v37.fasta\tM5:1b22b98cdeb4a9304cb5d48026a85128\tAH:*\tAN:a,b,c\tDS:test\tSP:testspecies\tTP:nonallowedvalue\n@SQ\tSN:2\tLN:243199373\tAS:NCBI37\tUR:file:/data/local/ref/GATK/human_g1k_v37.fasta\tM5:a0d9851da00400dec1098a9255ac712e\n@SQ\tSN:3\tLN:198022430\tAS:NCBI37\tUR:file:/data/local/ref/GATK/human_g1k_v37.fasta\tM5:fdfd811849cc2fadebc929bb925902e5";
        using var reader = new SamStreamReader(text);
        var exception = Assert.Throws<SamFileFormatException>(() =>
        {
            var read = reader.Read().ToArray();
        });
        Assert.Equal("Invalid molecule topology : nonallowedvalue", exception.Message);
    }

    [Fact]
    public void Read_group_headers_are_parsed_correctly()
    {
        var text =
            "@HD VN:1.3\tSO:coordinate\n@RG\tID:L1\tPU:SC_1_10\tLB:SC_1\tPG:program\tFO:*\tSM:NA1289\tDS:Test description\tPI:12\tBC:barcode\tPM:platformmodel\n@RG\tID:UM0098:1\tPL:ILLUMINA\tPU:HWUSI-EAS1707-615LHAAXX-L001\tLB:80\tDT:2010-05-05T20:00:00-0400\tSM:SD37743\tCN:UMCORE\tFO:A";
        using var reader = new SamStreamReader(text);
        var elements = reader.Read().ToArray();
        Assert.Equal("L1", reader.ReadGroups[0].Identifier);
        Assert.Equal("SC_1_10", reader.ReadGroups[0].PlatformUnit);
        Assert.Equal("SC_1", reader.ReadGroups[0].Library);
        Assert.Equal("NA1289", reader.ReadGroups[0].Sample);
        Assert.Equal("Test description", reader.ReadGroups[0].Description);
        Assert.Equal(12, reader.ReadGroups[0].PredictedMedianInsertSize);
        Assert.Equal("barcode", reader.ReadGroups[0].BarcodeSequence);
        Assert.Equal("platformmodel", reader.ReadGroups[0].PlatformModel);
        Assert.Equal("program", reader.ReadGroups[0].Programs);
        Assert.Equal("*", reader.ReadGroups[0].FlowOrder);
        Assert.Equal(SamFileReadGroup.PlatformTechnologyType.Illumina, reader.ReadGroups[1].PlatformTechnology);
        Assert.Equal("UMCORE", reader.ReadGroups[1].SequencingCenterName);
        Assert.Equal(2010, reader.ReadGroups[1].RunDate!.Value.Year);
        Assert.Equal(5, reader.ReadGroups[1].RunDate!.Value.Month);
        Assert.Equal(5, reader.ReadGroups[1].RunDate!.Value.Day);
        Assert.Equal(20, reader.ReadGroups[1].RunDate!.Value.Hour);
        Assert.Equal("A", reader.ReadGroups[1].FlowOrder);
    }

    [Fact]
    public void Read_group_headers_throws_exception_when_PL_field_parse_fails()
    {
        var text =
            "@HD VN:1.3\tSO:coordinate\n@RG\tID:L1\tPL:test";
        using var reader = new SamStreamReader(text);
        var exception = Assert.Throws<SamFileFormatException>(() =>
        {
            var elements = reader.Read().ToArray();
        });
        Assert.Equal("The platform technology value test is not defined in the standard for SAM files",
            exception.Message);
    }

    [Fact]
    public void Read_group_headers_throws_exception_when_FO_field_parse_fails()
    {
        var text =
            "@HD VN:1.3\tSO:coordinate\n@RG\tID:L1\tFO:(O)";
        using var reader = new SamStreamReader(text);
        var exception = Assert.Throws<SamFileFormatException>(() =>
        {
            var elements = reader.Read().ToArray();
        });
        Assert.Equal("FlowOrder (RG:FO) should be in format *[ACMGRSVTWYHKDBN]",
            exception.Message);
    }


    [Fact]
    public void Read_program_headers_are_read_correctly()
    {
        var text =
            "@HD\tVN:1.0\tSO:coordinate\n@PG\tID:bwa\tVN:0.5.4\n@PG\tID:GATK TableRecalibration\tVN:1.0.3471\tCL:Covariates=[ReadGroupCovariate, QualityScoreCovariate, CycleCovariate, DinucCovariate, TileCovariate], default_read_group=null, default_platform=null, force_read_group=null, force_platform=null, solid_recal_mode=SET_Q_ZERO, window_size_nqs=5, homopolymer_nback=7, exception_if_no_tile=false, ignore_nocall_colorspace=false, pQ=5, maxQ=40, smoothing=1\tDS:Test Description\tPP:PrevID\tPN:Test name";
        using var reader = new SamStreamReader(text);
        var elements = reader.Read().ToArray();
        Assert.Equal("bwa", reader.ProgramHeaders[0].Identifier);
        Assert.Equal("0.5.4", reader.ProgramHeaders[0].Version);
        Assert.Equal("GATK TableRecalibration", reader.ProgramHeaders[1].Identifier);
        Assert.Equal("1.0.3471", reader.ProgramHeaders[1].Version);
        Assert.Equal("Test Description", reader.ProgramHeaders[1].Description);
        Assert.Equal("PrevID", reader.ProgramHeaders[1].PreviousProgramId);
        Assert.Equal("Test name", reader.ProgramHeaders[1].Name);
        Assert.Equal(
            "Covariates=[ReadGroupCovariate, QualityScoreCovariate, CycleCovariate, DinucCovariate, TileCovariate], default_read_group=null, default_platform=null, force_read_group=null, force_platform=null, solid_recal_mode=SET_Q_ZERO, window_size_nqs=5, homopolymer_nback=7, exception_if_no_tile=false, ignore_nocall_colorspace=false, pQ=5, maxQ=40, smoothing=1",
            reader.ProgramHeaders[1].CommandLine);
    }
}