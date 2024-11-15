#### [Fantasista.DNA](index.md 'index')
### [Fantasista.DNA.VcfFile](Fantasista.DNA.VcfFile.md 'Fantasista.DNA.VcfFile').[VcfColumnValue&lt;T&gt;](Fantasista.DNA.VcfFile.VcfColumnValue_T_.md 'Fantasista.DNA.VcfFile.VcfColumnValue<T>')

## VcfColumnValue<T>.GetValue<TI>() Method

Get value of type TI, which should be the same a T

```csharp
public TI GetValue<TI>();
```
#### Type parameters

<a name='Fantasista.DNA.VcfFile.VcfColumnValue_T_.GetValue_TI_().TI'></a>

`TI`

The type of the column

Implements [GetValue&lt;T&gt;()](Fantasista.DNA.VcfFile.IVcfColumnValue.GetValue_T_().md 'Fantasista.DNA.VcfFile.IVcfColumnValue.GetValue<T>()')

#### Returns
[TI](Fantasista.DNA.VcfFile.VcfColumnValue_T_.GetValue_TI_().md#Fantasista.DNA.VcfFile.VcfColumnValue_T_.GetValue_TI_().TI 'Fantasista.DNA.VcfFile.VcfColumnValue<T>.GetValue<TI>().TI')  
The value as TI

#### Exceptions

[VcfColumnValueTypeException](Fantasista.DNA.VcfFile.Exceptions.VcfColumnValueTypeException.md 'Fantasista.DNA.VcfFile.Exceptions.VcfColumnValueTypeException')  
Thrown if T and TI mismatches