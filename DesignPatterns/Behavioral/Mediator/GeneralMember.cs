using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    public class GeneralMember : AuthorizedMember
    {
        public GeneralMember(string name) : base(name)
        {
        }
    }
}
