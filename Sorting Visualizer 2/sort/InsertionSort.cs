using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Visualizer_2.sort
{
    class InsertionSort : SortingAlgorithm
    {
        public void sort(SortingArray array, int sortingSpeed)
        {
            Stopwatch sw = new Stopwatch();

            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array.values[j - 1] > array.values[j])
                {
                    array.setColorAt(System.Drawing.Color.Red, j);
                    array.notifySubscribers();

                    sw.Start();
                    while (true)
                        if (sw.ElapsedMilliseconds > sortingSpeed) break;
                    sw.Reset();

                    int pom = array.values[j];
                    array.values[j] = array.values[j - 1];
                    array.values[j - 1] = pom;
                    array.setColorAt(System.Drawing.Color.Green, j);
                    j--;
                }
            }
            array.notifySubscribers();
        }
    }
}
