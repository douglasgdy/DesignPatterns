using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class PickupTruck : BenzTruck
    {
        public override void Move()
        {
            Console.WriteLine("A benz pickup truck is moving.");
        }
    }
}
