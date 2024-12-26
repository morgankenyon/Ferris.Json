namespace Ferris.Json;
internal static class TokenExtensions
{
    internal static bool IsUnknown(this Token token) =>
        token == Token.Unknown;
    internal static bool IsNone(this Token token) =>
        token == Token.None;
    internal static bool IsEndOfInput(this Token token) =>
        token == Token.EndOfInput;
    internal static bool IsWhitespace(this Token token) =>
        token == Token.Whitespace;
    internal static bool IsOpenBrace(this Token token) =>
        token == Token.OpenBrace;
    internal static bool IsCloseBrace(this Token token) =>
        token == Token.CloseBrace;
    internal static bool IsPropertyName(this Token token) =>
        token == Token.PropertyName;
    internal static bool IsPropertyValue(this Token token) =>
        token == Token.PropertyValue;
    internal static bool IsComma(this Token token) =>
        token == Token.Comma;
    internal static bool IsColon(this Token token) =>
        token == Token.Colon;
}
