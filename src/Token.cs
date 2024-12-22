namespace Ferris.Json;
public enum Token
{
    Unknown,
    None,
    EndOfInput,
    Whitespace,
    OpenBracket,
    CloseBracket,
    PropertyName,
    PropertyValue
}
