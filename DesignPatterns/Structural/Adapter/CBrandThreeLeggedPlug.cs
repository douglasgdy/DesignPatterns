using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    public class CBrandThreeLeggedPlug : ThreeLeggedPlug
    {
        public override string Brand => "C-Brand";
    }
}
