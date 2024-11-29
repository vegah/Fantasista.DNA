using System.Text;
using Fantasista.DNA.SAMFile.Exceptions;

namespace Fantasista.DNA.SAMFile;

public class SamFileCigar
{
    public SamFileCigar(SamFileCigarPart[] parts)
    {
        Parts = parts;
    }

    public SamFileCigarPart[] Parts { get; set; }

    public static SamFileCigar GetCIGAR(string s)
    {
        var array = GetCigarParts(s).ToArray();
        return new SamFileCigar(array);
    }

    private static IEnumerable<SamFileCigarPart> GetCigarParts(string s)
    {
        var currentValue = new StringBuilder();
        var numberIsExpected = true;
        for (var i = 0; i < s.Length; i++)
        {
            var ch = s[i];
            if (char.IsLetter(ch) && (i == 0 || char.IsLetter(s[i - 1])))
                throw new SamFileCigarException($"Expected number at this place in CIGAR parts - got {ch}");
            if (char.IsDigit(ch))
            {
                currentValue.Append(ch);
            }
            else if (char.IsLetter(ch))
            {
                yield return CreateCigarPart(currentValue.ToString(), ch);
                currentValue.Clear();
            }

            else
            {
                throw new SamFileCigarException($"Only digits and characters are valid in CIGAR parts - got {ch}");
            }
        }
    }

    private static SamFileCigarPart CreateCigarPart(string p, char ch)
    {
        if (!int.TryParse(p, out var number)) throw new SamFileCigarException($"Number part is not a number : {p}");
        switch (ch)
        {
            case 'M': return new SamFileCigarPart(CigarOperator.Match, number);
            case 'X': return new SamFileCigarPart(CigarOperator.Mismatch, number);
            case 'D': return new SamFileCigarPart(CigarOperator.Deletion, number);
            case 'I': return new SamFileCigarPart(CigarOperator.Insertion, number);
            case 'N': return new SamFileCigarPart(CigarOperator.Gap, number);
            case 'S': return new SamFileCigarPart(CigarOperator.SoftClipping, number);
            case 'H': return new SamFileCigarPart(CigarOperator.HardClipping, number);
            case 'P': return new SamFileCigarPart(CigarOperator.Padding, number);
            case '=': return new SamFileCigarPart(CigarOperator.SequenceMatch, number);
            default: throw new SamFileCigarException($"Unexpected operator : got {ch}");
        }
    }
}