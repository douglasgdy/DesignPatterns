using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade
{
    internal class InMemoryStorage : IStorage
    {
        private readonly Dictionary<int, string> _messages = new Dictionary<int, string>();

        public void Add(int id, string message)
        {
            this._messages[id] = message;
        }

        public void Remove(int id)
        {
            this._messages.Remove(id);
        }

        public string Get(int id)
        {
            this._messages.TryGetValue(id, out string message);
            return message;
        }
    }
}
