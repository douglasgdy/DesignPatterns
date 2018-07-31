using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public class Underwear : Decorator
    {
        public Underwear(Person person) : base(person)
        {
        }

        public override void DressUp()
        {
            base.DressUp();
            WearUnderwear();
        }

        protected virtual void WearUnderwear()
        {
            Console.WriteLine("wear underwear...");
        }
    }
}
