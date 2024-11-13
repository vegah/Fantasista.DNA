namespace Fantasista.DNA.VcfFile;

public enum TokenType
{
    Start,
    End,
    Equal,
    Identifier,
    Quote,
    Comma,
    Whitespace
}

public class Token(TokenType tokenType, string value)
{
    public TokenType TokenType { get; } = tokenType;
    public string Value { get; } = value;
}