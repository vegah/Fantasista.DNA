# Fantasista.DNA
Simple helper files for reading and working with different types of DNA stuff.  
Not at all  done.



## VcfFileReader
A class to read vcf files. For now this is just based on being able to read the ClinVar vcf file.
Example:
```csharp
        using var vcfFile = File.Open("clinvar.vcf");
        using var reader = new VcfFileReader(vcfFile);
        reader.Read();
```

## HgvsVariant
A simple class to parse and write information about a gene.
Example:
```csharp
        var str = "NM_000018.4(ACADVL):c.62+5G>A";
        var variant = HgvsVariant.Parse(str);
        Console.WriteLine(variant.GeneSymbol); // ACADVL
```


