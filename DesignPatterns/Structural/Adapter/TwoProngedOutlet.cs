using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// 两孔插座。
    /// </summary>
    public class TwoProngedOutlet
    {
        public void Connect(ITwoLeggedPlug plug)
        {
            Console.WriteLine($"{plug.Description} is connected to a two pronged outlet.");
        }
    }
}
