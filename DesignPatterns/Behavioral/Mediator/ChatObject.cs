using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class ChatObject
    {
        protected ChatObject(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
    }
}
