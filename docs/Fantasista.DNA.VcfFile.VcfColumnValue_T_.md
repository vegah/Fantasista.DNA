#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.VcfFile](Fantasista.DNA.VcfFile.md 'Fantasista.DNA.VcfFile')

## VcfColumnValue<T> Class

A generic class for a column value that contains a value of type T

```csharp
public class VcfColumnValue<T> :
Fantasista.DNA.VcfFile.IVcfColumnValue
```
#### Type parameters

<a name='Fantasista.DNA.VcfFile.VcfColumnValue_T_.T'></a>

`T`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; VcfColumnValue<T>

Derived  
&#8627; [AltVcfColumnValue](Fantasista.DNA.VcfFile.AltVcfColumnValue.md 'Fantasista.DNA.VcfFile.AltVcfColumnValue')  
&#8627; [IdVcfColumnValue](Fantasista.DNA.VcfFile.IdVcfColumnValue.md 'Fantasista.DNA.VcfFile.IdVcfColumnValue')  
&#8627; [InfoVcfColumnValue](Fantasista.DNA.VcfFile.InfoVcfColumnValue.md 'Fantasista.DNA.VcfFile.InfoVcfColumnValue')

Implements [IVcfColumnValue](Fantasista.DNA.VcfFile.IVcfColumnValue.md 'Fantasista.DNA.VcfFile.IVcfColumnValue')

| Constructors | |
| :--- | :--- |
| [VcfColumnValue(string, string, T)](Fantasista.DNA.VcfFile.VcfColumnValue_T_.VcfColumnValue(string,string,T).md 'Fantasista.DNA.VcfFile.VcfColumnValue<T>.VcfColumnValue(string, string, T)') | A generic class for a column value that contains a value of type T |

| Properties | |
| :--- | :--- |
| [Name](Fantasista.DNA.VcfFile.VcfColumnValue_T_.Name.md 'Fantasista.DNA.VcfFile.VcfColumnValue<T>.Name') | Name of the column |
| [Type](Fantasista.DNA.VcfFile.VcfColumnValue_T_.Type.md 'Fantasista.DNA.VcfFile.VcfColumnValue<T>.Type') | Type of the column (integer, float, string etc) |
| [Value](Fantasista.DNA.VcfFile.VcfColumnValue_T_.Value.md 'Fantasista.DNA.VcfFile.VcfColumnValue<T>.Value') | The value of type T |

| Methods | |
| :--- | :--- |
| [GetValue&lt;TI&gt;()](Fantasista.DNA.VcfFile.VcfColumnValue_T_.GetValue_TI_().md 'Fantasista.DNA.VcfFile.VcfColumnValue<T>.GetValue<TI>()') | Get value of type TI, which should be the same a T |
