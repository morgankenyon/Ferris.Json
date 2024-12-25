using BenchmarkDotNet.Attributes;
using Ferris.Json.Test.TestObjects;
using Newtonsoft.Json;

namespace Ferris.Json.Benchmark;
public class ToObjectBenchmark
{
    private static string jsonString = "{\"Property\":\"testValue\"}";
    private int count = 0;
    private int N = 25;

    [Benchmark]
    [BenchmarkCategory("Single")]
    public void FerrisValueMapping()
    {
        var obj = JsonTransformer.Deserialize<StringPropertyObj>(jsonString);
        count += obj.Property.GetHashCode();
    }

    [Benchmark]
    [BenchmarkCategory("Single")]
    public void NewtonsoftValueMapping()
    {
        var obj = JsonConvert.DeserializeObject<StringPropertyObj>(jsonString);
        count += obj.Property.GetHashCode();
    }

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("Single")]
    public void TextJsonValueMapping()
    {
        var obj = System.Text.Json.JsonSerializer.Deserialize<StringPropertyObj>(jsonString);
        count += obj.Property.GetHashCode();
    }
}
