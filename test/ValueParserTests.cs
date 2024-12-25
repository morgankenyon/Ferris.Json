using Ferris.Json.Test.TestObjects;

namespace Ferris.Json.Test;
public class ValueParserTests
{
    [Theory(DisplayName = "Can find simple tokens")]
    [InlineData("", Token.EndOfInput, 0)]
    [InlineData("&", Token.Unknown, 0)]
    [InlineData("{", Token.OpenBracket, 0)]
    [InlineData("}", Token.CloseBracket, 0)]
    [InlineData("\"Property\"", Token.PropertyName, 0)]
    [InlineData(":283,", Token.PropertyValue, 0)]
    [InlineData(":{", Token.OpenBracket, 1)]
    public void JsonTransform_GetNextToken(
        string json,
        Token expectedToken,
        int expectedTokenOffset)
    {
        //Act
        var (token, tokenOffset) = JsonTransformer.GetNextToken(json, 0);

        //Assert
        Assert.Multiple(() =>
        {
            Assert.Equal(expectedToken, token);
            Assert.Equal(expectedTokenOffset, tokenOffset);
        });
    }

    [Theory(DisplayName = "Can find simple token with offset")]
    [InlineData("{", 1, Token.EndOfInput, 0)]
    [InlineData("{&", 1, Token.Unknown, 0)]
    [InlineData("{\"n\":{", 5, Token.OpenBracket, 0)]
    [InlineData("{}", 1, Token.CloseBracket, 0)]
    [InlineData("{\"Property\"", 1, Token.PropertyName, 0)]
    [InlineData("{\"Property\":283,", 11, Token.PropertyValue, 0)]
    [InlineData("{\"Property\":{", 11, Token.OpenBracket, 1)]
    public void JsonTransform_GetNextTokenWithOffset(
        string json,
        int offset,
        Token expectedToken,
        int expectedTokenOffset)
    {
        //Act
        var (token, tokenOffset) = JsonTransformer.GetNextToken(json, offset);

        //Assert
        Assert.Multiple(() =>
        {
            Assert.Equal(expectedToken, token);
            Assert.Equal(expectedTokenOffset, tokenOffset);
        });
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
    [InlineData("{\"Property\"", 1, "Property", 10, Token.PropertyName)]
    [InlineData("{:283,", 1, "283", 5, Token.PropertyValue)]
    [InlineData("{\"val\":\"data\",", 6, "data", 8, Token.PropertyValue)]
    [InlineData("{\"Property Baby\"", 1, "Property Baby", 15, Token.PropertyName)]
    [InlineData("{\"val\":283424,", 6, "283424", 8, Token.PropertyValue)]
    [InlineData("{\"val\":283424}", 6, "283424", 7, Token.PropertyValue)]
    [InlineData("{\"bobby\":\"data point\",", 8, "data point", 14, Token.PropertyValue)]
    [InlineData("{\"name\"", 1, "name", 6, Token.PropertyName)]
    ////[InlineData("{\"val\":283424", 6, "283424", 7, Token.PropertyValue)] //error case to cover
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

    [Fact(DisplayName = "Can extract simple tokens from string")]
    public void JsonTransform_ExtractSimpleTokens()
    {
        //Arrange
        var jsonString = "{\"name\":234}";

        //Act
        var tokenInfo = JsonTransformer.TokenizeString(jsonString);

        //Assert
        Assert.Equal(5, tokenInfo.Count);

        var tokens = tokenInfo.Select(ti => ti.token).ToList();
        var expectedTokens = new List<Token> {
            Token.OpenBracket,
            Token.PropertyName,
            Token.PropertyValue,
            Token.CloseBracket,
            Token.EndOfInput
        };

        Assert.Equal(expectedTokens, tokens);
    }

    [Fact(DisplayName = "Can extract more complex tokens from string")]
    public void JsonTransform_ExtractMoreComplexTokens()
    {
        //Arrange
        var jsonString = "{\"name\":234,\"value\":\"baby\",\"second\":{\"level\":23}}";

        //Act
        var tokenInfo = JsonTransformer.TokenizeString(jsonString);

        //Assert
        Assert.Equal(12, tokenInfo.Count);

        var tokens = tokenInfo.Select(ti => ti.token).ToList();
        var expectedTokens = new List<Token> {
            Token.OpenBracket,
            Token.PropertyName,
            Token.PropertyValue,
            Token.PropertyName,
            Token.PropertyValue,
            Token.PropertyName,
            Token.OpenBracket,
            Token.PropertyName,
            Token.PropertyValue,
            Token.CloseBracket,
            Token.CloseBracket,
            Token.EndOfInput
        };

        Assert.Equal(expectedTokens, tokens);
    }

    [Fact(DisplayName = "Can parse json string to object")]
    public void JsonTransform_ToObject_SingleStringProperty()
    {
        //Arrange
        var jsonString = "{\"Property\":\"testValue\"}";

        //Act
        var obj = JsonTransformer.ToObject<StringPropertyObj>(jsonString);

        //Assert
        Assert.True(obj is StringPropertyObj);

        var stringProp = obj as StringPropertyObj;
        Assert.Equal("testValue", stringProp.Property);
    }

    [Fact(DisplayName = "Can parse json number to object")]
    public void JsonTransform_ToObject_SingleIntProperty()
    {
        //Arrange
        var jsonString = "{\"Property\":293}";

        //Act
        var obj = JsonTransformer.ToObject<IntPropertyObj>(jsonString);

        //Assert
        Assert.True(obj is IntPropertyObj);

        var intProp = obj as IntPropertyObj;
        Assert.Equal(293, intProp.Property);
    }
}
