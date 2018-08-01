using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade
{
    public class ReaderService
    {
        private readonly IStorage storage;

        public ReaderService(IStorage storage)
        {
            this.storage = storage;
        }

        public string Get(int id)
        {
            return this.storage.Get(id);
        }
    }
}
