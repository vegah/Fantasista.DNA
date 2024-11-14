<a name='assembly'></a>
# Fantasista.DNA

## Contents

- [FastaStreamReader](#T-Fantasista-DNA-FastaFile-FastaStreamReader 'Fantasista.DNA.FastaFile.FastaStreamReader')
  - [#ctor(s)](#M-Fantasista-DNA-FastaFile-FastaStreamReader-#ctor-System-String- 'Fantasista.DNA.FastaFile.FastaStreamReader.#ctor(System.String)')
  - [#ctor(stream)](#M-Fantasista-DNA-FastaFile-FastaStreamReader-#ctor-System-IO-Stream- 'Fantasista.DNA.FastaFile.FastaStreamReader.#ctor(System.IO.Stream)')
  - [Read()](#M-Fantasista-DNA-FastaFile-FastaStreamReader-Read 'Fantasista.DNA.FastaFile.FastaStreamReader.Read')
- [FastqStreamReader](#T-Fantasista-DNA-FastaFile-FastqStreamReader 'Fantasista.DNA.FastaFile.FastqStreamReader')
  - [#ctor(s)](#M-Fantasista-DNA-FastaFile-FastqStreamReader-#ctor-System-String- 'Fantasista.DNA.FastaFile.FastqStreamReader.#ctor(System.String)')
  - [#ctor(stream)](#M-Fantasista-DNA-FastaFile-FastqStreamReader-#ctor-System-IO-Stream- 'Fantasista.DNA.FastaFile.FastqStreamReader.#ctor(System.IO.Stream)')
  - [Read()](#M-Fantasista-DNA-FastaFile-FastqStreamReader-Read 'Fantasista.DNA.FastaFile.FastqStreamReader.Read')
- [HgvsVariant](#T-Fantasista-DNA-HgvsVariant 'Fantasista.DNA.HgvsVariant')
  - [Parse(hgvsString)](#M-Fantasista-DNA-HgvsVariant-Parse-System-String- 'Fantasista.DNA.HgvsVariant.Parse(System.String)')
  - [ToString()](#M-Fantasista-DNA-HgvsVariant-ToString 'Fantasista.DNA.HgvsVariant.ToString')
- [MyRegex_0](#T-System-Text-RegularExpressions-Generated-MyRegex_0 'System.Text.RegularExpressions.Generated.MyRegex_0')
  - [#ctor()](#M-System-Text-RegularExpressions-Generated-MyRegex_0-#ctor 'System.Text.RegularExpressions.Generated.MyRegex_0.#ctor')
  - [Instance](#F-System-Text-RegularExpressions-Generated-MyRegex_0-Instance 'System.Text.RegularExpressions.Generated.MyRegex_0.Instance')
- [Runner](#T-System-Text-RegularExpressions-Generated-MyRegex_0-RunnerFactory-Runner 'System.Text.RegularExpressions.Generated.MyRegex_0.RunnerFactory.Runner')
  - [Scan(inputSpan)](#M-System-Text-RegularExpressions-Generated-MyRegex_0-RunnerFactory-Runner-Scan-System-ReadOnlySpan{System-Char}- 'System.Text.RegularExpressions.Generated.MyRegex_0.RunnerFactory.Runner.Scan(System.ReadOnlySpan{System.Char})')
  - [TryFindNextPossibleStartingPosition(inputSpan)](#M-System-Text-RegularExpressions-Generated-MyRegex_0-RunnerFactory-Runner-TryFindNextPossibleStartingPosition-System-ReadOnlySpan{System-Char}- 'System.Text.RegularExpressions.Generated.MyRegex_0.RunnerFactory.Runner.TryFindNextPossibleStartingPosition(System.ReadOnlySpan{System.Char})')
  - [TryMatchAtCurrentPosition(inputSpan)](#M-System-Text-RegularExpressions-Generated-MyRegex_0-RunnerFactory-Runner-TryMatchAtCurrentPosition-System-ReadOnlySpan{System-Char}- 'System.Text.RegularExpressions.Generated.MyRegex_0.RunnerFactory.Runner.TryMatchAtCurrentPosition(System.ReadOnlySpan{System.Char})')
- [RunnerFactory](#T-System-Text-RegularExpressions-Generated-MyRegex_0-RunnerFactory 'System.Text.RegularExpressions.Generated.MyRegex_0.RunnerFactory')
  - [CreateInstance()](#M-System-Text-RegularExpressions-Generated-MyRegex_0-RunnerFactory-CreateInstance 'System.Text.RegularExpressions.Generated.MyRegex_0.RunnerFactory.CreateInstance')
- [Utilities](#T-System-Text-RegularExpressions-Generated-Utilities 'System.Text.RegularExpressions.Generated.Utilities')
  - [s_asciiExceptDigits](#F-System-Text-RegularExpressions-Generated-Utilities-s_asciiExceptDigits 'System.Text.RegularExpressions.Generated.Utilities.s_asciiExceptDigits')
  - [s_defaultTimeout](#F-System-Text-RegularExpressions-Generated-Utilities-s_defaultTimeout 'System.Text.RegularExpressions.Generated.Utilities.s_defaultTimeout')
  - [s_hasTimeout](#F-System-Text-RegularExpressions-Generated-Utilities-s_hasTimeout 'System.Text.RegularExpressions.Generated.Utilities.s_hasTimeout')
  - [IndexOfAnyDigit()](#M-System-Text-RegularExpressions-Generated-Utilities-IndexOfAnyDigit-System-ReadOnlySpan{System-Char}- 'System.Text.RegularExpressions.Generated.Utilities.IndexOfAnyDigit(System.ReadOnlySpan{System.Char})')
- [VcfFileMetaData](#T-Fantasista-DNA-VcfFile-VcfFileMetaData 'Fantasista.DNA.VcfFile.VcfFileMetaData')
  - [MyRegex()](#M-Fantasista-DNA-VcfFile-VcfFileMetaData-MyRegex 'Fantasista.DNA.VcfFile.VcfFileMetaData.MyRegex')
- [VcfFileRow](#T-Fantasista-DNA-VcfFile-VcfFileRow 'Fantasista.DNA.VcfFile.VcfFileRow')
  - [Alt](#P-Fantasista-DNA-VcfFile-VcfFileRow-Alt 'Fantasista.DNA.VcfFile.VcfFileRow.Alt')
  - [Chrom](#P-Fantasista-DNA-VcfFile-VcfFileRow-Chrom 'Fantasista.DNA.VcfFile.VcfFileRow.Chrom')
  - [Filter](#P-Fantasista-DNA-VcfFile-VcfFileRow-Filter 'Fantasista.DNA.VcfFile.VcfFileRow.Filter')
  - [Id](#P-Fantasista-DNA-VcfFile-VcfFileRow-Id 'Fantasista.DNA.VcfFile.VcfFileRow.Id')
  - [Pos](#P-Fantasista-DNA-VcfFile-VcfFileRow-Pos 'Fantasista.DNA.VcfFile.VcfFileRow.Pos')
  - [Qual](#P-Fantasista-DNA-VcfFile-VcfFileRow-Qual 'Fantasista.DNA.VcfFile.VcfFileRow.Qual')
  - [Ref](#P-Fantasista-DNA-VcfFile-VcfFileRow-Ref 'Fantasista.DNA.VcfFile.VcfFileRow.Ref')
- [VcfStreamReader](#T-Fantasista-DNA-VcfFile-VcfStreamReader 'Fantasista.DNA.VcfFile.VcfStreamReader')
  - [#ctor(s)](#M-Fantasista-DNA-VcfFile-VcfStreamReader-#ctor-System-String- 'Fantasista.DNA.VcfFile.VcfStreamReader.#ctor(System.String)')
  - [#ctor(s)](#M-Fantasista-DNA-VcfFile-VcfStreamReader-#ctor-System-IO-Stream- 'Fantasista.DNA.VcfFile.VcfStreamReader.#ctor(System.IO.Stream)')
  - [Columns](#P-Fantasista-DNA-VcfFile-VcfStreamReader-Columns 'Fantasista.DNA.VcfFile.VcfStreamReader.Columns')
  - [MetaData](#P-Fantasista-DNA-VcfFile-VcfStreamReader-MetaData 'Fantasista.DNA.VcfFile.VcfStreamReader.MetaData')
  - [Read()](#M-Fantasista-DNA-VcfFile-VcfStreamReader-Read 'Fantasista.DNA.VcfFile.VcfStreamReader.Read')

<a name='T-Fantasista-DNA-FastaFile-FastaStreamReader'></a>
## FastaStreamReader `type`

##### Namespace

Fantasista.DNA.FastaFile

##### Summary

Class for reading FASTA files

<a name='M-Fantasista-DNA-FastaFile-FastaStreamReader-#ctor-System-String-'></a>
### #ctor(s) `constructor`

##### Summary

Construct with a string. Use the stream constructor unless you have a small string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A string containing the FASTA file |

<a name='M-Fantasista-DNA-FastaFile-FastaStreamReader-#ctor-System-IO-Stream-'></a>
### #ctor(stream) `constructor`

##### Summary

Stream constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | A stream continaing the FASTA file |

<a name='M-Fantasista-DNA-FastaFile-FastaStreamReader-Read'></a>
### Read() `method`

##### Summary

Reads sequences from the file.

##### Returns

An IEnumerable containing Sequence elements

##### Parameters

This method has no parameters.

<a name='T-Fantasista-DNA-FastaFile-FastqStreamReader'></a>
## FastqStreamReader `type`

##### Namespace

Fantasista.DNA.FastaFile

##### Summary

Class for reading FASTQ files

<a name='M-Fantasista-DNA-FastaFile-FastqStreamReader-#ctor-System-String-'></a>
### #ctor(s) `constructor`

##### Summary

Construct with a string. Use the stream constructor unless you have a small string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A string containing the FASTQ file |

<a name='M-Fantasista-DNA-FastaFile-FastqStreamReader-#ctor-System-IO-Stream-'></a>
### #ctor(stream) `constructor`

##### Summary

Stream constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | A stream continaing the FASTQ file |

<a name='M-Fantasista-DNA-FastaFile-FastqStreamReader-Read'></a>
### Read() `method`

##### Summary

Reads sequences from the file.

##### Returns

An IEnumerable containing Sequence elements

##### Parameters

This method has no parameters.

<a name='T-Fantasista-DNA-HgvsVariant'></a>
## HgvsVariant `type`

##### Namespace

Fantasista.DNA

<a name='M-Fantasista-DNA-HgvsVariant-Parse-System-String-'></a>
### Parse(hgvsString) `method`

##### Summary

Parses a hgvs string to a HgvsVariant model. The process can be reversed with HgvsVariant.ToString()

##### Returns

A HgvsVariant model

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hgvsString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to parse |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.FormatException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.FormatException 'System.FormatException') | Thrown if the input is not in the correct format |

##### Example

var str = "NM_000018.4(ACADVL):c.62+5G>A";
var variant = HgvsVariant.Parse(str);
Console.WriteLine(variant.GeneSymbol); // ACADVL

<a name='M-Fantasista-DNA-HgvsVariant-ToString'></a>
### ToString() `method`

##### Summary

Writes the model back in HgvsFormat.

##### Returns

string in Hgvs format

##### Parameters

This method has no parameters.

<a name='T-System-Text-RegularExpressions-Generated-MyRegex_0'></a>
## MyRegex_0 `type`

##### Namespace

System.Text.RegularExpressions.Generated

##### Summary

Custom [Regex](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Regex 'System.Text.RegularExpressions.Regex')-derived type for the MyRegex method.

<a name='M-System-Text-RegularExpressions-Generated-MyRegex_0-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes the instance.

##### Parameters

This constructor has no parameters.

<a name='F-System-Text-RegularExpressions-Generated-MyRegex_0-Instance'></a>
### Instance `constants`

##### Summary

Cached, thread-safe singleton instance.

<a name='T-System-Text-RegularExpressions-Generated-MyRegex_0-RunnerFactory-Runner'></a>
## Runner `type`

##### Namespace

System.Text.RegularExpressions.Generated.MyRegex_0.RunnerFactory

##### Summary

Provides the runner that contains the custom logic implementing the specified regular expression.

<a name='M-System-Text-RegularExpressions-Generated-MyRegex_0-RunnerFactory-Runner-Scan-System-ReadOnlySpan{System-Char}-'></a>
### Scan(inputSpan) `method`

##### Summary

Scan the `inputSpan` starting from base.runtextstart for the next match.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputSpan | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The text being scanned by the regular expression. |

<a name='M-System-Text-RegularExpressions-Generated-MyRegex_0-RunnerFactory-Runner-TryFindNextPossibleStartingPosition-System-ReadOnlySpan{System-Char}-'></a>
### TryFindNextPossibleStartingPosition(inputSpan) `method`

##### Summary

Search `inputSpan` starting from base.runtextpos for the next location a match could possibly start.

##### Returns

true if a possible match was found; false if no more matches are possible.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputSpan | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The text being scanned by the regular expression. |

<a name='M-System-Text-RegularExpressions-Generated-MyRegex_0-RunnerFactory-Runner-TryMatchAtCurrentPosition-System-ReadOnlySpan{System-Char}-'></a>
### TryMatchAtCurrentPosition(inputSpan) `method`

##### Summary

Determine whether `inputSpan` at base.runtextpos is a match for the regular expression.

##### Returns

true if the regular expression matches at the current position; otherwise, false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputSpan | [System.ReadOnlySpan{System.Char}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ReadOnlySpan 'System.ReadOnlySpan{System.Char}') | The text being scanned by the regular expression. |

<a name='T-System-Text-RegularExpressions-Generated-MyRegex_0-RunnerFactory'></a>
## RunnerFactory `type`

##### Namespace

System.Text.RegularExpressions.Generated.MyRegex_0

##### Summary

Provides a factory for creating [RegexRunner](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.RegexRunner 'System.Text.RegularExpressions.RegexRunner') instances to be used by methods on [Regex](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Regex 'System.Text.RegularExpressions.Regex').

<a name='M-System-Text-RegularExpressions-Generated-MyRegex_0-RunnerFactory-CreateInstance'></a>
### CreateInstance() `method`

##### Summary

Creates an instance of a [RegexRunner](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.RegexRunner 'System.Text.RegularExpressions.RegexRunner') used by methods on [Regex](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Regex 'System.Text.RegularExpressions.Regex').

##### Parameters

This method has no parameters.

<a name='T-System-Text-RegularExpressions-Generated-Utilities'></a>
## Utilities `type`

##### Namespace

System.Text.RegularExpressions.Generated

##### Summary

Helper methods used by generated [Regex](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Regex 'System.Text.RegularExpressions.Regex')-derived implementations.

<a name='F-System-Text-RegularExpressions-Generated-Utilities-s_asciiExceptDigits'></a>
### s_asciiExceptDigits `constants`

##### Summary

Supports searching for characters in or not in "\0\u0001\u0002\u0003\u0004\u0005\u0006\a\b\t\n\v\f\r\u000e\u000f\u0010\u0011\u0012\u0013\u0014\u0015\u0016\u0017\u0018\u0019\u001a\u001b\u001c\u001d\u001e\u001f !\"#$%&'()*+,-./:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_\`abcdefghijklmnopqrstuvwxyz{|}~\u007f".

<a name='F-System-Text-RegularExpressions-Generated-Utilities-s_defaultTimeout'></a>
### s_defaultTimeout `constants`

##### Summary

Default timeout value set in [AppContext](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.AppContext 'System.AppContext'), or [InfiniteMatchTimeout](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Regex.InfiniteMatchTimeout 'System.Text.RegularExpressions.Regex.InfiniteMatchTimeout') if none was set.

<a name='F-System-Text-RegularExpressions-Generated-Utilities-s_hasTimeout'></a>
### s_hasTimeout `constants`

##### Summary

Whether [s_defaultTimeout](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.RegularExpressions.Generated.Utilities.s_defaultTimeout 'System.Text.RegularExpressions.Generated.Utilities.s_defaultTimeout') is non-infinite.

<a name='M-System-Text-RegularExpressions-Generated-Utilities-IndexOfAnyDigit-System-ReadOnlySpan{System-Char}-'></a>
### IndexOfAnyDigit() `method`

##### Summary

Finds the next index of any character that matches a Unicode digit.

##### Parameters

This method has no parameters.

<a name='T-Fantasista-DNA-VcfFile-VcfFileMetaData'></a>
## VcfFileMetaData `type`

##### Namespace

Fantasista.DNA.VcfFile

<a name='M-Fantasista-DNA-VcfFile-VcfFileMetaData-MyRegex'></a>
### MyRegex() `method`

##### Parameters

This method has no parameters.

##### Remarks

Pattern:

```
(\\d\\d\\d\\d)[-]?(\\d\\d)[-]?(\\d\\d)
```

Explanation:

```
○ 1st capture group.
```

<a name='T-Fantasista-DNA-VcfFile-VcfFileRow'></a>
## VcfFileRow `type`

##### Namespace

Fantasista.DNA.VcfFile

<a name='P-Fantasista-DNA-VcfFile-VcfFileRow-Alt'></a>
### Alt `property`

##### Summary

The standard Alt field

<a name='P-Fantasista-DNA-VcfFile-VcfFileRow-Chrom'></a>
### Chrom `property`

##### Summary

The standard Chrom field - it is a string because some files contains characters instead of numbers here.

<a name='P-Fantasista-DNA-VcfFile-VcfFileRow-Filter'></a>
### Filter `property`

##### Summary

The standard Filter field

<a name='P-Fantasista-DNA-VcfFile-VcfFileRow-Id'></a>
### Id `property`

##### Summary

The standard id field

<a name='P-Fantasista-DNA-VcfFile-VcfFileRow-Pos'></a>
### Pos `property`

##### Summary

The standard Pos field

<a name='P-Fantasista-DNA-VcfFile-VcfFileRow-Qual'></a>
### Qual `property`

##### Summary

The standard Qual field

<a name='P-Fantasista-DNA-VcfFile-VcfFileRow-Ref'></a>
### Ref `property`

##### Summary

The standard Ref field

<a name='T-Fantasista-DNA-VcfFile-VcfStreamReader'></a>
## VcfStreamReader `type`

##### Namespace

Fantasista.DNA.VcfFile

##### Summary

A class for reading Variant Call Format (VCF)

<a name='M-Fantasista-DNA-VcfFile-VcfStreamReader-#ctor-System-String-'></a>
### #ctor(s) `constructor`

##### Summary

Reading the file directly from a string. Use the constructor with stream if you need to.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A vcf file as a string |

<a name='M-Fantasista-DNA-VcfFile-VcfStreamReader-#ctor-System-IO-Stream-'></a>
### #ctor(s) `constructor`

##### Summary

Reading the file from a stream. Use the constructor with string if you need to. This one uses far less memory.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | A readable stream containing the vcf file |

<a name='P-Fantasista-DNA-VcfFile-VcfStreamReader-Columns'></a>
### Columns `property`

##### Summary

Information about the columns in the vcf file.

<a name='P-Fantasista-DNA-VcfFile-VcfStreamReader-MetaData'></a>
### MetaData `property`

##### Summary

Contains metadata about the vcf file

<a name='M-Fantasista-DNA-VcfFile-VcfStreamReader-Read'></a>
### Read() `method`

##### Summary

Lazy reads the file as an IEnumerable. It will read one row after another, as the function is enumerated.

##### Returns

An VcfFileRow per row

##### Parameters

This method has no parameters.
