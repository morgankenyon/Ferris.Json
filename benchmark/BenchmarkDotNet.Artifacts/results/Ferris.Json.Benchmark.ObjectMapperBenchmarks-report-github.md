```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.307
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2


```
| Method                   | Mean     | Error    | StdDev   | Code Size | Gen0   | Allocated |
|------------------------- |---------:|---------:|---------:|----------:|-------:|----------:|
| FerrisSingleProperty     | 202.9 ns |  9.97 ns | 28.29 ns |   3,377 B | 0.0515 |     216 B |
| NewtonsoftSingleProperty | 384.6 ns | 12.89 ns | 35.08 ns |     904 B | 0.3223 |    1352 B |
