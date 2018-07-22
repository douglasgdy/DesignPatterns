using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class Bike : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("A bike is moving.");
        }
    }
}
