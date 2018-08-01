using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade
{
    public class Sample
    {
        public static void Start()
        {
            Console.WriteLine("Access services directly: ");
            IStorage storage = new InMemoryStorage();
            Console.WriteLine("Create a writer service.");
            var writer = new WriterService(storage);
            writer.Add(1, "aaaaaaaaaaa");
            writer.Add(2, "bbbbbbbbbbb");
            Console.WriteLine("Create a reader service.");
            var reader = new ReaderService(storage);
            Console.WriteLine($"Result of id [1]: {reader.Get(1)}");

            Console.WriteLine("Use a facade to access services: ");
            var facade = new ReaderWriterFacade();
            facade.Add(1, "aaaaaaaaaaa");
            facade.Add(2, "bbbbbbbbbbb");
            Console.WriteLine($"Result of id [1]: {facade.Get(1)}");
        }
    }
}
