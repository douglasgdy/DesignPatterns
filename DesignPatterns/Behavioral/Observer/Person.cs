using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public class Person : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"A person received a message: {message}");
        }
    }
}
