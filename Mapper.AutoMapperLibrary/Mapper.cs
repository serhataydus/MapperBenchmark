using System.Collections.Generic;
using AutoMapper;
using Mapper.AutoMapperLibrary.Profiles;

namespace Mapper.AutoMapperLibrary
{
    public class Mapper : Core.IMapper
    {
        private MapperConfiguration configuration;

        public Mapper()
        {
            var profiles = new List<Profile>
            {
                new CustomerProfile()
            };

            configuration = new MapperConfiguration(cfg =>
            {
                foreach (var item in profiles)
                {
                    cfg.AddProfile(item);
                }
            });
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return configuration.CreateMapper().Map<TDestination>(source);
        }
    }
}
