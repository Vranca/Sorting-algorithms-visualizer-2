using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Visualizer_2.sort
{
    class BubbleSort : SortingAlgorithm 
    {
        public void sort(SortingArray array, int sortingSpeed)
        {
            int n = array.Length;
            
            Stopwatch sw = new Stopwatch();

            while (n > 1)
            {
                int new_n = 0;
                for (int i = 1; i < n; i++)
                {
                    array.setColorAt(System.Drawing.Color.Red, i - 1);
                    array.notifySubscribers();

                    sw.Start();
                    while (true)
                        if (sw.ElapsedMilliseconds > sortingSpeed) break;
                    sw.Reset();

                    if (array.values[i] < array.values[i - 1])
                    {
                        int pom = array.values[i];
                        array.values[i] = array.values[i - 1];
                        array.values[i - 1] = pom;
                        new_n = n - 1;
                    }
                    array.setColorAt(System.Drawing.Color.Green, i - 1);
                }
                n = new_n;
            }
            array.notifySubscribers();

        }
    }
}
