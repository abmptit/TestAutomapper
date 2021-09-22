using System;
using System.Dynamic;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var mapper = MapperHelpers.CreateMapper();

            dynamic dynamicSurvey = new ExpandoObject();
            var sourceSurvey = mapper.Map<SourceSurvey>(dynamicSurvey);

            dynamic dynamicSource = new ExpandoObject();
            dynamicSource.Name = "toto";
            var source = mapper.Map<SourceCollection>(dynamicSource);

            var destinationSurvey = mapper.Map<DestinationSurvey>(sourceSurvey);

            Console.ReadKey();
        }
    }
}