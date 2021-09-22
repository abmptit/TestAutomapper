using AutoMapper;
using System;
using System.Dynamic;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<ISourceCollection, DestinationCollection>();
                    cfg.CreateMap<SourceSurvey, DestinationSurvey>()
                          .ForMember(m => m.Collection, act => act.MapFrom(src => src.Collection));
                });

            var mapper = config.CreateMapper();

            dynamic dynamicSurvey = new ExpandoObject();
            var sourceSurvey = mapper.Map<SourceSurvey>(dynamicSurvey);

            var destinationSurvey = mapper.Map<DestinationSurvey>(sourceSurvey);

            Console.ReadKey();
        }
    }
}