using System.Text;

namespace Fantasista.DNA.Tests;

public class VcfFileReaderTests
{
    private Stream CreateStreamFromString(string s)
    {
        return new MemoryStream(Encoding.UTF8.GetBytes(s));
    }
    
    [Fact]
    public void Fileformat_is_set_correctly()
    {
        using var stream = CreateStreamFromString("##fileformat=VCFv4.3");
        using var reader = new VcfFileReader(stream);
        reader.Read();
        Assert.Equal("VCFv4.3",reader.MetaData.FileFormat);
    }

    [Fact]
    public void Filedate_is_set_correctly()
    {
        using var stream = CreateStreamFromString("##fileDate=20090805");
        using var reader = new VcfFileReader(stream);
        reader.Read();
        Assert.Equal(2009,reader.MetaData.FileDate!.Value.Year);
        Assert.Equal(8,reader.MetaData.FileDate!.Value.Month);
        Assert.Equal(5,reader.MetaData.FileDate!.Value.Day);
    }

    [Fact]
    public void Source_is_set_correctly()
    {
        using var stream = CreateStreamFromString("##source=myImputationProgramV3.1");
        using var reader = new VcfFileReader(stream);
        reader.Read();
        Assert.Equal("myImputationProgramV3.1",reader.MetaData.Source);
    }

    [Fact]
    public void Reference_is_set_correctly()
    {
        using var stream = CreateStreamFromString("##reference=file:///seq/references/1000GenomesPilot-NCBI36.fasta");
        using var reader = new VcfFileReader(stream);
        reader.Read();
        Assert.Equal("file:///seq/references/1000GenomesPilot-NCBI36.fasta",reader.MetaData.Reference);
    }
    
    
    [Fact]
    public void File_id_and_description_is_set_correctly()
    {
        using var stream = CreateStreamFromString("##ID=<Description=\"ClinVar Variation ID\">");
        using var reader = new VcfFileReader(stream);
        reader.Read();
        Assert.Equal("ClinVar Variation ID",reader.MetaData.Id!.Description);
    }

    [Fact]
    public void Info_field_is_set_correctly()
    {
        using var stream = CreateStreamFromString("##INFO=<ID=AA,Number=1,Type=String,Description=\"Ancestral Allele\">");
        using var reader = new VcfFileReader(stream);
        reader.Read();
        Assert.Single(reader.MetaData.Info);
        Assert.Equal("Ancestral Allele",reader.MetaData.Info[0].Description);
        Assert.Equal("1",reader.MetaData.Info[0].Number);
        Assert.Equal("String",reader.MetaData.Info[0].Type);
        Assert.Equal("AA",reader.MetaData.Info[0].Id);
    }

    [Fact]
    public void Multiple_info_fields_is_set_correctly()
    {
        using var stream = CreateStreamFromString("##INFO=<ID=AA,Number=1,Type=String,Description=\"Ancestral Allele\">\n##INFO=<ID=DB,Number=0,Type=Flag,Description=\"dbSNP membership, build 129\">\n");
        using var reader = new VcfFileReader(stream);
        reader.Read();
        Assert.Equal(2,reader.MetaData.Info.Count);
        Assert.Equal("Ancestral Allele",reader.MetaData.Info[0].Description);
        Assert.Equal("1",reader.MetaData.Info[0].Number);
        Assert.Equal("String",reader.MetaData.Info[0].Type);
        Assert.Equal("AA",reader.MetaData.Info[0].Id);
        Assert.Equal("dbSNP membership, build 129",reader.MetaData.Info[1].Description);
        Assert.Equal("0",reader.MetaData.Info[1].Number);
        Assert.Equal("Flag",reader.MetaData.Info[1].Type);
        Assert.Equal("DB",reader.MetaData.Info[1].Id);
        
    }
    
    [Fact]
    public void Columns_are_set_correctly()
    {
        using var stream = CreateStreamFromString("#CHROM POS      ID         REF   ALT    QUAL  FILTER   INFO                             FORMAT       NA00001         NA00002          NA00003");
        using var reader = new VcfFileReader(stream);
        reader.Read();
        Assert.Equal(12,reader.Columns.Count);
        Assert.Equal("CHROM",reader.Columns[0].ColumnName);
        Assert.Equal(0,reader.Columns[0].Index);
        Assert.Equal("REF",reader.Columns[3].ColumnName);
        Assert.Equal(3,reader.Columns[3].Index);
        Assert.Equal("NA00003",reader.Columns[11].ColumnName);
        Assert.Equal(11,reader.Columns[11].Index);
    }
    
    
}