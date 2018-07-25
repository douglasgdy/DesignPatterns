using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    public class BBrandThreeLeggedPlug : ThreeLeggedPlug
    {
        public override string Brand => "B-Brand";
    }
}
