using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    public class ABrandTwoLeggedPlug : ITwoLeggedPlug
    {
        public string Description => "A two legged plug produced by A-Brand";
    }
}
