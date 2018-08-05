using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public interface IObserver
    {
        void Update(string message);
    }
}
