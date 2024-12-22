namespace Ferris.Json.Test;
public class ValueParserTests
{
    [Theory(DisplayName = "Can find simple tokens")]
    [InlineData("", Token.EndOfInput)]
    [InlineData("&", Token.Unknown)]
    [InlineData("{", Token.OpenBracket)]
    [InlineData("}", Token.CloseBracket)]
    [InlineData("\"Property\"", Token.PropertyName)]
    [InlineData(":283,", Token.PropertyValue)]
    public void JsonTransform_GetNextToken(string json, Token expectedToken)
    {
        //Act
        var token = JsonTransformer.GetNextToken(json, 0);

        //Assert
        Assert.Equal(expectedToken, token);
    }

    [Theory(DisplayName = "Can find simple token with offset")]
    [InlineData("{", 1, Token.EndOfInput)]
    [InlineData("{&", 1, Token.Unknown)]
    [InlineData("{\"n\":{", 5, Token.OpenBracket)]
    [InlineData("{}", 1, Token.CloseBracket)]
    [InlineData("{\"Property\"", 1, Token.PropertyName)]
    [InlineData("{\"Property\":283,", 11, Token.PropertyValue)]
    public void JsonTransform_GetNextTokenWithOffset(
        string json,
        int offset,
        Token expectedToken)
    {
        //Act
        var token = JsonTransformer.GetNextToken(json, offset);

        //Assert
        Assert.Equal(expectedToken, token);
    }

    [Theory(DisplayName = "Can find values to appropriate tokens")]
    [InlineData("", 1, null, Token.EndOfInput)]
    [InlineData("&", 1, null, Token.Unknown)]
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
        var (token, placeholder, data) = JsonTransformer.GetNextTokenAndData(json, 0);

        //Assert
        Assert.Multiple(() =>
        {
            Assert.Equal(expectedToken, token);
            Assert.Equal(expectedPlaceholder, placeholder);
            Assert.Equal(expectedData, data);
        });
    }

    [Theory(DisplayName = "Can find offset values")]
    [InlineData("{\"name\"", 0, Token.OpenBracket, 1, null)]
    [InlineData("{\"name\"", 1, Token.PropertyName, 6, "name")]
    public void JsonTransform_GetNextTokenAndToken_IncorpratesOffset(
        string json,
        int offset,
        Token expectedToken,
        int expectedPlaceholder,
        string expectedData)
    {
        //Act
        var (token, placeholder, data) = JsonTransformer.GetNextTokenAndData(json, offset);

        //Assert
        Assert.Multiple(() =>
        {
            Assert.Equal(expectedToken, token);
            Assert.Equal(expectedPlaceholder, placeholder);
            Assert.Equal(expectedData, data);
        });

    }

    [Theory(DisplayName = "Can extract token data")]
    [InlineData("\"Property\"", "Property", 10, Token.PropertyName)]
    [InlineData(":283,", "283", 5, Token.PropertyValue)]
    [InlineData(":\"data\",", "data", 8, Token.PropertyValue)]
    [InlineData("\"Property Baby\"", "Property Baby", 15, Token.PropertyName)]
    [InlineData(":283424,", "283424", 8, Token.PropertyValue)]
    [InlineData(":\"data point\",", "data point", 14, Token.PropertyValue)]
    [InlineData("\"name\"", "name", 6, Token.PropertyName)]
    public void JsonTransform_ExtractTokenData(
        string json,
        string expectedData,
        int expectedLength,
        Token token)
    {
        //Act
        var (data, length) = JsonTransformer.ExtractTokenData(token, json, 0);

        //Assert
        Assert.Multiple(() =>
        {
            Assert.Equal(expectedData, data);
            Assert.Equal(expectedLength, length);
        });
    }

    [Theory(DisplayName = "Can extract token data")]
    //[InlineData("{\"Property\"", 1, "Property", 10, Token.PropertyName)]
    //[InlineData("{:283,", 1, "283", 5, Token.PropertyValue)]
    //[InlineData("{\"val\":\"data\",", 6, "data", 8, Token.PropertyValue)]
    //[InlineData("{\"Property Baby\"", 1, "Property Baby", 15, Token.PropertyName)]
    //[InlineData("{\"val\":283424,", 6, "283424", 8, Token.PropertyValue)]
    [InlineData("{\"val\":283424", 6, "283424", 7, Token.PropertyValue)]
    //[InlineData("{\"bobby\":\"data point\",", 8, "data point", 14, Token.PropertyValue)]
    //[InlineData("{\"name\"", 1, "name", 6, Token.PropertyName)]
    public void JsonTransform_ExtractTokenDataWithOffset(
        string json,
        int offset,
        string expectedData,
        int expectedLength,
        Token token)
    {
        //Act
        var (data, length) = JsonTransformer.ExtractTokenData(token, json, offset);

        //Assert
        Assert.Multiple(() =>
        {
            Assert.Equal(expectedData, data);
            Assert.Equal(expectedLength, length);
        });
    }

    [Fact(DisplayName = "Can extract all tokens from string")]
    public void JsonTransform_ExtractAllTokens()
    {
        //Arrange
        var jsonString = "{\"name\":234}";

        //Act
        var tokenInfo = JsonTransformer.TokenizeString(jsonString);

        //Assert
        Assert.Equal(4, tokenInfo.Count);
    }
}
