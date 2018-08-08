using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    public class SortContext
    {
        private SortAlgorithm sortAlgorithm;

        public SortContext()
        {
            this.sortAlgorithm = new QuickSort();
        }

        public void ChangeSortAlgorithm(SortAlgorithm sortAlgorithm)
        {
            this.sortAlgorithm = sortAlgorithm;
        }

        public void Sort<T>(IList<T> collection)
        {
            this.sortAlgorithm.Execute(collection);
        }
    }
}
