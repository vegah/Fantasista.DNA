using Fantasista.DNA.GtfFile;
using Fantasista.DNA.GtfFile.Exceptions;

namespace Fantasista.DNA.Tests.GffFileTests;

public class Gff3StreamReaderTests
{
    [Fact]
    public void Gff_header_are_read_correctly()
    {
        using var reader = new Gff3StreamReader("##gff-version 3");
        var result = reader.Read().ToArray();
    }

    [Fact]
    public void Throws_exception_if_header_is_missing()
    {
        using var reader = new Gff3StreamReader("##gff-version 2");
        Assert.Throws<Gff3FormatException>(() =>
        {
            var result = reader.Read().ToArray();
        });
    }

    [Fact]
    public void Parses_one_line_correctly()
    {
        using var reader =
            new Gff3StreamReader("##gff-version 3\nctg123\t.\texon\t1300\t1500\t.\t+\t.\tID=exon00001");
        var result = reader.Read().ToArray();
        Assert.Equal("ctg123", result[0].SequenceId);
        Assert.Equal(".", result[0].Source);
        Assert.Equal("exon", result[0].FeatureType);
        Assert.Equal(1300, result[0].Start);
        Assert.Equal(1500, result[0].End);
        Assert.Null(result[0].Score);
        Assert.Equal('+', result[0].Strand);
        Assert.Null(result[0].Phase);
        Assert.Equal("exon00001", result[0].Attributes["ID"]);
        Assert.Equal("exon00001", result[0].Tags.Id);
    }

    [Fact]
    public void Parses_tags_correctly()
    {
        using var reader =
            new Gff3StreamReader(
                "##gff-version 3\nctg123\t.\texon\t1300\t1500\t.\t+\t.\tID=exon00001;Name=name;Alias=alias;Parent=parent;Target=target;Gap=gap;Derives_from=derives_from;Note=note;Dbxref=dbxref;Ontology_term=ontology_term");
        var result = reader.Read().ToArray();
        Assert.Equal("exon00001", result[0].Tags.Id);
        Assert.Equal("parent", result[0].Tags.Parent);
        Assert.Equal("alias", result[0].Tags.Alias);
        Assert.Equal("name", result[0].Tags.Name);
        Assert.Equal("dbxref", result[0].Tags.Dbxref);
        Assert.Equal("gap", result[0].Tags.Gap);
        Assert.Equal("note", result[0].Tags.Note);
        Assert.Equal("target", result[0].Tags.Target);
        Assert.Equal("derives_from", result[0].Tags.DerivesFrom);
        Assert.Equal("ontology_term", result[0].Tags.OntologyTerm);
    }

    [Fact]
    public void Parses_strand_correctly()
    {
        using var reader =
            new Gff3StreamReader(
                "##gff-version 3\nctg123\t.\texon\t1300\t1500\t.\t-\t.\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t.\t.\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t?\t.\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t+\t.\tID=exon00001");
        var result = reader.Read().ToArray();
        Assert.Equal(4, result.Length);
        Assert.Equal('-', result[0].Strand);
        Assert.Equal('.', result[1].Strand);
        Assert.Equal('?', result[2].Strand);
        Assert.Equal('+', result[3].Strand);
    }

    [Fact]
    public void Throws_exception_when_strand_is_invalid_char()
    {
        using var reader =
            new Gff3StreamReader(
                "##gff-version 3\nctg123\t.\texon\t1300\t1500\t.\tx\t.\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t.\t.\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t?\t.\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t+\t.\tID=exon00001");
        Assert.Throws<Gff3FormatException>(() =>
        {
            var result = reader.Read().ToArray();
        });
    }

    [Fact]
    public void Throws_exception_when_strand_is_more_than_a_char()
    {
        using var reader =
            new Gff3StreamReader(
                "##gff-version 3\nctg123\t.\texon\t1300\t1500\t.\t--\t.\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t.\t.\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t?\t.\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t+\t.\tID=exon00001");
        Assert.Throws<Gff3FormatException>(() =>
        {
            var result = reader.Read().ToArray();
        });
    }

    [Fact]
    public void Parses_phase_correctly()
    {
        using var reader =
            new Gff3StreamReader(
                "##gff-version 3\nctg123\t.\texon\t1300\t1500\t.\t+\t0\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t+\t1\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t+\t2\tID=exon00001");
        var result = reader.Read().ToArray();
        Assert.Equal(0, result[0].Phase);
        Assert.Equal(1, result[1].Phase);
        Assert.Equal(2, result[2].Phase);
    }

    [Fact]
    public void Throws_exception_if_phase_is_outside_bounds()
    {
        using var reader =
            new Gff3StreamReader(
                "##gff-version 3\nctg123\t.\texon\t1300\t1500\t.\t+\t4\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t+\t1\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t+\t2\tID=exon00001");
        Assert.Throws<Gff3FormatException>(() =>
        {
            var result = reader.Read().ToArray();
        });

        using var reader2 =
            new Gff3StreamReader(
                "##gff-version 3\nctg123\t.\texon\t1300\t1500\t.\t+\t-1\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t+\t1\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t+\t2\tID=exon00001");
        Assert.Throws<Gff3FormatException>(() =>
        {
            var result = reader2.Read().ToArray();
        });
    }

    [Fact]
    public void Throws_exception_if_phase_is_not_a_number()
    {
        using var reader =
            new Gff3StreamReader(
                "##gff-version 3\nctg123\t.\texon\t1300\t1500\t.\t+\tX\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t+\t1\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t+\t2\tID=exon00001");
        Assert.Throws<Gff3FormatException>(() =>
        {
            var result = reader.Read().ToArray();
        });
    }

    [Fact]
    public void Throws_exception_if_attributes_is_not_split_correctly()
    {
        using var reader =
            new Gff3StreamReader(
                "##gff-version 3\nctg123\t.\texon\t1300\t1500\t.\t+\t0\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t+\t1\tID=exon00001\nctg123\t.\texon\t1300\t1500\t.\t+\t2\tID|exon00001");
        var exception = Assert.Throws<Gff3FormatException>(() =>
        {
            var result = reader.Read().ToArray();
        });

        Assert.StartsWith("Expected attribute to be in the form 'key=value", exception.Message);
    }

    [Fact]
    public void Throws_exception_if_start_or_end_is_not_a_number()
    {
        using var reader =
            new Gff3StreamReader(
                "##gff-version 3\nctg123\t.\texon\ttest\t1500\t.\t+\t0\tID=exon00001\n");
        var exception = Assert.Throws<Gff3FormatException>(() =>
        {
            var result = reader.Read().ToArray();
        });

        Assert.Equal("Expected start to be a number - got test", exception.Message);

        using var reader2 =
            new Gff3StreamReader(
                "##gff-version 3\nctg123\t.\texon\t1\ttest\t.\t+\t0\tID=exon00001\n");
        var exception2 = Assert.Throws<Gff3FormatException>(() =>
        {
            var result = reader2.Read().ToArray();
        });

        Assert.Equal("Expected end to be a number - got test", exception2.Message);
    }

    [Fact]
    public void Sets_score_as_long_as_it_is_a_number()
    {
        using var reader =
            new Gff3StreamReader(
                "##gff-version 3\nctg123\t.\texon\t1000\t1500\t50.5\t+\t0\tID=exon00001\n");
        var result = reader.Read().ToArray();
        Assert.Equal(50.5M, result[0].Score);
    }
}