using System;
using System.Dynamic;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            dynamic dynamicSource = new ExpandoObject();
            dynamicSource.Name = "toto";
            var mapper = MapperHelpers.CreateMapper();
            var source = mapper.Map<SourceCollection>(dynamicSource);

            var destination = mapper.Map<IDestinationCollection>(source);

            Console.ReadKey();
        }
    }
}