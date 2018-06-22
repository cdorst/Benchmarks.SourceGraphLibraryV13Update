``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-3570K CPU 3.40GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=2.1.300
  [Host]     : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  Job-IOKBIZ : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT

LaunchCount=10  

```
|     Method |         Mean |     Error |     StdDev |       Median | Rank |    Gen 0 |   Gen 1 | Allocated |
|----------- |-------------:|----------:|-----------:|-------------:|-----:|---------:|--------:|----------:|
| GetAccount | 1,692.868 us | 3.4788 us | 12.2892 us | 1,690.752 us |    2 | 128.9063 | 35.1563 | 399.64 KB |
|    GetCode |     6.152 us | 0.0388 us |  0.1451 us |     6.110 us |    1 |   1.8463 |       - |   5.69 KB |
