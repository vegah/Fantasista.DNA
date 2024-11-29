#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[SamStreamReader](Fantasista.DNA.SAMFile.SamStreamReader.md 'Fantasista.DNA.SAMFile.SamStreamReader')

## SamStreamReader.ProgramHeaders Property

Gets or sets the collection of program headers in the SAM file.

```csharp
public System.Collections.Generic.List<Fantasista.DNA.SAMFile.SamFileProgram> ProgramHeaders { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[SamFileProgram](Fantasista.DNA.SAMFile.SamFileProgram.md 'Fantasista.DNA.SAMFile.SamFileProgram')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

### Remarks
The ProgramHeaders property contains a list of [SamFileProgram](Fantasista.DNA.SAMFile.SamFileProgram.md 'Fantasista.DNA.SAMFile.SamFileProgram') instances representing various  
programs that have been used during the processing of the SAM file. Each program record provides detailed  
information about a specific program, including its name, version, description, and the command line used  
during its execution.