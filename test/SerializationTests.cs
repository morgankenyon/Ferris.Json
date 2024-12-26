using Ferris.Json.Test.TestObjects;
using FluentAssertions;

namespace Ferris.Json.Test;

public class SerializationTests
{
    [Theory(DisplayName = "Map bool property to Json")]
    [InlineData(true)]
    [InlineData(false)]
    public void JsonTransformer_MapBoolProperty(bool value)
    {
        //Arrange
        var obj = new BoolPropertyObj
        {
            Property = value
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal($"{{\"Property\":{value.ToString().ToLower()}}}", jsonString);
    }

    [Fact(DisplayName = "Map byte property to Json")]
    public void JsonTransformer_MapByteProperty()
    {
        //Arrange
        var obj = new BytePropertyObj
        {
            Property = 77
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":77}", jsonString);
    }

    [Fact(DisplayName = "Map sbyte property to Json")]
    public void JsonTransformer_MapSByteProperty()
    {
        //Arrange
        var obj = new SBytePropertyObj
        {
            Property = 79
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":79}", jsonString);
    }

    [Fact(DisplayName = "Map char property to Json")]
    public void JsonTransformer_MapCharProperty()
    {
        //Arrange
        var obj = new CharPropertyObj
        {
            Property = 'M'
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":\"M\"}", jsonString);
    }

    [Fact(DisplayName = "Map decimal property to Json")]
    public void JsonTransformer_MapDecimalProperty()
    {
        //Arrange
        var obj = new DecimalPropertyObj
        {
            Property = 23.29m
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":23.29}", jsonString);
    }

    [Fact(DisplayName = "Map double property to Json")]
    public void JsonTransformer_MapDoubleProperty()
    {
        //Arrange
        var obj = new DoublePropertyObj
        {
            Property = 23.1
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":23.1}", jsonString);
    }

    [Fact(DisplayName = "Map float property to Json")]
    public void JsonTransformer_MapFloatProperty()
    {
        //Arrange
        var obj = new FloatPropertyObj
        {
            Property = 23.1f
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":23.1}", jsonString);
    }

    [Fact(DisplayName = "Map int property to Json")]
    public void JsonTransformer_MapIntProperty()
    {
        //Arrange
        var obj = new IntPropertyObj
        {
            Property = 23
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":23}", jsonString);
    }

    [Fact(DisplayName = "Map uint property to Json")]
    public void JsonTransformer_MapUIntProperty()
    {
        //Arrange
        var obj = new UIntPropertyObj
        {
            Property = 223
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":223}", jsonString);
    }

    [Fact(DisplayName = "Map nint property to Json")]
    public void JsonTransformer_MapNIntProperty()
    {
        //Arrange
        var obj = new NIntPropertyObj
        {
            Property = 83
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":83}", jsonString);
    }

    [Fact(DisplayName = "Map nuint property to Json")]
    public void JsonTransformer_MapNUIntProperty()
    {
        //Arrange
        var obj = new NUIntPropertyObj
        {
            Property = 2277
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":2277}", jsonString);
    }

    [Fact(DisplayName = "Map long property to Json")]
    public void JsonTransformer_MapLongProperty()
    {
        //Arrange
        var obj = new LongPropertyObj
        {
            Property = 832839272
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":832839272}", jsonString);
    }

    [Fact(DisplayName = "Map ulong property to Json")]
    public void JsonTransformer_MapULongProperty()
    {
        //Arrange
        var obj = new ULongPropertyObj
        {
            Property = 2283283927277
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":2283283927277}", jsonString);
    }

    [Fact(DisplayName = "Map int128 property to Json")]
    public void JsonTransformer_MapInt128Property()
    {
        //Arrange
        var obj = new Int128PropertyObj
        {
            Property = 828392722342422424
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":828392722342422424}", jsonString);
    }

    [Fact(DisplayName = "Map uint128 property to Json")]
    public void JsonTransformer_MapUInt128Property()
    {
        //Arrange
        var obj = new UInt128PropertyObj
        {
            Property = 8328392722342422424
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":8328392722342422424}", jsonString);
    }

    [Fact(DisplayName = "Map short property to Json")]
    public void JsonTransformer_MapShortProperty()
    {
        //Arrange
        var obj = new ShortPropertyObj
        {
            Property = 22
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":22}", jsonString);
    }

    [Fact(DisplayName = "Map ushort property to Json")]
    public void JsonTransformer_MapUShortProperty()
    {
        //Arrange
        var obj = new UShortPropertyObj
        {
            Property = 2283
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":2283}", jsonString);
    }

    [Fact(DisplayName = "Map string property to Json")]
    public void JsonTransformer_MapStringProperty()
    {
        //Arrange
        var obj = new StringPropertyObj
        {
            Property = "FirstTest"
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":\"FirstTest\"}", jsonString);
    }

    [Fact(DisplayName = "Map null property to Json")]
    public void JsonTransformer_MapNullProperty()
    {
        //Arrange
        var obj = new StringPropertyObj();

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("""{"Property":null}""", jsonString);
    }

    [Fact(DisplayName = "Map nested string property to Json")]
    public void JsonTransformer_MapNestedProperti()
    {
        //Arrange
        var obj = new NestedStringObj
        {
            Property = new StringPropertyObj
            {
                Property = "value"
            }
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("{\"Property\":{\"Property\":\"value\"}}", jsonString);
    }

    [Fact(DisplayName = "Map ValueTestObject to Json")]
    public void JsonTransformer_MapValueTestObject()
    {
        //Arrange
        var obj = TestObjs.GetValueTestObject();

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal(TestObjs.GetValueTestObjectJson(), jsonString);
    }

    [Fact(DisplayName = "Map nullable string property to Json")]
    public void JsonTransformer_MapNullableStringProperty()
    {
        //Arrange
        var obj = new StringNullablePropertyObj();

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        Assert.Equal("""{"Property":null}""", jsonString);
    }

    [Fact(DisplayName = "Map datetime property to Json")]
    public void JsonTransformer_MapDateTimeProperty()
    {
        //Arrange
        var obj = new DateTimePropertyObj
        {
            Property = DateTime.MinValue,
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        var dateString = obj.Property.ToString("s", System.Globalization.CultureInfo.InvariantCulture);
        Assert.Equal($"{{\"Property\":\"{dateString}\"}}", jsonString);
    }

    [Fact(DisplayName = "Map list property to json array")]
    public void JsonTransformer_MapListProperty()
    {
        //Arrange
        var obj = new ListTestObj
        {
            Strings = new List<StringPropertyObj>
            {
                new StringPropertyObj
                {
                    Property = "FirstString"
                },
                new StringPropertyObj
                {
                    Property = "SecondString"
                }
            }
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        jsonString.Should().Be("""{"Strings":[{"Property":"FirstString"},{"Property":"SecondString"}]}""");
    }

    [Fact(DisplayName = "Map linkedlist property to json array")]
    public void JsonTransformer_MapLinkedListProperty()
    {
        //Arrange
        var strings = new LinkedList<StringPropertyObj>();
        strings.AddLast(new StringPropertyObj
        {
            Property = "FirstString"
        });
        strings.AddLast(new StringPropertyObj
        {
            Property = "SecondString"
        });
        var obj = new LinkedListObj
        {
            Strings = strings
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        jsonString.Should().Be("""{"Strings":[{"Property":"FirstString"},{"Property":"SecondString"}]}""");
    }

    [Fact(DisplayName = "Map mixed list property to json array")]
    public void JsonTransformer_MapMixedListProperty()
    {
        //Arrange
        var obj = new MixedListTestObj
        {
            Strings = new List<StringPropertyObj>
            {
                new StringPropertyObj
                {
                    Property = "FirstString"
                },
                new StringPropertyObj
                {
                    Property = "SecondString"
                }
            },
            Property = "prop"
        };

        //Act
        var jsonString = JsonTransformer.Serialize(obj);

        //Assert
        jsonString.Should().Be("""{"Strings":[{"Property":"FirstString"},{"Property":"SecondString"}],"Property":"prop"}""");
    }
}