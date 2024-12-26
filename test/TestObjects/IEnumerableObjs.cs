namespace Ferris.Json.Test.TestObjects;
internal class ListTestObj
{
    public List<StringPropertyObj>? Strings { get; set; }
}
internal class LinkedListObj
{
    public LinkedList<StringPropertyObj>? Strings { get; set; }
}
internal class MixedListTestObj
{
    public List<StringPropertyObj>? Strings { get; set; }
    public string? Property { get; set; }
}
internal class ArrayTestObj
{
    public StringPropertyObj[]? Strings { get; set; }
}
