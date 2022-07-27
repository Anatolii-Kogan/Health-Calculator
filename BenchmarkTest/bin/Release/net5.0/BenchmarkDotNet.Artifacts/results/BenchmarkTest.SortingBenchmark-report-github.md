``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1766 (21H2)
Intel Core i7-10750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=5.0.406
  [Host]     : .NET 5.0.15 (5.0.1522.11506), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.15 (5.0.1522.11506), X64 RyuJIT


```
|                         Method |             Mean |           Error |          StdDev |  Gen 0 | Allocated |
|------------------------------- |-----------------:|----------------:|----------------:|-------:|----------:|
|     GetMaxValuesSmallArrayTest |         355.4 ns |         4.04 ns |         3.37 ns | 0.0100 |      64 B |
|               GetMaxValuesTest |      14,013.3 ns |       102.27 ns |        90.66 ns |      - |      64 B |
|     GetMaxValuesLargeArrayTest |   1,354,992.3 ns |    15,633.84 ns |    14,623.91 ns |      - |      64 B |
| GetMaxValuesVeryLargeArrayTest | 148,074,864.7 ns | 2,852,071.82 ns | 2,928,867.78 ns |      - |      74 B |
