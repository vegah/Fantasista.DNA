# How to read a SAM file
```csharp
using var samfile = File.OpenRead("toy.sam");
using var samreader = new SamStreamReader(samfile);
foreach (var row in samreader.Read())
{
    Console.WriteLine(row.CIGAR.Parts[0].Operator);
    Console.WriteLine(row.ReadSequence);
}
```
# How to read a FASTA file
## Read the sequence
```csharp
// Read 5 lines from fasta file
var fastafile = File.OpenRead("G:\\genes\\uniprot_sprot.fasta\\uniprot_sprot.fasta");
var fastareader = new FastaStreamReader(fastafile);
foreach (var sequence in fastareader.Read().Take(5))
{
    Console.WriteLine(sequence.RawSequence);
}
```
## With an inspector
You can decorate a sequence with an inspector. An inspector is a class that implements the ISequenceInspector&lt;T&gt; interface, and will return a object instansiated from a class that inherits BasicSequence.   
Included in the package is SimpleSequenceInspector which tries to guess the sequence type.
```csharp
// Read and inspect 5 lines from fasta file
var fastafile2 = File.OpenRead("file.fasta");
var fastareader2 = new FastaStreamReader(fastafile);
var inspector = new SimpleSequenceInspector();
foreach (var sequence in fastareader.ReadInspected(inspector).Take(5))
{
    Console.WriteLine(sequence.GuessedType);
}
```
# How to read a FASTQ file
Both examples above could be used by just switching from ```FastaStreamReader``` to ```FastqStreamReader```. 

# How do read VCF file
```csharp
// Read 5 lines from vcf file
using var file = File.OpenRead("file.vcf");
using var reader = new VcfStreamReader(file);
foreach (var row in reader.Read().Take(5))
{
    Console.WriteLine(row.Info.Value["MC"].GetValue<string[]>()[0]);
    Console.WriteLine($"{row.Chrom.Value} - {row.Info.Value["ALLELEID"].GetValue<int>()}");
}
```

# How to parse a HGVS string
```csharp
var hgvs = HgvsVariant.Parse("NM_000018.4(ACADVL):c.62+5G>A");
Console.WriteLine(hgvs.GeneSymbol);
```
