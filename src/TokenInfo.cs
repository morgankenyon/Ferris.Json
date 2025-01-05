namespace Ferris.Json;
internal class TokenInfo
{
    public TokenInfo(Token token, int length)
    {
        Token = token;
        Length = length;
        HasValue = false;
    }

    public TokenInfo(
        Token token,
        int length,
        object data) : this(token, length)
    {
        HasValue = true;
        Data = data;
    }

    public Token Token { get; }
    public int Length { get; }
    public bool HasValue { get; }
    public object? Data { get; }
}
