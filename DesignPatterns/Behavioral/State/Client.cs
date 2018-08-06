using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    public class Client : TCPConnection
    {
        public Client() : base("Client", new ClosedState())
        {
        }
    }
}
