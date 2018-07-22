using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public interface IVehicleFactory
    {
        Vehicle Create();
    }
}
