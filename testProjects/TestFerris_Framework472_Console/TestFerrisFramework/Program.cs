using Ferris.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFerrisFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Console.ReadLine();
        }
    }

    public class TestObject
    {
        public string Property { get; set; }
    }

    public class TestListObject
    {
        public List<string> Strings { get; set; }
    }
}
