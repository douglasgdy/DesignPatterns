using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.SimpleFactory
{
    public class Sample
    {
        public static void Start()
        {
            Vehicle vehicle = VehicleFactory.Create(VehicleType.Bike);
            vehicle.Move();

            vehicle = VehicleFactory.Create(VehicleType.Bus);
            vehicle.Move();

            vehicle = VehicleFactory.Create(VehicleType.Car);
            vehicle.Move();

            vehicle = VehicleFactory.Create(VehicleType.Train);
            vehicle.Move();
        }
    }
}
