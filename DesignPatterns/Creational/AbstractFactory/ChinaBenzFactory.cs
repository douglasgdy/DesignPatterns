using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class ChinaBenzFactory : IBenzFactory
    {
        public ChinaBenzFactory()
        {
            Console.WriteLine("China Benz factory starts work.");
        }

        public BenzBus ProduceBus()
        {
            return new ECitaroBus();
        }

        public BenzCar ProduceCar()
        {
            return new AClassCar();
        }

        public BenzTruck ProduceTruck()
        {
            return new PickupTruck();
        }
    }
}
