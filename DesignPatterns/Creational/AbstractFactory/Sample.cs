using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Sample
    {
        public static void Start()
        {
            var chinaFactory = new ChinaBenzFactory();
            chinaFactory.ProduceBus().Move();
            chinaFactory.ProduceCar().Move();
            chinaFactory.ProduceTruck().Move();

            var germanyFactory = new GermanyBenzFactory();
            germanyFactory.ProduceBus().Move();
            germanyFactory.ProduceCar().Move();
            germanyFactory.ProduceTruck().Move();
        }
    }
}
