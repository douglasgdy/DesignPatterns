using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Proxy
{
    public class Sample
    {
        public static void Start()
        {
            ISubject proxy = new Proxy();
            proxy.SendRequest();
        }
    }
}
