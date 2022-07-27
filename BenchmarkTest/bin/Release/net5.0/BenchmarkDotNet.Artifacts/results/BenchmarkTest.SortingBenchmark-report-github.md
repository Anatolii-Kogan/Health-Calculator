``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1766 (21H2)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.406
  [Host]     : .NET 5.0.15 (5.0.1522.11506), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.15 (5.0.1522.11506), X64 RyuJIT


```
|                                Method |             Mean |           Error |          StdDev |  Gen 0 | Allocated |
|-------------------------------------- |-----------------:|----------------:|----------------:|-------:|----------:|
|            GetMaxValuesSmallArrayTest |         630.5 ns |        10.74 ns |        10.05 ns | 0.2518 |      2 KB |
|                      GetMaxValuesTest |      21,487.6 ns |       191.96 ns |       179.56 ns | 0.5493 |      4 KB |
|            GetMaxValuesLargeArrayTest |   1,978,151.0 ns |    28,041.64 ns |    24,858.18 ns |      - |      6 KB |
|        GetMaxValuesVeryLargeArrayTest | 201,076,300.0 ns | 1,185,738.55 ns |   925,746.66 ns |      - |      9 KB |
|     GetMaxValuesIndexesSmallArrayTest |         722.5 ns |         4.27 ns |         3.78 ns | 0.2975 |      2 KB |
|               GetMaxValuesIndexesTest |      21,422.6 ns |       185.80 ns |       164.71 ns | 0.4883 |      3 KB |
|     GetMaxValuesIndexesLargeArrayTest |   1,958,194.9 ns |     8,853.32 ns |     7,848.24 ns |      - |      6 KB |
| GetMaxValuesIndexesVeryLargeArrayTest | 205,616,737.3 ns | 4,061,764.79 ns | 5,422,339.33 ns |      - |      8 KB |
