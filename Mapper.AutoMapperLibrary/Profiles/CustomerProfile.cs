using AutoMapper;
using Mapper.DTO;
using Mapper.Entity;

namespace Mapper.AutoMapperLibrary.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            _ = CreateMap<CustomerDto, Customer>();
            _ = CreateMap<Customer, CustomerDto>();
            _ = CreateMap<AddressDto, Address>();
            _ = CreateMap<Address, AddressDto>();
        }
    }
}