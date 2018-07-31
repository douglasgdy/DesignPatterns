using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public abstract class Decorator : IPersonBehavior
    {
        private readonly Person person;

        protected Decorator(Person person)
        {
            this.person = person;
        }

        public virtual void DressUp()
        {
            this.person.DressUp();
        }
    }
}
