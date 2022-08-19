# Mapper Benchmark 
 
# Libraries included in the comparison :
1. Custom Manual Mapping
2. System Linq Mapping
3. Auto Mapper Mapping - AutoMapper Version="11.0.1"
4. Agile Mapper Mapping - AgileObjects.AgileMapper Version="1.8.1"
5. Express Mapper Mapping - Expressmapper Version="1.9.1"
6. Mapster Mapping - Mapster Version="7.3.0"
7. Tiny Mapper Mapping - TinyMapper Version="3.0.3"

# 3 consecutive results

```javascript
1. Result :
|                  Method |       Mean | Error |        Min |        Max |     Median |   Allocated |
|------------------------ |-----------:|------:|-----------:|-----------:|-----------:|------------:|
|      CustomMapperCount1 |   9.118 ms |    NA |   9.118 ms |   9.118 ms |   9.118 ms |       496 B |
|        LinqMapperCount1 |   8.586 ms |    NA |   8.586 ms |   8.586 ms |   8.586 ms |       496 B |
|       AgileMapperCount1 | 183.562 ms |    NA | 183.562 ms | 183.562 ms | 183.562 ms |       936 B |
|        AutoMapperCount1 |  16.584 ms |    NA |  16.584 ms |  16.584 ms |  16.584 ms |       496 B |
|     ExpressMapperCount1 |  82.928 ms |    NA |  82.928 ms |  82.928 ms |  82.928 ms |       584 B |
|     MapsterMapperCount1 |  88.166 ms |    NA |  88.166 ms |  88.166 ms |  88.166 ms |       496 B |
|        TinyMapperCount1 |   1.631 ms |    NA |   1.631 ms |   1.631 ms |   1.631 ms |       592 B |
|     CustomMapperCount10 |   1.289 ms |    NA |   1.289 ms |   1.289 ms |   1.289 ms |     1,832 B |
|       LinqMapperCount10 |   1.234 ms |    NA |   1.234 ms |   1.234 ms |   1.234 ms |     1,752 B |
|      AgileMapperCount10 | 134.457 ms |    NA | 134.457 ms | 134.457 ms | 134.457 ms |     2,080 B |
|       AutoMapperCount10 |  22.808 ms |    NA |  22.808 ms |  22.808 ms |  22.808 ms |     1,832 B |
|    ExpressMapperCount10 |  75.660 ms |    NA |  75.660 ms |  75.660 ms |  75.660 ms |     2,880 B |
|    MapsterMapperCount10 |  63.366 ms |    NA |  63.366 ms |  63.366 ms |  63.366 ms |     1,640 B |
|       TinyMapperCount10 |   2.495 ms |    NA |   2.495 ms |   2.495 ms |   2.495 ms |     2,352 B |
|    CustomMapperCount100 |   1.229 ms |    NA |   1.229 ms |   1.229 ms |   1.229 ms |    13,776 B |
|      LinqMapperCount100 |   1.154 ms |    NA |   1.154 ms |   1.154 ms |   1.154 ms |    12,552 B |
|     AgileMapperCount100 | 135.015 ms |    NA | 135.015 ms | 135.015 ms | 135.015 ms |    12,880 B |
|      AutoMapperCount100 |  22.867 ms |    NA |  22.867 ms |  22.867 ms |  22.867 ms |    13,776 B |
|   ExpressMapperCount100 |  79.112 ms |    NA |  79.112 ms |  79.112 ms |  79.112 ms |    15,544 B |
|   MapsterMapperCount100 |  62.673 ms |    NA |  62.673 ms |  62.673 ms |  62.673 ms |    12,440 B |
|      TinyMapperCount100 |   2.756 ms |    NA |   2.756 ms |   2.756 ms |   2.756 ms |    18,616 B |
|   CustomMapperCount1000 |   1.407 ms |    NA |   1.407 ms |   1.407 ms |   1.407 ms |   128,984 B |
|     LinqMapperCount1000 |   1.185 ms |    NA |   1.185 ms |   1.185 ms |   1.185 ms |   120,552 B |
|    AgileMapperCount1000 | 133.538 ms |    NA | 133.538 ms | 133.538 ms | 133.538 ms |   120,880 B |
|     AutoMapperCount1000 |  22.927 ms |    NA |  22.927 ms |  22.927 ms |  22.927 ms |   128,984 B |
|  ExpressMapperCount1000 |  76.597 ms |    NA |  76.597 ms |  76.597 ms |  76.597 ms |   137,952 B |
|  MapsterMapperCount1000 |  63.385 ms |    NA |  63.385 ms |  63.385 ms |  63.385 ms |   120,440 B |
|     TinyMapperCount1000 |   3.224 ms |    NA |   3.224 ms |   3.224 ms |   3.224 ms |   177,024 B |
|  CustomMapperCount10000 |   2.526 ms |    NA |   2.526 ms |   2.526 ms |   2.526 ms | 1,382,840 B |
|    LinqMapperCount10000 |   2.358 ms |    NA |   2.358 ms |   2.358 ms |   2.358 ms | 1,200,552 B |
|   AgileMapperCount10000 | 138.144 ms |    NA | 138.144 ms | 138.144 ms | 138.144 ms | 1,200,880 B |
|    AutoMapperCount10000 |  24.923 ms |    NA |  24.923 ms |  24.923 ms |  24.923 ms | 1,383,176 B |
| ExpressMapperCount10000 |  78.053 ms |    NA |  78.053 ms |  78.053 ms |  78.053 ms | 1,463,808 B |
| MapsterMapperCount10000 |  67.641 ms |    NA |  67.641 ms |  67.641 ms |  67.641 ms | 1,200,440 B |
|    TinyMapperCount10000 |   5.239 ms |    NA |   5.239 ms |   5.239 ms |   5.239 ms | 1,862,880 B |

2. Result :
|                  Method |       Mean | Error |        Min |        Max |     Median |   Allocated |
|------------------------ |-----------:|------:|-----------:|-----------:|-----------:|------------:|
|      CustomMapperCount1 |   8.652 ms |    NA |   8.652 ms |   8.652 ms |   8.652 ms |       496 B |
|        LinqMapperCount1 |   1.715 ms |    NA |   1.715 ms |   1.715 ms |   1.715 ms |       496 B |
|       AgileMapperCount1 | 202.301 ms |    NA | 202.301 ms | 202.301 ms | 202.301 ms |       936 B |
|        AutoMapperCount1 |  16.758 ms |    NA |  16.758 ms |  16.758 ms |  16.758 ms |       496 B |
|     ExpressMapperCount1 |  81.170 ms |    NA |  81.170 ms |  81.170 ms |  81.170 ms |       584 B |
|     MapsterMapperCount1 |  77.503 ms |    NA |  77.503 ms |  77.503 ms |  77.503 ms |       496 B |
|        TinyMapperCount1 |   1.685 ms |    NA |   1.685 ms |   1.685 ms |   1.685 ms |       592 B |
|     CustomMapperCount10 |   1.331 ms |    NA |   1.331 ms |   1.331 ms |   1.331 ms |     1,832 B |
|       LinqMapperCount10 |   1.144 ms |    NA |   1.144 ms |   1.144 ms |   1.144 ms |     1,752 B |
|      AgileMapperCount10 | 130.891 ms |    NA | 130.891 ms | 130.891 ms | 130.891 ms |     2,080 B |
|       AutoMapperCount10 |  22.701 ms |    NA |  22.701 ms |  22.701 ms |  22.701 ms |     1,832 B |
|    ExpressMapperCount10 |  76.496 ms |    NA |  76.496 ms |  76.496 ms |  76.496 ms |     2,880 B |
|    MapsterMapperCount10 |  62.656 ms |    NA |  62.656 ms |  62.656 ms |  62.656 ms |     1,640 B |
|       TinyMapperCount10 |   2.809 ms |    NA |   2.809 ms |   2.809 ms |   2.809 ms |     2,352 B |
|    CustomMapperCount100 |   1.274 ms |    NA |   1.274 ms |   1.274 ms |   1.274 ms |    13,776 B |
|      LinqMapperCount100 |   1.135 ms |    NA |   1.135 ms |   1.135 ms |   1.135 ms |    12,552 B |
|     AgileMapperCount100 | 130.198 ms |    NA | 130.198 ms | 130.198 ms | 130.198 ms |    12,880 B |
|      AutoMapperCount100 |  22.731 ms |    NA |  22.731 ms |  22.731 ms |  22.731 ms |    13,776 B |
|   ExpressMapperCount100 |  82.230 ms |    NA |  82.230 ms |  82.230 ms |  82.230 ms |    15,544 B |
|   MapsterMapperCount100 |  62.477 ms |    NA |  62.477 ms |  62.477 ms |  62.477 ms |    12,440 B |
|      TinyMapperCount100 |   2.832 ms |    NA |   2.832 ms |   2.832 ms |   2.832 ms |    18,616 B |
|   CustomMapperCount1000 |   1.393 ms |    NA |   1.393 ms |   1.393 ms |   1.393 ms |   128,984 B |
|     LinqMapperCount1000 |   1.328 ms |    NA |   1.328 ms |   1.328 ms |   1.328 ms |   120,552 B |
|    AgileMapperCount1000 | 135.130 ms |    NA | 135.130 ms | 135.130 ms | 135.130 ms |   120,880 B |
|     AutoMapperCount1000 |  23.076 ms |    NA |  23.076 ms |  23.076 ms |  23.076 ms |   128,984 B |
|  ExpressMapperCount1000 |  75.889 ms |    NA |  75.889 ms |  75.889 ms |  75.889 ms |   137,952 B |
|  MapsterMapperCount1000 |  58.890 ms |    NA |  58.890 ms |  58.890 ms |  58.890 ms |   120,440 B |
|     TinyMapperCount1000 |   2.818 ms |    NA |   2.818 ms |   2.818 ms |   2.818 ms |   177,024 B |
|  CustomMapperCount10000 |   2.398 ms |    NA |   2.398 ms |   2.398 ms |   2.398 ms | 1,382,840 B |
|    LinqMapperCount10000 |   2.229 ms |    NA |   2.229 ms |   2.229 ms |   2.229 ms | 1,200,552 B |
|   AgileMapperCount10000 | 135.104 ms |    NA | 135.104 ms | 135.104 ms | 135.104 ms | 1,200,880 B |
|    AutoMapperCount10000 |  24.904 ms |    NA |  24.904 ms |  24.904 ms |  24.904 ms | 1,382,840 B |
| ExpressMapperCount10000 |  74.225 ms |    NA |  74.225 ms |  74.225 ms |  74.225 ms | 1,463,808 B |
| MapsterMapperCount10000 |  63.606 ms |    NA |  63.606 ms |  63.606 ms |  63.606 ms | 1,200,440 B |
|    TinyMapperCount10000 |   4.717 ms |    NA |   4.717 ms |   4.717 ms |   4.717 ms | 1,862,880 B |

3. Result : 
|                  Method |       Mean | Error |        Min |        Max |     Median |   Allocated |
|------------------------ |-----------:|------:|-----------:|-----------:|-----------:|------------:|
|      CustomMapperCount1 |   8.420 ms |    NA |   8.420 ms |   8.420 ms |   8.420 ms |       496 B |
|        LinqMapperCount1 |   8.834 ms |    NA |   8.834 ms |   8.834 ms |   8.834 ms |       496 B |
|       AgileMapperCount1 | 189.714 ms |    NA | 189.714 ms | 189.714 ms | 189.714 ms |       936 B |
|        AutoMapperCount1 |  17.280 ms |    NA |  17.280 ms |  17.280 ms |  17.280 ms |       496 B |
|     ExpressMapperCount1 |  83.058 ms |    NA |  83.058 ms |  83.058 ms |  83.058 ms |       584 B |
|     MapsterMapperCount1 |  89.060 ms |    NA |  89.060 ms |  89.060 ms |  89.060 ms |       496 B |
|        TinyMapperCount1 |   1.604 ms |    NA |   1.604 ms |   1.604 ms |   1.604 ms |       592 B |
|     CustomMapperCount10 |   1.287 ms |    NA |   1.287 ms |   1.287 ms |   1.287 ms |     1,832 B |
|       LinqMapperCount10 |   1.102 ms |    NA |   1.102 ms |   1.102 ms |   1.102 ms |     1,752 B |
|      AgileMapperCount10 | 128.481 ms |    NA | 128.481 ms | 128.481 ms | 128.481 ms |     2,080 B |
|       AutoMapperCount10 |  22.902 ms |    NA |  22.902 ms |  22.902 ms |  22.902 ms |     1,832 B |
|    ExpressMapperCount10 |  75.789 ms |    NA |  75.789 ms |  75.789 ms |  75.789 ms |     2,880 B |
|    MapsterMapperCount10 |  63.243 ms |    NA |  63.243 ms |  63.243 ms |  63.243 ms |     1,640 B |
|       TinyMapperCount10 |   2.663 ms |    NA |   2.663 ms |   2.663 ms |   2.663 ms |     2,352 B |
|    CustomMapperCount100 |   1.352 ms |    NA |   1.352 ms |   1.352 ms |   1.352 ms |    13,776 B |
|      LinqMapperCount100 |   1.163 ms |    NA |   1.163 ms |   1.163 ms |   1.163 ms |    12,552 B |
|     AgileMapperCount100 | 134.475 ms |    NA | 134.475 ms | 134.475 ms | 134.475 ms |    12,880 B |
|      AutoMapperCount100 |  24.589 ms |    NA |  24.589 ms |  24.589 ms |  24.589 ms |    13,776 B |
|   ExpressMapperCount100 |  79.615 ms |    NA |  79.615 ms |  79.615 ms |  79.615 ms |    15,544 B |
|   MapsterMapperCount100 |  64.298 ms |    NA |  64.298 ms |  64.298 ms |  64.298 ms |    12,440 B |
|      TinyMapperCount100 |   2.641 ms |    NA |   2.641 ms |   2.641 ms |   2.641 ms |    18,616 B |
|   CustomMapperCount1000 |   1.491 ms |    NA |   1.491 ms |   1.491 ms |   1.491 ms |   128,984 B |
|     LinqMapperCount1000 |   1.284 ms |    NA |   1.284 ms |   1.284 ms |   1.284 ms |   120,552 B |
|    AgileMapperCount1000 | 136.253 ms |    NA | 136.253 ms | 136.253 ms | 136.253 ms |   120,880 B |
|     AutoMapperCount1000 |  23.450 ms |    NA |  23.450 ms |  23.450 ms |  23.450 ms |   128,984 B |
|  ExpressMapperCount1000 |  76.144 ms |    NA |  76.144 ms |  76.144 ms |  76.144 ms |   137,952 B |
|  MapsterMapperCount1000 |  62.772 ms |    NA |  62.772 ms |  62.772 ms |  62.772 ms |   120,440 B |
|     TinyMapperCount1000 |   2.926 ms |    NA |   2.926 ms |   2.926 ms |   2.926 ms |   177,024 B |
|  CustomMapperCount10000 |   2.417 ms |    NA |   2.417 ms |   2.417 ms |   2.417 ms | 1,382,840 B |
|    LinqMapperCount10000 |   2.272 ms |    NA |   2.272 ms |   2.272 ms |   2.272 ms | 1,200,552 B |
|   AgileMapperCount10000 | 130.109 ms |    NA | 130.109 ms | 130.109 ms | 130.109 ms | 1,200,880 B |
|    AutoMapperCount10000 |  23.122 ms |    NA |  23.122 ms |  23.122 ms |  23.122 ms | 1,382,840 B |
| ExpressMapperCount10000 |  77.949 ms |    NA |  77.949 ms |  77.949 ms |  77.949 ms | 1,463,808 B |
| MapsterMapperCount10000 |  62.072 ms |    NA |  62.072 ms |  62.072 ms |  62.072 ms | 1,200,440 B |
|    TinyMapperCount10000 |   5.111 ms |    NA |   5.111 ms |   5.111 ms |   5.111 ms | 1,862,880 B |
```