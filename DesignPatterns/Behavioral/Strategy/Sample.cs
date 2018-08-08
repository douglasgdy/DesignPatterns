using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Sample
    {
        public static void Start()
        {
            var context = new SortContext();
            var collection = new List<int>(Enumerable.Range(1, 100));

            context.Sort(collection);
            context.ChangeSortAlgorithm(new SelectionSort());
            context.Sort(collection);
            context.ChangeSortAlgorithm(new HeapSort());
            context.Sort(collection);
        }
    }
}
