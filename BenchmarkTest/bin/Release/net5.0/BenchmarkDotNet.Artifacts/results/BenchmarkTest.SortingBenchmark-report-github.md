``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1766 (21H2)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.406
  [Host]     : .NET 5.0.15 (5.0.1522.11506), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.15 (5.0.1522.11506), X64 RyuJIT


```
|                                Method |             Mean |           Error |          StdDev |  Gen 0 | Allocated |
|-------------------------------------- |-----------------:|----------------:|----------------:|-------:|----------:|
|            GetMaxValuesSmallArrayTest |         723.7 ns |        14.28 ns |        23.46 ns | 0.2518 |      2 KB |
|                      GetMaxValuesTest |      25,005.9 ns |        95.22 ns |        84.41 ns | 0.7324 |      5 KB |
|            GetMaxValuesLargeArrayTest |   2,251,997.7 ns |    17,978.48 ns |    15,937.45 ns |      - |      6 KB |
|        GetMaxValuesVeryLargeArrayTest | 207,042,902.5 ns | 3,101,093.76 ns | 5,512,191.01 ns |      - |      8 KB |
|     GetMaxValuesIndexesSmallArrayTest |         711.5 ns |         7.61 ns |         6.36 ns | 0.2670 |      2 KB |
|               GetMaxValuesIndexesTest |      22,125.8 ns |       326.74 ns |       376.27 ns | 0.5493 |      3 KB |
|     GetMaxValuesIndexesLargeArrayTest |   2,028,167.8 ns |    39,892.11 ns |    53,254.82 ns |      - |      6 KB |
| GetMaxValuesIndexesVeryLargeArrayTest | 226,918,185.7 ns | 2,524,760.35 ns | 2,238,134.29 ns |      - |      9 KB |
