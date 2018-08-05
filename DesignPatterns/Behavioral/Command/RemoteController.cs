using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public class RemoteController
    {
        private readonly TV tv;
        private readonly Stack<Command> undoCommands = new Stack<Command>();
        private readonly Stack<Command> redoCommands = new Stack<Command>();

        public RemoteController(TV tv)
        {
            this.tv = tv;
        }

        public void ExecuteCommand(Command command)
        {
            command.Execute(this.tv);
            this.undoCommands.Push(command);
        }

        public void Undo()
        {
            Console.WriteLine("Undo a command.");
            if (this.undoCommands.Count == 0) return;
            var command = this.undoCommands.Pop();
            command.Undo();
            this.redoCommands.Push(command);
        }

        public void Redo()
        {
            Console.WriteLine("Redo a command.");
            if (this.redoCommands.Count == 0) return;
            var command = this.redoCommands.Pop();
            command.Execute(this.tv);
            this.undoCommands.Push(command);
        }
    }
}
