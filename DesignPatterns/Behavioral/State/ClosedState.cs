using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    public class ClosedState : TCPState
    {
        public ClosedState() : base("Closed")
        {
        }
        
        public override void Connect(TCPConnection source, TCPConnection target)
        {
            Open(source);
            target.Connect(source);
        }

        public override void Disconnect(TCPConnection source, TCPConnection target)
        {
            Console.WriteLine("TCP connection is already closed.");
        }

        public override void Transmit(TCPConnection target, string message)
        {
            Console.WriteLine("TCP connection isn't established.");
        }

        protected virtual void Open(TCPConnection connection)
        {
            connection.ChangeState(new EstablishedState());
        }
    }
}
