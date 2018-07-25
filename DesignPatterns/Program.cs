using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a number to start pattern sample, numbers as follow:");
            Console.WriteLine(" 1: simple factory pattern");
            Console.WriteLine(" 2: factory method pattern");
            Console.WriteLine(" 3: abstract factory pattern");
            Console.WriteLine(" 4: builder pattern");
            Console.WriteLine(" 5: singleton pattern");
            Console.WriteLine(" 6: adapter pattern");

            while (true)
            {
                int number = 0;
                while (true)
                {
                    Console.Write("Please enter: ");
                    string numText = Console.ReadLine();
                    if (int.TryParse(numText, out number))
                        break;
                }

                switch (number)
                {
                    case 1:
                        Creational.SimpleFactory.Sample.Start();
                        break;
                    case 2:
                        Creational.FactoryMethod.Sample.Start();
                        break;
                    case 3:
                        Creational.AbstractFactory.Sample.Start();
                        break;
                    case 4:
                        Creational.Builder.Sample.Start();
                        break;
                    case 5:
                        break;
                    case 6:
                        Structural.Adapter.Sample.Start();
                        break;
                    default:
                        goto Exit;
                }
                Console.WriteLine("------------------");
            }

            Exit:
            return;
        }
    }
}
