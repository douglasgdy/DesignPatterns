using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public class OpenCommand : Command
    {
        private TV _tv;

        public override void Execute(TV tv)
        {
            this._tv = tv;
            tv.Open();
        }

        public override void Undo()
        {
            this._tv.Close();
        }
    }
}
