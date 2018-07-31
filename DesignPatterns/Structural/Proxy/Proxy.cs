using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Proxy
{
    public class Proxy : ISubject
    {
        public void SendRequest()
        {
            var realSubject = new RealSubject();
            PreSendRequest();
            realSubject.SendRequest();
            PostSendRequest();
        }

        protected virtual void PreSendRequest()
        {
            Console.WriteLine("Start send request...");
        }

        protected virtual void PostSendRequest()
        {
            Console.WriteLine("Post send request...");
        }
    }
}
