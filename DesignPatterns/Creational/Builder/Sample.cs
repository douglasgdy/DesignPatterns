using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class Sample
    {
        public static void Start()
        {
            Console.WriteLine("Get 3 A-Class benz cars:");
            foreach (var car in BenzCompany.ProduceCar(BenzCar.ClassType.AClass, 3))
            {
                car.Move();
            }
            
            Console.WriteLine("Get 5 B-Class benz cars:");
            foreach (var car in BenzCompany.ProduceCar(BenzCar.ClassType.BClass, 5))
            {
                car.Move();
            }
        }
    }
}
