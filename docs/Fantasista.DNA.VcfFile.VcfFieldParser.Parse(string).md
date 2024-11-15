#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.VcfFile](Fantasista.DNA.VcfFile.md 'Fantasista.DNA.VcfFile').[VcfFieldParser](Fantasista.DNA.VcfFile.VcfFieldParser.md 'Fantasista.DNA.VcfFile.VcfFieldParser')

## VcfFieldParser.Parse(string) Method

A parser to parse metadata field that contains more information - for example Info  
It will parse fields with extra information between lower than and greater than signs

```csharp
public static System.Collections.Generic.Dictionary<string,string> Parse(string s);
```
#### Parameters

<a name='Fantasista.DNA.VcfFile.VcfFieldParser.Parse(string).s'></a>

`s` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The metadata excluding the ##

#### Returns
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')  
A dictionary with the parsed fields

#### Exceptions

[VcfFieldParserException](Fantasista.DNA.VcfFile.Exceptions.VcfFieldParserException.md 'Fantasista.DNA.VcfFile.Exceptions.VcfFieldParserException')  
Thrown if the string is not parseable