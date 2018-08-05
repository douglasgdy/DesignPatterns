using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public class WeatherStation : ISubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();
        private readonly Random r = new Random();

        public void AddObserver(IObserver observer)
        {
            this.observers.Add(observer);
            Console.WriteLine("An observer added.");
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
            Console.WriteLine("An observer removed");
        }

        public void Publish()
        {
            var types = Enum.GetNames(typeof(WeatherType));
            var i = r.Next(types.Length);
            NotifyObservers(types[i]);
        }

        private void NotifyObservers(string currentWeather)
        {
            foreach (var observer in this.observers)
            {
                observer.Update($"The weather will be {currentWeather} today.");
            }
        }
    }
}
