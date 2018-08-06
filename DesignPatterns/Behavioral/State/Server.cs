using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    public class Server : TCPConnection
    {
        public Server() : base("Server", new ListenState())
        {
        }
    }
}
