using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class AuthorizedMember : Member
    {
        protected AuthorizedMember(string name) : base(name)
        {
        }

        public virtual void SendMessage(Group group, string message, params Member[] atMembers)
        {
            if (group == null) return;

            if (IsMemberOf(group))
            {
                ShowLocalMessage(message);
                group.DispatchMessage(this, message, atMembers);
            }
        }

        public virtual void SendMessage(string message, params Member[] atMembers)
        {
            ShowLocalMessage(message);
            CurrentGroup?.DispatchMessage(this, message, atMembers);
        }

        protected virtual void ShowLocalMessage(string message)
        {
            Console.WriteLine($"{this.Name}: {message}");
        }
    }
}
