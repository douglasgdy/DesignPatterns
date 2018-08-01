using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    public class Singing : Skill
    {
        public override void Perform()
        {
            Console.WriteLine("Sing a song.");
        }
    }
}
