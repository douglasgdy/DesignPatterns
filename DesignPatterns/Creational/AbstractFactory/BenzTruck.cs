using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class BenzTruck : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("A truck is moving.");
        }
    }
}
