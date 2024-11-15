namespace Fantasista.DNA.VcfFile.Exceptions;

/// <summary>
/// Exception for when the field parser fails
/// </summary>
/// <param name="message">The error message</param>
public class VcfFieldParserException(string message) : Exception(message);