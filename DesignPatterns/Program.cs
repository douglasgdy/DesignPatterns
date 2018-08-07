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
            Console.WriteLine(" 7: bridge pattern");
            Console.WriteLine(" 8: decorator pattern");
            Console.WriteLine(" 9: facade pattern");
            Console.WriteLine("10: flyweight pattern");
            Console.WriteLine("11: proxy pattern");
            Console.WriteLine("12: command pattern");
            Console.WriteLine("13: observer pattern");
            Console.WriteLine("14: state pattern");
            Console.WriteLine("15: mediator pattern");

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
                    case 7:
                        Structural.Bridge.Sample.Start();
                        break;
                    case 8:
                        Structural.Decorator.Sample.Start();
                        break;
                    case 9:
                        Structural.Facade.Sample.Start();
                        break;
                    case 10:
                        Structural.Flyweight.Sample.Start();
                        break;
                    case 11:
                        Structural.Proxy.Sample.Start();
                        break;
                    case 12:
                        Behavioral.Command.Sample.Start();
                        break;
                    case 13:
                        Behavioral.Observer.Sample.Start();
                        break;
                    case 14:
                        Behavioral.State.Sample.Start();
                        break;
                    case 15:
                        Behavioral.Mediator.Sample.Start();
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
