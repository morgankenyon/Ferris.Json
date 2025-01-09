using System.Collections.Generic;

namespace Ferris.Json.Test.TestObjects
{
    internal class ListTestObj
    {
        public List<StringPropertyObj> Strings { get; set; }
    }
    internal class StringListTestObj
    {
        public List<string> Strings { get; set; }
    }
    internal class ObjectListTestObj
    {
        public List<object> Objects { get; set; }
    }
    internal class LinkedListObj
    {
        public LinkedList<StringPropertyObj> Strings { get; set; }
    }
    public class MixedListTestObj
    {
        public List<StringPropertyObj> Strings { get; set; }
        public string Property { get; set; }
    }
    internal class ArrayTestObj
    {
        public StringPropertyObj[] Strings { get; set; }
    }
}
