# Fantasista.DNA
A library for reading, handling and working with bioinformatic files and formats.  
The library is work in progress, and it is mainly created to be able to work with this stuff myself.  

![Logo](Fantasista.DNA/icon.png)

# Roadmap
The first versions will prioritize reading different kinds of file formats. See list below over supported files.

Next versions:
 *  Reading Cram files
 *  Reading Bam files



# Install
```bash
$ dotnet add package Fantasista.DNA
```
## Documentation
[Examples](./examples.md)  
[Complete API Documentation](./docs/index.md)  

## Supported file formats: 

| File format               | Class             | Description                                                            | 
|---------------------------|-------------------|------------------------------------------------------------------------|
| Variant Call Format (VCF) | VcfStreamReader   | Reads variations between reference genomes and sequences aligned to it | 
| FASTA                     | FastaStreamReader | Reads the sequence format FASTA                                        | 
| FASTQ                     | FastqStreamReader | Reads the sequence format FASTQ                                        | 
|SAM | SamStreamReader | Reads SAM Files |
## Other supported parses
| Type | Class        | Description                                                                                                                                  | 
|------|--------------|----------------------------------------------------------------------------------------------------------------------------------------------|
| HGVS | HgvsVariant  | Human Genome Variation Society Formatting iternationally-recognized standard for the description of DNA, RNA, and protein sequence variants. |

# I found a bug
Please use [Github Issues](https://github.com/vegah/Fantasista.DNA/issues), or even better, send a pull request.  

# Where to find data
Are you new to bioinformatics?  
There are a lot of places to find data files you could use for starting in bioinformatics.  
 * The ftp server at [ClinVar](https://ftp.ncbi.nlm.nih.gov/pub/clinvar/)
 * Uniprot have a [Download page](https://www.uniprot.org/help/downloads)


