#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA](Fantasista.DNA.md 'Fantasista.DNA').[HgvsVariant](Fantasista.DNA.HgvsVariant.md 'Fantasista.DNA.HgvsVariant')

## HgvsVariant.Parse(string) Method

Parses a hgvs string to a HgvsVariant model. The process can be reversed with HgvsVariant.ToString()

```csharp
public static Fantasista.DNA.HgvsVariant Parse(string hgvsString);
```
#### Parameters

<a name='Fantasista.DNA.HgvsVariant.Parse(string).hgvsString'></a>

`hgvsString` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The string to parse

#### Returns
[HgvsVariant](Fantasista.DNA.HgvsVariant.md 'Fantasista.DNA.HgvsVariant')  
A HgvsVariant model

#### Exceptions

[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
Thrown if the input is not in the correct format

### Example
var str = "NM_000018.4(ACADVL):c.62+5G>A";  
var variant = HgvsVariant.Parse(str);  
Console.WriteLine(variant.GeneSymbol); // ACADVL