using Mapper.DTO;
using Mapper.Entity;

namespace Mapper.SystemLinqLibrary
{
    public static class MapperClass
    {
        public static IEnumerable<CustomerDto> ToCustomerDtos(this IEnumerable<Customer> source)
        {
            return source.Select(l => new CustomerDto
            {
                Age = l.Age,
                Gender = l.Gender,
                Id = l.Id,
                IdentityNumber = l.IdentityNumber,
                IsStudent = l.IsStudent,
                Name = l.Name,
                Surname = l.Surname,
                Address = new AddressDto
                {
                    ApartmentNumber = l.Address.ApartmentNumber,
                    City = l.Address.City,
                    Country = l.Address.Country,
                    IsResidentialArea = l.Address.IsResidentialArea,
                    ZipCode = l.Address.ZipCode
                }
            });
        }

        public static CustomerDto ToCustomerDto(this Customer source)
        {
            return new CustomerDto
            {
                Age = source.Age,
                Gender = source.Gender,
                Id = source.Id,
                IdentityNumber = source.IdentityNumber,
                IsStudent = source.IsStudent,
                Name = source.Name,
                Surname = source.Surname,
                Address = new AddressDto
                {
                    ApartmentNumber = source.Address.ApartmentNumber,
                    City = source.Address.City,
                    Country = source.Address.Country,
                    IsResidentialArea = source.Address.IsResidentialArea,
                    ZipCode = source.Address.ZipCode
                }
            };
        }
    }
}