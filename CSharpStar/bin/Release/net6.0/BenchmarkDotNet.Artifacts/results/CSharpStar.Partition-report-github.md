``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.674)
AMD Ryzen 5 3600, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.400
  [Host]     : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2  [AttachedDebugger]
  DefaultJob : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2


```
|                 Method |       Mean |     Error |    StdDev |
|----------------------- |-----------:|----------:|----------:|
|        SquareEachValue | 3,162.9 μs | 110.27 μs | 325.12 μs |
| SquareEachValueChunked |   559.7 μs |   7.97 μs |   7.46 μs |
