using Reflection.App.Models;
using Reflection.App.Services;
using System;

namespace Reflection.App
{
    class Program
    {
        static void Main(string[] args)
        {
            GetTypesService _example = new GetTypesService();
            People _people = new People();
            
            Console.WriteLine("--- Capturando assembly ---");
            Console.WriteLine(_example.GetAssemby(_people));
            
            Console.WriteLine("");

            Console.WriteLine("--- Capturando manifest type ---");
            Console.WriteLine(_example.GetManifestInfo(_people));

            Console.WriteLine("");

            Console.WriteLine("--- Capturando tipos que tem relação com o assembly ---");
            var types = _example.GetTypesClass(_people);
            foreach (var type in types)
                Console.WriteLine(type.Name);

            Console.WriteLine("");

            Console.WriteLine("--- Verifica se existe referência no Assembly ---");
            Console.WriteLine(_example.ExistsTypeImplemented());

            Console.WriteLine("");

            Console.WriteLine("--- Capturando tipos que tem uma interface generica implementada ---");
            var typesWithInterface = _example.GetClassWithGenericInteface(_people);
            foreach (var type in typesWithInterface)
                Console.WriteLine(type);
        }
    }
}
