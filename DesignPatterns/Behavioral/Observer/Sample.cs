using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public class Sample
    {
        public static void Start()
        {
            var subject = new WeatherStation();
            var observer1 = new Organization();
            var observer2 = new Person();
            subject.AddObserver(observer1);
            subject.AddObserver(observer2);
            subject.Publish();
            subject.RemoveObserver(observer1);
            subject.RemoveObserver(observer2);
        }
    }
}
