using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    public class QuickSort : SortAlgorithm
    {
        public QuickSort() : base("Quick Sort")
        {
        }

        public override void Execute<T>(IList<T> collection)
        {
            Console.WriteLine($"Use {this.Name} to execute sorting operation...");
        }
    }
}
