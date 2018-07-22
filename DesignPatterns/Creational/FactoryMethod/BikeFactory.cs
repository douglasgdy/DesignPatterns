using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class BikeFactory : IVehicleFactory
    {
        public Vehicle Create()
        {
            return new Bike();
        }
    }
}
