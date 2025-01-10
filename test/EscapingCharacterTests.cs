using Ferris.Json.Test.TestObjects;
using FluentAssertions;
using Xunit;

namespace Ferris.Json.Test
{
    public class EscapingCharacterTests
    {
        [Theory]
        [InlineData("\"", "\"\"\"")]
        [InlineData("\\", "\"\\\"")]
        [InlineData("/", "\"/\"")]
        [InlineData("\b", "\"\b\"")]
        [InlineData("\f", "\"\f\"")]
        [InlineData("\n", "\"\n\"")]
        [InlineData("\r", "\"\r\"")]
        [InlineData("\t", "\"\t\"")]
        [InlineData("12\u002f", "\"12/\"")]
        internal void JsonTransform_CanSerializeEscapedCharacters(
            string testString,
            string expectedResult)
        {
            //Arrange
            var obj = new StringPropertyObj
            {
                Property = testString
            };

            //Act
            var jsonString = JsonTransformer.Serialize(obj);

            //Assert
            jsonString.Should().Be($"{{\"Property\":{expectedResult}}}");
        }

        [Theory]
        [InlineData("\"\\\"\"", "\\\"")]
        [InlineData("\"\\\"", "\\")]
        [InlineData("\"/\"", "/")]
        [InlineData("\"\b\"", "\b")]
        [InlineData("\"\f\"", "\f")]
        [InlineData("\"\n\"", "\n")]
        [InlineData("\"\r\"", "\r")]
        [InlineData("\"\t\"", "\t")]
        [InlineData("\"12/\"", "12\u002f")]
        internal void JsonTransform_CanDeserializeEscapedCharacters(
            string propertyString,
            string expectedResult)
        {
            //Arrange
            var jsonString = $"{{\"Property\":{propertyString}}}";

            //Act
            var obj = JsonTransformer.Deserialize<StringPropertyObj>(jsonString);

            //Assert
            obj.Should().BeOfType<StringPropertyObj>();
            var stringProp = obj as StringPropertyObj;

            stringProp.Property.Should().Be(expectedResult);
        }
    }
}
