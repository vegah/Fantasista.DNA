namespace Fantasista.DNA.VcfFile;

/// <summary>
/// Different tokens used in parsing the information in metadata fields
/// </summary>
internal enum TokenType
{
    Start,
    End,
    Equal,
    Identifier,
    Quote,
    Comma,
    Whitespace
}

/// <summary>
///  Describes a token
/// </summary>
/// <param name="tokenType">The tokentype</param>
/// <param name="value">The content of the token</param>
internal class Token(TokenType tokenType, string value)
{
    public TokenType TokenType { get; } = tokenType;
    public string Value { get; } = value;
}