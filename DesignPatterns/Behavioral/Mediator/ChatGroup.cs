using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    public class ChatGroup : Group
    {
        public ChatGroup(string name, Manager manager) : base(name)
        {
            AddMember(manager);
        }
    }
}
