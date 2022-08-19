using Mapper.Entity;
using Mapper.Models.Enums;

// 1, 10, 100, 1000, 10000 ve 100000

namespace Mapper.Logic
{
    public class MockData
    {
        private static List<Customer> Customers;

        public static Customer Customer;
        public static List<Customer> Customer10;
        public static List<Customer> Customer100;
        public static List<Customer> Customer1000;
        public static List<Customer> Customer10000;

        public static void CreateMockData()
        {
            Customers = new List<Customer>();
            for (int i = 0; i < 10000; i++)
            {
                Customers.Add(new Customer
                {
                    Id = i,
                    Age = 10,
                    Gender = enmGender.Male,
                    IdentityNumber = "45412344578",
                    IsStudent = true,
                    Name = "Ricardo Andrade",
                    Surname = "Quaresma Bernard",
                    Address = new Address
                    {
                        ApartmentNumber = 100,
                        City = "Antalya",
                        Country = "Turkey",
                        IsResidentialArea = true,
                        ZipCode = "7200"
                    }
                });
            }

            Customer = Customers.FirstOrDefault();
            Customer10 = Customers.Skip(0).Take(10).ToList();
            Customer100 = Customers.Skip(0).Take(100).ToList();
            Customer1000 = Customers.Skip(0).Take(1000).ToList();
            Customer10000 = Customers.Skip(0).Take(10000).ToList();
        }
    }
}
