```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.307
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2


```
| Method                 | Mean     | Error   | StdDev   | Median   | Ratio | RatioSD |
|----------------------- |---------:|--------:|---------:|---------:|------:|--------:|
| FerrisValueMapping     | 292.6 ns | 6.22 ns | 17.93 ns | 287.7 ns |  1.32 |    0.08 |
| NewtonsoftValueMapping | 533.1 ns | 8.94 ns |  9.56 ns | 529.7 ns |  2.41 |    0.05 |
| TextJsonValueMapping   | 221.4 ns | 2.24 ns |  1.75 ns | 221.1 ns |  1.00 |    0.01 |
