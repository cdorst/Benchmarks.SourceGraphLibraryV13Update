``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-3570K CPU 3.40GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=2.1.300
  [Host]     : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  Job-OZLYTP : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT

LaunchCount=10  

```
|     Method |         Mean |     Error |     StdDev |       Median | Rank |    Gen 0 |   Gen 1 | Allocated |
|----------- |-------------:|----------:|-----------:|-------------:|-----:|---------:|--------:|----------:|
| GetAccount | 1,714.277 us | 8.9811 us | 33.6627 us | 1,706.504 us |    2 | 123.0469 | 39.0625 | 383.45 KB |
|    GetCode |     5.055 us | 0.0199 us |  0.0720 us |     5.038 us |    1 |   1.4496 |       - |   4.46 KB |
