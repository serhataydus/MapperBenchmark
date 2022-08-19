using AutoMapper;
using Mapper.AutoMapperLibrary.Profiles;

namespace Mapper.AutoMapperLibrary
{
    public class MapperClass : Core.IMapperService
    {
        private readonly MapperConfiguration configuration;

        public readonly AutoMapper.Mapper mapper;

        public MapperClass()
        {
            List<Profile>? profiles = new()
            {
                new CustomerProfile()
            };

            configuration = new MapperConfiguration(cfg =>
            {
                foreach (Profile? item in profiles)
                {
                    cfg.AddProfile(item);
                }
            });

            mapper = new AutoMapper.Mapper(configuration);
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return configuration.CreateMapper().Map<TDestination>(source);
        }
    }
}