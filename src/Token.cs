namespace Ferris.Json;
internal enum Token
{
    Unknown,
    None,
    EndOfInput,
    Whitespace,
    OpenBrace,
    CloseBrace,
    PropertyName,
    PropertyValue,
    Comma,
    Colon
}
