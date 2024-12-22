namespace Ferris.Json.Test;
public class ValueParserTests
{
    [Theory(DisplayName = "Can find simple tokens")]
    [InlineData("", Token.None)]
    [InlineData("&", Token.Unknown)]
    [InlineData("{", Token.OpenBracket)]
    [InlineData("}", Token.CloseBracket)]
    [InlineData("\"Property\"", Token.PropertyName)]
    [InlineData(":283,", Token.PropertyValue)]
    public void JsonTransform_GetNextToken(string json, Token expectedToken)
    {
        //Act
        var token = JsonTransformer.GetNextToken(json);

        //Assert
        Assert.Equal(expectedToken, token);
    }

    [Theory(DisplayName = "Can find values to appropriate tokens")]
    [InlineData("", 0, null, Token.None)]
    [InlineData("&", 0, null, Token.Unknown)]
    [InlineData("{", 1, null, Token.OpenBracket)]
    [InlineData("}", 1, null, Token.CloseBracket)]
    [InlineData("\"Property\"", 10, "Property", Token.PropertyName)]
    [InlineData(":283,", 5, "283", Token.PropertyValue)]
    [InlineData(":\"data\",", 8, "data", Token.PropertyValue)]
    public void JsonTransform_GetNextTokenAndData(string json,
        int expectedPlaceholder,
        string expectedData,
        Token expectedToken)
    {
        //Act
        var (token, placeholder, data) = JsonTransformer.GetNextTokenAndData(json);

        //Assert
        Assert.Multiple(() =>
        {
            Assert.Equal(expectedToken, token);
            Assert.Equal(expectedPlaceholder, placeholder);
            Assert.Equal(expectedData, data);
        });
    }

    [Theory(DisplayName = "Can extract token data")]
    [InlineData("\"Property\"", "Property", Token.PropertyName)]
    [InlineData(":283,", "283", Token.PropertyValue)]
    [InlineData(":\"data\",", "data", Token.PropertyValue)]
    public void JsonTransform_ExtractTokenData(string json, string expectedData, Token token)
    {
        //Act
        var data = JsonTransformer.ExtractTokenData(token, json);

        //Assert
        Assert.Equal(expectedData, data);
    }
}
