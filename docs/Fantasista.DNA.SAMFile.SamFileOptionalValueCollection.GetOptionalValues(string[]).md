#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile](Fantasista.DNA.SAMFile.md 'Fantasista.DNA.SAMFile').[SamFileOptionalValueCollection](Fantasista.DNA.SAMFile.SamFileOptionalValueCollection.md 'Fantasista.DNA.SAMFile.SamFileOptionalValueCollection')

## SamFileOptionalValueCollection.GetOptionalValues(string[]) Method

Parses a string of SAM file optional values and returns a collection of SamFileOptionalValue instances.

```csharp
public static Fantasista.DNA.SAMFile.SamFileOptionalValueCollection GetOptionalValues(string[] optionalValues);
```
#### Parameters

<a name='Fantasista.DNA.SAMFile.SamFileOptionalValueCollection.GetOptionalValues(string[]).optionalValues'></a>

`optionalValues` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

A semicolon-separated string representing the optional values in a SAM file, where each  
value is formatted as "tag:type:value".

#### Returns
[SamFileOptionalValueCollection](Fantasista.DNA.SAMFile.SamFileOptionalValueCollection.md 'Fantasista.DNA.SAMFile.SamFileOptionalValueCollection')  
A SamFileOptionalValueCollection containing all the parsed optional values.

#### Exceptions

[SamFileOptionalValueException](Fantasista.DNA.SAMFile.Exceptions.SamFileOptionalValueException.md 'Fantasista.DNA.SAMFile.Exceptions.SamFileOptionalValueException')  
Thrown when the input string does not conform to the expected format of  
"tag:type:value".