using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Visualizer_2.sort
{
    class Quicksort : SortingAlgorithm
    {
        public void sort(SortingArray array, int sortingSpeed)
        {
            int lowBound = 0;
            int highBound = array.Length;

            if (lowBound < highBound)
            {
                int p = partition(array, lowBound, highBound, sortingSpeed);
                quicksort(array, lowBound, p, sortingSpeed);
                quicksort(array, p + 1, highBound, sortingSpeed);
            }

            array.resetColors();
            array.notifySubscribers();
        }

        private void quicksort(SortingArray array, int lowBound, int highBound, int sortingSpeed)
        {
            if (lowBound < highBound)
            {
                int p = partition(array, lowBound, highBound, sortingSpeed);
                quicksort(array, lowBound, p, sortingSpeed);
                quicksort(array, p + 1, highBound, sortingSpeed);
            }         
        }

        private int partition(SortingArray array, int lowBound, int highBound, int sortingSpeed)
        {
            int pivot = array.values[lowBound + (highBound - lowBound) / 2];
            int i = lowBound;
            int j = highBound - 1;
            int pom;

            Stopwatch sw = new Stopwatch();

            while (i < j)
            {
                while (array.values[i] < pivot)
                {
                    i++;
                    array.setRedAt(i);
                    array.setRedAt(j);
                    array.notifySubscribers();
                    array.setGreenAt(i);
                    array.setGreenAt(j);

                    sw.Start();
                    while (true)
                        if (sw.ElapsedMilliseconds > sortingSpeed) break;
                }
                sw.Reset();

                while (array.values[j] > pivot)
                {
                    j--;
                    array.setRedAt(i);
                    array.setRedAt(j);
                    array.notifySubscribers();
                    array.setGreenAt(i);
                    array.setGreenAt(j);

                    sw.Start();
                    while (true)
                        if (sw.ElapsedMilliseconds > sortingSpeed) break;
                }
                sw.Reset();
                

                if (i >= j)
                {
                    return j;
                }

                pom = array.values[i];
                array.values[i] = array.values[j];
                array.values[j] = pom;

                array.setRedAt(i);
                array.setRedAt(j);
                array.notifySubscribers();
                array.setGreenAt(i);
                array.setGreenAt(j);
            }
            return j;
        }
    }
}
