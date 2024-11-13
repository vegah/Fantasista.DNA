# Fantasista.DNA
Simple helper files for reading and working with different types of DNA stuff.  
![Logo](./icon.png)

# Install
```bash
$ dotnet add package Fantasista.DNA
```

# Classes
## VcfFileReader
A class to read vcf files. For now this is just based on being able to read the ClinVar vcf file.
This is still work in progress, but it works for most cases. If you have suggestions, please feel free to use "Issues" on github.
Example:
```csharp
        using var vcfFile = File.Open("clinvar.vcf");
        using var reader = new VcfStreamReader(file);
        foreach (var row in reader.Read())
        {
            Console.WriteLine($"{row.Chrom.Value} - {row.Info.Value["ALLELEID"].GetValue<int>()}");
        }

```


## HgvsVariant
A simple class to parse and write Human Genome Variation Society Formatting (HGVS)
Example:
```csharp
        var str = "NM_000018.4(ACADVL):c.62+5G>A";
        var variant = HgvsVariant.Parse(str);
        Console.WriteLine(variant.GeneSymbol); // ACADVL
```


