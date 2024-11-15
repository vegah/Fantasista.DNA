#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.VcfFile.Exceptions](Fantasista.DNA.VcfFile.Exceptions.md 'Fantasista.DNA.VcfFile.Exceptions').[VcfColumnValueTypeException](Fantasista.DNA.VcfFile.Exceptions.VcfColumnValueTypeException.md 'Fantasista.DNA.VcfFile.Exceptions.VcfColumnValueTypeException')

## VcfColumnValueTypeException(Type, Type, string) Constructor

Thrown when a column value has one type but GetValue is called with a different type

```csharp
public VcfColumnValueTypeException(System.Type expected, System.Type actual, string name);
```
#### Parameters

<a name='Fantasista.DNA.VcfFile.Exceptions.VcfColumnValueTypeException.VcfColumnValueTypeException(System.Type,System.Type,string).expected'></a>

`expected` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The expected type

<a name='Fantasista.DNA.VcfFile.Exceptions.VcfColumnValueTypeException.VcfColumnValueTypeException(System.Type,System.Type,string).actual'></a>

`actual` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type used on GetValue

<a name='Fantasista.DNA.VcfFile.Exceptions.VcfColumnValueTypeException.VcfColumnValueTypeException(System.Type,System.Type,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the column