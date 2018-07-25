using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class ECitaroBus : BenzBus
    {
        public override void Move()
        {
            Console.WriteLine("A benz fully-electric eCitaro bus is moving.");
        }
    }
}
