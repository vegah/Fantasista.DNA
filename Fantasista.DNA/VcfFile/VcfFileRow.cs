using System.Globalization;
using Fantasista.DNA.VcfFile.Exceptions;

namespace Fantasista.DNA.VcfFile;

public class VcfFileRow : Dictionary<string,IVcfColumnValue>
{
    public VcfColumnValue<string> Chrom => (VcfColumnValue<string>)this["CHROM"];
    public VcfColumnValue<int> Pos => (VcfColumnValue<int>)this["POS"];
    public IdVcfColumnValue Id => (IdVcfColumnValue)this["ID"];
    public VcfColumnValue<string> Ref => (VcfColumnValue<string>)this["REF"];
    public AltVcfColumnValue Alt => (AltVcfColumnValue)this["ALT"];
    public VcfColumnValue<string> Qual => (VcfColumnValue<string>)this["QUAL"];
    public VcfColumnValue<string> Filter => (VcfColumnValue<string>)this["FILTER"];
    public InfoVcfColumnValue Info => (InfoVcfColumnValue)this["INFO"];
    public void AddColumn(VcfFileColumn vcfFileColumn, string s,VcfFileMetaData metaData)
    {
        switch (vcfFileColumn.ColumnName)
        {
            case "CHROM":
                Add("CHROM",new VcfColumnValue<string>("CHROM","integer",s));
                break;
            case "POS":
                Add("POS",new VcfColumnValue<int>("POS","integer",int.Parse(s)));
                break;
            case "ID":
                Add("ID",new IdVcfColumnValue("ID","string",s));
                break;
            case "REF":
                Add("REF",new VcfColumnValue<string>("REF","string",s));
                break;
            case "ALT":
                Add("ALT",new AltVcfColumnValue("ALT","string",s));
                break;
            case "QUAL":
                Add("QUAL",new VcfColumnValue<string>("ALT","integer",s));
                break;
            case "FILTER":
                Add("FILTER",new VcfColumnValue<string>("FILTER","string",s));
                break;
            case "INFO":
                Add("INFO",new InfoVcfColumnValue("INFO","list",s,metaData));
                break;
             default:
                 Add(vcfFileColumn.ColumnName,new VcfColumnValue<string>(vcfFileColumn.ColumnName,"string",s));
                 break;
        }
    }
}

public class InfoVcfColumnValue : VcfColumnValue<Dictionary<string,IVcfColumnValue>>
{
    public InfoVcfColumnValue(string name, string type, string rawValue, VcfFileMetaData metaData) : base(name,type,new Dictionary<string, IVcfColumnValue>())
    {
        var values = rawValue.Split(';')
            .Select(v => v.Split('='));
        foreach (var v in values)
        {
            var subname = v[0];
            var metaDataInfo = metaData.Info.FirstOrDefault(x => x.Id == subname);
            if (metaDataInfo?.Type == "Flag")
            {
                Value.Add(subname, new VcfColumnValue<bool>(subname, type, true));
                continue;                
            }

            if (v.Length < 2) throw new InfoVcfColumnValueException($"Expected key=value, but got {v}");        
            var value = v[1];
            if (metaDataInfo == null)
            {
                Value.Add(subname, new VcfColumnValue<string>(subname, type, value));
            }
            else if (metaDataInfo.Number=="1")
            {
                switch (metaDataInfo.Type)
                {
                    case "String":
                        Value.Add(subname, new VcfColumnValue<string>(subname, type, value));
                        break;
                    case "Integer":
                        Value.Add(subname, new VcfColumnValue<int>(subname, type, int.Parse(value,CultureInfo.InvariantCulture)));
                        break;
                    case "Float":
                        Value.Add(subname, new VcfColumnValue<decimal>(subname, type, decimal.Parse(value,CultureInfo.InvariantCulture)));
                        break;
                }
            }
            else 
            {
                switch (metaDataInfo.Type)
                {
                    case "String":
                        Value.Add(subname, new VcfColumnValue<string[]>(subname, type, value.Split(',')));
                        break;
                    case "Integer":
                        Value.Add(subname, new VcfColumnValue<int[]>(subname, type, value.Split(',').Select(x=>int.Parse(x,CultureInfo.InvariantCulture)).ToArray()));
                        break;
                    case "Float":
                        Value.Add(subname, new VcfColumnValue<decimal[]>(subname, type, value.Split(',').Select(x=>decimal.Parse(x,CultureInfo.InvariantCulture)).ToArray()));
                        break;
                }
            }
            
        }

    }
}