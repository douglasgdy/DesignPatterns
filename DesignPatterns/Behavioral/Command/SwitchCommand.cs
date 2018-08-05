using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public class SwitchCommand : Command
    {
        private readonly int channel;
        private TV _tv;
        private int _lastChannel;

        public SwitchCommand(int channel)
        {
            this.channel = channel;
        }

        public override void Execute(TV tv)
        {
            this._tv = tv;
            this._lastChannel = tv.Channel;
            tv.Switch(this.channel);
        }

        public override void Undo()
        {
            this._tv.Switch(this._lastChannel);
        }
    }
}
