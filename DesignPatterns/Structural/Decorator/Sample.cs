using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public class Sample
    {
        public static void Start()
        {
            var person = new Female();
            person.WithUnderwear().WithTrousers().WithCoat();
            Console.WriteLine("A beautiful female appears!");
        }
    }

    public static class PersonExtension
    {
        public static Person WithUnderwear(this Person person)
        {
            new Underwear(person).DressUp();
            return person;
        }

        public static Person WithTrousers(this Person person)
        {
            new Trouser(person).DressUp();
            return person;
        }

        public static Person WithCoat(this Person person)
        {
            new Coat(person).DressUp();
            return person;
        }
    }
}
