using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using Ferris.Json.Test.TestObjects;
using Newtonsoft.Json;

namespace Ferris.Json.Benchmark;

[MemoryDiagnoser]
[DisassemblyDiagnoser]
[CategoriesColumn]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
public class SimpleJsonBenchmark
{
    private static StringPropertyObj stringTestObj = TestObjs.GetStringTestObject();
    private static ValueTestObject valueTestObj = TestObjs.GetValueTestObject();
    private static MixedListTestObj listTestObj = TestObjs.GetListTestObject();
    private int count = 0;
    private int N = 25;

    [Benchmark]
    [BenchmarkCategory("Single")]
    public void FerrisSingleMapping()
    {
        var json = JsonTransformer.Serialize(stringTestObj);
        var obj = JsonTransformer.Deserialize<StringPropertyObj>(json);
        if (stringTestObj.Property.Equals(obj.Property))
        {
            count++;
        }
        else
        {
            count--;
        }
    }

    [Benchmark]
    [BenchmarkCategory("Single")]
    public void NewtonsoftSingleMapping()
    {
        var json = JsonConvert.SerializeObject(stringTestObj);
        var obj = JsonConvert.DeserializeObject<StringPropertyObj>(json);
        if (stringTestObj.Property.Equals(obj?.Property))
        {
            count++;
        }
        else
        {
            count--;
        }
    }

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("Single")]
    public void STJSingleMapping()
    {
        var json = System.Text.Json.JsonSerializer.Serialize(stringTestObj);
        var obj = System.Text.Json.JsonSerializer.Deserialize<StringPropertyObj>(json);
        if (stringTestObj.Property.Equals(obj?.Property))
        {
            count++;
        }
        else
        {
            count--;
        }
    }

    [Benchmark]
    [BenchmarkCategory("Value")]
    public void FerrisValueMapping()
    {
        var json = JsonTransformer.Serialize(valueTestObj);
        var obj = JsonTransformer.Deserialize<ValueTestObject>(json);
        if (valueTestObj.StringProp.Equals(obj?.StringProp))
        {
            count++;
        }
        else
        {
            count--;
        }
    }

    [Benchmark]
    [BenchmarkCategory("Value")]
    public void NewtonsoftValueMapping()
    {
        var json = JsonConvert.SerializeObject(valueTestObj);
        var obj = JsonConvert.DeserializeObject<ValueTestObject>(json);
        if (valueTestObj.StringProp.Equals(obj?.StringProp))
        {
            count++;
        }
        else
        {
            count--;
        }
    }

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("Value")]
    public void TextJsonValueMapping()
    {
        var json = System.Text.Json.JsonSerializer.Serialize(valueTestObj);
        var obj = System.Text.Json.JsonSerializer.Deserialize<ValueTestObject>(json);
        if (valueTestObj.StringProp.Equals(obj?.StringProp))
        {
            count++;
        }
        else
        {
            count--;
        }
    }

    [Benchmark]
    [BenchmarkCategory("List")]
    public void FerrisListMapping()
    {
        var json = JsonTransformer.Serialize(listTestObj);
        var obj = JsonTransformer.Deserialize<MixedListTestObj>(json);
        if (listTestObj.Strings.Count == obj.Strings.Count)
        {
            count++;
        }
        else
        {
            count--;
        }
    }

    [Benchmark]
    [BenchmarkCategory("List")]
    public void NewtonsoftListMapping()
    {
        var json = JsonConvert.SerializeObject(listTestObj);
        var obj = JsonConvert.DeserializeObject<MixedListTestObj>(json);
        if (listTestObj.Strings.Count == obj.Strings.Count)
        {
            count++;
        }
        else
        {
            count--;
        }
    }

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("List")]
    public void TextJsonListMapping()
    {
        var json = System.Text.Json.JsonSerializer.Serialize(listTestObj);
        var obj = System.Text.Json.JsonSerializer.Deserialize<MixedListTestObj>(json);
        if (listTestObj.Strings.Count == obj.Strings.Count)
        {
            count++;
        }
        else
        {
            count--;
        }
    }
}
