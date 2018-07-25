using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class BClassCar : BenzCar
    {
        public override void Move()
        {
            Console.WriteLine("A benz B-Class car is moving.");
        }
    }
}
