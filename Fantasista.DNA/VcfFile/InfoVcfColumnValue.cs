using System.Globalization;
using Fantasista.DNA.VcfFile.Exceptions;

namespace Fantasista.DNA.VcfFile;
/// <summary>
/// A class which contains the value of a Info column, using metadata the data split up.
/// It inherits from VcfColumnValue but the value is a dictionary.
/// </summary>
public class InfoVcfColumnValue : VcfColumnValue<Dictionary<string,IVcfColumnValue>>
{
    
    internal InfoVcfColumnValue(string name, string type, string rawValue, VcfFileMetaData metaData) : base(name,type,new Dictionary<string, IVcfColumnValue>())
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