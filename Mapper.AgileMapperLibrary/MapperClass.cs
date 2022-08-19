namespace Mapper.AgileMapperLibrary
{
    public class MapperClass : Core.IMapperService
    {
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return AgileObjects.AgileMapper.Mapper.Map(source).ToANew<TDestination>();
        }
    }
}