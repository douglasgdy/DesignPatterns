using System;

namespace DesignPatterns.SimpleFactory
{
    public enum VehicleType
    {
        Bike,
        Bus,
        Car,
        Train
    }

    public class VehicleFactory
    {
        public static Vehicle Create(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Bike:
                    return new Bike();
                case VehicleType.Bus:
                    return new Bus();
                case VehicleType.Car:
                    return new Car();
                case VehicleType.Train:
                    return new Train();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}