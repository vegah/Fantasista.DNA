using Fantasista.DNA.SAMFile.SamFileAlignmentExceptions;

namespace Fantasista.DNA.SAMFile;

public class RawSequenceAlignment(int lineNo)
{
    public SamFileAlignmentInformationFlag AlignmentInformationFlag { get; set; }

    public int MappingQuality { get; set; }

    public int Position { get; set; }

    public string ReferenceSequence { get; set; }

    public string QueryTemplateName { get; set; }

    public SamFileCigar CIGAR { get; set; }

    public SamFileOptionalValueCollection OptionalValueCollection { get; set; }

    public string ReadSequence { get; set; }

    public string TLen { get; set; }

    public string PNext { get; set; }

    public string RNext { get; set; }


    public static RawSequenceAlignment Parse(int lineNo, string line)
    {
        var splitLine = line.Split('\t');
        return new RawSequenceAlignment(lineNo)
        {
            QueryTemplateName = splitLine[0],
            AlignmentInformationFlag = GetFlag(lineNo, splitLine[1])
            /*ReferenceSequence = splitLine[2];
            Position = GetPos(splitLine[3]);
            MappingQuality = GetMapQ(splitLine[4]);
            CIGAR = SamFileCigar.GetCIGAR(splitLine[5]);
            RNext = splitLine[6];
            PNext = splitLine[7];
            TLen = splitLine[8];
            ReadSequence = splitLine[9];
            OptionalValueCollection = SamFileOptionalValueCollection.GetOptionalValues(splitLine[10]);
            */
        };
    }

    private int GetMapQ(string s)
    {
        throw new NotImplementedException();
    }

    private int GetPos(object o)
    {
        throw new NotImplementedException();
    }

    private static SamFileAlignmentInformationFlag GetFlag(int lineNo, string s)
    {
        if (!int.TryParse(s, out var result)) throw new SamFileFlagNotIntegerException(lineNo, s);
        return (SamFileAlignmentInformationFlag)result;
    }
}