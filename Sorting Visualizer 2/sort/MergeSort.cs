using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Visualizer_2.sort
{
    class MergeSort : SortingAlgorithm
    {
        public void sort(SortingArray array, int sortingSpeed)
        {
            SortingArray helpArray = new SortingArray(array.values);

            for (int width = 1; width < array.Length; width *= 2)
            {
                for (int i = 0; i < array.Length; i += 2 * width)
                {
                    merge(array, helpArray, i, min(i + width, array.Length), min(i + 2 * width, array.Length), sortingSpeed);
                }
                array.values.CopyTo(helpArray.values, 0);
            }
            array.resetColors();
            array.notifySubscribers();
        }

        private void merge(SortingArray array, SortingArray helpArray, int iLeft, int iRight, int iEnd, int sortingSpeed)
        {
            int i = iLeft;
            int j = iRight;
            Stopwatch sw = new Stopwatch();

            for (int k = i; k < iEnd; k++)
            {
                if (i < iRight && (j >= iEnd || helpArray.values[i] <= helpArray.values[j]))
                {
                    for (int h = i - 1; h > k; h--)
                    {
                        array.values[h] = array.values[h - 1];
                    }
                    array.values[k] = helpArray.values[i++];

                    array.setRedAt(k);
                    array.setRedAt(min(j, array.Length - 1));
                    array.notifySubscribers();
                    array.setGreenAt(k);
                    array.setGreenAt(min(j, array.Length - 1));

                    sw.Start();
                    while (true)
                        if (sw.ElapsedMilliseconds > sortingSpeed) break;
                }
                else
                {
                    for (int h = j; h > k; h--)
                    {
                        array.values[h] = array.values[h - 1];
                    }
                    array.values[k] = helpArray.values[j++];

                    array.setRedAt(k);
                    array.setRedAt(min(j, array.Length - 1));
                    array.notifySubscribers();
                    array.setGreenAt(k);
                    array.setGreenAt(min(j, array.Length - 1));

                    sw.Start();
                    while (true)
                        if (sw.ElapsedMilliseconds > sortingSpeed) break;
                }
                sw.Reset();
            }
        }

        private int min(int x, int y)
        {
            return (x < y) ? x : y;
        }
    }
}
