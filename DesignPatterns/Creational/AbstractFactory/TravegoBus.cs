using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class TravegoBus : BenzBus
    {
        public override void Move()
        {
            Console.WriteLine("A benz travego bus is moving.");
        }
    }
}
