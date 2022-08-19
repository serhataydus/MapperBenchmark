using Mapper.DTO;
using Mapper.Entity;

namespace Mapper.CustomMapperLibrary
{
    public static class MapperClass
    {
        public static CustomerDto ToCustomerMapper(Customer item)
        {
            return new CustomerDto
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
            };
        }
    }
}