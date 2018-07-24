using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class BenzCompany
    {
        public static IEnumerable<BenzCar> ProduceCar(BenzCar.ClassType carType, int count)
        {
            switch (carType)
            {
                case BenzCar.ClassType.AClass:
                    var aDirector = new BenzAssemblyLine("A-Class");
                    for (int i = 0; i < count; i++)
                    {
                        var builder = new AClassCarBuilder();
                        aDirector.Produce(builder);
                        yield return builder.GetCar();
                    }
                    break;
                case BenzCar.ClassType.BClass:
                    var bDirector = new BenzAssemblyLine("B-Class");
                    for (int i = 0; i < count; i++)
                    {
                        var builder = new BClassCarBuilder();
                        bDirector.Produce(builder);
                        yield return builder.GetCar();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
