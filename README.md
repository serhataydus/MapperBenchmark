# MapperBenchmark 

Benchmar 1 Result

    BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.592 (1909/November2018Update/19H2)
    Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
    .NET Core SDK=5.0.100
      [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT  [AttachedDebugger]
      Job-HIPRHG : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

    IterationCount=1  RunStrategy=ColdStart  

  Method                               Mean        Error   Min         Max         Median      Gen 0   Gen 1   Gen 2   Allocated
  ------------------------------------ ----------- ------- ----------- ----------- ----------- ------- ------- ------- -----------
  ManuelMappingDataCount10             NA          NA      NA          NA          NA          -       -       -       -
  ManuelMappingDataCount100            NA          NA      NA          NA          NA          -       -       -       -
  ManuelMappingDataCount1000           NA          NA      NA          NA          NA          -       -       -       -
  ManuelMappingDataCount10000          NA          NA      NA          NA          NA          -       -       -       -
  ManuelLinqMappingDataCount10         NA          NA      NA          NA          NA          -       -       -       -
  ManuelLinqMappingDataCount100        NA          NA      NA          NA          NA          -       -       -       -
  ManuelLinqMappingDataCount1000       NA          NA      NA          NA          NA          -       -       -       -
  ManuelLinqMappingDataCount10000      NA          NA      NA          NA          NA          -       -       -       -
  AgileMapperLibraryDataCount10        46.33 ms    NA      46.33 ms    46.33 ms    46.33 ms    -       -       -       64 B
  AgileMapperLibraryDataCount100       45.80 ms    NA      45.80 ms    45.80 ms    45.80 ms    -       -       -       64 B
  AgileMapperLibraryDataCount1000      45.32 ms    NA      45.32 ms    45.32 ms    45.32 ms    -       -       -       64 B
  AgileMapperLibraryDataCount10000     44.36 ms    NA      44.36 ms    44.36 ms    44.36 ms    -       -       -       64 B
  AutoMapperLibraryDataCount10         149.30 ms   NA      149.30 ms   149.30 ms   149.30 ms   -       -       -       805520 B
  AutoMapperLibraryDataCount100        141.98 ms   NA      141.98 ms   141.98 ms   141.98 ms   -       -       -       805520 B
  AutoMapperLibraryDataCount1000       138.81 ms   NA      138.81 ms   138.81 ms   138.81 ms   -       -       -       805520 B
  AutoMapperLibraryDataCount10000      143.24 ms   NA      143.24 ms   143.24 ms   143.24 ms   -       -       -       805520 B
  ExpressMapperLibraryDataCount10      NA          NA      NA          NA          NA          -       -       -       -
  ExpressMapperLibraryDataCount100     NA          NA      NA          NA          NA          -       -       -       -
  ExpressMapperLibraryDataCount1000    NA          NA      NA          NA          NA          -       -       -       -
  ExpressMapperLibraryDataCount10000   NA          NA      NA          NA          NA          -       -       -       -
  MapsterLibraryDataCount10            15.48 ms    NA      15.48 ms    15.48 ms    15.48 ms    -       -       -       24 B
  MapsterLibraryDataCount100           15.64 ms    NA      15.64 ms    15.64 ms    15.64 ms    -       -       -       24 B
  MapsterLibraryDataCount1000          15.20 ms    NA      15.20 ms    15.20 ms    15.20 ms    -       -       -       24 B
  MapsterLibraryDataCount10000         16.53 ms    NA      16.53 ms    16.53 ms    16.53 ms    -       -       -       24 B
  TinyMapperLibraryDataCount10         NA          NA      NA          NA          NA          -       -       -       -
  TinyMapperLibraryDataCount100        NA          NA      NA          NA          NA          -       -       -       -
  TinyMapperLibraryDataCount1000       NA          NA      NA          NA          NA          -       -       -       -
  TinyMapperLibraryDataCount10000      NA          NA      NA          NA          NA          -       -       -       -


---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Benchmark 2 Result

    BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.592 (1909/November2018Update/19H2)
    Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
    .NET Core SDK=5.0.100
      [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT  [AttachedDebugger]
      Job-KQFSQK : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

    IterationCount=1  RunStrategy=ColdStart  

  Method                               Mean        Error   Min         Max         Median      Gen 0   Gen 1   Gen 2   Allocated
  ------------------------------------ ----------- ------- ----------- ----------- ----------- ------- ------- ------- -----------
  ManuelMappingDataCount10             NA          NA      NA          NA          NA          -       -       -       -
  ManuelMappingDataCount100            NA          NA      NA          NA          NA          -       -       -       -
  ManuelMappingDataCount1000           NA          NA      NA          NA          NA          -       -       -       -
  ManuelMappingDataCount10000          NA          NA      NA          NA          NA          -       -       -       -
  ManuelLinqMappingDataCount10         NA          NA      NA          NA          NA          -       -       -       -
  ManuelLinqMappingDataCount100        NA          NA      NA          NA          NA          -       -       -       -
  ManuelLinqMappingDataCount1000       NA          NA      NA          NA          NA          -       -       -       -
  ManuelLinqMappingDataCount10000      NA          NA      NA          NA          NA          -       -       -       -
  AgileMapperLibraryDataCount10        49.88 ms    NA      49.88 ms    49.88 ms    49.88 ms    -       -       -       64 B
  AgileMapperLibraryDataCount100       50.26 ms    NA      50.26 ms    50.26 ms    50.26 ms    -       -       -       64 B
  AgileMapperLibraryDataCount1000      49.35 ms    NA      49.35 ms    49.35 ms    49.35 ms    -       -       -       64 B
  AgileMapperLibraryDataCount10000     52.85 ms    NA      52.85 ms    52.85 ms    52.85 ms    -       -       -       64 B
  AutoMapperLibraryDataCount10         160.09 ms   NA      160.09 ms   160.09 ms   160.09 ms   -       -       -       805520 B
  AutoMapperLibraryDataCount100        163.51 ms   NA      163.51 ms   163.51 ms   163.51 ms   -       -       -       805520 B
  AutoMapperLibraryDataCount1000       169.73 ms   NA      169.73 ms   169.73 ms   169.73 ms   -       -       -       805520 B
  AutoMapperLibraryDataCount10000      163.67 ms   NA      163.67 ms   163.67 ms   163.67 ms   -       -       -       805520 B
  ExpressMapperLibraryDataCount10      NA          NA      NA          NA          NA          -       -       -       -
  ExpressMapperLibraryDataCount100     NA          NA      NA          NA          NA          -       -       -       -
  ExpressMapperLibraryDataCount1000    NA          NA      NA          NA          NA          -       -       -       -
  ExpressMapperLibraryDataCount10000   NA          NA      NA          NA          NA          -       -       -       -
  MapsterLibraryDataCount10            16.39 ms    NA      16.39 ms    16.39 ms    16.39 ms    -       -       -       24 B
  MapsterLibraryDataCount100           17.46 ms    NA      17.46 ms    17.46 ms    17.46 ms    -       -       -       24 B
  MapsterLibraryDataCount1000          16.22 ms    NA      16.22 ms    16.22 ms    16.22 ms    -       -       -       24 B
  MapsterLibraryDataCount10000         17.07 ms    NA      17.07 ms    17.07 ms    17.07 ms    -       -       -       24 B
  TinyMapperLibraryDataCount10         NA          NA      NA          NA          NA          -       -       -       -
  TinyMapperLibraryDataCount100        NA          NA      NA          NA          NA          -       -       -       -
  TinyMapperLibraryDataCount1000       NA          NA      NA          NA          NA          -       -       -       -
  TinyMapperLibraryDataCount10000      NA          NA      NA          NA          NA          -       -       -       -

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Benchmark 3 Result

    BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.592 (1909/November2018Update/19H2)
    Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
    .NET Core SDK=5.0.100
      [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT  [AttachedDebugger]
      Job-DCGRNS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

    IterationCount=1  RunStrategy=ColdStart  

  Method                               Mean        Error   Min         Max         Median      Gen 0   Gen 1   Gen 2   Allocated
  ------------------------------------ ----------- ------- ----------- ----------- ----------- ------- ------- ------- -----------
  ManuelMappingDataCount10             NA          NA      NA          NA          NA          -       -       -       -
  ManuelMappingDataCount100            NA          NA      NA          NA          NA          -       -       -       -
  ManuelMappingDataCount1000           NA          NA      NA          NA          NA          -       -       -       -
  ManuelMappingDataCount10000          NA          NA      NA          NA          NA          -       -       -       -
  ManuelLinqMappingDataCount10         NA          NA      NA          NA          NA          -       -       -       -
  ManuelLinqMappingDataCount100        NA          NA      NA          NA          NA          -       -       -       -
  ManuelLinqMappingDataCount1000       NA          NA      NA          NA          NA          -       -       -       -
  ManuelLinqMappingDataCount10000      NA          NA      NA          NA          NA          -       -       -       -
  AgileMapperLibraryDataCount10        57.56 ms    NA      57.56 ms    57.56 ms    57.56 ms    -       -       -       64 B
  AgileMapperLibraryDataCount100       53.01 ms    NA      53.01 ms    53.01 ms    53.01 ms    -       -       -       64 B
  AgileMapperLibraryDataCount1000      53.58 ms    NA      53.58 ms    53.58 ms    53.58 ms    -       -       -       64 B
  AgileMapperLibraryDataCount10000     51.15 ms    NA      51.15 ms    51.15 ms    51.15 ms    -       -       -       64 B
  AutoMapperLibraryDataCount10         165.70 ms   NA      165.70 ms   165.70 ms   165.70 ms   -       -       -       805520 B
  AutoMapperLibraryDataCount100        159.10 ms   NA      159.10 ms   159.10 ms   159.10 ms   -       -       -       805520 B
  AutoMapperLibraryDataCount1000       161.51 ms   NA      161.51 ms   161.51 ms   161.51 ms   -       -       -       805520 B
  AutoMapperLibraryDataCount10000      176.04 ms   NA      176.04 ms   176.04 ms   176.04 ms   -       -       -       805544 B
  ExpressMapperLibraryDataCount10      NA          NA      NA          NA          NA          -       -       -       -
  ExpressMapperLibraryDataCount100     NA          NA      NA          NA          NA          -       -       -       -
  ExpressMapperLibraryDataCount1000    NA          NA      NA          NA          NA          -       -       -       -
  ExpressMapperLibraryDataCount10000   NA          NA      NA          NA          NA          -       -       -       -
  MapsterLibraryDataCount10            16.91 ms    NA      16.91 ms    16.91 ms    16.91 ms    -       -       -       24 B
  MapsterLibraryDataCount100           16.80 ms    NA      16.80 ms    16.80 ms    16.80 ms    -       -       -       24 B
  MapsterLibraryDataCount1000          17.84 ms    NA      17.84 ms    17.84 ms    17.84 ms    -       -       -       24 B
  MapsterLibraryDataCount10000         16.78 ms    NA      16.78 ms    16.78 ms    16.78 ms    -       -       -       24 B
  TinyMapperLibraryDataCount10         NA          NA      NA          NA          NA          -       -       -       -
  TinyMapperLibraryDataCount100        NA          NA      NA          NA          NA          -       -       -       -
  TinyMapperLibraryDataCount1000       NA          NA      NA          NA          NA          -       -       -       -
  TinyMapperLibraryDataCount10000      NA          NA      NA          NA          NA          -       -       -       -
