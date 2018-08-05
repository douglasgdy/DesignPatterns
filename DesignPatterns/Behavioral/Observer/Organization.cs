using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public class Organization : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"An organization received a message: {message}");
        }
    }
}
