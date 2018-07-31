using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public class Coat : Decorator
    {
        public Coat(Person person) : base(person)
        {
        }

        public override void DressUp()
        {
            base.DressUp();
            WearCoat();
        }

        protected void WearCoat()
        {
            Console.WriteLine("wear coat...");
        }
    }
}
