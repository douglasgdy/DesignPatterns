using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class Bus : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("A bus is moving.");
        }
    }
}
