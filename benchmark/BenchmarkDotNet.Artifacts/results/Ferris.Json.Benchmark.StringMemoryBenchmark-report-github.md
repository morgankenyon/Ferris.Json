```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.307
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Categories=10  

```
| Method       | Mean     | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------- |---------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| TestBaseline | 3.329 μs | 0.1007 μs | 0.2954 μs |  1.01 |    0.12 |     328 B |         - |          NA |
| TestCast     | 3.110 μs | 0.0572 μs | 0.1016 μs |  0.94 |    0.08 |     324 B |         - |          NA |
| TestToString | 3.162 μs | 0.0631 μs | 0.1487 μs |  0.96 |    0.09 |     328 B |         - |          NA |
