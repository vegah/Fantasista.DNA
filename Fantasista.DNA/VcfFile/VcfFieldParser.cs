﻿using System.Text;
using Fantasista.DNA.VcfFile.Exceptions;

namespace Fantasista.DNA.VcfFile;

/// <summary>
/// Class for parsing metadata fields containing information between lower than and greater than signs;  
/// </summary>
public static class VcfFieldParser
{
    /// <summary>
    /// A parser to parse metadata field that contains more information - for example Info
    /// It will parse fields with extra information between lower than and greater than signs
    /// </summary>
    /// <param name="s">The metadata excluding the ## </param>
    /// <returns>A dictionary with the parsed fields</returns>
    /// <exception cref="VcfFieldParserException">Thrown if the string is not parseable</exception>
    public static Dictionary<string, string> Parse(string s)
    {
        var retVal = new Dictionary<string, string>();
        var tokens = ParseTokens(s).Where(token=>token.TokenType!=TokenType.Whitespace  && token.TokenType!=TokenType.Quote).ToList();
        if (tokens[0].TokenType!=TokenType.Start) throw new VcfFieldParserException("Expected start token '<'");
        if (tokens[^1].TokenType!=TokenType.End) throw new VcfFieldParserException("Expected end token to end definition '>'");
        for (var x = 1; x < tokens.Count - 1; x+=3)
        {
            if (x != 1 && tokens[x].TokenType != TokenType.Comma)
                throw new VcfFieldParserException($"Expected ',', but found {tokens[x].Value}");
            if (tokens[x].TokenType == TokenType.Comma) x++;
            if (tokens[x].TokenType==TokenType.Identifier && tokens[x+1].TokenType==TokenType.Equal && tokens[x+2].TokenType==TokenType.Identifier)
                retVal.Add(tokens[x].Value, tokens[x+2].Value);
        }

        return retVal;
    }

    static IEnumerable<Token> ParseTokens(string s)
    {
        var currentString = new StringBuilder();
        for (var x = 0;x<s.Length;x++)
        {
            var ch = s[x];
            switch (ch)
            {
                case '<':
                    yield return new Token(TokenType.Start,"<");
                    break;
                case '>':
                    if (currentString.Length > 0)
                    {
                        yield return new Token(TokenType.Identifier,currentString.ToString());
                        currentString.Clear();
                    }
                    yield return new Token(TokenType.End,">");
                    break;
                case '=':
                    if (currentString.Length > 0)
                    {
                        yield return new Token(TokenType.Identifier,currentString.ToString());
                        currentString.Clear();
                    }
                    yield return new Token(TokenType.Equal,"=");
                    break;
                case '"':
                    yield return new Token(TokenType.Quote,"\"");
                    var tempCh = s[++x];
                    while (tempCh != '"')
                    {
                        currentString.Append(tempCh);
                        tempCh = s[++x];
                    }
                    yield return new Token(TokenType.Identifier,currentString.ToString());
                    currentString.Clear();
                    yield return new Token(TokenType.Quote,"\"");
                    break;
                case ',':
                    if (currentString.Length > 0)
                    {
                        yield return new Token(TokenType.Identifier,currentString.ToString());
                        currentString.Clear();
                    }
                    yield return new Token(TokenType.Comma,",");
                    break;
                default:
                {
                    if (char.IsLetter(ch) || char.IsDigit(ch) || ch=='_' || ch=='.')
                    {
                        currentString.Append(ch);
                    }
                    else throw new VcfFieldParserException("Unexpected character '" + ch + "'");

                    break;
                }
            }
        }
    }
}