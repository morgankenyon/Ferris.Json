```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.307
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2


```
| Method                     | Categories | Mean       | Error     | StdDev     | Median     | Ratio | RatioSD | Gen0    | Code Size | Allocated | Alloc Ratio |
|--------------------------- |----------- |-----------:|----------:|-----------:|-----------:|------:|--------:|--------:|----------:|----------:|------------:|
| FerrisValueLoopMapping     | Loop       | 141.356 μs | 4.9400 μs | 14.0141 μs | 140.951 μs |  3.13 |    0.38 | 21.4844 |  10,462 B |   90004 B |        5.70 |
| NewtonsoftValueLoopMapping | Loop       |  97.503 μs | 1.6050 μs |  2.4987 μs |  96.952 μs |  2.16 |    0.16 | 20.5078 |   1,370 B |   85811 B |        5.43 |
| TextJsonValueLoopMapping   | Loop       |  45.373 μs | 1.1864 μs |  3.3850 μs |  44.076 μs |  1.01 |    0.10 |  3.7231 |   2,896 B |   15800 B |        1.00 |
|                            |            |            |           |            |            |       |         |         |           |           |             |
| FerrisValueMapping         | Single     |  10.160 μs | 2.2338 μs |  6.5866 μs |   6.640 μs |  5.50 |    3.57 |  0.8545 |   9,215 B |    3602 B |        5.70 |
| NewtonsoftValueMapping     | Single     |   4.654 μs | 0.1680 μs |  0.4847 μs |   4.559 μs |  2.52 |    0.31 |  0.8087 |   1,221 B |    3432 B |        5.43 |
| TextJsonValueMapping       | Single     |   1.858 μs | 0.0469 μs |  0.1359 μs |   1.832 μs |  1.01 |    0.10 |  0.1488 |   2,588 B |     632 B |        1.00 |
