using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class BClassCarBuilder : IBenzCarBuilder
    {
        private string _chassis;
        private string _bodywork;
        private string _motor;
        private string _electricalEquipment;
        
        public IBenzCarBuilder WithChassis(string chassis)
        {
            this._chassis = chassis;
            Console.WriteLine("Add chassis...");
            return this;
        }

        public IBenzCarBuilder WithBodywork(string bodywork)
        {
            this._bodywork = bodywork;
            Console.WriteLine("Add bodywork...");
            return this;
        }

        public IBenzCarBuilder WithMotor(string motor)
        {
            this._motor = motor;
            Console.WriteLine("Add motor...");
            return this;
        }

        public IBenzCarBuilder WithElectricalEquipment(string electricalEquipment)
        {
            this._electricalEquipment = electricalEquipment;
            Console.WriteLine("Add electrical equipment...");
            return this;
        }

        public BenzCar GetCar()
        {
            var car = new BenzCar();
            car.AddPart(this._chassis);
            car.AddPart(this._bodywork);
            car.AddPart(this._motor);
            car.AddPart(this._electricalEquipment);
            return car;
        }
    }
}
