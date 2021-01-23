using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using Mapper.Core;
using Mapper.DTO;
using Mapper.Entity;
using Mapper.Logic;

namespace Mapper.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            new MockData().CreateMockData();

            // AgileMapperLibrary
            Console.WriteLine(string.Format("...: # AgileMapper Begin # :..."));
            IMapper AgileMapper = new AgileMapperLibrary.Mapper();
            var resultAgileMapper = AgileMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
            foreach (var item in resultAgileMapper)
            {
                Console.WriteLine(string.Format("Customer ID : {0} - Name : {1} {2} - City : {3}", item.Id, item.Name, item.Surname, item.Address?.City));
            }
            Console.WriteLine(string.Format("...: # AgileMapper End # :..."));
            Console.WriteLine();

            // AutoMapperLibrary
            Console.WriteLine(string.Format("...: # AutoMapper Begin # :..."));
            IMapper AutoMapper = new AutoMapperLibrary.Mapper();
            var resultAutoMapper = AutoMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
            foreach (var item in resultAutoMapper)
            {
                Console.WriteLine(string.Format("Customer ID : {0} - Name : {1} {2} - City : {3}", item.Id, item.Name, item.Surname, item.Address?.City));
            }
            Console.WriteLine(string.Format("...: # AutoMapper End # :..."));
            Console.WriteLine();

            // ExpressMapperLibrary
            Console.WriteLine(string.Format("...: # ExpressMapper Begin # :..."));
            IMapper ExpressMapper = new ExpressMapperLibrary.Mapper();
            var resultExpressMapper = ExpressMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
            foreach (var item in resultExpressMapper)
            {
                Console.WriteLine(string.Format("Customer ID : {0} - Name : {1} {2} - City : {3}", item.Id, item.Name, item.Surname, item.Address?.City));
            }
            Console.WriteLine(string.Format("...: # ExpressMapper End # :..."));
            Console.WriteLine();

            // MapsterLibrary
            Console.WriteLine(string.Format("...: # Mapster Begin # :..."));
            IMapper Mapster = new MapsterLibrary.Mapper();
            var resultMapster = Mapster.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
            foreach (var item in resultMapster)
            {
                Console.WriteLine(string.Format("Customer ID : {0} - Name : {1} {2} - City : {3}", item.Id, item.Name, item.Surname, item.Address?.City));
            }
            Console.WriteLine(string.Format("...: # Mapster End # :..."));
            Console.WriteLine();

            // TinyMapperLibrary
            Console.WriteLine(string.Format("...: # TinyMapper Begin # :..."));
            IMapper TinyMapper = new TinyMapperLibrary.Mapper();
            var resultTinyMapper = TinyMapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
            foreach (var item in resultTinyMapper)
            {
                Console.WriteLine(string.Format("Customer ID : {0} - Name : {1} {2} - City : {3}", item.Id, item.Name, item.Surname, item.Address?.City));
            }
            Console.WriteLine(string.Format("...: # TinyMapper End # :..."));
            Console.WriteLine();


            List<CustomerDto> customerDtos = new List<CustomerDto>();
            foreach (var item in MockData.Customer10000)
            {
                customerDtos.Add(new CustomerDto
                {
                    Age = item.Age,
                    Gender = item.Gender,
                    Id = item.Id,
                    IdentityNumber = item.IdentityNumber,
                    IsStudent = item.IsStudent,
                    Name = item.Name,
                    Surname = item.Surname,
                    Address = new AddressDto
                    {
                        ApartmentNumber = item.Address.ApartmentNumber,
                        City = item.Address.City,
                        Country = item.Address.Country,
                        IsResidentialArea = item.Address.IsResidentialArea,
                        ZipCode = item.Address.ZipCode
                    }
                });
            }

            List<CustomerDto> customerDtos1 = new List<CustomerDto>();
            foreach (var item in MockData.Customer10000)
            {
                customerDtos1.Add(new CustomerDto
                {
                    Age = item.Age,
                    Gender = item.Gender,
                    Id = item.Id,
                    IdentityNumber = item.IdentityNumber,
                    IsStudent = item.IsStudent,
                    Name = item.Name,
                    Surname = item.Surname,
                    Address = new AddressDto
                    {
                        ApartmentNumber = item.Address.ApartmentNumber,
                        City = item.Address.City,
                        Country = item.Address.Country,
                        IsResidentialArea = item.Address.IsResidentialArea,
                        ZipCode = item.Address.ZipCode
                    }
                });
            }

            List<CustomerDto> customerDtos2 = new List<CustomerDto>();
            customerDtos2.AddRange(MockData.Customer10000.Select(item =>
                 new CustomerDto
                 {
                     Age = item.Age,
                     Gender = item.Gender,
                     Id = item.Id,
                     IdentityNumber = item.IdentityNumber,
                     IsStudent = item.IsStudent,
                     Name = item.Name,
                     Surname = item.Surname,
                     Address = new AddressDto
                     {
                         ApartmentNumber = item.Address.ApartmentNumber,
                         City = item.Address.City,
                         Country = item.Address.Country,
                         IsResidentialArea = item.Address.IsResidentialArea,
                         ZipCode = item.Address.ZipCode
                     }
                 }));

            BenchmarkRunner.Run<TestCustomer1>();
        }
    }

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
    [MemoryDiagnoser]
    [SimpleJob(RunStrategy.ColdStart, targetCount: 1)]
    [MinColumn, MaxColumn, MeanColumn, MedianColumn]
    public class TestCustomer1
    {
        List<Customer> customers = MockData.Customer10;

        #region ManuelMapping
        [Benchmark(Description = "ManuelMappingDataCount10", OperationsPerInvoke = 1)]
        public void ManuelMappingDataCount10()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();
            foreach (var item in MockData.Customer10)
            {
                customerDtos.Add(new CustomerDto
                {
                    Age = item.Age,
                    Gender = item.Gender,
                    Id = item.Id,
                    IdentityNumber = item.IdentityNumber,
                    IsStudent = item.IsStudent,
                    Name = item.Name,
                    Surname = item.Surname,
                    Address = new AddressDto
                    {
                        ApartmentNumber = item.Address.ApartmentNumber,
                        City = item.Address.City,
                        Country = item.Address.Country,
                        IsResidentialArea = item.Address.IsResidentialArea,
                        ZipCode = item.Address.ZipCode
                    }
                });
            }           
        }

        [Benchmark(Description = "ManuelMappingDataCount100", OperationsPerInvoke = 1)]
        public void ManuelMappingDataCount100()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();
            foreach (var item in MockData.Customer100)
            {
                customerDtos.Add(new CustomerDto
                {
                    Age = item.Age,
                    Gender = item.Gender,
                    Id = item.Id,
                    IdentityNumber = item.IdentityNumber,
                    IsStudent = item.IsStudent,
                    Name = item.Name,
                    Surname = item.Surname,
                    Address = new AddressDto
                    {
                        ApartmentNumber = item.Address.ApartmentNumber,
                        City = item.Address.City,
                        Country = item.Address.Country,
                        IsResidentialArea = item.Address.IsResidentialArea,
                        ZipCode = item.Address.ZipCode
                    }
                });
            }
        }

        [Benchmark(Description = "ManuelMappingDataCount1000", OperationsPerInvoke = 1)]
        public void ManuelMappingDataCount1000()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();
            foreach (var item in MockData.Customer1000)
            {
                customerDtos.Add(new CustomerDto
                {
                    Age = item.Age,
                    Gender = item.Gender,
                    Id = item.Id,
                    IdentityNumber = item.IdentityNumber,
                    IsStudent = item.IsStudent,
                    Name = item.Name,
                    Surname = item.Surname,
                    Address = new AddressDto
                    {
                        ApartmentNumber = item.Address.ApartmentNumber,
                        City = item.Address.City,
                        Country = item.Address.Country,
                        IsResidentialArea = item.Address.IsResidentialArea,
                        ZipCode = item.Address.ZipCode
                    }
                });
            }
        }

        [Benchmark(Description = "ManuelMappingDataCount10000", OperationsPerInvoke = 1)]
        public void ManuelMappingDataCount10000()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();
            foreach (var item in MockData.Customer10000)
            {
                customerDtos.Add(new CustomerDto
                {
                    Age = item.Age,
                    Gender = item.Gender,
                    Id = item.Id,
                    IdentityNumber = item.IdentityNumber,
                    IsStudent = item.IsStudent,
                    Name = item.Name,
                    Surname = item.Surname,
                    Address = new AddressDto
                    {
                        ApartmentNumber = item.Address.ApartmentNumber,
                        City = item.Address.City,
                        Country = item.Address.Country,
                        IsResidentialArea = item.Address.IsResidentialArea,
                        ZipCode = item.Address.ZipCode
                    }
                });
            }
        }
        #endregion

        #region ManuelLinqMapping
        [Benchmark(Description = "ManuelLinqMappingDataCount10", OperationsPerInvoke = 1)]
        public void ManuelLinqMappingDataCount10()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();

            customerDtos.AddRange(MockData.Customer10.Select(item =>
                 new CustomerDto
                 {
                     Age = item.Age,
                     Gender = item.Gender,
                     Id = item.Id,
                     IdentityNumber = item.IdentityNumber,
                     IsStudent = item.IsStudent,
                     Name = item.Name,
                     Surname = item.Surname,
                     Address = new AddressDto
                     {
                         ApartmentNumber = item.Address.ApartmentNumber,
                         City = item.Address.City,
                         Country = item.Address.Country,
                         IsResidentialArea = item.Address.IsResidentialArea,
                         ZipCode = item.Address.ZipCode
                     }
                 }));
        }

        [Benchmark(Description = "ManuelLinqMappingDataCount100", OperationsPerInvoke = 1)]
        public void ManuelLinqMappingDataCount100()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();

            customerDtos.AddRange(MockData.Customer100.Select(item =>
                 new CustomerDto
                 {
                     Age = item.Age,
                     Gender = item.Gender,
                     Id = item.Id,
                     IdentityNumber = item.IdentityNumber,
                     IsStudent = item.IsStudent,
                     Name = item.Name,
                     Surname = item.Surname,
                     Address = new AddressDto
                     {
                         ApartmentNumber = item.Address.ApartmentNumber,
                         City = item.Address.City,
                         Country = item.Address.Country,
                         IsResidentialArea = item.Address.IsResidentialArea,
                         ZipCode = item.Address.ZipCode
                     }
                 }));
        }

        [Benchmark(Description = "ManuelLinqMappingDataCount1000", OperationsPerInvoke = 1)]
        public void ManuelLinqMappingDataCount1000()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();

            customerDtos.AddRange(MockData.Customer1000.Select(item =>
                 new CustomerDto
                 {
                     Age = item.Age,
                     Gender = item.Gender,
                     Id = item.Id,
                     IdentityNumber = item.IdentityNumber,
                     IsStudent = item.IsStudent,
                     Name = item.Name,
                     Surname = item.Surname,
                     Address = new AddressDto
                     {
                         ApartmentNumber = item.Address.ApartmentNumber,
                         City = item.Address.City,
                         Country = item.Address.Country,
                         IsResidentialArea = item.Address.IsResidentialArea,
                         ZipCode = item.Address.ZipCode
                     }
                 }));
        }

        [Benchmark(Description = "ManuelLinqMappingDataCount10000", OperationsPerInvoke = 1)]
        public void ManuelLinqMappingDataCount10000()
        {
            List<CustomerDto> customerDtos = new List<CustomerDto>();

            customerDtos.AddRange(MockData.Customer10000.Select(item =>
                 new CustomerDto
                 {
                     Age = item.Age,
                     Gender = item.Gender,
                     Id = item.Id,
                     IdentityNumber = item.IdentityNumber,
                     IsStudent = item.IsStudent,
                     Name = item.Name,
                     Surname = item.Surname,
                     Address = new AddressDto
                     {
                         ApartmentNumber = item.Address.ApartmentNumber,
                         City = item.Address.City,
                         Country = item.Address.Country,
                         IsResidentialArea = item.Address.IsResidentialArea,
                         ZipCode = item.Address.ZipCode
                     }
                 }));
        }
        #endregion


        #region ManuelMapping
        [Benchmark(Description = "AgileMapperLibraryDataCount10", OperationsPerInvoke = 1)]
        public void AgileMapperLibraryDataCount10()
        {
            IMapper Mapper = new AgileMapperLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
        }

        [Benchmark(Description = "AgileMapperLibraryDataCount100", OperationsPerInvoke = 1)]
        public void AgileMapperLibraryDataCount100()
        {
            IMapper Mapper = new AgileMapperLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer100);
        }

        [Benchmark(Description = "AgileMapperLibraryDataCount1000", OperationsPerInvoke = 1)]
        public void AgileMapperLibraryDataCount1000()
        {
            IMapper Mapper = new AgileMapperLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer1000);
        }

        [Benchmark(Description = "AgileMapperLibraryDataCount10000", OperationsPerInvoke = 1)]
        public void AgileMapperLibraryDataCount10000()
        {
            IMapper Mapper = new AgileMapperLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10000);
        }
        #endregion


        #region ManuelMapping
        [Benchmark(Description = "AutoMapperLibraryDataCount10", OperationsPerInvoke = 1)]
        public void AutoMapperLibraryDataCount10()
        {
            IMapper Mapper = new AutoMapperLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
        }

        [Benchmark(Description = "AutoMapperLibraryDataCount100", OperationsPerInvoke = 1)]
        public void AutoMapperLibraryDataCount100()
        {
            IMapper Mapper = new AutoMapperLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer100);
        }

        [Benchmark(Description = "AutoMapperLibraryDataCount1000", OperationsPerInvoke = 1)]
        public void AutoMapperLibraryDataCount1000()
        {
            IMapper Mapper = new AutoMapperLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer1000);
        }

        [Benchmark(Description = "AutoMapperLibraryDataCount10000", OperationsPerInvoke = 1)]
        public void AutoMapperLibraryDataCount10000()
        {
            IMapper Mapper = new AutoMapperLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10000);
        }
        #endregion


        #region ManuelMapping
        [Benchmark(Description = "ExpressMapperLibraryDataCount10", OperationsPerInvoke = 1)]
        public void ExpressMapperLibraryDataCount10()
        {
            IMapper Mapper = new ExpressMapperLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
        }

        [Benchmark(Description = "ExpressMapperLibraryDataCount100", OperationsPerInvoke = 1)]
        public void ExpressMapperLibraryDataCount100()
        {
            IMapper Mapper = new ExpressMapperLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer100);
        }

        [Benchmark(Description = "ExpressMapperLibraryDataCount1000", OperationsPerInvoke = 1)]
        public void ExpressMapperLibraryDataCount1000()
        {
            IMapper Mapper = new ExpressMapperLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer1000);
        }

        [Benchmark(Description = "ExpressMapperLibraryDataCount10000", OperationsPerInvoke = 1)]
        public void ExpressMapperLibraryDataCount10000()
        {
            IMapper Mapper = new ExpressMapperLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10000);
        }
        #endregion


        #region ManuelMapping
        [Benchmark(Description = "MapsterLibraryDataCount10", OperationsPerInvoke = 1)]
        public void MapsterLibraryDataCount10()
        {
            IMapper Mapper = new MapsterLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
        }

        [Benchmark(Description = "MapsterLibraryDataCount100", OperationsPerInvoke = 1)]
        public void MapsterLibraryDataCount100()
        {
            IMapper Mapper = new MapsterLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer100);
        }

        [Benchmark(Description = "MapsterLibraryDataCount1000", OperationsPerInvoke = 1)]
        public void MapsterLibraryDataCount1000()
        {
            IMapper Mapper = new MapsterLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer1000);
        }

        [Benchmark(Description = "MapsterLibraryDataCount10000", OperationsPerInvoke = 1)]
        public void MapsterLibraryDataCount10000()
        {
            IMapper Mapper = new MapsterLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10000);
        }
        #endregion


        #region ManuelMapping
        [Benchmark(Description = "TinyMapperLibraryDataCount10", OperationsPerInvoke = 1)]
        public void TinyMapperLibraryDataCount10()
        {
            IMapper Mapper = new TinyMapperLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10);
        }

        [Benchmark(Description = "TinyMapperLibraryDataCount100", OperationsPerInvoke = 1)]
        public void TinyMapperLibraryDataCount100()
        {
            IMapper Mapper = new TinyMapperLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer100);
        }

        [Benchmark(Description = "TinyMapperLibraryDataCount1000", OperationsPerInvoke = 1)]
        public void TinyMapperLibraryDataCount1000()
        {
            IMapper Mapper = new TinyMapperLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer1000);
        }

        [Benchmark(Description = "TinyMapperLibraryDataCount10000", OperationsPerInvoke = 1)]
        public void TinyMapperLibraryDataCount10000()
        {
            IMapper Mapper = new TinyMapperLibrary.Mapper();
            Mapper.Map<List<Customer>, List<CustomerDto>>(MockData.Customer10000);
        }
        #endregion

    }
}
