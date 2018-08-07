using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class Member : ChatObject
    {
        private readonly HashSet<Group> _groups = new HashSet<Group>();

        protected Member(string name) : base(name)
        {
        }

        public Group CurrentGroup
        {
            get { return this._groups.FirstOrDefault(); }
        }

        public bool IsMemberOf(Group group)
        {
            return this._groups.Contains(group);
        }

        public virtual void Join(Group group)
        {
            this._groups.Add(group);
        }

        public virtual void Exit(Group group)
        {
            this._groups.Remove(group);
        }

        public virtual void Add(Group group)
        {
            group.AddMember(this);
        }

        public virtual void Remove(Group group)
        {
            group.RemoveMember(this);
        }

        public virtual void ReceiveMessage(string message)
        {
            Console.WriteLine($"{this.Name} received: {message}");
        }

        public virtual void Remind(Member sender)
        {
            Console.WriteLine($"[sent by {sender.Name}]");
        }
    }
}
