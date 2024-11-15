namespace Fantasista.DNA.VcfFile.Exceptions;

/// <summary>
/// Thrown when the number of columns in the metadata mismatches with the number of columns with values
/// </summary>
/// <param name="s"></param>
public class ColumnMismatchException(string s) : Exception(s);