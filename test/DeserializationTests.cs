using Ferris.Json.Test.TestObjects;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Xunit;

namespace Ferris.Json.Test
{
    public class DeserializationTests
    {
        [Theory(DisplayName = "Can find simple tokens")]
        [InlineData("", Token.None, Token.EndOfInput)]
        [InlineData("&", Token.None, Token.Unknown)]
        [InlineData("{", Token.None, Token.OpenBrace)]
        [InlineData("}", Token.PropertyValue, Token.CloseBrace)]
        [InlineData("[", Token.None, Token.OpenBracket)]
        [InlineData("]", Token.PropertyValue, Token.CloseBracket)]
        [InlineData(",", Token.PropertyValue, Token.Comma)]
        [InlineData("\"Property\"", Token.Comma, Token.PropertyName)]
        [InlineData("283,", Token.Colon, Token.PropertyValue)]
        [InlineData(":{", Token.PropertyName, Token.Colon)]
        [InlineData(" ", Token.None, Token.Whitespace)]
        internal void JsonTransform_GetNextToken(
            string json,
            Token previousToken,
            Token expectedToken)
        {
            //Act
            var token = JsonTransformer.GetNextToken(previousToken, json.AsSpan());

            //Assert
            token.Should().Be(expectedToken);
        }

        [Theory(DisplayName = "Can find values to appropriate tokens")]
        [InlineData("", Token.None, 1, false, null, Token.EndOfInput)]
        [InlineData("&", Token.None, 1, false, null, Token.Unknown)]
        [InlineData("{", Token.None, 1, false, null, Token.OpenBrace)]
        [InlineData("}", Token.PropertyValue, 1, false, null, Token.CloseBrace)]
        [InlineData("\"Property\"", Token.OpenBrace, 10, true, "Property", Token.PropertyName)]
        [InlineData("283,", Token.Colon, 3, true, "283", Token.PropertyValue)]
        [InlineData("283]},", Token.Colon, 3, true, "283", Token.PropertyValue)]
        [InlineData("283],}", Token.Colon, 3, true, "283", Token.PropertyValue)]
        [InlineData("283,]}", Token.Colon, 3, true, "283", Token.PropertyValue)]
        [InlineData("283,}]", Token.Colon, 3, true, "283", Token.PropertyValue)]
        [InlineData("283}],", Token.Colon, 3, true, "283", Token.PropertyValue)]
        [InlineData("283},]", Token.Colon, 3, true, "283", Token.PropertyValue)]
        [InlineData("283}", Token.Colon, 3, true, "283", Token.PropertyValue)]
        [InlineData("\"data\",", Token.Colon, 6, true, "data", Token.PropertyValue)]
        [InlineData("     ", Token.None, 5, false, null, Token.Whitespace)]
        [InlineData("\"one\\\"one\"", Token.Colon, 10, true, "one\\\"one", Token.PropertyValue)]
        [InlineData("\"\\\"\"", Token.Colon, 4, true, "\\\"", Token.PropertyValue)]
        [InlineData("\"\"", Token.Colon, 2, true, "", Token.PropertyValue)]
        [InlineData("\"What\\\"s that\\\"s got\\\"s to\\\"s do\"", Token.Colon, 33, true, "What\\\"s that\\\"s got\\\"s to\\\"s do", Token.PropertyValue)]
        internal void JsonTransform_GetNextTokenAndData(string json,
            Token previousToken,
            int expectedPlaceholder,
            bool expectedHasValue,
            string expectedData,
            Token expectedToken)
        {
            //Act
            var tokenInfo = JsonTransformer.GetNextTokenAndData(previousToken, json.AsSpan());

            //Assert
            tokenInfo.Token.Should().Be(expectedToken);
            tokenInfo.Length.Should().Be(expectedPlaceholder);
            tokenInfo.HasValue.Should().Be(expectedHasValue);
            tokenInfo.Data.Should().Be(expectedData);
        }

        [Theory(DisplayName = "Can extract token data")]
        [InlineData("\"Property\"", "Property", 10, Token.PropertyName)]
        [InlineData("283,", "283", 3, Token.PropertyValue)]
        [InlineData("283},", "283", 3, Token.PropertyValue)]
        [InlineData("\"data\",", "data", 6, Token.PropertyValue)]
        [InlineData("\"Property Baby\"", "Property Baby", 15, Token.PropertyName)]
        [InlineData("283424,", "283424", 6, Token.PropertyValue)]
        [InlineData("\"data point\",", "data point", 12, Token.PropertyValue)]
        [InlineData("\"name\"", "name", 6, Token.PropertyName)]
        [InlineData("\"maxValue\"},", "maxValue", 10, Token.PropertyValue)]
        [InlineData("\"null\"},", "null", 6, Token.PropertyValue)]
        [InlineData("\"null\",", "null", 6, Token.PropertyValue)]
        internal void JsonTransform_ExtractTokenData(
            string json,
            string expectedData,
            int expectedLength,
            Token token)
        {
            //Act
            var tokenInfo = JsonTransformer.ExtractTokenData(token, json.AsSpan());

            //Assert
            tokenInfo.Length.Should().Be(expectedLength);
            tokenInfo.Data.Should().Be(expectedData);
        }

        [Fact(DisplayName = "Can extract simple tokens from string")]
        public void JsonTransform_ExtractSimpleTokens()
        {
            //Arrange
            var jsonString = "{\"name\":234}";

            //Act
            var tokenInfo = JsonTransformer.TokenizeString(jsonString);

            //Assert
            var expectedTokens = new List<Token> {
                Token.OpenBrace,
                Token.PropertyName,
                Token.Colon,
                Token.PropertyValue,
                Token.CloseBrace,
                Token.EndOfInput
            };
            Assert.Equal(expectedTokens.Count, tokenInfo.Count);

            var tokens = tokenInfo.Select(ti => ti.Token).ToList();

            Assert.Equal(expectedTokens, tokens);
        }

        [Fact(DisplayName = "Can extract simple tokens from string with whitespace")]
        public void JsonTransform_ExtractWhitespaceTokens()
        {
            //Arrange
            var jsonString = " { \"name\" : 234 } ";

            //Act
            var tokenInfo = JsonTransformer.TokenizeString(jsonString);

            //Assert
            var expectedTokens = new List<Token> {
                Token.Whitespace,
                Token.OpenBrace,
                Token.Whitespace,
                Token.PropertyName,
                Token.Whitespace,
                Token.Colon,
                Token.Whitespace,
                Token.PropertyValue,
                //Token.Whitespace, //not sure if this token is needed
                Token.CloseBrace,
                Token.Whitespace,
                Token.EndOfInput
            };
            Assert.Equal(expectedTokens.Count, tokenInfo.Count);

            var tokens = tokenInfo.Select(ti => ti.Token).ToList();

            Assert.Equal(expectedTokens, tokens);
        }

        [Fact(DisplayName = "Can extract tokens from nested string")]
        public void JsonTransform_CanExtractNestedTokens()
        {
            //Arrange
            var jsonString = "{\"IntProp\":{\"Property\":234},\"Number\":4242}";

            //Act
            var tokenInfo = JsonTransformer.TokenizeString(jsonString);

            //Assert
            var expectedTokens = new List<Token> {
                Token.OpenBrace,
                Token.PropertyName,
                Token.Colon,
                Token.OpenBrace,
                Token.PropertyName,
                Token.Colon,
                Token.PropertyValue,
                Token.CloseBrace,
                Token.Comma,
                Token.PropertyName,
                Token.Colon,
                Token.PropertyValue,
                Token.CloseBrace,
                Token.EndOfInput
            };
            Assert.Equal(expectedTokens.Count, tokenInfo.Count);

            var tokens = tokenInfo.Select(ti => ti.Token).ToList();

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
            var expectedTokens = new List<Token> {
                Token.OpenBrace,
                Token.PropertyName,
                Token.Colon,
                Token.PropertyValue,
                Token.Comma,
                Token.PropertyName,
                Token.Colon,
                Token.PropertyValue,
                Token.Comma,
                Token.PropertyName,
                Token.Colon,
                Token.OpenBrace,
                Token.PropertyName,
                Token.Colon,
                Token.PropertyValue,
                Token.CloseBrace,
                Token.CloseBrace,
                Token.EndOfInput
            };
            Assert.Equal(expectedTokens.Count, tokenInfo.Count);

            var tokens = tokenInfo.Select(ti => ti.Token).ToList();

            Assert.Equal(expectedTokens, tokens);
        }

        [Theory(DisplayName = "Can parse json string to object")]
        [InlineData("{\"Property\":\"testValue\"}", false)]
        [InlineData(" { \"Property\" : \"testValue\" } ", false)]
        [InlineData("       {        \"Property\"             :          \"testValue\"     }   ", false)]
        [InlineData("{\"Property\":null}", true)]
        [InlineData(" { \"Property\" : null } ", true)]
        public void JsonTransform_Deserialize_SingleStringProperty(
            string jsonString,
            bool isNull)
        {
            //Act
            var obj = JsonTransformer.Deserialize<StringPropertyObj>(jsonString);

            //Assert
            obj.Should().BeOfType<StringPropertyObj>();

            var stringProp = obj as StringPropertyObj;
            if (isNull)
                obj.Property.Should().BeNull();
            else
                obj.Property.Should().Be("testValue");
        }

        [Theory(DisplayName = "Can parse string with escaped double quotes")]
        [InlineData("{\"Property\":\"mo\\\"s\"}", "mo\\\"s")]
        [InlineData("{\"Property\":\"What\\\"s that\\\"s got\\\"s to\\\"s do\"}", "What\\\"s that\\\"s got\\\"s to\\\"s do")]
        public void JsonTransform_Deserialize_EscapedStringProperty(
            string jsonString,
            string expectedValue)
        {
            //Act
            var obj = JsonTransformer.Deserialize<StringPropertyObj>(jsonString);

            //Assert
            obj.Should().BeOfType<StringPropertyObj>();

            var stringProp = obj as StringPropertyObj;
            obj.Property.Should().Be(expectedValue);
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
            var jsonString = $"{{\"Property\":{maxValue.ToString("R", CultureInfo.InvariantCulture)}}}";

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
            var jsonString = $"{{\"Property\":{maxValue.ToString("R", CultureInfo.InvariantCulture)}}}";

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

        //[Fact(DisplayName = "Can parse json number to int128")]
        //public void JsonTransform_Deserialize_SingleInt128Property()
        //{
        //    //Arrange
        //    var maxValue = Int128.MaxValue;
        //    var jsonString = $"{{\"Property\":{maxValue}}}";

        //    //Act
        //    var obj = JsonTransformer.Deserialize<Int128PropertyObj>(jsonString);

        //    //Assert
        //    Assert.True(obj is Int128PropertyObj);

        //    var prop = obj as Int128PropertyObj;
        //    prop.Property.Should().Be(maxValue);
        //}

        //[Fact(DisplayName = "Can parse json number to uint128")]
        //public void JsonTransform_Deserialize_SingleUInt128Property()
        //{
        //    //Arrange
        //    var maxValue = UInt128.MaxValue;
        //    var jsonString = $"{{\"Property\":{maxValue}}}";

        //    //Act
        //    var obj = JsonTransformer.Deserialize<UInt128PropertyObj>(jsonString);

        //    //Assert
        //    Assert.True(obj is UInt128PropertyObj);

        //    var prop = obj as UInt128PropertyObj;
        //    prop.Property.Should().Be(maxValue);
        //}

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
            //obj.Int128Prop.Should().Be(Int128.MaxValue);
            //obj.UInt128Prop.Should().Be(UInt128.MaxValue);
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

        [Fact(DisplayName = "Can parse nested json")]
        public void JsonTransform_Deserialize_ParseNestedNullValue()
        {
            //Arrange
            var maxValue = DateTime.MaxValue;
            var jsonString = "{\"Property\":null}";

            //Act
            var obj = JsonTransformer.Deserialize<NestedStringObj>(jsonString);

            //Assert
            Assert.True(obj is NestedStringObj);

            var prop = obj as NestedStringObj;
            prop.Property.Should().BeNull();
        }

        [Fact(DisplayName = "Can parse triple property json")]
        public void JsonTransform_Deserialize_ParseTriplePropertyJson()
        {
            //Arrange
            var maxValue = DateTime.MaxValue;
            var jsonString = "{\"IntProp\":2342,\"StringProp\":\"max\",\"DoubleProp\":232.23}";

            //Act
            var obj = JsonTransformer.Deserialize<TriplePropertyObj>(jsonString);

            //Assert
            Assert.True(obj is TriplePropertyObj);

            var prop = obj as TriplePropertyObj;
            prop.IntProp.Should().Be(2342);
            prop.StringProp.Should().NotBeNull();
            prop.StringProp.Should().Be("max");
            prop.DoubleProp.Should().BeApproximately(232.23, 0.01);
        }

        [Fact(DisplayName = "Can parse more complex json")]
        public void JsonTransform_Deserialize_ParseMultipleNestedString()
        {
            //Arrange
            var maxValue = DateTime.MaxValue;
            var jsonString = "{\"StringProp\":{\"Property\":\"maxValue\"},\"IntProp\":{\"Property\":234},\"Number\":4242}";

            //Act
            var obj = JsonTransformer.Deserialize<NestedMultipleObj>(jsonString);

            //Assert
            Assert.True(obj is NestedMultipleObj);

            var prop = obj as NestedMultipleObj;
            prop.StringProp.Should().NotBeNull();
            prop.StringProp.Property.Should().Be("maxValue");
            prop.IntProp.Should().NotBeNull();
            prop.IntProp.Property.Should().Be(234);
            prop.Number.Should().Be(4242);
        }

        [Fact(DisplayName = "Can parse a json array to C# List")]
        public void JsonTransform_Deserialize_ParseToList()
        {
            //Arrange
            var jsonString = "{\"Strings\":[{\"Property\":\"FirstString\"},{\"Property\":\"SecondString\"}]}";

            //Act
            var obj = JsonTransformer.Deserialize<ListTestObj>(jsonString);

            //Assert
            obj.Should().BeOfType<ListTestObj>();

            var prop = obj as ListTestObj;
            prop.Strings.Should().NotBeNull();
            prop.Strings.Should().HaveCount(2);
            prop.Strings.First().Property.Should().Be("FirstString");
            prop.Strings.Last().Property.Should().Be("SecondString");
        }

        [Fact(DisplayName = "Can parse a json array to C# LinkedList", Skip = "Not supporting LinkedLists for now")]
        public void JsonTransform_Deserialize_ParseToLinkedList()
        {
            //Arrange
            var jsonString = "{\"Strings\":[{\"Property\":\"FirstString\"},{\"Property\":\"SecondString\"}]}";

            //Act
            var obj = JsonTransformer.Deserialize<LinkedListObj>(jsonString);

            //Assert
            obj.Should().BeOfType<LinkedListObj>();

            var prop = obj as LinkedListObj;
            prop.Strings.Should().NotBeNull();
            prop.Strings.Should().HaveCount(2);
            prop.Strings.First().Property.Should().Be("FirstString");
            prop.Strings.Last().Property.Should().Be("SecondString");
        }

        [Fact(DisplayName = "Can parse a json array to C# array")]
        public void JsonTransform_Deserialize_ParseToArray()
        {
            //Arrange
            var jsonString = "{\"Strings\":[{\"Property\":\"FirstString\"},{\"Property\":\"SecondString\"}]}";

            //Act
            var obj = JsonTransformer.Deserialize<ArrayTestObj>(jsonString);

            //Assert
            obj.Should().BeOfType<ArrayTestObj>();

            var prop = obj as ArrayTestObj;
            prop.Strings.Should().NotBeNull();
            prop.Strings.Should().HaveCount(2);
            prop.Strings.First().Property.Should().Be("FirstString");
            prop.Strings.Last().Property.Should().Be("SecondString");
        }

        [Fact(DisplayName = "Can parse json array to bool list")]
        public void JsonTransformer_Deserialize_ParseToBoolList()
        {
            //Arrange
            var jsonString = "{\"Values\":[true,false,true]}";

            //Act
            var obj = JsonTransformer.Deserialize<BoolListTestObj>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Values.Should()
                .BeEquivalentTo(new List<bool> { true, false, true });
        }

        [Fact(DisplayName = "Can parse json array to byte list")]
        public void JsonTransformer_Deserialize_ParseToByteList()
        {
            //Arrange
            var jsonString = $"{{\"Values\":[{byte.MinValue},{byte.MaxValue},{byte.MinValue}]}}";

            //Act
            var obj = JsonTransformer.Deserialize<ByteListTestObj>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Values.Should()
                .BeEquivalentTo(new List<byte> { byte.MinValue, byte.MaxValue, byte.MinValue });
        }

        [Fact(DisplayName = "Can parse json array to sbyte list")]
        public void JsonTransformer_Deserialize_ParseToSByteList()
        {
            //Arrange
            var jsonString = $"{{\"Values\":[{sbyte.MinValue},{sbyte.MaxValue},{sbyte.MinValue}]}}";

            //Act
            var obj = JsonTransformer.Deserialize<SByteListTestObj>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Values.Should()
                .BeEquivalentTo(new List<sbyte> { sbyte.MinValue, sbyte.MaxValue, sbyte.MinValue });
        }

        [Fact(DisplayName = "Can parse json array to char list")]
        public void JsonTransformer_Deserialize_ParseToCharList()
        {
            //Arrange
            var jsonString = $"{{\"Values\":[{sbyte.MinValue},{sbyte.MaxValue},{sbyte.MinValue}]}}";

            //Act
            var obj = JsonTransformer.Deserialize<SByteListTestObj>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Values.Should()
                .BeEquivalentTo(new List<sbyte> { sbyte.MinValue, sbyte.MaxValue, sbyte.MinValue });
        }

        [Fact(DisplayName = "Can parse json array to datetime list")]
        public void JsonTransformer_Deserialize_ParseToDateTimeList()
        {
            //Arrange
            var jsonString = $"{{\"Values\":[\"{DateTime.MinValue}\",\"{DateTime.MaxValue}\",\"{DateTime.MinValue}\"]}}";

            //Act
            var obj = JsonTransformer.Deserialize<DateTimeListTestObj>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Values.First().Should().Be(DateTime.MinValue);
            obj.Values.Skip(1).First().Should().BeCloseTo(DateTime.MaxValue, TimeSpan.FromSeconds(1));
            obj.Values.Last().Should().Be(DateTime.MinValue);
            //obj.Values.Should()
            //    .BeEquivalentTo(new List<DateTime> { DateTime.MinValue, DateTime.MaxValue, DateTime.MinValue });
        }

        [Fact(DisplayName = "Can parse json array to decimal list")]
        public void JsonTransformer_Deserialize_ParseToDecimalList()
        {
            //Arrange
            var jsonString = $"{{\"Values\":[{decimal.MinValue},{decimal.MaxValue},{decimal.MinValue}]}}";

            //Act
            var obj = JsonTransformer.Deserialize<DecimalListTestObj>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Values.Should()
                .BeEquivalentTo(new List<decimal> { decimal.MinValue, decimal.MaxValue, decimal.MinValue });
        }

        [Fact(DisplayName = "Can parse json array to double list")]
        public void JsonTransformer_Deserialize_ParseToDoubleList()
        {
            //Arrange
            var jsonString = $"{{\"Values\":[{double.MinValue.ToString("R", CultureInfo.InvariantCulture)},{double.MaxValue.ToString("R", CultureInfo.InvariantCulture)},{double.MinValue.ToString("R", CultureInfo.InvariantCulture)}]}}";

            //Act
            var obj = JsonTransformer.Deserialize<DoubleListTestObj>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Values.Should()
                .BeEquivalentTo(new List<double> { double.MinValue, double.MaxValue, double.MinValue });
        }

        [Fact(DisplayName = "Can parse json array to float list")]
        public void JsonTransformer_Deserialize_ParseToFloatList()
        {
            //Arrange
            var jsonString = $"{{\"Values\":[{float.MinValue.ToString("R", CultureInfo.InvariantCulture)},{float.MaxValue.ToString("R", CultureInfo.InvariantCulture)},{float.MinValue.ToString("R", CultureInfo.InvariantCulture)}]}}";

            //Act
            var obj = JsonTransformer.Deserialize<FloatListTestObj>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Values.Should()
                .BeEquivalentTo(new List<float> { float.MinValue, float.MaxValue, float.MinValue });
        }

        [Fact(DisplayName = "Can parse json array to int list")]
        public void JsonTransformer_Deserialize_ParseToIntList()
        {
            //Arrange
            var jsonString = "{\"Values\":[1, 2, 3]}";

            //Act
            var obj = JsonTransformer.Deserialize<IntListTestObj>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Values.Should()
                .BeEquivalentTo(new List<int> { 1, 2, 3 });
        }

        [Fact(DisplayName = "Can parse json array to uint list")]
        public void JsonTransformer_Deserialize_ParseToUIntList()
        {
            //Arrange
            var jsonString = $"{{\"Values\":[{uint.MinValue},{uint.MaxValue},{uint.MinValue}]}}";

            //Act
            var obj = JsonTransformer.Deserialize<UIntListTestObj>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Values.Should()
                .BeEquivalentTo(new List<uint> { uint.MinValue, uint.MaxValue, uint.MinValue });
        }

        [Fact(DisplayName = "Can parse json array to long list")]
        public void JsonTransformer_Deserialize_ParseToLongList()
        {
            //Arrange
            var jsonString = $"{{\"Values\":[{long.MinValue},{long.MaxValue},{long.MinValue}]}}";

            //Act
            var obj = JsonTransformer.Deserialize<LongListTestObj>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Values.Should()
                .BeEquivalentTo(new List<long> { long.MinValue, long.MaxValue, long.MinValue });
        }
        [Fact(DisplayName = "Can parse json array to ulong list")]
        public void JsonTransformer_Deserialize_ParseToULongList()
        {
            //Arrange
            var jsonString = $"{{\"Values\":[{ulong.MinValue},{ulong.MaxValue},{ulong.MinValue}]}}";

            //Act
            var obj = JsonTransformer.Deserialize<ULongListTestObj>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Values.Should()
                .BeEquivalentTo(new List<ulong> { ulong.MinValue, ulong.MaxValue, ulong.MinValue });
        }

        [Fact(DisplayName = "Can parse json array to short list")]
        public void JsonTransformer_Deserialize_ParseToShortList()
        {
            //Arrange
            var jsonString = $"{{\"Values\":[{short.MinValue},{short.MaxValue},{short.MinValue}]}}";

            //Act
            var obj = JsonTransformer.Deserialize<ShortListTestObj>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Values.Should()
                .BeEquivalentTo(new List<short> { short.MinValue, short.MaxValue, short.MinValue });
        }

        [Fact(DisplayName = "Can parse json array to ushort list")]
        public void JsonTransformer_Deserialize_ParseToUShortList()
        {
            //Arrange
            var jsonString = $"{{\"Values\":[{ushort.MinValue},{ushort.MaxValue},{ushort.MinValue}]}}";

            //Act
            var obj = JsonTransformer.Deserialize<UShortListTestObj>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Values.Should()
                .BeEquivalentTo(new List<ushort> { ushort.MinValue, ushort.MaxValue, ushort.MinValue });
        }

        [Fact(DisplayName = "Can parse nested json array to string list")]
        public void JsonTransformer_Deserialize_ParseArrayToNestedStringList()
        {
            //Arrange
            var jsonString = "{\"Values\":[\"one\",\"two\",\"three\"]}";

            //Act
            var obj = JsonTransformer.Deserialize<StringListTestObj>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Values.Should()
                .BeEquivalentTo(new List<string> { "one", "two", "three" });
        }

        [Fact(DisplayName = "Can parse json array to string list")]
        public void JsonTransformer_Deserialize_ParseArrayToStringList()
        {
            //Arrange
            var jsonString = "[\"one\",\"two\",\"three\"]";

            //Act
            var obj = JsonTransformer.Deserialize<List<string>>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Should()
                .BeEquivalentTo(new List<string> { "one", "two", "three" });
        }

        [Fact(DisplayName = "Can parse json array to string array")]
        public void JsonTransformer_Deserialize_ParseArrayToStringArray()
        {
            //Arrange
            var jsonString = "[\"one\",\"two\",\"three\"]";

            //Act
            var obj = JsonTransformer.Deserialize<string[]>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Should()
                .BeEquivalentTo(new string[] { "one", "two", "three" });
        }

        [Fact(DisplayName = "Can parse json array to dictionary")]
        public void JsonTransformer_Deserialize_ParseArrayToDictionary()
        {
            //Arrange
            var jsonString = "{\"apple\":33,\"lol\":2,\"test\":1}";

            //Act
            var obj = JsonTransformer.Deserialize<Dictionary<string, int>>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Should()
                .BeEquivalentTo(new Dictionary<string, int> { { "apple", 33 }, { "lol", 2 }, { "test", 1 } });
        }

        [Fact(DisplayName = "Can parse json array to dictionary obj")]
        public void JsonTransformer_Deserialize_ParseArrayToDictObj()
        {
            //Arrange
            var jsonString = "{\"Values\":{\"apple\":33,\"lol\":2,\"test\":1}}";

            //Act
            var obj = JsonTransformer.Deserialize<DictObj<string>>(jsonString);

            //Assert
            obj.Should().NotBeNull();
            obj.Values.Should()
                .BeEquivalentTo(new Dictionary<string, int> { { "apple", 33 }, { "lol", 2 }, { "test", 1 } });
        }
    }
}
