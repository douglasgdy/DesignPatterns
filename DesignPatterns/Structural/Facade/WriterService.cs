using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade
{
    public class WriterService
    {
        private readonly IStorage storage;

        public WriterService(IStorage storage)
        {
            this.storage = storage;
        }

        public void Add(int id, string message)
        {
            if (string.IsNullOrEmpty(message))
                throw new ArgumentNullException(nameof(message));
            if (!string.IsNullOrEmpty(this.storage.Get(id)))
                throw new ArgumentException(nameof(id));

            this.storage.Add(id, message);
            Console.WriteLine("A message added.");
        }

        public void Remove(int id)
        {
            if (!string.IsNullOrEmpty(this.storage.Get(id)))
                throw new ArgumentException(nameof(id));

            this.storage.Remove(id);
            Console.WriteLine("A message removed.");
        }
    }
}
