using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class TankerTruck : BenzTruck
    {
        public override void Move()
        {
            Console.WriteLine("A benz tanker truck is moving.");
        }
    }
}
