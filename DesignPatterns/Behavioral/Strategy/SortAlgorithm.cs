using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    public abstract class SortAlgorithm
    {
        protected SortAlgorithm(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public abstract void Execute<T>(IList<T> collection);
    }
}
