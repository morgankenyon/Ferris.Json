```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.307
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2


```
| Method                     | Categories | Mean       | Error     | StdDev     | Ratio | RatioSD | Gen0    | Code Size | Allocated | Alloc Ratio |
|--------------------------- |----------- |-----------:|----------:|-----------:|------:|--------:|--------:|----------:|----------:|------------:|
| FerrisValueLoopMapping     | Loop       | 255.278 μs | 7.6363 μs | 21.6629 μs |  2.11 |    0.20 | 25.3906 |  11,268 B |  111944 B |        4.83 |
| NewtonsoftValueLoopMapping | Loop       | 169.724 μs | 3.1085 μs |  4.6527 μs |  1.40 |    0.07 | 23.9258 |   1,365 B |  100813 B |        4.35 |
| TextJsonValueLoopMapping   | Loop       | 121.424 μs | 2.4140 μs |  5.0920 μs |  1.00 |    0.06 |  5.4932 |   2,891 B |   23200 B |        1.00 |
|                            |            |            |           |            |       |         |         |           |           |             |
| FerrisValueMapping         | Single     |  11.134 μs | 0.2226 μs |  0.5666 μs |  2.28 |    0.14 |  1.0681 |  10,261 B |    4473 B |        4.82 |
| NewtonsoftValueMapping     | Single     |   8.763 μs | 0.1717 μs |  0.3183 μs |  1.80 |    0.09 |  0.9613 |   1,216 B |    4033 B |        4.35 |
| TextJsonValueMapping       | Single     |   4.882 μs | 0.0965 μs |  0.1741 μs |  1.00 |    0.05 |  0.2213 |   2,577 B |     928 B |        1.00 |
