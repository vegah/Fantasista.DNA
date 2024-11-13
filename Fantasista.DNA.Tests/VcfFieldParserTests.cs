using Fantasista.DNA.VcfFile;
using Fantasista.DNA.VcfFile.Exceptions;

namespace Fantasista.DNA.Tests;

public class VcfFieldParserTests
{
    [Fact]
    public void Can_parse_a_field()
    {
        var str = "<ID=NS,Number=1,Type=Integer,Description=\"Number of Samples With Data\">";
        var dictionary = VcfFieldParser.Parse(str);
        Assert.NotNull(dictionary);
        Assert.Equal("NS",dictionary["ID"]);
        Assert.Equal("1",dictionary["Number"]);
        Assert.Equal("Number of Samples With Data",dictionary["Description"]);
    }
    
    [Fact]
    public void Can_parse_a_field2()
    {
        var str = "<ID=GT,Number=1,Type=String,Description=\"Genotype\">";
        var dictionary = VcfFieldParser.Parse(str);
        Assert.NotNull(dictionary);
        Assert.Equal("GT",dictionary["ID"]);
        Assert.Equal("1",dictionary["Number"]);
        Assert.Equal("Genotype",dictionary["Description"]);
    }

    [Fact]
    public void Can_parse_a_field3()
    {
        var str = "<ID=20,length=62435964,assembly=B36,md5=f126cdf8a6e0c7f379d618ff66beb2da,species=\"Homo sapiens\",taxonomy=x>";
        var dictionary = VcfFieldParser.Parse(str);
        Assert.NotNull(dictionary);
        Assert.Equal("Homo sapiens",dictionary["species"]);
        Assert.Equal("x",dictionary["taxonomy"]);
        Assert.Equal("62435964",dictionary["length"]);
    }

    [Fact]
    public void Throws_VcfFieldParserException_if_field_description_is_incorrect()
    {
        var str = "<ID=20 length=62435964,assembly=B36,md5=f126cdf8a6e0c7f379d618ff66beb2da,species=\"Homo sapiens\",taxonomy=x>";
        var exception = Assert.Throws<VcfFieldParserException>(() =>
        {
            var dictionary = VcfFieldParser.Parse(str);
        });
        Assert.IsType<VcfFieldParserException>(exception);
    }
    
    [Fact]
    public void Throws_VcfFieldParserException_if_field_description_is_incorrect2()
    {
        var str = "<ID=20,length=62435964=,assembly=B36,md5=f126cdf8a6e0c7f379d618ff66beb2da,species=\"Homo sapiens\",taxonomy=x>";
        var exception = Assert.Throws<VcfFieldParserException>(() =>
        {
            var dictionary = VcfFieldParser.Parse(str);
        });
        Assert.IsType<VcfFieldParserException>(exception);
        
    }
    
}