// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Fantasista.DNA;
using Fantasista.DNA.FastaFile;
using Fantasista.DNA.Sequence.Inspectors;
using Fantasista.DNA.VcfFile;

Console.WriteLine("Just some examples using the library");

// Human Genome Variation Society Formatting Parsing
var hgvs = HgvsVariant.Parse("NM_000018.4(ACADVL):c.62+5G>A");
Console.WriteLine(hgvs.GeneSymbol);

// Read 5 lines from fasta file
var fastafile = File.OpenRead("G:\\genes\\uniprot_sprot.fasta\\uniprot_sprot.fasta");
var fastareader = new FastaStreamReader(fastafile);
foreach (var sequence in fastareader.Read().Take(5))
{
    Console.WriteLine(sequence.RawSequence);
}

// Read and inspect 5 lines from fasta file
var fastafile2 = File.OpenRead("G:\\genes\\uniprot_sprot.fasta\\uniprot_sprot.fasta");
var fastareader2 = new FastaStreamReader(fastafile);
var inspector = new SimpleSequenceInspector();
foreach (var sequence in fastareader.ReadInspected(inspector).Take(5))
{
    Console.WriteLine(sequence.GuessedType);
}


// Read 5 lines from vcf file
using var file = File.OpenRead("G:\\genes\\clinvar.vcf\\clinvar.vcf");
using var reader = new VcfStreamReader(file);
var watch = Stopwatch.StartNew();
var counter = 0;
foreach (var row in reader.Read().Take(5))
{
    Console.WriteLine(row.Info.Value["MC"].GetValue<string[]>()[0]);
    Console.WriteLine($"{row.Chrom.Value} - {row.Info.Value["ALLELEID"].GetValue<int>()}");
    counter++;
    if (counter%100000==0) Console.WriteLine($"Read {counter} rows");
}
watch.Stop();
Console.WriteLine($"Reading {counter} rows took {watch.ElapsedMilliseconds}ms");