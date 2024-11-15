namespace Fantasista.DNA.VcfFile;

/// <summary>
/// Contains data for one row of a vcf file
/// </summary>
public class VcfFileRow : Dictionary<string,IVcfColumnValue>
{
    /// <summary>
    /// The standard Chrom field - it is a string because some files contains characters instead of numbers here. 
    /// </summary>
    public VcfColumnValue<string> Chrom => (VcfColumnValue<string>)this["CHROM"];

    /// <summary>
    /// The standard Pos field
    /// </summary>
    public VcfColumnValue<int> Pos => (VcfColumnValue<int>)this["POS"];
    /// <summary>
    /// The standard id field
    /// </summary>
    public IdVcfColumnValue Id => (IdVcfColumnValue)this["ID"];
    /// <summary>
    /// The standard Ref field
    /// </summary>
    public VcfColumnValue<string> Ref => (VcfColumnValue<string>)this["REF"];
    /// <summary>
    /// The standard Alt field
    /// </summary>
    public AltVcfColumnValue Alt => (AltVcfColumnValue)this["ALT"];
    /// <summary>
    /// The standard Qual field
    /// </summary>
    public VcfColumnValue<string> Qual => (VcfColumnValue<string>)this["QUAL"];
    /// <summary>
    /// The standard Filter field
    /// </summary>
    public VcfColumnValue<string> Filter => (VcfColumnValue<string>)this["FILTER"];
    /// <summary>
    /// The standard Info field. The info field will contain subinfo field under it's [""]
    /// For example will Info["ALLELEID"].GetValue{int}() return the int stored in the ALLELEID field, if it exists and is an int.
    /// </summary>
    public InfoVcfColumnValue Info => (InfoVcfColumnValue)this["INFO"];
    
    /// <summary>
    /// Adds a column to the row.
    /// </summary>
    /// <param name="vcfFileColumn">The column to add</param>
    /// <param name="s">The value as a string</param>
    /// <param name="metaData">The metadata for the file</param>
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