using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sorting_Visualizer_2.observer;
using Sorting_Visualizer_2.sort;

namespace Sorting_Visualizer_2.views
{
    public partial class ArrayPictureBox : PictureBox, Subscriber
    {
        public SortingArray ArrayModel { get; set; }
        public utility.Painter painter { get; set; }

        public ArrayPictureBox()
        {
            InitializeComponent();
            painter = new utility.Painter();
        }

        public void update()
        {
            painter.imgSize = this.Size;
            Image img = null;

            //Kreiranje niti za crtanje niza tako sto konstruktoru prosljedjujemo 
            //lambda izraz u kome objektu img dodjeljujemo Image dobijen iz painter.draw() metode 
            //
            var paintThread = new System.Threading.Thread(() =>
            {
                img = painter.draw(ArrayModel);
            });

            // Pokretanje niti za crtanje
            //
            paintThread.Start();


            // Ako moramo pristupiti UI niti zbog crtanja, a metoda nije pozvana iz UI niti
            //
            if (InvokeRequired)
            {
                paintThread.Join();

                this.Invoke((MethodInvoker)delegate
                {
                    // Ovaj dio koda se odvija na UI niti
                    //
                    Image = img;
                    Refresh();
                });
                
            }
            else
            {
                paintThread.Join();
                Image = img;
                Refresh();
            }
        }
    }
}
