using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SimpleFactory
{
    public class Train : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("A train is moving.");
        }
    }
}
