```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.307
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2


```
| Method                   | Mean     | Error    | StdDev    | Median   | Code Size | Gen0   | Allocated |
|------------------------- |---------:|---------:|----------:|---------:|----------:|-------:|----------:|
| FerrisSingleProperty     | 361.1 ns | 46.88 ns | 134.52 ns | 318.3 ns |   3,361 B | 0.0515 |     216 B |
| NewtonsoftSingleProperty | 736.4 ns | 60.29 ns | 173.94 ns | 688.6 ns |     904 B | 0.3223 |    1352 B |
| TextJsonSingleProperty   | 400.8 ns |  7.88 ns |  16.09 ns | 401.8 ns |   2,256 B | 0.0153 |      64 B |
