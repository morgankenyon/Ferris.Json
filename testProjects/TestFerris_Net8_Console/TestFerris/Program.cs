using Ferris.Json;
using System.Reflection;

namespace TestFerris;

internal class Program
{
    static void Main(string[] args)
    {
        //var list = TestDynamicList();
        //TestNewtonsoft();
        var obj = new TestObject
        {
            Property = "string"
        };

        var jsonString = JsonTransformer.Serialize(obj);

        var firstObj = JsonTransformer.Deserialize<TestObject>(jsonString);


        var testListObj = new TestListObject
        {
            Strings = new List<string>
            {
                "one","two"
            }
        };

        var jsonListString = JsonTransformer.Serialize(testListObj);
        var secondObj = JsonTransformer.Deserialize<TestListObject>(jsonListString);

        //Reflection();
        Console.ReadLine();
    }

    static void Reflection()
    {
        var testObj = new ReflectionObj
        {
            BoolProperty = true,
            IntProperty = 1,
            StringProperty = "hello",
        };

        Type type = testObj.GetType();

        Type anotherWay = typeof(ReflectionObj);

        object? instance = Activator.CreateInstance(type);

        ReflectionObj typedInstance = (ReflectionObj)Activator.CreateInstance(type);

        PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        //foreach (PropertyInfo property in properties)
        //{
        //    if (property.Name == "BoolProperty")
        //        property.SetValue(instance, true);
        //    else if (property.Name == "IntProperty")
        //        property.SetValue(instance, 234);
        //    else if (property.Name == "StringProperty")
        //        property.SetValue(instance, "hello");
        //}

        var valueDict = new Dictionary<string, object>();
        valueDict["BoolProperty"] = true;
        valueDict["IntProperty"] = 234;
        valueDict["StringProperty"] = "hello";

        foreach (PropertyInfo property in properties)
        {
            if (valueDict.TryGetValue(property.Name, out var value))
            {
                property.SetValue(instance, value);
            }
        }
    }

    //static dynamic TestDynamicList()
    //{
    //    dynamic list = new List<TestObject>();

    //    list.Add(new TestObject
    //    {
    //        Property = "string"
    //    });

    //    return list;
    //}

    //static string TestNewtonsoft()
    //{
    //    var linkedList = new LinkedList<TestObject>();
    //    linkedList.AddLast(new TestObject
    //    {
    //        Property = "test"
    //    });
    //    var testList = new TestList<string>();

    //    testList.Add("string");

    //    var testObj = new TestListObject
    //    {
    //        Strings = testList
    //    };

    //    var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(testObj);
    //    var jsonSTring = Newtonsoft.Json.JsonConvert.SerializeObject(linkedList);

    //    return jsonString;
    //}

    //static string TestLinkedList()
    //{
    //    var list = new LinkedList<string>();
    //    //vlist.Add
    //    var stack = new Stack<string>();
        
    //}
}



public class ReflectionObj
{
    public string StringProperty { get; set; }
    public int IntProperty { get; set; }
    public bool BoolProperty { get; set; }
}
public class TestObject
{
    public string Property { get; set; }
}

public class TestListObject
{
    public List<string> Strings { get; set; }
}

public class TestList<T>
{
    private List<T> strings = new List<T>();

    public void Add(T value)
    {
        strings.Add(value);
    }

    public T Last()
    {
        return strings.Last();
    }
}