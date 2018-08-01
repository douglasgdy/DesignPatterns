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
            person.Attach(new Programming());
            person.Perform();
            person.Detach();

            person.Attach(new Singing());
            person.Perform();
            person.Detach();
        }
    }
}
