using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    public class ListenState : TCPState
    {
        public ListenState() : base("Listen")
        {
        }
        
        public override void Connect(TCPConnection source, TCPConnection target)
        {
            Open(source);
            target.Connect(source);
        }

        public override void Disconnect(TCPConnection source, TCPConnection target)
        {
            Close(source);
        }

        public override void Transmit(TCPConnection target, string message)
        {
            Console.WriteLine("TCP connection isn't established.");
        }

        protected virtual void Open(TCPConnection connection)
        {
            connection.ChangeState(new EstablishedState());
        }

        protected virtual void Close(TCPConnection connection)
        {
            connection.ChangeState(new ClosedState());
        }
    }
}
