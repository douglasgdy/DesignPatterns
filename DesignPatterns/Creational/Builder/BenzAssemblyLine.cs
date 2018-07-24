using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class BenzAssemblyLine
    {
        private readonly string _name;

        public BenzAssemblyLine(string name)
        {
            this._name = name;
            Console.WriteLine($"Assembly line for {this._name} starts work.");
        }

        public void Produce(IBenzCarBuilder builder)
        {
            builder.WithBodywork("bodywork")
                   .WithChassis("chassis")
                   .WithMotor("motor")
                   .WithElectricalEquipment("electrical equipment");
        }
    }
}
