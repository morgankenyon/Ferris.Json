using BenchmarkDotNet.Attributes;
using Ferris.Json.Test.TestObjects;
using Newtonsoft.Json;

namespace Ferris.Json.Benchmark;

[MemoryDiagnoser]
[DisassemblyDiagnoser]
public class ObjectMapperBenchmarks
{
    private StringPropertyObj singlePropertyTest = new StringPropertyObj
    {
        Property = "Test"
    };

    [Benchmark]
    public void FerrisSingleProperty()
    {
        JsonTransformer.ToJson(singlePropertyTest);
    }

    [Benchmark]
    public void NewtonsoftSingleProperty()
    {
        JsonConvert.SerializeObject(singlePropertyTest);
    }

    [Benchmark]
    public void TextJsonSingleProperty()
    {
        System.Text.Json.JsonSerializer.Serialize(singlePropertyTest);
    }
}
