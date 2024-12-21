```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.307
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2


```
| Method                   | Mean     | Error     | StdDev    | Median   | Code Size | Gen0   | Allocated |
|------------------------- |---------:|----------:|----------:|---------:|----------:|-------:|----------:|
| FerrisSingleProperty     | 4.825 μs | 0.1452 μs | 0.4257 μs | 4.754 μs |  10,008 B | 0.8545 |    3599 B |
| NewtonsoftSingleProperty | 3.538 μs | 0.0855 μs | 0.2438 μs | 3.451 μs |   1,221 B | 0.8202 |    3432 B |
| TextJsonSingleProperty   | 1.740 μs | 0.0321 μs | 0.0268 μs | 1.737 μs |   2,588 B | 0.1507 |     632 B |
