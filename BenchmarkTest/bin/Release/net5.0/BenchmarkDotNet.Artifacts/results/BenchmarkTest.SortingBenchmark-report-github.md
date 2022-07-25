``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1766 (21H2)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.406
  [Host]     : .NET 5.0.15 (5.0.1522.11506), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.15 (5.0.1522.11506), X64 RyuJIT


```
|                      Method |             Mean |           Error |          StdDev | Rank |  Gen 0 | Allocated |
|---------------------------- |-----------------:|----------------:|----------------:|-----:|-------:|----------:|
|  GetMaxValuesSmallArrayTest |         354.9 ns |         3.76 ns |         3.51 ns |    1 | 0.0100 |      64 B |
|            GetMaxValuesTest |      10,519.9 ns |       114.84 ns |       107.43 ns |    2 |      - |      64 B |
|  GetMaxValuesLargeArrayTest |     975,360.1 ns |    18,781.07 ns |    22,357.53 ns |    3 |      - |      64 B |
| GetMaxValuesVLargeArrayTest | 100,025,676.2 ns | 1,879,214.70 ns | 1,845,640.11 ns |    4 |      - |      64 B |
