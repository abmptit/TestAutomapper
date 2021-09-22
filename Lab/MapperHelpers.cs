using AutoMapper;
using System.Collections.Generic;
using System.Dynamic;

namespace Lab
{
    public static class MapperHelpers
    {
        public static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<ISourceCollection, DestinationCollection>();
                    //cfg.CreateMap<ISourceSurvey, IDestinationSurvey>();
                    cfg.CreateMap<SourceSurvey, DestinationSurvey>()
                          .ForMember(m => m.Collection, act => act.MapFrom(src => src.Collection));
                });

            var mapper = config.CreateMapper();
            return mapper;
        }
    }
}
