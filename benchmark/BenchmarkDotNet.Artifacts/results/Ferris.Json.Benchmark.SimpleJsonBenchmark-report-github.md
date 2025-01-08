```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.307
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2


```
| Method                  | Categories | Mean        | Error     | StdDev      | Median      | Ratio | RatioSD | Code Size | Gen0   | Allocated | Alloc Ratio |
|------------------------ |----------- |------------:|----------:|------------:|------------:|------:|--------:|----------:|-------:|----------:|------------:|
| FerrisListMapping       | List       |  3,972.7 ns | 126.01 ns |   371.56 ns |  3,957.0 ns |  1.76 |    0.17 |  19,355 B | 1.2550 |    5257 B |        3.65 |
| NewtonsoftListMapping   | List       |  3,534.4 ns |  89.41 ns |   257.97 ns |  3,450.2 ns |  1.56 |    0.12 |   1,843 B | 1.1597 |    4872 B |        3.38 |
| TextJsonListMapping     | List       |  2,260.4 ns |  40.31 ns |    35.73 ns |  2,267.5 ns |  1.00 |    0.02 |   4,524 B | 0.3433 |    1440 B |        1.00 |
|                         |            |             |           |             |             |       |         |           |        |           |             |
| FerrisSingleMapping     | Single     |    462.4 ns |   9.30 ns |    15.79 ns |    464.5 ns |  0.81 |    0.12 |  16,996 B | 0.1926 |     808 B |        5.32 |
| NewtonsoftSingleMapping | Single     |  2,125.5 ns | 126.60 ns |   369.30 ns |  2,088.5 ns |  3.72 |    0.85 |   2,201 B | 0.9613 |    4024 B |       26.47 |
| STJSingleMapping        | Single     |    585.3 ns |  34.32 ns |    97.36 ns |    556.5 ns |  1.02 |    0.23 |   4,130 B | 0.0362 |     152 B |        1.00 |
|                         |            |             |           |             |             |       |         |           |        |           |             |
| FerrisValueMapping      | Value      |  8,996.5 ns | 199.51 ns |   572.43 ns |  8,809.5 ns |  1.88 |    0.12 |  16,413 B | 2.1973 |    9250 B |        8.44 |
| NewtonsoftValueMapping  | Value      | 13,409.9 ns | 658.60 ns | 1,835.92 ns | 12,891.0 ns |  2.80 |    0.39 |   2,204 B | 1.8921 |    7977 B |        7.28 |
| TextJsonValueMapping    | Value      |  4,788.0 ns |  93.40 ns |    95.91 ns |  4,784.3 ns |  1.00 |    0.03 |   4,892 B | 0.2594 |    1096 B |        1.00 |
