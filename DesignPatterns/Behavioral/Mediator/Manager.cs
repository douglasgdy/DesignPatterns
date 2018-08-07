using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Manager : AuthorizedMember
    {
        public Manager(string name) : base(name)
        {
        }
    }
}
