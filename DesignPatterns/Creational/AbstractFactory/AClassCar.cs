using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class AClassCar : BenzCar
    {
        public override void Move()
        {
            Console.WriteLine("An benz A-Class car is moving.");
        }
    }
}
