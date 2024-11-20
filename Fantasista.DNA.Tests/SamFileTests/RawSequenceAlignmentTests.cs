using Fantasista.DNA.SAMFile;

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
}