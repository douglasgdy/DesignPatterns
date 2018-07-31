using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Proxy
{
    public class RealSubject : ISubject
    {
        public void SendRequest()
        {
            Console.WriteLine("Send a request to real subject.");
        }
    }
}
