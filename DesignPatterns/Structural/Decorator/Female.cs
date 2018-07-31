using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public class Female : Person
    {
        public override void DressUp()
        {
            Console.Write("A female is dressing up: ");
        }
    }
}
