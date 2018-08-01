using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    public class Programming : Skill
    {
        public override void Perform()
        {
            Console.WriteLine("Write a program: Hello World!");
        }
    }
}
