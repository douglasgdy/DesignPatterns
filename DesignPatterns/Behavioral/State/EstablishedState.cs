using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    public class EstablishedState : TCPState
    {
        public EstablishedState() : base("Established")
        {
        }

        public override void Connect(TCPConnection source, TCPConnection target)
        {
            Console.WriteLine("TCP connection is already established.");
        }

        public override void Disconnect(TCPConnection source, TCPConnection target)
        {
            Close(source);
            target.Disconnect();
        }

        public override void Transmit(TCPConnection target, string message)
        {
            target.Receive(message);
        }

        protected virtual void Close(TCPConnection connection)
        {
            connection.ChangeState(new ClosedState());
        }
    }
}
