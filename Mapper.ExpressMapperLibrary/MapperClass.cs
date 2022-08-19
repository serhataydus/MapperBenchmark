namespace Mapper.ExpressMapperLibrary
{
    public class MapperClass : Core.IMapperService
    {
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return ExpressMapper.Mapper.Map<TSource, TDestination>(source);
        }
    }
}