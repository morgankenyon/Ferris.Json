```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.307
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  .NET 8.0 : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2


```
| Method                  | Job                  | Runtime              | Categories | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD | Code Size | Gen0   | Allocated | Alloc Ratio |
|------------------------ |--------------------- |--------------------- |----------- |-----------:|----------:|----------:|-----------:|------:|--------:|----------:|-------:|----------:|------------:|
| FerrisListMapping       | .NET 8.0             | .NET 8.0             | List       | 3,638.5 ns | 151.15 ns | 443.31 ns | 3,621.7 ns |  1.68 |    0.21 |  19,043 B | 1.2512 |    5257 B |        3.65 |
| NewtonsoftListMapping   | .NET 8.0             | .NET 8.0             | List       | 3,554.7 ns | 210.15 ns | 609.70 ns | 3,261.2 ns |  1.64 |    0.28 |   1,843 B | 1.1597 |    4872 B |        3.38 |
| TextJsonListMapping     | .NET 8.0             | .NET 8.0             | List       | 2,163.7 ns |  41.84 ns |  37.09 ns | 2,161.7 ns |  1.00 |    0.02 |   4,536 B | 0.3433 |    1440 B |        1.00 |
|                         |                      |                      |            |            |           |           |            |       |         |           |        |           |             |
| FerrisListMapping       | .NET Framework 4.6.2 | .NET Framework 4.6.2 | List       |         NA |        NA |        NA |         NA |     ? |       ? |        NA |     NA |        NA |           ? |
| NewtonsoftListMapping   | .NET Framework 4.6.2 | .NET Framework 4.6.2 | List       |         NA |        NA |        NA |         NA |     ? |       ? |        NA |     NA |        NA |           ? |
| TextJsonListMapping     | .NET Framework 4.6.2 | .NET Framework 4.6.2 | List       |         NA |        NA |        NA |         NA |     ? |       ? |        NA |     NA |        NA |           ? |
|                         |                      |                      |            |            |           |           |            |       |         |           |        |           |             |
| FerrisSingleMapping     | .NET 8.0             | .NET 8.0             | Single     |   444.2 ns |   5.04 ns |   4.21 ns |   443.0 ns |  1.15 |    0.04 |  17,152 B | 0.1931 |     808 B |        5.32 |
| NewtonsoftSingleMapping | .NET 8.0             | .NET 8.0             | Single     |   750.9 ns |  13.86 ns |  23.91 ns |   740.2 ns |  1.94 |    0.09 |   2,201 B | 0.9613 |    4024 B |       26.47 |
| STJSingleMapping        | .NET 8.0             | .NET 8.0             | Single     |   387.4 ns |   6.98 ns |  12.94 ns |   385.9 ns |  1.00 |    0.05 |   4,130 B | 0.0362 |     152 B |        1.00 |
|                         |                      |                      |            |            |           |           |            |       |         |           |        |           |             |
| FerrisSingleMapping     | .NET Framework 4.6.2 | .NET Framework 4.6.2 | Single     |         NA |        NA |        NA |         NA |     ? |       ? |        NA |     NA |        NA |           ? |
| NewtonsoftSingleMapping | .NET Framework 4.6.2 | .NET Framework 4.6.2 | Single     |         NA |        NA |        NA |         NA |     ? |       ? |        NA |     NA |        NA |           ? |
| STJSingleMapping        | .NET Framework 4.6.2 | .NET Framework 4.6.2 | Single     |         NA |        NA |        NA |         NA |     ? |       ? |        NA |     NA |        NA |           ? |
|                         |                      |                      |            |            |           |           |            |       |         |           |        |           |             |
| FerrisValueMapping      | .NET 8.0             | .NET 8.0             | Value      | 6,398.0 ns | 127.10 ns | 112.68 ns | 6,435.4 ns |  2.05 |    0.06 |  16,700 B | 1.8692 |    7849 B |        9.34 |
| NewtonsoftValueMapping  | .NET 8.0             | .NET 8.0             | Value      | 6,845.9 ns | 117.76 ns | 135.61 ns | 6,840.2 ns |  2.19 |    0.07 |   2,204 B | 1.7090 |    7168 B |        8.53 |
| TextJsonValueMapping    | .NET 8.0             | .NET 8.0             | Value      | 3,123.6 ns |  60.70 ns |  81.03 ns | 3,153.2 ns |  1.00 |    0.04 |   4,892 B | 0.1984 |     840 B |        1.00 |
|                         |                      |                      |            |            |           |           |            |       |         |           |        |           |             |
| FerrisValueMapping      | .NET Framework 4.6.2 | .NET Framework 4.6.2 | Value      |         NA |        NA |        NA |         NA |     ? |       ? |        NA |     NA |        NA |           ? |
| NewtonsoftValueMapping  | .NET Framework 4.6.2 | .NET Framework 4.6.2 | Value      |         NA |        NA |        NA |         NA |     ? |       ? |        NA |     NA |        NA |           ? |
| TextJsonValueMapping    | .NET Framework 4.6.2 | .NET Framework 4.6.2 | Value      |         NA |        NA |        NA |         NA |     ? |       ? |        NA |     NA |        NA |           ? |

Benchmarks with issues:
  SimpleJsonBenchmark.FerrisListMapping: .NET Framework 4.6.2(Runtime=.NET Framework 4.6.2)
  SimpleJsonBenchmark.NewtonsoftListMapping: .NET Framework 4.6.2(Runtime=.NET Framework 4.6.2)
  SimpleJsonBenchmark.TextJsonListMapping: .NET Framework 4.6.2(Runtime=.NET Framework 4.6.2)
  SimpleJsonBenchmark.FerrisSingleMapping: .NET Framework 4.6.2(Runtime=.NET Framework 4.6.2)
  SimpleJsonBenchmark.NewtonsoftSingleMapping: .NET Framework 4.6.2(Runtime=.NET Framework 4.6.2)
  SimpleJsonBenchmark.STJSingleMapping: .NET Framework 4.6.2(Runtime=.NET Framework 4.6.2)
  SimpleJsonBenchmark.FerrisValueMapping: .NET Framework 4.6.2(Runtime=.NET Framework 4.6.2)
  SimpleJsonBenchmark.NewtonsoftValueMapping: .NET Framework 4.6.2(Runtime=.NET Framework 4.6.2)
  SimpleJsonBenchmark.TextJsonValueMapping: .NET Framework 4.6.2(Runtime=.NET Framework 4.6.2)
