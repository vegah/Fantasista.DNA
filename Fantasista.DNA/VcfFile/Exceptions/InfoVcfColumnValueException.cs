namespace Fantasista.DNA.VcfFile.Exceptions;

/// <summary>
/// Thrown when a description in the info meta data (or similar metadata field) is not being parsed correctly
/// </summary>
/// <param name="s">The error message</param>
public class InfoVcfColumnValueException(string s) : Exception(s);