using Mapper.DTO;
using Mapper.Entity;
using Nelibur.ObjectMapper;

namespace Mapper.TinyMapperLibrary
{
    public class MapperClass : Core.IMapperService
    {
        public MapperClass()
        {
            TinyMapper.Bind<List<Customer>, List<CustomerDto>>();
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return TinyMapper.Map<TDestination>(source);
        }
    }

    public class SingleMapperClass : Core.IMapperService
    {
        public SingleMapperClass()
        {
            TinyMapper.Bind<Customer, CustomerDto>();
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return TinyMapper.Map<TDestination>(source);
        }
    }
}