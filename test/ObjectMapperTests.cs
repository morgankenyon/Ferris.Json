using Ferris.Json.Test.TestObjects;

namespace Ferris.Json.Test;

public class ObjectMapperTests
{
    [Fact(DisplayName = "Map string property to Json")]
    public void JsonTransformer_MapStringProperty()
    {
        //Arrange
        var obj = new StringPropertyObj
        {
            Property = "FirstTest"
        };

        //Act
        var jsonString = JsonTransformer.ToJson(obj);

        //Assert
        Assert.Equal("{\"Property\":\"FirstTest\"}", jsonString);
    }

    [Fact(DisplayName = "Map int property to Json")]
    public void JsonTransformer_MapIntProperty()
    {
        //Arrange
        var obj = new IntPropertyObj
        {
            Value = 23
        };

        //Act
        var jsonString = JsonTransformer.ToJson(obj);

        //Assert
        Assert.Equal("{\"Value\":23}", jsonString);
    }

    [Theory(DisplayName = "Map bool property to Json")]
    [InlineData(true)]
    [InlineData(false)]
    public void JsonTransformer_MapBoolProperty(bool value)
    {
        //Arrange
        var obj = new BoolPropertyObj
        {
            Value = value
        };

        //Act
        var jsonString = JsonTransformer.ToJson(obj);

        //Assert
        Assert.Equal($"{{\"Value\":{value.ToString().ToLower()}}}", jsonString);
    }
}