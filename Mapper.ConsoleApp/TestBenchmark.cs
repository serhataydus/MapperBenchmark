using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using Mapper.Core;
using Mapper.DTO;
using Mapper.Entity;
using Mapper.Logic;
using Mapper.SystemLinqLibrary;

namespace Mapper.ConsoleApp
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [AsciiDocExporter]
    [CsvExporter]
    [CsvMeasurementsExporter]
    [HtmlExporter]
    [PlainExporter]
    [RPlotExporter]
    [JsonExporterAttribute.Brief]
    [JsonExporterAttribute.BriefCompressed]
    [JsonExporterAttribute.Full]
    [JsonExporterAttribute.FullCompressed]
    [MarkdownExporterAttribute.Default]
    [MarkdownExporterAttribute.GitHub]
    [MarkdownExporterAttribute.StackOverflow]
    [MarkdownExporterAttribute.Atlassian]
    [XmlExporterAttribute.Brief]
    [XmlExporterAttribute.BriefCompressed]
    [XmlExporterAttribute.Full]
    [XmlExporterAttribute.FullCompressed]
    [SimpleJob(RunStrategy.ColdStart, targetCount: 1)]
    [MinColumn, MaxColumn, MeanColumn, MedianColumn]
    public class TestBenchmark
    {
        private static IMapperService _agileMapper;
        private static IMapperService _expressMapper;
        private static IMapperService _mapsterMapper;
        private static IMapperService _tinyMapperLibrary;
        private static IMapperService _tinySingleMapperLibrary;
        private static AutoMapper.Mapper _autoMapper;

        [GlobalSetup]
        public void Setup()
        {
            MockData.CreateMockData();

            _agileMapper = new AgileMapperLibrary.MapperClass();
            _expressMapper = new ExpressMapperLibrary.MapperClass();
            _mapsterMapper = new MapsterLibrary.MapperClass();
            _tinyMapperLibrary = new TinyMapperLibrary.MapperClass();
            _tinySingleMapperLibrary = new TinyMapperLibrary.SingleMapperClass();
            _autoMapper = new AutoMapperLibrary.MapperClass().mapper;
        }

        #region DataCount1

        [Benchmark]
        public void CustomMapperCount1()
        {
            _ = CustomMapperLibrary.MapperClass.ToCustomerMapper(MockData.Customer);
        }

        [Benchmark]
        public void LinqMapperCount1()
        {
            _ = MockData.Customer.ToCustomerDto();
        }

        [Benchmark]
        public void AgileMapperCount1()
        {
            _ = _agileMapper.Map<Customer, CustomerDto>(MockData.Customer);
        }

        [Benchmark]
        public void AutoMapperCount1()
        {
            _ = _autoMapper.Map<Customer, CustomerDto>(MockData.Customer);
        }

        [Benchmark]
        public void ExpressMapperCount1()
        {
            _ = _expressMapper.Map<Customer, CustomerDto>(MockData.Customer);
        }

        [Benchmark]
        public void MapsterMapperCount1()
        {
            _ = _mapsterMapper.Map<Customer, CustomerDto>(MockData.Customer);
        }

        [Benchmark]
        public void TinyMapperCount1()
        {
            _ = _tinySingleMapperLibrary.Map<Customer, CustomerDto>(MockData.Customer);
        }

        #endregion

        #region DataCount10
        [Benchmark]
        public void CustomMapperCount10()
        {
            List<CustomerDto> customerDtos = new();
            foreach (Customer customer in MockData.Customer10)
            {
                customerDtos.Add(CustomMapperLibrary.MapperClass.ToCustomerMapper(customer));
            }

            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void LinqMapperCount10()
        {
            List<CustomerDto> customerDtos = MockData.Customer10.ToCustomerDtos().ToList();
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void AgileMapperCount10()
        {
            List<CustomerDto> customerDtos = _agileMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void AutoMapperCount10()
        {
            List<CustomerDto> customerDtos = _autoMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void ExpressMapperCount10()
        {
            List<CustomerDto> customerDtos = _expressMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void MapsterMapperCount10()
        {
            List<CustomerDto> customerDtos = _mapsterMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void TinyMapperCount10()
        {
            List<CustomerDto> customerDtos = _tinyMapperLibrary.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
            _ = customerDtos.Count > 0;
        }
        #endregion

        #region DataCount100
        [Benchmark]
        public void CustomMapperCount100()
        {
            List<CustomerDto> customerDtos = new();
            foreach (Customer customer in MockData.Customer100)
            {
                customerDtos.Add(CustomMapperLibrary.MapperClass.ToCustomerMapper(customer));
            }

            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void LinqMapperCount100()
        {
            List<CustomerDto> customerDtos = MockData.Customer100.ToCustomerDtos().ToList();
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void AgileMapperCount100()
        {
            List<CustomerDto> customerDtos = _agileMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer100);
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void AutoMapperCount100()
        {
            List<CustomerDto> customerDtos = _autoMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer100);
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void ExpressMapperCount100()
        {
            List<CustomerDto> customerDtos = _expressMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer100);
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void MapsterMapperCount100()
        {
            List<CustomerDto> customerDtos = _mapsterMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer100);
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void TinyMapperCount100()
        {
            List<CustomerDto> customerDtos = _tinyMapperLibrary.Map<List<Customer>, List<CustomerDto>>(MockData.Customer100);
            _ = customerDtos.Count > 0;
        }
        #endregion

        #region DataCount1000
        [Benchmark]
        public void CustomMapperCount1000()
        {
            List<CustomerDto> customerDtos = new();
            foreach (Customer customer in MockData.Customer1000)
            {
                customerDtos.Add(CustomMapperLibrary.MapperClass.ToCustomerMapper(customer));
            }

            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void LinqMapperCount1000()
        {
            List<CustomerDto> customerDtos = MockData.Customer1000.ToCustomerDtos().ToList();
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void AgileMapperCount1000()
        {
            List<CustomerDto> customerDtos = _agileMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer1000);
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void AutoMapperCount1000()
        {
            List<CustomerDto> customerDtos = _autoMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer1000);
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void ExpressMapperCount1000()
        {
            List<CustomerDto> customerDtos = _expressMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer1000);
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void MapsterMapperCount1000()
        {
            List<CustomerDto> customerDtos = _mapsterMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer1000);
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void TinyMapperCount1000()
        {
            List<CustomerDto> customerDtos = _tinyMapperLibrary.Map<List<Customer>, List<CustomerDto>>(MockData.Customer1000);
            _ = customerDtos.Count > 0;
        }
        #endregion

        #region DataCount10000
        [Benchmark]
        public void CustomMapperCount10000()
        {
            List<CustomerDto> customerDtos = new();
            foreach (Customer customer in MockData.Customer10000)
            {
                customerDtos.Add(CustomMapperLibrary.MapperClass.ToCustomerMapper(customer));
            }

            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void LinqMapperCount10000()
        {
            List<CustomerDto> customerDtos = MockData.Customer10000.ToCustomerDtos().ToList();
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void AgileMapperCount10000()
        {
            List<CustomerDto> customerDtos = _agileMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10000);
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void AutoMapperCount10000()
        {
            List<CustomerDto> customerDtos = _autoMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10000);
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void ExpressMapperCount10000()
        {
            List<CustomerDto> customerDtos = _expressMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10000);
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void MapsterMapperCount10000()
        {
            List<CustomerDto> customerDtos = _mapsterMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10000);
            _ = customerDtos.Count > 0;
        }

        [Benchmark]
        public void TinyMapperCount10000()
        {
            List<CustomerDto> customerDtos = _tinyMapperLibrary.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10000);
            _ = customerDtos.Count > 0;
        }
        #endregion
    }
}
