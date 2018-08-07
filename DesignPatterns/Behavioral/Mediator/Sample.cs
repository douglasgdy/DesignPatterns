using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Sample
    {
        public static void Start()
        {
            var founder = new Manager("Douglas");
            var group = new ChatGroup("Programming", founder);

            var managerAlex = new Manager("Alex");
            var memberAlice = new GeneralMember("Alice");
            var memberKen = new GeneralMember("Ken");
            var strangerA = new Stranger("A");

            group.AddMember(managerAlex);
            group.AddMember(memberAlice);
            group.AddMember(memberKen);
            strangerA.Add(group);

            founder.SendMessage("hello everyone!");
            managerAlex.SendMessage("hello douglas, how are you?");
            memberAlice.SendMessage("hello douglas, nice to meet you.");
            memberKen.SendMessage("hello douglas, nice to meet you.");
            founder.SendMessage("I'm fine, alex. Where are you?", managerAlex);
            managerAlex.SendMessage("I'm in Chengdu.", founder);
        }
    }
}
