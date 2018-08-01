using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    public class Person : IHasSkill
    {
        private Skill _skill;

        public void Attach(Skill skill)
        {
            this._skill = skill;
            Console.WriteLine($"The person has {this._skill.GetType().Name} skill.");
        }

        public void Perform()
        {
            if (this._skill == null)
                Console.WriteLine("The person has no skill.");
            this._skill.Perform();
        }

        public void Detach()
        {
            Console.WriteLine($"The person no longer has {this._skill.GetType().Name} skill.");
            this._skill = null;
        }
    }
}
