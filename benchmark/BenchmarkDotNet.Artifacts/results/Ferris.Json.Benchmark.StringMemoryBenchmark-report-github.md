```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.307
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Categories=10  

```
| Method       | Mean     | Error   | StdDev   | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|------------- |---------:|--------:|---------:|------:|--------:|----------:|----------:|------------:|
| TestBaseline | 357.4 ns | 8.83 ns | 25.48 ns |  1.00 |    0.10 |     328 B |         - |          NA |
| TestCast     | 330.8 ns | 4.19 ns |  3.71 ns |  0.93 |    0.06 |     324 B |         - |          NA |
| TestToString | 327.0 ns | 6.00 ns |  5.01 ns |  0.92 |    0.06 |     328 B |         - |          NA |
