using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public abstract class Command
    {
        public abstract void Execute(TV tv);
        public abstract void Undo();
    }
}
