#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.SAMFile.Exceptions](Fantasista.DNA.SAMFile.Exceptions.md 'Fantasista.DNA.SAMFile.Exceptions').[SamFileOptionalValueException](Fantasista.DNA.SAMFile.Exceptions.SamFileOptionalValueException.md 'Fantasista.DNA.SAMFile.Exceptions.SamFileOptionalValueException')

## SamFileOptionalValueException(string) Constructor

Represents an exception that is thrown when a SAM file optional value does not conform  
to the expected format. This exception is typically raised during the parsing process  
when the data structure does not contain exactly three components: a tag, a type, and  
a value.

```csharp
public SamFileOptionalValueException(string message);
```
#### Parameters

<a name='Fantasista.DNA.SAMFile.Exceptions.SamFileOptionalValueException.SamFileOptionalValueException(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')