using Mapster;

namespace Mapper.MapsterLibrary
{
    public class MapperClass : Core.IMapperService
    {
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return source.Adapt<TDestination>();
        }
    }
}