using Ferris.Json.Test.TestObjects;

namespace Ferris.Json.Test;

public class ObjectMapperTests
{
    [Fact(DisplayName = "Can map one string property to Json")]
    public void Test1()
    {
        //Arrange
        var obj = new SinglePropertyTest
        {
            Property = "FirstTest"
        };

        var transform = new JsonTransform();

        //Act
        var jsonString = transform.ToJson(obj);

        //Assert
        Assert.Equal("{\"Property\":\"FirstTest\"}", jsonString);
    }
}