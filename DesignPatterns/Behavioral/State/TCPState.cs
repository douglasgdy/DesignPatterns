using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    public abstract class TCPState : TCPObject
    {
        protected TCPState(string name) : base(name)
        {
        }

        public abstract void Connect(TCPConnection source, TCPConnection target);
        public abstract void Disconnect(TCPConnection source, TCPConnection target);
        public abstract void Transmit(TCPConnection target, string message);
    }
}
