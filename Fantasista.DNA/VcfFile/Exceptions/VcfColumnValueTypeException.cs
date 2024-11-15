namespace Fantasista.DNA.VcfFile.Exceptions;

/// <summary>
/// Thrown when a column value has one type but GetValue is called with a different type
/// </summary>
/// <param name="expected">The expected type</param>
/// <param name="actual">The type used on GetValue</param>
/// <param name="name">The name of the column</param>
public class VcfColumnValueTypeException(Type expected, Type actual,string name)
    : Exception($"Cannot convert type {expected} to {actual} for column {name}");