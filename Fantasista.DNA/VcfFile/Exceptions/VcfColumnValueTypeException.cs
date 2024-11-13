namespace Fantasista.DNA.VcfFile.Exceptions;

public class VcfColumnValueTypeException(Type expected, Type actual,string name)
    : Exception($"Cannot convert type {expected} to {actual} for column {name}");