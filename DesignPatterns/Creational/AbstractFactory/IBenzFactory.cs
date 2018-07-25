using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public interface IBenzFactory
    {
        BenzCar ProduceCar();
        BenzBus ProduceBus();
        BenzTruck ProduceTruck();
    }
}
