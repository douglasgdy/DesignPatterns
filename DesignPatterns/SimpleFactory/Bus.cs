using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SimpleFactory
{
    public class Bus : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("A bus is moving.");
        }
    }
}
