using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class Group : ChatObject
    {
        private readonly HashSet<Member> _members = new HashSet<Member>();

        protected Group(string name) : base(name)
        {
        }

        public virtual void AddMember(Member member)
        {
            this._members.Add(member);
            member.Join(this);
        }

        public virtual void RemoveMember(Member member)
        {
            this._members.Remove(member);
            member.Exit(this);
        }

        public void DispatchMessage(Member sender, string message, params Member[] atMembers)
        {
            foreach (var member in this._members)
            {
                if (member == sender) continue;

                member.ReceiveMessage(message);
                if(atMembers != null)
                {
                    foreach (var at in atMembers)
                    {
                        if (at != member) continue;
                        member.Remind(sender);
                    }
                }
            }
        }
    }
}
