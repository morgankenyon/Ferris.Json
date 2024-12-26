namespace Ferris.Json;
internal enum Token
{
    Unknown,
    None,
    EndOfInput,
    Whitespace,
    OpenBracket,
    CloseBracket,
    PropertyName,
    PropertyValue,
    Comma,
    Colon
}
