namespace Ferris.Json.Test.TestObjects
{
    public class NestedStringObj
    {
        public StringPropertyObj Property { get; set; }
    }
    public class NestedMultipleObj
    {
        public StringPropertyObj StringProp { get; set; }
        public IntPropertyObj IntProp { get; set; }
        public int Number { get; set; }
    }
}
