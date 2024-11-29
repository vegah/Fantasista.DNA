using Fantasista.DNA.SAMFile;
using Fantasista.DNA.SAMFile.Exceptions;

namespace Fantasista.DNA.Tests.SamFileTests;

public class SamFileCigarTests
{
    [Fact]
    public void Match_1_is_correctly_parsed()
    {
        var input = "1M";
        var cigar = SamFileCigar.GetCIGAR(input);
        Assert.Single(cigar.Parts);
        Assert.Equal(CigarOperator.Match, cigar.Parts[0].Operator);
        Assert.Equal(1, cigar.Parts[0].NumberOfAlignedNucelotides);
    }

    [Fact]
    public void Complex_cigar_is_correctly_parsed()
    {
        var input = "3M1I3M1D5M";
        var cigar = SamFileCigar.GetCIGAR(input);
        Assert.Equal(5, cigar.Parts.Length);
        Assert.Equal(CigarOperator.Match, cigar.Parts[0].Operator);
        Assert.Equal(3, cigar.Parts[0].NumberOfAlignedNucelotides);
        Assert.Equal(CigarOperator.Insertion, cigar.Parts[1].Operator);
        Assert.Equal(1, cigar.Parts[1].NumberOfAlignedNucelotides);
        Assert.Equal(CigarOperator.Match, cigar.Parts[2].Operator);
        Assert.Equal(3, cigar.Parts[2].NumberOfAlignedNucelotides);
        Assert.Equal(CigarOperator.Deletion, cigar.Parts[3].Operator);
        Assert.Equal(1, cigar.Parts[3].NumberOfAlignedNucelotides);
        Assert.Equal(CigarOperator.Match, cigar.Parts[4].Operator);
        Assert.Equal(5, cigar.Parts[4].NumberOfAlignedNucelotides);
    }

    [Fact]
    public void Large_numbers_is_correctly_parsed()
    {
        var input = "18M2D19M";
        var cigar = SamFileCigar.GetCIGAR(input);
        Assert.Equal(3, cigar.Parts.Length);
        Assert.Equal(CigarOperator.Match, cigar.Parts[0].Operator);
        Assert.Equal(18, cigar.Parts[0].NumberOfAlignedNucelotides);
        Assert.Equal(CigarOperator.Deletion, cigar.Parts[1].Operator);
        Assert.Equal(2, cigar.Parts[1].NumberOfAlignedNucelotides);
        Assert.Equal(CigarOperator.Match, cigar.Parts[2].Operator);
        Assert.Equal(19, cigar.Parts[2].NumberOfAlignedNucelotides);
    }

    [Fact]
    public void Mismatch_and_gap_is_correctly_parsed()
    {
        var input = "18N99X";
        var cigar = SamFileCigar.GetCIGAR(input);
        Assert.Equal(2, cigar.Parts.Length);
        Assert.Equal(CigarOperator.Gap, cigar.Parts[0].Operator);
        Assert.Equal(18, cigar.Parts[0].NumberOfAlignedNucelotides);
        Assert.Equal(CigarOperator.Mismatch, cigar.Parts[1].Operator);
        Assert.Equal(99, cigar.Parts[1].NumberOfAlignedNucelotides);
    }

    [Fact]
    public void Cigar_throws_exception_when_incorrect_input()
    {
        var input = "18NN99X";
        Assert.Throws<SamFileCigarException>(() =>
        {
            var cigar = SamFileCigar.GetCIGAR(input);
        });
    }
}