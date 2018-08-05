using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public class Sample
    {
        public static void Start()
        {
            var receiver = new TV("Xiaomi");
            var invoker = new RemoteController(receiver);
            invoker.ExecuteCommand(new OpenCommand());
            invoker.ExecuteCommand(new SwitchCommand(1));
            invoker.ExecuteCommand(new SwitchCommand(3));
            invoker.ExecuteCommand(new CloseCommand());
            Console.WriteLine("Support undo/redo mechanism:");
            invoker.Undo();
            invoker.Undo();
            invoker.Redo();
            invoker.Redo();
        }
    }
}
