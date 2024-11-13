using System.Text;
using Fantasista.DNA.VcfFile;
using Fantasista.DNA.VcfFile.Exceptions;

namespace Fantasista.DNA.Tests;

public class VcfStreamReaderTests
{
    private Stream CreateStreamFromString(string s)
    {
        return new MemoryStream(Encoding.UTF8.GetBytes(s));
    }
    
    [Fact]
    public void Fileformat_is_set_correctly()
    {
        using var stream = CreateStreamFromString("##fileformat=VCFv4.3");
        using var reader = new VcfStreamReader(stream);
        var arr = reader.Read().ToArray();
        Assert.Equal("VCFv4.3",reader.MetaData.FileFormat);
    }

    [Fact]
    public void Filedate_is_set_correctly()
    {
        using var stream = CreateStreamFromString("##fileDate=20090805");
        using var reader = new VcfStreamReader(stream);
        var arr = reader.Read().ToArray();
        Assert.Equal(2009,reader.MetaData.FileDate!.Value.Year);
        Assert.Equal(8,reader.MetaData.FileDate!.Value.Month);
        Assert.Equal(5,reader.MetaData.FileDate!.Value.Day);
    }

    [Fact]
    public void Source_is_set_correctly()
    {
        using var stream = CreateStreamFromString("##source=myImputationProgramV3.1");
        using var reader = new VcfStreamReader(stream);
        var arr = reader.Read().ToArray();
        Assert.Equal("myImputationProgramV3.1",reader.MetaData.Source);
    }

    [Fact]
    public void Reference_is_set_correctly()
    {
        using var stream = CreateStreamFromString("##reference=file:///seq/references/1000GenomesPilot-NCBI36.fasta");
        using var reader = new VcfStreamReader(stream);
        var arr = reader.Read().ToArray();
        Assert.Equal("file:///seq/references/1000GenomesPilot-NCBI36.fasta",reader.MetaData.Reference);
    }
    
    
    [Fact]
    public void File_id_and_description_is_set_correctly()
    {
        using var stream = CreateStreamFromString("##ID=<Description=\"ClinVar Variation ID\">");
        using var reader = new VcfStreamReader(stream);
        var arr = reader.Read().ToArray();
        Assert.Equal("ClinVar Variation ID",reader.MetaData.Id!.Description);
    }

    [Fact]
    public void Info_field_is_set_correctly()
    {
        using var stream = CreateStreamFromString("##INFO=<ID=AA,Number=1,Type=String,Description=\"Ancestral Allele\">");
        using var reader = new VcfStreamReader(stream);
        var arr = reader.Read().ToArray();
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
        using var reader = new VcfStreamReader(stream);
        var arr = reader.Read().ToArray();
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
        using var reader = new VcfStreamReader(stream);
        var arr = reader.Read().ToArray();
        Assert.Equal(12,reader.Columns.Count);
        Assert.Equal("CHROM",reader.Columns[0].ColumnName);
        Assert.Equal(0,reader.Columns[0].Index);
        Assert.Equal("REF",reader.Columns[3].ColumnName);
        Assert.Equal(3,reader.Columns[3].Index);
        Assert.Equal("NA00003",reader.Columns[11].ColumnName);
        Assert.Equal(11,reader.Columns[11].Index);
    }
    
    [Fact]
    public void One_row_is_read_correctly()
    {
        using var stream = CreateStreamFromString("##fileformat=VCFv4.3\n##fileDate=20090805\n##source=myImputationProgramV3.1\n##reference=file:///seq/references/1000GenomesPilot-NCBI36.fasta\n##contig=<ID=20,length=62435964,assembly=B36,md5=f126cdf8a6e0c7f379d618ff66beb2da,species=\"Homo sapiens\",taxonomy=x>\n##phasing=partial\n##INFO=<ID=NS,Number=1,Type=Integer,Description=\"Number of Samples With Data\">\n##INFO=<ID=DP,Number=1,Type=Integer,Description=\"Total Depth\">\n##INFO=<ID=AF,Number=A,Type=Float,Description=\"Allele Frequency\">\n##INFO=<ID=AA,Number=1,Type=String,Description=\"Ancestral Allele\">\n##INFO=<ID=DB,Number=0,Type=Flag,Description=\"dbSNP membership, build 129\">\n##INFO=<ID=H2,Number=0,Type=Flag,Description=\"HapMap2 membership\">\n##FILTER=<ID=q10,Description=\"Quality below 10\">\n##FILTER=<ID=s50,Description=\"Less than 50% of samples have data\">\n##FORMAT=<ID=GT,Number=1,Type=String,Description=\"Genotype\">\n##FORMAT=<ID=GQ,Number=1,Type=Integer,Description=\"Genotype Quality\">\n##FORMAT=<ID=DP,Number=1,Type=Integer,Description=\"Read Depth\">\n##FORMAT=<ID=HQ,Number=2,Type=Integer,Description=\"Haplotype Quality\">\n#CHROM POS      ID         REF   ALT    QUAL  FILTER   INFO                             FORMAT       NA00001         NA00002          NA00003\n20     14370    rs6054257  G     A      29    PASS    NS=3;DP=14;AF=0.5;DB;H2           GT:GQ:DP:HQ  0|0:48:1:51,51  1|0:48:8:51,51   1/1:43:5");
        using var reader = new VcfStreamReader(stream);
        var arr = reader.Read().ToArray();
        Assert.Equal(12,reader.Columns.Count);
        Assert.Equal("CHROM",reader.Columns[0].ColumnName);
        Assert.Equal(0,reader.Columns[0].Index);
        Assert.Equal("REF",reader.Columns[3].ColumnName);
        Assert.Equal(3,reader.Columns[3].Index);
        Assert.Equal("NA00003",reader.Columns[11].ColumnName);
        Assert.Equal(11,reader.Columns[11].Index);
        Assert.Equal("20",arr[0].Chrom.Value);
        Assert.Equal(14370,arr[0].Pos.Value);
        Assert.Equal("rs6054257",arr[0].Id.Value[0]);
        Assert.Equal("G",arr[0].Ref.Value);
        Assert.Equal("A",arr[0].Alt.Value[0]);
        Assert.Equal("29",arr[0].Qual.Value);
        Assert.Equal("PASS",arr[0].Filter.Value);
        Assert.Equal(3,arr[0].Info.Value["NS"].GetValue<int>());
        Assert.Equal(14,arr[0].Info.Value["DP"].GetValue<int>());
        Assert.Equal(0.5M,arr[0].Info.Value["AF"].GetValue<decimal[]>()[0]);
        Assert.True(arr[0].Info.Value["DB"].GetValue<bool>());
        Assert.True(arr[0].Info.Value["H2"].GetValue<bool>());
    }

    [Fact]
    public void One_throws_exception_when_columns_mismatch()
    {
        using var stream = CreateStreamFromString("##fileformat=VCFv4.3\n##fileDate=20090805\n##source=myImputationProgramV3.1\n##reference=file:///seq/references/1000GenomesPilot-NCBI36.fasta\n##contig=<ID=20,length=62435964,assembly=B36,md5=f126cdf8a6e0c7f379d618ff66beb2da,species=\"Homo sapiens\",taxonomy=x>\n##phasing=partial\n##INFO=<ID=NS,Number=1,Type=Integer,Description=\"Number of Samples With Data\">\n##INFO=<ID=DP,Number=1,Type=Integer,Description=\"Total Depth\">\n##INFO=<ID=AF,Number=A,Type=Float,Description=\"Allele Frequency\">\n##INFO=<ID=AA,Number=1,Type=String,Description=\"Ancestral Allele\">\n##INFO=<ID=DB,Number=0,Type=Flag,Description=\"dbSNP membership, build 129\">\n##INFO=<ID=H2,Number=0,Type=Flag,Description=\"HapMap2 membership\">\n##FILTER=<ID=q10,Description=\"Quality below 10\">\n##FILTER=<ID=s50,Description=\"Less than 50% of samples have data\">\n##FORMAT=<ID=GT,Number=1,Type=String,Description=\"Genotype\">\n##FORMAT=<ID=GQ,Number=1,Type=Integer,Description=\"Genotype Quality\">\n##FORMAT=<ID=DP,Number=1,Type=Integer,Description=\"Read Depth\">\n##FORMAT=<ID=HQ,Number=2,Type=Integer,Description=\"Haplotype Quality\">\n#CHROM POS      ID         REF   ALT    QUAL  FILTER   INFO                             FORMAT       NA00001         NA00002          NA00003\n20     14370    rs6054257  G     A      29    PASS    NS=3;DP=14;AF=0.5;DB;H2           GT:GQ:DP:HQ  0|0:48:1:51,51  1|0:48:8:51,51");
        using var reader = new VcfStreamReader(stream);
        Assert.Throws<ColumnMismatchException>(() =>
        {
            var arr = reader.Read().ToArray();
        });
    }

    [Fact]
    public void One_throws_exception_when_infofield_not_keyvalue_and_not_flag()
    {
        using var stream = CreateStreamFromString("##fileformat=VCFv4.3\n##fileDate=20090805\n##source=myImputationProgramV3.1\n##reference=file:///seq/references/1000GenomesPilot-NCBI36.fasta\n##contig=<ID=20,length=62435964,assembly=B36,md5=f126cdf8a6e0c7f379d618ff66beb2da,species=\"Homo sapiens\",taxonomy=x>\n##phasing=partial\n##INFO=<ID=NS,Number=1,Type=Integer,Description=\"Number of Samples With Data\">\n##INFO=<ID=DP,Number=1,Type=Integer,Description=\"Total Depth\">\n##INFO=<ID=AF,Number=A,Type=Float,Description=\"Allele Frequency\">\n##INFO=<ID=AA,Number=1,Type=String,Description=\"Ancestral Allele\">\n##INFO=<ID=DB,Number=0,Type=String,Description=\"dbSNP membership, build 129\">\n##INFO=<ID=H2,Number=0,Type=Flag,Description=\"HapMap2 membership\">\n##FILTER=<ID=q10,Description=\"Quality below 10\">\n##FILTER=<ID=s50,Description=\"Less than 50% of samples have data\">\n##FORMAT=<ID=GT,Number=1,Type=String,Description=\"Genotype\">\n##FORMAT=<ID=GQ,Number=1,Type=Integer,Description=\"Genotype Quality\">\n##FORMAT=<ID=DP,Number=1,Type=Integer,Description=\"Read Depth\">\n##FORMAT=<ID=HQ,Number=2,Type=Integer,Description=\"Haplotype Quality\">\n#CHROM POS      ID         REF   ALT    QUAL  FILTER   INFO                             FORMAT       NA00001         NA00002          NA00003\n20     14370    rs6054257  G     A      29    PASS    NS=3;DP=14;AF=0.5;DB;H2           GT:GQ:DP:HQ  0|0:48:1:51,51  1|0:48:8:51,51 asd");
        using var reader = new VcfStreamReader(stream);
        Assert.Throws<InfoVcfColumnValueException>(() =>
        {
            var arr = reader.Read().ToArray();
        });
    }

    [Fact]
    public void One_throws_exception_when_trying_to_access_wrong_type()
    {
        using var stream = CreateStreamFromString("##fileformat=VCFv4.3\n##fileDate=20090805\n##source=myImputationProgramV3.1\n##reference=file:///seq/references/1000GenomesPilot-NCBI36.fasta\n##contig=<ID=20,length=62435964,assembly=B36,md5=f126cdf8a6e0c7f379d618ff66beb2da,species=\"Homo sapiens\",taxonomy=x>\n##phasing=partial\n##INFO=<ID=NS,Number=1,Type=Integer,Description=\"Number of Samples With Data\">\n##INFO=<ID=DP,Number=1,Type=Integer,Description=\"Total Depth\">\n##INFO=<ID=AF,Number=A,Type=Float,Description=\"Allele Frequency\">\n##INFO=<ID=AA,Number=1,Type=String,Description=\"Ancestral Allele\">\n##INFO=<ID=DB,Number=0,Type=Flag,Description=\"dbSNP membership, build 129\">\n##INFO=<ID=H2,Number=0,Type=Flag,Description=\"HapMap2 membership\">\n##FILTER=<ID=q10,Description=\"Quality below 10\">\n##FILTER=<ID=s50,Description=\"Less than 50% of samples have data\">\n##FORMAT=<ID=GT,Number=1,Type=String,Description=\"Genotype\">\n##FORMAT=<ID=GQ,Number=1,Type=Integer,Description=\"Genotype Quality\">\n##FORMAT=<ID=DP,Number=1,Type=Integer,Description=\"Read Depth\">\n##FORMAT=<ID=HQ,Number=2,Type=Integer,Description=\"Haplotype Quality\">\n#CHROM POS      ID         REF   ALT    QUAL  FILTER   INFO                             FORMAT       NA00001         NA00002          NA00003\n20     14370    rs6054257  G     A      29    PASS    NS=3;DP=14;AF=0.5;DB;H2           GT:GQ:DP:HQ  0|0:48:1:51,51  1|0:48:8:51,51   1/1:43:5");
        using var reader = new VcfStreamReader(stream);
        var arr = reader.Read().ToArray();
        Assert.Throws<VcfColumnValueTypeException>(() =>
        {
            arr[0].Info.Value["DP"].GetValue<string>();
        });

    }
    
    [Fact]
    public void Works_with_unknown_info_field()
    {
        using var stream = CreateStreamFromString("##fileformat=VCFv4.3\n##fileDate=20090805\n##source=myImputationProgramV3.1\n##reference=file:///seq/references/1000GenomesPilot-NCBI36.fasta\n##contig=<ID=20,length=62435964,assembly=B36,md5=f126cdf8a6e0c7f379d618ff66beb2da,species=\"Homo sapiens\",taxonomy=x>\n##phasing=partial\n##INFO=<ID=NS,Number=1,Type=Integer,Description=\"Number of Samples With Data\">\n##INFO=<ID=DP,Number=1,Type=Integer,Description=\"Total Depth\">\n##INFO=<ID=AF,Number=A,Type=Float,Description=\"Allele Frequency\">\n##INFO=<ID=AA,Number=1,Type=String,Description=\"Ancestral Allele\">\n##INFO=<ID=DB,Number=0,Type=Flag,Description=\"dbSNP membership, build 129\">\n##INFO=<ID=H2,Number=0,Type=Flag,Description=\"HapMap2 membership\">\n##FILTER=<ID=q10,Description=\"Quality below 10\">\n##FILTER=<ID=s50,Description=\"Less than 50% of samples have data\">\n##FORMAT=<ID=GT,Number=1,Type=String,Description=\"Genotype\">\n##FORMAT=<ID=GQ,Number=1,Type=Integer,Description=\"Genotype Quality\">\n##FORMAT=<ID=DP,Number=1,Type=Integer,Description=\"Read Depth\">\n##FORMAT=<ID=HQ,Number=2,Type=Integer,Description=\"Haplotype Quality\">\n#CHROM POS      ID         REF   ALT    QUAL  FILTER   INFO                             FORMAT       NA00001         NA00002          NA00003\n20     14370    rs6054257  G     A      29    PASS    NS=3;DP=14;AF=0.5;DX=Test;H2           GT:GQ:DP:HQ  0|0:48:1:51,51  1|0:48:8:51,51   1/1:43:5");
        using var reader = new VcfStreamReader(stream);
        var arr = reader.Read().ToArray();
        Assert.Equal("Test",arr[0].Info.Value["DX"].GetValue<string>());
    }
    
    [Fact]
    public void Works_with_all_datatype()
    {
        using var stream = CreateStreamFromString("##fileformat=VCFv4.3\n##fileDate=20090805\n##source=myImputationProgramV3.1\n##reference=file:///seq/references/1000GenomesPilot-NCBI36.fasta\n##contig=<ID=20,length=62435964,assembly=B36,md5=f126cdf8a6e0c7f379d618ff66beb2da,species=\"Homo sapiens\",taxonomy=x>\n##phasing=partial\n##INFO=<ID=NS,Number=1,Type=Integer,Description=\"Number of Samples With Data\">\n##INFO=<ID=DP,Number=1,Type=Integer,Description=\"Total Depth\">\n##INFO=<ID=AF,Number=1,Type=Float,Description=\"Allele Frequency\">\n##INFO=<ID=AA,Number=1,Type=String,Description=\"Ancestral Allele\">\n##INFO=<ID=DB,Number=0,Type=Flag,Description=\"dbSNP membership, build 129\">\n##INFO=<ID=H2,Number=0,Type=Flag,Description=\"HapMap2 membership\">\n##FILTER=<ID=q10,Description=\"Quality below 10\">\n##FILTER=<ID=s50,Description=\"Less than 50% of samples have data\">\n##FORMAT=<ID=GT,Number=1,Type=String,Description=\"Genotype\">\n##FORMAT=<ID=GQ,Number=1,Type=Integer,Description=\"Genotype Quality\">\n##FORMAT=<ID=DP,Number=1,Type=Integer,Description=\"Read Depth\">\n##FORMAT=<ID=HQ,Number=2,Type=Integer,Description=\"Haplotype Quality\">\n#CHROM POS      ID         REF   ALT    QUAL  FILTER   INFO                             FORMAT       NA00001         NA00002          NA00003\n20     14370    rs6054257  G     A      29    PASS    NS=3;DP=14;AF=0.5;DB;H2           GT:GQ:DP:HQ  0|0:48:1:51,51  1|0:48:8:51,51   1/1:43:5:.,.\n20     17330    .          T     A      3     q10     NS=3;DP=11;AF=0.017               GT:GQ:DP:HQ  0|0:49:3:58,50  0|1:3:5:65,3     0/0:41:3\n20     1110696  rs6040355  A     G,T    67    PASS    NS=2;DP=10;AF=0.333;AA=T;DB GT:GQ:DP:HQ  1|2:21:6:23,27  2|1:2:0:18,2     2/2:35:4\n20     1230237  .          T     .      47    PASS    NS=3;DP=13;AA=T                   GT:GQ:DP:HQ  0|0:54:7:56,60  0|0:48:4:51,51   0/0:61:2\n20     1234567  microsat1  GTC   G,GTCT 50    PASS    NS=3;DP=9;AA=G                    GT:GQ:DP     0/1:35:4        0/2:17:2         1/1:40:3");
        using var reader = new VcfStreamReader(stream);
        var arr = reader.Read().ToArray();
        Assert.Equal("G",arr[4].Info.Value["AA"].GetValue<string>());
        Assert.Equal(0.5M,arr[0].Info.Value["AF"].GetValue<decimal>());

    }

    [Fact]
    public void Works_with_all_array_datatypes()
    {
        using var stream = CreateStreamFromString("##fileformat=VCFv4.3\n##fileDate=20090805\n##source=myImputationProgramV3.1\n##reference=file:///seq/references/1000GenomesPilot-NCBI36.fasta\n##contig=<ID=20,length=62435964,assembly=B36,md5=f126cdf8a6e0c7f379d618ff66beb2da,species=\"Homo sapiens\",taxonomy=x>\n##phasing=partial\n##INFO=<ID=NS,Number=A,Type=Integer,Description=\"Number of Samples With Data\">\n##INFO=<ID=DP,Number=A,Type=Integer,Description=\"Total Depth\">\n##INFO=<ID=AF,Number=A,Type=Float,Description=\"Allele Frequency\">\n##INFO=<ID=AA,Number=A,Type=String,Description=\"Ancestral Allele\">\n##FILTER=<ID=q10,Description=\"Quality below 10\">\n##FILTER=<ID=s50,Description=\"Less than 50% of samples have data\">\n##FORMAT=<ID=GT,Number=1,Type=String,Description=\"Genotype\">\n##FORMAT=<ID=GQ,Number=1,Type=Integer,Description=\"Genotype Quality\">\n##FORMAT=<ID=DP,Number=1,Type=Integer,Description=\"Read Depth\">\n##FORMAT=<ID=HQ,Number=2,Type=Integer,Description=\"Haplotype Quality\">\n#CHROM POS      ID         REF   ALT    QUAL  FILTER   INFO                             FORMAT       NA00001         NA00002          NA00003\n20     14370    rs6054257  G     A      29    PASS    NS=3,4;DP=14,5;AF=0.5,0.2;AA=N,U           GT:GQ:DP:HQ  0|0:48:1:51,51  1|0:48:8:51,51   1/1:43:5");
        using var reader = new VcfStreamReader(stream);
        var arr = reader.Read().ToArray();
        Assert.Equal("N",arr[0].Info.Value["AA"].GetValue<string[]>()[0]);
        Assert.Equal("U",arr[0].Info.Value["AA"].GetValue<string[]>()[1]);
        Assert.Equal(3,arr[0].Info.Value["NS"].GetValue<int[]>()[0]);
        Assert.Equal(4,arr[0].Info.Value["NS"].GetValue<int[]>()[1]);
        Assert.Equal(14,arr[0].Info.Value["DP"].GetValue<int[]>()[0]);
        Assert.Equal(5,arr[0].Info.Value["DP"].GetValue<int[]>()[1]);
        Assert.Equal(0.5M,arr[0].Info.Value["AF"].GetValue<decimal[]>()[0]);
        Assert.Equal(0.2M,arr[0].Info.Value["AF"].GetValue<decimal[]>()[1]);
    }

}