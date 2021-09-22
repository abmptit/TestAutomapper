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
                });
            //var config = new MapperConfiguration(
            //    cfg =>
            //    {
            //        //cfg.CreateMap<ISourceCollection, IDestinationCollection>().ReverseMap();
            //        cfg.CreateMap<ExpandoObject, SourceCollection>();
            //        //.ForAllMembers((options) => options.MapFrom((resolution) =>
            //        //{
            //        //    var dictionary = (IDictionary<string, object>)resolution..Context.SourceValue;
            //        //    return dictionary[resolution.Context.MemberName];
            //        //}));

            //    });
            var mapper = config.CreateMapper();
            return mapper;
        }
    }
}
