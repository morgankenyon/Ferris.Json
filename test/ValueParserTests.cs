using Ferris.Json.Test.TestObjects;
using FluentAssertions;

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
        var (token, tokenOffset) = JsonTransformer.GetNextToken(json);

        //Assert
        Assert.Multiple(() =>
        {
            Assert.Equal(expectedToken, token);
            Assert.Equal(expectedTokenOffset, tokenOffset);
        });
    }

    //This was leftover from when I was using strings versus
    //ReadOnlySpan<char>, see if we still need these tests
    //[Theory(DisplayName = "Can find simple token with offset")]
    //[InlineData("{", 1, Token.EndOfInput, 0)]
    //[InlineData("{&", 1, Token.Unknown, 0)]
    //[InlineData("{\"n\":{", 5, Token.OpenBracket, 0)]
    //[InlineData("{}", 1, Token.CloseBracket, 0)]
    //[InlineData("{\"Property\"", 1, Token.PropertyName, 0)]
    //[InlineData("{\"Property\":283,", 11, Token.PropertyValue, 0)]
    //[InlineData("{\"Property\":{", 11, Token.OpenBracket, 1)]
    //public void JsonTransform_GetNextTokenWithOffset(
    //    string json,
    //    int offset,
    //    Token expectedToken,
    //    int expectedTokenOffset)
    //{
    //    //Act
    //    var (token, tokenOffset) = JsonTransformer.GetNextToken(json, offset);

    //    //Assert
    //    Assert.Multiple(() =>
    //    {
    //        Assert.Equal(expectedToken, token);
    //        Assert.Equal(expectedTokenOffset, tokenOffset);
    //    });
    //}

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
        var (token, placeholder, data) = JsonTransformer.GetNextTokenAndData(json);

        //Assert
        Assert.Multiple(() =>
        {
            Assert.Equal(expectedToken, token);
            Assert.Equal(expectedPlaceholder, placeholder);
            Assert.Equal(expectedData, data);
        });
    }

    //This was leftover from when I was using strings versus
    //ReadOnlySpan<char>, see if this is still needed
    [Theory(DisplayName = "Can find offset values")]
    [InlineData("{\"name\"", Token.OpenBracket, 1, null)]
    [InlineData("\"name\"", Token.PropertyName, 6, "name")]
    public void JsonTransform_GetNextTokenAndToken_IncorpratesOffset(
        string json,
        Token expectedToken,
        int expectedPlaceholder,
        string expectedData)
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
        var (data, length) = JsonTransformer.ExtractTokenData(token, json);

        //Assert
        Assert.Multiple(() =>
        {
            Assert.Equal(expectedData, data);
            Assert.Equal(expectedLength, length);
        });
    }

    //Leftover from using strings instead of ReadOnlySpan<char>
    //[Theory(DisplayName = "Can extract token data")]
    //[InlineData("{\"Property\"", 1, "Property", 10, Token.PropertyName)]
    //[InlineData("{:283,", 1, "283", 5, Token.PropertyValue)]
    //[InlineData("{\"val\":\"data\",", 6, "data", 8, Token.PropertyValue)]
    //[InlineData("{\"Property Baby\"", 1, "Property Baby", 15, Token.PropertyName)]
    //[InlineData("{\"val\":283424,", 6, "283424", 8, Token.PropertyValue)]
    //[InlineData("{\"val\":283424}", 6, "283424", 7, Token.PropertyValue)]
    //[InlineData("{\"bobby\":\"data point\",", 8, "data point", 14, Token.PropertyValue)]
    //[InlineData("{\"name\"", 1, "name", 6, Token.PropertyName)]
    //////[InlineData("{\"val\":283424", 6, "283424", 7, Token.PropertyValue)] //error case to cover
    //public void JsonTransform_ExtractTokenDataWithOffset(
    //    string json,
    //    int offset,
    //    string expectedData,
    //    int expectedLength,
    //    Token token)
    //{
    //    //Act
    //    var (data, length) = JsonTransformer.ExtractTokenData(token, json, offset);

    //    //Assert
    //    Assert.Multiple(() =>
    //    {
    //        Assert.Equal(expectedData, data);
    //        Assert.Equal(expectedLength, length);
    //    });
    //}

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
    public void JsonTransform_Deserialize_SingleStringProperty()
    {
        //Arrange
        var jsonString = "{\"Property\":\"testValue\"}";

        //Act
        var obj = JsonTransformer.Deserialize<StringPropertyObj>(jsonString);

        //Assert
        Assert.True(obj is StringPropertyObj);

        var stringProp = obj as StringPropertyObj;
        Assert.Equal("testValue", stringProp.Property);
    }

    [Fact(DisplayName = "Can parse json number to integer")]
    public void JsonTransform_Deserialize_SingleIntProperty()
    {
        //Arrange
        var maxValue = int.MaxValue;
        var jsonString = $"{{\"Property\":{maxValue}}}";

        //Act
        var obj = JsonTransformer.Deserialize<IntPropertyObj>(jsonString);

        //Assert
        Assert.True(obj is IntPropertyObj);

        var intProp = obj as IntPropertyObj;
        Assert.Equal(maxValue, intProp.Property);
    }

    [Fact(DisplayName = "Can parse json number to uint")]
    public void JsonTransform_Deserialize_SingleUIntProperty()
    {
        //Arrange
        var maxValue = uint.MaxValue;
        var jsonString = $"{{\"Property\":{maxValue}}}";

        //Act
        var obj = JsonTransformer.Deserialize<UIntPropertyObj>(jsonString);

        //Assert
        Assert.True(obj is UIntPropertyObj);

        var intProp = obj as UIntPropertyObj;
        intProp.Property.Should().Be(maxValue);
    }

    [Fact(DisplayName = "Can parse json number to float")]
    public void JsonTransform_Deserialize_SingleFloatProperty()
    {
        //Arrange
        var maxValue = float.MaxValue;
        var jsonString = $"{{\"Property\":{maxValue}}}";

        //Act
        var obj = JsonTransformer.Deserialize<FloatPropertyObj>(jsonString);

        //Assert
        Assert.True(obj is FloatPropertyObj);

        var floatProp = obj as FloatPropertyObj;
        floatProp.Property.Should().BeApproximately(maxValue, 0.01f);
    }

    [Fact(DisplayName = "Can parse json number to double")]
    public void JsonTransform_Deserialize_SingleDoubleProperty()
    {
        //Arrange
        var maxValue = double.MaxValue;
        var jsonString = $"{{\"Property\":{maxValue}}}";

        //Act
        var obj = JsonTransformer.Deserialize<DoublePropertyObj>(jsonString);

        //Assert
        Assert.True(obj is DoublePropertyObj);

        var prop = obj as DoublePropertyObj;
        prop.Property.Should().BeApproximately(maxValue, 0.01);
    }

    [Fact(DisplayName = "Can parse json bool to object")]
    public void JsonTransform_Deserialize_SingleBoolProperty()
    {
        //Arrange
        var jsonString = "{\"Property\":true}";

        //Act
        var obj = JsonTransformer.Deserialize<BoolPropertyObj>(jsonString);

        //Assert
        Assert.True(obj is BoolPropertyObj);

        var prop = obj as BoolPropertyObj;
        prop.Property.Should().BeTrue();
    }

    [Fact(DisplayName = "Can parse json number to byte")]
    public void JsonTransform_Deserialize_SingleByteProperty()
    {
        //Arrange
        var maxValue = byte.MaxValue;
        var jsonString = $"{{\"Property\":{maxValue}}}";

        //Act
        var obj = JsonTransformer.Deserialize<BytePropertyObj>(jsonString);

        //Assert
        Assert.True(obj is BytePropertyObj);

        var prop = obj as BytePropertyObj;
        prop.Property.Should().Be(maxValue);
    }

    [Fact(DisplayName = "Can parse json number to sbyte")]
    public void JsonTransform_Deserialize_SingleSByteProperty()
    {
        //Arrange
        var maxValue = sbyte.MaxValue;
        var jsonString = $"{{\"Property\":{maxValue}}}";

        //Act
        var obj = JsonTransformer.Deserialize<SBytePropertyObj>(jsonString);

        //Assert
        Assert.True(obj is SBytePropertyObj);

        var prop = obj as SBytePropertyObj;
        prop.Property.Should().Be(maxValue);
    }

    [Fact(DisplayName = "Can parse json char to object")]
    public void JsonTransform_Deserialize_SingleCharProperty()
    {
        //Arrange
        var jsonString = "{\"Property\":\"a\"}";

        //Act
        var obj = JsonTransformer.Deserialize<CharPropertyObj>(jsonString);

        //Assert
        Assert.True(obj is CharPropertyObj);

        var prop = obj as CharPropertyObj;
        prop.Property.Should().Be('a');
    }

    [Fact(DisplayName = "Can parse json number to decimal")]
    public void JsonTransform_Deserialize_SingleDecimalProperty()
    {
        //Arrange
        var maxValue = decimal.MaxValue;
        var jsonString = $"{{\"Property\":{maxValue}}}";

        //Act
        var obj = JsonTransformer.Deserialize<DecimalPropertyObj>(jsonString);

        //Assert
        Assert.True(obj is DecimalPropertyObj);

        var prop = obj as DecimalPropertyObj;
        prop.Property.Should().Be(maxValue);
    }

    [Fact(DisplayName = "Can parse json number to long")]
    public void JsonTransform_Deserialize_SingleLongProperty()
    {
        //Arrange
        var maxValue = long.MaxValue;
        var jsonString = $"{{\"Property\":{maxValue}}}";

        //Act
        var obj = JsonTransformer.Deserialize<LongPropertyObj>(jsonString);

        //Assert
        Assert.True(obj is LongPropertyObj);

        var prop = obj as LongPropertyObj;
        prop.Property.Should().Be(maxValue);
    }

    [Fact(DisplayName = "Can parse json number to ulong")]
    public void JsonTransform_Deserialize_SingleULongProperty()
    {
        //Arrange
        var maxValue = ulong.MaxValue;
        var jsonString = $"{{\"Property\":{maxValue}}}";

        //Act
        var obj = JsonTransformer.Deserialize<ULongPropertyObj>(jsonString);

        //Assert
        Assert.True(obj is ULongPropertyObj);

        var prop = obj as ULongPropertyObj;
        prop.Property.Should().Be(maxValue);
    }

    [Fact(DisplayName = "Can parse json number to int128")]
    public void JsonTransform_Deserialize_SingleInt128Property()
    {
        //Arrange
        var maxValue = Int128.MaxValue;
        var jsonString = $"{{\"Property\":{maxValue}}}";

        //Act
        var obj = JsonTransformer.Deserialize<Int128PropertyObj>(jsonString);

        //Assert
        Assert.True(obj is Int128PropertyObj);

        var prop = obj as Int128PropertyObj;
        prop.Property.Should().Be(maxValue);
    }

    [Fact(DisplayName = "Can parse json number to uint128")]
    public void JsonTransform_Deserialize_SingleUInt128Property()
    {
        //Arrange
        var maxValue = UInt128.MaxValue;
        var jsonString = $"{{\"Property\":{maxValue}}}";

        //Act
        var obj = JsonTransformer.Deserialize<UInt128PropertyObj>(jsonString);

        //Assert
        Assert.True(obj is UInt128PropertyObj);

        var prop = obj as UInt128PropertyObj;
        prop.Property.Should().Be(maxValue);
    }

    [Fact(DisplayName = "Can parse json number to short")]
    public void JsonTransform_Deserialize_SingleShortProperty()
    {
        //Arrange
        var maxValue = short.MaxValue;
        var jsonString = $"{{\"Property\":{maxValue}}}";

        //Act
        var obj = JsonTransformer.Deserialize<ShortPropertyObj>(jsonString);

        //Assert
        Assert.True(obj is ShortPropertyObj);

        var prop = obj as ShortPropertyObj;
        prop.Property.Should().Be(maxValue);
    }

    [Fact(DisplayName = "Can parse json number to ushort")]
    public void JsonTransform_Deserialize_SingleUShortProperty()
    {
        //Arrange
        var maxValue = ushort.MaxValue;
        var jsonString = $"{{\"Property\":{maxValue}}}";

        //Act
        var obj = JsonTransformer.Deserialize<UShortPropertyObj>(jsonString);

        //Assert
        Assert.True(obj is UShortPropertyObj);

        var prop = obj as UShortPropertyObj;
        prop.Property.Should().Be(maxValue);
    }

    [Fact(DisplayName = "Can parse json to value test object")]
    public void JsonTransform_Deserialize_ValueTestObject()
    {
        //Arrange
        var json = TestObjs.GetValueTestObjectJson();

        //Act
        var obj = JsonTransformer.Deserialize<ValueTestObject>(json);

        //Assert
        obj.BoolProp.Should().BeTrue();
        obj.ByteProp.Should().Be(byte.MaxValue);
        obj.SByteProp.Should().Be(sbyte.MaxValue);
        obj.CharProp.Should().Be(char.MaxValue);
        obj.DecimalProp.Should().Be(decimal.MaxValue);
        obj.DoubleProp.Should().Be(double.MaxValue);
        obj.FloatProp.Should().Be(float.MaxValue);
        obj.IntProp.Should().Be(int.MaxValue);
        obj.UIntProp.Should().Be(uint.MaxValue);
        obj.LongProp.Should().Be(long.MaxValue);
        obj.ULongProp.Should().Be(ulong.MaxValue);
        obj.Int128Prop.Should().Be(Int128.MaxValue);
        obj.UInt128Prop.Should().Be(UInt128.MaxValue);
        obj.ShortProp.Should().Be(short.MaxValue);
        obj.UShortProp.Should().Be(ushort.MaxValue);
        obj.StringProp.Should().Be("maxValue");
    }

    [Fact(DisplayName = "Can parse json date to DateTime")]
    public void JsonTransform_Deserialize_SingleDateTimeProperty()
    {
        //Arrange
        var maxValue = DateTime.MaxValue;
        var jsonString = $"{{\"Property\":{maxValue}}}";

        //Act
        var obj = JsonTransformer.Deserialize<DateTimePropertyObj>(jsonString);

        //Assert
        Assert.True(obj is DateTimePropertyObj);

        var prop = obj as DateTimePropertyObj;
        prop.Property.Should().BeAfter(maxValue.AddSeconds(-1));
    }

    [Fact(DisplayName = "Can parse nested json")]
    public void JsonTransform_Deserialize_ParseNestedString()
    {
        //Arrange
        var maxValue = DateTime.MaxValue;
        var jsonString = "{\"Property\":{\"Property\":\"maxValue\"}}";

        //Act
        var obj = JsonTransformer.Deserialize<NestedStringObj>(jsonString);

        //Assert
        Assert.True(obj is NestedStringObj);

        var prop = obj as NestedStringObj;
        prop.Property.Should().NotBeNull();
        prop.Property.Property.Should().Be("maxValue");
    }
}
