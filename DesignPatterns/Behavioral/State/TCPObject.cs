using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    public abstract class TCPObject
    {
        protected TCPObject(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
    }
}
