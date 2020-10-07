using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting_Visualizer_2.sort;

namespace Sorting_Visualizer_2.sorterFactory
{
    interface SorterCreator
    {
        SortingAlgorithm create();
    }
}
