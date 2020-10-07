using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Visualizer_2.sorterFactory
{
    public class SortingAlgorithmFactory
    {
        private static Dictionary<String, SorterCreator> algorithmDictionary = createDict();

        public static sort.SortingAlgorithm create(String algorithmName)
        {
            SorterCreator creator = algorithmDictionary[algorithmName];
            return creator.create();
        }

        private static Dictionary<String, SorterCreator> createDict()
        {
            Dictionary<String, SorterCreator> dict = new Dictionary<string, SorterCreator>();
            dict["Bubble sort"] = new BubbleSortCreator();
            dict["Insertion sort"] = new InsertionSortCreator();
            dict["Quicksort"] = new QuicksortCreator();
            dict["Merge sort"] = new MergeSortCreator();

            return dict;
        }
    }
}
