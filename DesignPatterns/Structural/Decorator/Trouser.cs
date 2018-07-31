using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public class Trouser : Decorator
    {
        public Trouser(Person person) : base(person)
        {
        }

        public override void DressUp()
        {
            base.DressUp();
            WearTrousers();
        }

        protected void WearTrousers()
        {
            Console.WriteLine("wear trousers...");
        }
    }
}
