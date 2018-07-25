using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class GermanyBenzFactory : IBenzFactory
    {
        public GermanyBenzFactory()
        {
            Console.WriteLine("Germany Benz factory starts work.");
        }

        public BenzBus ProduceBus()
        {
            return new TravegoBus();
        }

        public BenzCar ProduceCar()
        {
            return new BClassCar();
        }

        public BenzTruck ProduceTruck()
        {
            return new TankerTruck();
        }
    }
}
