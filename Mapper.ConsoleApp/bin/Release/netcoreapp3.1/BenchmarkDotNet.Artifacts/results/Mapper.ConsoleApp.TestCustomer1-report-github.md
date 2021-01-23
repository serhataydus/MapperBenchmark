``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.592 (1909/November2018Update/19H2)
Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT  [AttachedDebugger]
  Job-DCGRNS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

IterationCount=1  RunStrategy=ColdStart  

```
|                             Method |      Mean | Error |       Min |       Max |    Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------------- |----------:|------:|----------:|----------:|----------:|------:|------:|------:|----------:|
|           ManuelMappingDataCount10 |        NA |    NA |        NA |        NA |        NA |     - |     - |     - |         - |
|          ManuelMappingDataCount100 |        NA |    NA |        NA |        NA |        NA |     - |     - |     - |         - |
|         ManuelMappingDataCount1000 |        NA |    NA |        NA |        NA |        NA |     - |     - |     - |         - |
|        ManuelMappingDataCount10000 |        NA |    NA |        NA |        NA |        NA |     - |     - |     - |         - |
|       ManuelLinqMappingDataCount10 |        NA |    NA |        NA |        NA |        NA |     - |     - |     - |         - |
|      ManuelLinqMappingDataCount100 |        NA |    NA |        NA |        NA |        NA |     - |     - |     - |         - |
|     ManuelLinqMappingDataCount1000 |        NA |    NA |        NA |        NA |        NA |     - |     - |     - |         - |
|    ManuelLinqMappingDataCount10000 |        NA |    NA |        NA |        NA |        NA |     - |     - |     - |         - |
|      AgileMapperLibraryDataCount10 |  57.56 ms |    NA |  57.56 ms |  57.56 ms |  57.56 ms |     - |     - |     - |      64 B |
|     AgileMapperLibraryDataCount100 |  53.01 ms |    NA |  53.01 ms |  53.01 ms |  53.01 ms |     - |     - |     - |      64 B |
|    AgileMapperLibraryDataCount1000 |  53.58 ms |    NA |  53.58 ms |  53.58 ms |  53.58 ms |     - |     - |     - |      64 B |
|   AgileMapperLibraryDataCount10000 |  51.15 ms |    NA |  51.15 ms |  51.15 ms |  51.15 ms |     - |     - |     - |      64 B |
|       AutoMapperLibraryDataCount10 | 165.70 ms |    NA | 165.70 ms | 165.70 ms | 165.70 ms |     - |     - |     - |  805520 B |
|      AutoMapperLibraryDataCount100 | 159.10 ms |    NA | 159.10 ms | 159.10 ms | 159.10 ms |     - |     - |     - |  805520 B |
|     AutoMapperLibraryDataCount1000 | 161.51 ms |    NA | 161.51 ms | 161.51 ms | 161.51 ms |     - |     - |     - |  805520 B |
|    AutoMapperLibraryDataCount10000 | 176.04 ms |    NA | 176.04 ms | 176.04 ms | 176.04 ms |     - |     - |     - |  805544 B |
|    ExpressMapperLibraryDataCount10 |        NA |    NA |        NA |        NA |        NA |     - |     - |     - |         - |
|   ExpressMapperLibraryDataCount100 |        NA |    NA |        NA |        NA |        NA |     - |     - |     - |         - |
|  ExpressMapperLibraryDataCount1000 |        NA |    NA |        NA |        NA |        NA |     - |     - |     - |         - |
| ExpressMapperLibraryDataCount10000 |        NA |    NA |        NA |        NA |        NA |     - |     - |     - |         - |
|          MapsterLibraryDataCount10 |  16.91 ms |    NA |  16.91 ms |  16.91 ms |  16.91 ms |     - |     - |     - |      24 B |
|         MapsterLibraryDataCount100 |  16.80 ms |    NA |  16.80 ms |  16.80 ms |  16.80 ms |     - |     - |     - |      24 B |
|        MapsterLibraryDataCount1000 |  17.84 ms |    NA |  17.84 ms |  17.84 ms |  17.84 ms |     - |     - |     - |      24 B |
|       MapsterLibraryDataCount10000 |  16.78 ms |    NA |  16.78 ms |  16.78 ms |  16.78 ms |     - |     - |     - |      24 B |
|       TinyMapperLibraryDataCount10 |        NA |    NA |        NA |        NA |        NA |     - |     - |     - |         - |
|      TinyMapperLibraryDataCount100 |        NA |    NA |        NA |        NA |        NA |     - |     - |     - |         - |
|     TinyMapperLibraryDataCount1000 |        NA |    NA |        NA |        NA |        NA |     - |     - |     - |         - |
|    TinyMapperLibraryDataCount10000 |        NA |    NA |        NA |        NA |        NA |     - |     - |     - |         - |

Benchmarks with issues:
  TestCustomer1.ManuelMappingDataCount10: Job-DCGRNS(IterationCount=1, RunStrategy=ColdStart)
  TestCustomer1.ManuelMappingDataCount100: Job-DCGRNS(IterationCount=1, RunStrategy=ColdStart)
  TestCustomer1.ManuelMappingDataCount1000: Job-DCGRNS(IterationCount=1, RunStrategy=ColdStart)
  TestCustomer1.ManuelMappingDataCount10000: Job-DCGRNS(IterationCount=1, RunStrategy=ColdStart)
  TestCustomer1.ManuelLinqMappingDataCount10: Job-DCGRNS(IterationCount=1, RunStrategy=ColdStart)
  TestCustomer1.ManuelLinqMappingDataCount100: Job-DCGRNS(IterationCount=1, RunStrategy=ColdStart)
  TestCustomer1.ManuelLinqMappingDataCount1000: Job-DCGRNS(IterationCount=1, RunStrategy=ColdStart)
  TestCustomer1.ManuelLinqMappingDataCount10000: Job-DCGRNS(IterationCount=1, RunStrategy=ColdStart)
  TestCustomer1.ExpressMapperLibraryDataCount10: Job-DCGRNS(IterationCount=1, RunStrategy=ColdStart)
  TestCustomer1.ExpressMapperLibraryDataCount100: Job-DCGRNS(IterationCount=1, RunStrategy=ColdStart)
  TestCustomer1.ExpressMapperLibraryDataCount1000: Job-DCGRNS(IterationCount=1, RunStrategy=ColdStart)
  TestCustomer1.ExpressMapperLibraryDataCount10000: Job-DCGRNS(IterationCount=1, RunStrategy=ColdStart)
  TestCustomer1.TinyMapperLibraryDataCount10: Job-DCGRNS(IterationCount=1, RunStrategy=ColdStart)
  TestCustomer1.TinyMapperLibraryDataCount100: Job-DCGRNS(IterationCount=1, RunStrategy=ColdStart)
  TestCustomer1.TinyMapperLibraryDataCount1000: Job-DCGRNS(IterationCount=1, RunStrategy=ColdStart)
  TestCustomer1.TinyMapperLibraryDataCount10000: Job-DCGRNS(IterationCount=1, RunStrategy=ColdStart)
