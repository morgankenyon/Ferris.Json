using BenchmarkDotNet.Attributes;
using Ferris.Json.Test.TestObjects;
using Newtonsoft.Json;

namespace Ferris.Json.Benchmark;

[MemoryDiagnoser]
[DisassemblyDiagnoser]
public class ObjectMapperBenchmarks
{
    private SinglePropertyTest singlePropertyTest = new SinglePropertyTest
    {
        Property = "Test"
    };
    private JsonTransform transform = new JsonTransform();

    [Benchmark]
    public void FerrisSingleProperty()
    {
        transform.ToJson(singlePropertyTest);
    }

    [Benchmark]
    public void NewtonsoftSingleProperty()
    {
        JsonConvert.SerializeObject(singlePropertyTest);
    }
}
