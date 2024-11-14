# Fantasista.DNA
Simple helper files for reading and working with different types of DNA stuff.  
![Logo](Fantasista.DNA/icon.png)

# Install
```bash
$ dotnet add package Fantasista.DNA
```
## Documentation
[Documentation](./docs/readme.md)

## Supported file formats: 

| File format               | Class             | Description                                                            | 
|---------------------------|-------------------|------------------------------------------------------------------------|
| Variant Call Format (VCF) | VcfStreamReader   | Reads variations between reference genomes and sequences aligned to it | 
| FASTA                     | FastaStreamReader | Reads the sequence format FASTA                                        | 
| FASTQ                     | FastqStreamReader | Reads the sequence format FASTQ                                        | 

## Other supported parses
| Type | Class        | Description                                                                                                                                  | 
|------|--------------|----------------------------------------------------------------------------------------------------------------------------------------------|
| HGVS | HgvsVariant  | Human Genome Variation Society Formatting iternationally-recognized standard for the description of DNA, RNA, and protein sequence variants. |  