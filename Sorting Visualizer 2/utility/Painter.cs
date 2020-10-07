using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Visualizer_2.utility
{
    public class Painter
    {
        public Size imgSize { get; set; }

        public Image draw(sort.SortingArray array)
        {
            Image img = new Bitmap(imgSize.Width, imgSize.Height);

            using (Graphics g = Graphics.FromImage(img))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.FillRectangle(Brushes.White, new Rectangle(Point.Empty, imgSize));

                Pen pen = new Pen(Color.Green);
                pen.Width = (float)imgSize.Width / (float)array.Length;

                for (int i = 0; i < array.Length; i++)
                {
                    pen.Color = array.colors[i];
                    Point start = new Point((int)(0 + (i * pen.Width)), imgSize.Height);
                    Point end = new Point((int)(0 + (i * pen.Width)), imgSize.Height - array.values[i] * imgSize.Height / array.values.Max());
                    g.DrawLine(pen, start, end);
                }
            }

            return img;
        }
    }
}
