using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SimpleFactory
{
    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("A car is moving.");
        }
    }
}
