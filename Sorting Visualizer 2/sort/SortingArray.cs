using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Sorting_Visualizer_2.observer;

namespace Sorting_Visualizer_2.sort
{
    public class SortingArray : Provider
    {
          
        public SortingArray(int[] array)
        {
            values = new int[array.Length];
            array.CopyTo(values, 0);
            colors = new Color[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                colors[i] = Color.Green;
            }
        }

        public void updateArray(int[] newArray)
        {
            values = new int[newArray.Length];
            newArray.CopyTo(values, 0);
            colors = new Color[newArray.Length];
            for (int i = 0; i < newArray.Length; i++)
            {
                colors[i] = Color.Green;
            }
        }

        public void setColorAt(Color color, int index)
        {
            colors[index] = color;
        }

        public void setRedAt(int index)
        {
            colors[index] = Color.Red;
        }

        public void setGreenAt(int index)
        {
            colors[index] = Color.Green;
        }

        public void resetColors()
        {
            for(int i = 0; i < colors.Length; i++)
            {
                colors[i] = Color.Green;
            }
        }

        public int[] values { get; set; }

        public Color[] colors { get; set; }

        public int Length
        {
            get
            {
                return values.Length;
            }
        }
    }
}
