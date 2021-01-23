using System;
using System.Collections.Generic;
using Mapper.DTO;
using Mapper.Entity;
using Nelibur.ObjectMapper;

namespace Mapper.TinyMapperLibrary
{
    public class Mapper : Core.IMapper
    {
        public Mapper()
        {
            TinyMapper.Bind<List<Customer>, List<CustomerDto>>();
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return TinyMapper.Map<TDestination>(source);
        }
    }
}
