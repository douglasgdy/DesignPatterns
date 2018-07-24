using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class BenzCar : Car
    {
        public enum ClassType
        {
            AClass,
            BClass
        }

        private readonly List<string> _parts = new List<string>();

        public BenzCar()
        {
        }

        public void AddPart(string part)
        {
            this._parts.Add(part);
        }

        public override void Move()
        {
            Console.WriteLine("A Benz car is moving.");
        }
    }
}
