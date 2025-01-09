using BenchmarkDotNet.Running;

namespace Ferris.Json.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SimpleJsonBenchmark>();
        }
    }
}