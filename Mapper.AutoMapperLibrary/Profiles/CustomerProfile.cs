using AutoMapper;
using Mapper.DTO;
using Mapper.Entity;

namespace Mapper.AutoMapperLibrary.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerDto, Customer>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<AddressDto, Address>();
            CreateMap<Address, AddressDto>();
        }
    }
}