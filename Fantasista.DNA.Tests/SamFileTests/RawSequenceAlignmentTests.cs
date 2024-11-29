using Fantasista.DNA.SAMFile;
using Fantasista.DNA.SAMFile.Exceptions;

namespace Fantasista.DNA.Tests.SamFileTests;

public class RawSequenceAlignmentTests
{
    [Fact]
    public void Test_flag_values_are_converted_correctly()
    {
        var test1 = "r001\t1\tref\t7\t30\t8M2I4M1D3M\t=\t37\t39\tTTAGATAAAGGATACTG\t*";
        var seq1 = RawSequenceAlignment.Parse(1, test1);
        Assert.Equal(SamFileAlignmentInformationFlag.TemplateHavingMultipleSegments, seq1.AlignmentInformationFlag);
        var test2 = "r001\t3\tref\t7\t30\t8M2I4M1D3M\t=\t37\t39\tTTAGATAAAGGATACTG\t*";
        var seq2 = RawSequenceAlignment.Parse(1, test2);
        Assert.Equal(
            SamFileAlignmentInformationFlag.TemplateHavingMultipleSegments |
            SamFileAlignmentInformationFlag.EachSegmentProperlyAligned, seq2.AlignmentInformationFlag);
        var test3 = "r001\t4\tref\t7\t30\t8M2I4M1D3M\t=\t37\t39\tTTAGATAAAGGATACTG\t*";
        var seq3 = RawSequenceAlignment.Parse(1, test3);
        Assert.Equal(SamFileAlignmentInformationFlag.SegmentUnmapped, seq3.AlignmentInformationFlag);
        var test4 = "r001\t56\tref\t7\t30\t8M2I4M1D3M\t=\t37\t39\tTTAGATAAAGGATACTG\t*";
        var seq4 = RawSequenceAlignment.Parse(1, test4);
        Assert.Equal(
            SamFileAlignmentInformationFlag.NextSegmentUnmapped |
            SamFileAlignmentInformationFlag.SeqBeingReverseComplemented |
            SamFileAlignmentInformationFlag.SeqOfNextSegmentInTemplateBeingReverseComplemented,
            seq4.AlignmentInformationFlag);
        var test5 = "r001\t4032\tref\t7\t30\t8M2I4M1D3M\t=\t37\t39\tTTAGATAAAGGATACTG\t*";
        var seq5 = RawSequenceAlignment.Parse(1, test5);
        Assert.Equal(
            SamFileAlignmentInformationFlag.TheFirstSegmentInTemplate |
            SamFileAlignmentInformationFlag.TheLastSegmentInTemplate |
            SamFileAlignmentInformationFlag.SecondaryAlignment | SamFileAlignmentInformationFlag.NotPassingFilters |
            SamFileAlignmentInformationFlag.PcrOrOpticalDuplicate |
            SamFileAlignmentInformationFlag.SupplementaryAlignment,
            seq5.AlignmentInformationFlag);
    }

    [Fact]
    public void Reference_sequence_is_correct()
    {
        var test1 = "r001\t1\tref\t7\t30\t8M2I4M1D3M\t=\t37\t39\tTTAGATAAAGGATACTG\t*";
        var seq1 = RawSequenceAlignment.Parse(1, test1);
        Assert.Equal("ref", seq1.ReferenceSequence);
    }

    [Fact]
    public void Position_is_read_correctly()
    {
        var test1 = "r001\t1\tref\t7\t30\t8M2I4M1D3M\t=\t37\t39\tTTAGATAAAGGATACTG\t*";
        var seq1 = RawSequenceAlignment.Parse(1, test1);
        Assert.Equal(7, seq1.Position);
    }

    [Fact]
    public void Position_throws_exception_if_not_a_number()
    {
        var test1 = "r001\t1\tref\tX\t30\t8M2I4M1D3M\t=\t37\t39\tTTAGATAAAGGATACTG\t*";
        Assert.Throws<SamFileExpectedIntegerException>(() =>
        {
            var seq1 = RawSequenceAlignment.Parse(1, test1);
            Assert.Equal(7, seq1.Position);
        });
    }

    [Fact]
    public void Mapping_quality_is_read_correctly()
    {
        var test1 = "r001\t1\tref\t7\t30\t8M2I4M1D3M\t=\t37\t39\tTTAGATAAAGGATACTG\t*";
        var seq1 = RawSequenceAlignment.Parse(1, test1);
        Assert.Equal(30, seq1.MappingQuality);
    }

    [Fact]
    public void Cigar_is_read_correctly()
    {
        var test1 = "r001\t1\tref\t7\t30\t8M\t=\t37\t39\tTTAGATAAAGGATACTG\t*";
        var seq1 = RawSequenceAlignment.Parse(1, test1);
        Assert.Single(seq1.CIGAR.Parts);
        Assert.Equal(CigarOperator.Match, seq1.CIGAR.Parts[0].Operator);
        Assert.Equal(8, seq1.CIGAR.Parts[0].NumberOfAlignedNucelotides);
    }

    [Fact]
    public void Rnext_and_pnext_and_tlen_is_read_correctly()
    {
        var test1 = "r001\t1\tref\t7\t30\t8M\t=\t37\t39\tTTAGATAAAGGATACTG\t*";
        var seq1 = RawSequenceAlignment.Parse(1, test1);
        Assert.Equal("=", seq1.RNext);
        Assert.Equal(37, seq1.PNext);
        Assert.Equal(39, seq1.TLen);
    }

    [Fact]
    public void Sequence_is_read_correctly()
    {
        var test1 = "r001\t1\tref\t7\t30\t8M\t=\t37\t39\tTTAGATAAAGGATACTG\t*";
        var seq1 = RawSequenceAlignment.Parse(1, test1);
        Assert.Equal("TTAGATAAAGGATACTG", seq1.ReadSequence);
    }

    [Fact]
    public void Qual_is_read_correctly()
    {
        var test1 = "r001\t1\tref\t7\t30\t8M\t=\t37\t39\tTTAGATAAAGGATACTG\t*";
        var seq1 = RawSequenceAlignment.Parse(1, test1);
        Assert.Equal("*", seq1.Quality);
    }

    [Fact]
    public void Optional_values_is_read_correctly()
    {
        var test1 =
            "r002\t0\tref\t9\t30\t3S6M1D5M\t*\t0\t0\tAAAAGATAAGGATA\t*\tXT:A:R\tNM:i:2\tSM:i:0\tAM:i:0\tX0:i:4\tX1:i:0\tXM:i:0\tXO:i:1\tXG:i:2\tMD:Z:18^CA19";
        var seq1 = RawSequenceAlignment.Parse(1, test1);
        Assert.Equal(10, seq1.OptionalValueCollection.Count);
        Assert.Equal("XT", seq1.OptionalValueCollection[0].Tag);
        Assert.Equal("A", seq1.OptionalValueCollection[0].Type);
        Assert.Equal("R", seq1.OptionalValueCollection[0].Value);
    }

    [Fact]
    public void Optional_values_throws_exception_when_incorrect_format()
    {
        var test1 =
            "r002\t0\tref\t9\t30\t3S6M1D5M\t*\t0\t0\tAAAAGATAAGGATA\t*\tXT-A:R";
        Assert.Throws<SamFileOptionalValueException>(() =>
        {
            var seq1 = RawSequenceAlignment.Parse(1, test1);
        });
    }
}