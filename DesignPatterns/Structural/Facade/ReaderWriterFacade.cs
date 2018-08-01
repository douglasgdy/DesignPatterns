using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade
{
    public class ReaderWriterFacade
    {
        private WriterService _writer;
        private ReaderService _reader;

        public ReaderWriterFacade() : this(new InMemoryStorage())
        {
        }

        public ReaderWriterFacade(IStorage storage)
        {
            this._writer = new WriterService(storage);
            this._reader = new ReaderService(storage);
        }

        public void Add(int id, string message)
        {
            this._writer.Add(id, message);
        }

        public string Get(int id)
        {
            return this._reader.Get(id);
        }

        public void Remove(int id)
        {
            this._writer.Remove(id);
        }
    }
}
