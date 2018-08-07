using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    public class Sample
    {
        public static void Start()
        {
            var person = new Person();

            Console.WriteLine("Get a programmer:");
            person.Attach(new Programming());
            person.Perform();
            person.Detach();

            Console.WriteLine("Get a singer:");
            person.Attach(new Singing());
            person.Perform();
            person.Detach();
        }
    }
}
