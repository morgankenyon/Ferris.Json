```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.307
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Categories=Single  

```
| Method                 | Mean     | Error    | StdDev   | Ratio | RatioSD | Code Size | Gen0   | Allocated | Alloc Ratio |
|----------------------- |---------:|---------:|---------:|------:|--------:|----------:|-------:|----------:|------------:|
| FerrisValueMapping     | 450.9 ns | 15.04 ns | 44.12 ns |  1.87 |    0.18 |   7,427 B | 0.1125 |     472 B |        7.38 |
| NewtonsoftValueMapping | 583.7 ns |  8.85 ns |  7.85 ns |  2.42 |    0.05 |   1,088 B | 0.6323 |    2648 B |       41.38 |
| TextJsonValueMapping   | 241.4 ns |  4.71 ns |  4.18 ns |  1.00 |    0.02 |   2,370 B | 0.0153 |      64 B |        1.00 |
