using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    public abstract class TCPConnection : TCPObject
    {
        private TCPState state;
        private TCPConnection target;

        protected TCPConnection(string name, TCPState state) : base(name)
        {
            this.state = state;
        }

        public TCPState State => state;

        public void Connect(TCPConnection target)
        {
            this.target = target;
            this.state.Connect(this, target);
        }

        public void Disconnect()
        {
            this.state.Disconnect(this, this.target);
            this.target = null;
        }

        public void ChangeState(TCPState state)
        {
            this.state = state;
            Console.WriteLine($"{this.Name}'s connection state is changed to {state.Name}.");
        }

        public void Send(string message)
        {
            this.state.Transmit(this.target, message);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{this.Name} received a message: {message}");
        }
    }
}
