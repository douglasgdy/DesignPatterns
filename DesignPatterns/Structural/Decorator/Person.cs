using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public abstract class Person : IPersonBehavior
    {
        public abstract void DressUp();
    }
}
