using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    public class Sample
    {
        public static void Start()
        {
            var outlet = new TwoProngedOutlet();

            Console.WriteLine("Use compatible power equipment: ");
            outlet.Connect(new ABrandTwoLeggedPlug());

            Console.WriteLine("Use incompatible power equipment (class adapter): ");
            outlet.Connect(new PowerClassAdapter());

            Console.WriteLine("Use incompatible power equipment (object adapter): ");
            outlet.Connect(new PowerObjectAdapter(new BBrandThreeLeggedPlug()));
            outlet.Connect(new PowerObjectAdapter(new CBrandThreeLeggedPlug()));
        }
    }
}
