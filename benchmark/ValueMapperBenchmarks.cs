using BenchmarkDotNet.Attributes;
using Ferris.Json.Test.TestObjects;
using Newtonsoft.Json;

namespace Ferris.Json.Benchmark;

[MemoryDiagnoser]
[DisassemblyDiagnoser]
public class ValueMapperBenchmarks
{
    private static ValueTestObject testObj = TestObjs.GetValueTestObject();
    private int count = 0;

    [Benchmark]
    public void FerrisValueMapping()
    {
        var json = JsonTransformer.ToJson(testObj);
        count += json.GetHashCode();
    }

    [Benchmark]
    public void NewtonsoftValueMapping()
    {
        var json = JsonConvert.SerializeObject(testObj);
        count += json.GetHashCode();
    }

    [Benchmark]
    public void TextJsonValueMapping()
    {
        var json = System.Text.Json.JsonSerializer.Serialize(testObj);
        count += json.GetHashCode();
    }
}
