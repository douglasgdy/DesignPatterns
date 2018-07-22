using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Sample
    {
        public static void Start()
        {
            Vehicle bike = new BikeFactory().Create();
            bike.Move();

            Vehicle bus = new BusFactory().Create();
            bus.Move();
        }
    }
}
