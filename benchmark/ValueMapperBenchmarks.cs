using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using Ferris.Json.Test.TestObjects;
using Newtonsoft.Json;

namespace Ferris.Json.Benchmark;

[MemoryDiagnoser]
[DisassemblyDiagnoser]
[CategoriesColumn]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
public class ValueMapperBenchmarks
{
    private static ValueTestObject testObj = TestObjs.GetValueTestObject();
    private int count = 0;
    private int N = 25;

    [Benchmark]
    [BenchmarkCategory("Single")]
    public void FerrisValueMapping()
    {
        var json = JsonTransformer.ToJson(testObj);
        count += json.GetHashCode();
    }

    [Benchmark]
    [BenchmarkCategory("Single")]
    public void NewtonsoftValueMapping()
    {
        var json = JsonConvert.SerializeObject(testObj);
        count += json.GetHashCode();
    }

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("Single")]
    public void TextJsonValueMapping()
    {
        var json = System.Text.Json.JsonSerializer.Serialize(testObj);
        count += json.GetHashCode();
    }

    [Benchmark]
    [BenchmarkCategory("Loop")]
    public void FerrisValueLoopMapping()
    {
        for (int i = 0; i < N; i++)
        {
            var json = JsonTransformer.ToJson(testObj);
            count += json.GetHashCode();
        }
    }

    [Benchmark]
    [BenchmarkCategory("Loop")]
    public void NewtonsoftValueLoopMapping()
    {
        for (int i = 0; i < N; i++)
        {
            var json = JsonConvert.SerializeObject(testObj);
            count += json.GetHashCode();
        }
    }

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("Loop")]
    public void TextJsonValueLoopMapping()
    {
        for (int i = 0; i < N; i++)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(testObj);
            count += json.GetHashCode();
        }
    }
}
