using Sorting_Visualizer_2.sort;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Visualizer_2
{
    public partial class Form1 : Form
    {
        // Niz koji se sortira i njegova velicina
        //
        int[] array;
        int size;

        // Dva objekta koja sortiraju niz 
        //
        SortingArray topArray = null;
        SortingArray bottomArray = null;
        
        // Stoperice za gornji i donji niz respektivno
        //
        Stopwatch stopwatch1 = null;
        Stopwatch stopwatch2 = null;

        bool topIsSorting = false;
        bool bottomIsSorting = false;

        // Niti za sortiranje gornjeg i donjeg niza respektivno
        //
        System.Threading.Thread topThread = null;
        System.Threading.Thread bottomThread = null;

        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();
            size = sizeTrackBar.Value;
            array = Enumerable.Range(1, size).OrderBy(x => rnd.Next()).ToArray();
            SizeBox.Text = "Array size: " + size.ToString();

            topArray = new SortingArray(array);
            topArray.Subscribers.Add(picBoxArray1);
            picBoxArray1.ArrayModel = topArray;

            bottomArray = new SortingArray(array);
            bottomArray.Subscribers.Add(picBoxArray2);
            picBoxArray2.ArrayModel = bottomArray;

            topArray.notifySubscribers();
            bottomArray.notifySubscribers();
        }

        private void sizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            size = sizeTrackBar.Value;
            array = Enumerable.Range(1, size).OrderBy(x => rnd.Next()).ToArray();
            SizeBox.Text = "Array size: " + size.ToString();

            topArray = new SortingArray(array);
            topArray.Subscribers.Add(picBoxArray1);
            picBoxArray1.ArrayModel = topArray;

            bottomArray = new SortingArray(array);
            bottomArray.Subscribers.Add(picBoxArray2);
            picBoxArray2.ArrayModel = bottomArray;

            topArray.notifySubscribers();
            bottomArray.notifySubscribers();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnSortingAlgorithm1.Text == "Sorting Algorithm" || btnSortingAlgorithm2.Text == "Sorting Algorithm")
            {
                MessageBox.Show("Select a sorting algorithm first!");
            }
            else
            {
                setStartButtons();

                //Slucaj kada niti nisu napravljene
                //
                if ( topThread == null && bottomThread == null )
                {
                    createSortingThreads();
                }
                // Slucaj kada niti postoje, ali nisu ativne
                //
                else if(!topThread.IsAlive && !bottomThread.IsAlive)
                {
                    createSortingThreads();
                }
                else
                {
                    // Ako je nit suspendovana, pokreni je ponovo
                    //
                    if (topThread.IsAlive)
                    {
                        topThread.Resume();
                        stopwatch1.Start();
                    }
                    if (bottomThread.IsAlive)
                    {
                        bottomThread.Resume();
                        stopwatch2.Start();
                    }
                }
            }
        }

        private void createSortingThreads()
        {
            SortingAlgorithm topSorter = sorterFactory.SortingAlgorithmFactory.create(btnSortingAlgorithm1.Text);
            SortingAlgorithm bottomSorter = sorterFactory.SortingAlgorithmFactory.create(btnSortingAlgorithm2.Text);

            stopwatch1 = new Stopwatch();
            stopwatch2 = new Stopwatch();

            int speed = speedTrackBar.Value;

            // Kreiranje niti za gornji sorter tako sto konstruktoru prosljedjujemo 
            // lambda izraz u kome pocinjemo sortiranje i oznacavamo da je zavrseno sortiranje kada se zavrsi
            //
            topThread = new System.Threading.Thread(() =>
            {
                topSorter.sort(topArray, speed);
                topIsSorting = false;
            });

            // Kreiranje niti za donji sorter tako sto konstruktoru prosljedjujemo 
            // lambda izraz u kome pocinjemo sortiranje i oznacavamo da je zavrseno sortiranje kada se zavrsi
            //
            bottomThread = new System.Threading.Thread(() =>
            {
                bottomSorter.sort(bottomArray, speed);
                bottomIsSorting = false;
            });


            // Paralelno pokrecemo obje niti
            //
            Parallel.Invoke(
                () =>
                {
                    topIsSorting = true;
                    topThread.Start();
                },
                () =>
                {
                    bottomIsSorting = true;
                    bottomThread.Start();
                }
            );

            // Stoperice i tajmeri se ne pokrecu paralelno jer su njihovi procesi vezani za UI nit
            //
            stopwatch1.Start();
            stopwatch2.Start();
            //
            timer1.Start();
            timer2.Start();
        }

        private void algo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;
            btnSortingAlgorithm1.Text = btn.Text;
        }

        private void algo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;
            btnSortingAlgorithm2.Text = btn.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (topIsSorting)
            {
                TimeSpan ts = stopwatch1.Elapsed;
                labelTime1.Text = String.Format("{0}:{1:00}", ts.Minutes, ts.Seconds);
                toolStrip2.Update();
            }
            else if(!topIsSorting && !bottomIsSorting)
            {
                setStopButtons();
                timer2.Stop();
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (bottomIsSorting)
            {
                TimeSpan ts = stopwatch2.Elapsed;
                labelTime2.Text = String.Format("{0}:{1:00}", ts.Minutes, ts.Seconds);
                toolStrip3.Update();
            }
            else if (!topIsSorting && !bottomIsSorting)
            {
                setStopButtons();
                timer1.Stop();
                timer2.Stop();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            setPauseButtons();

            // Suspendovnje niti kad se klikne dugme Pause
            //
            topThread.Suspend();
            bottomThread.Suspend();

            stopwatch1.Stop();
            stopwatch2.Stop();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            setStopButtons();

            // Terminacija niti klikom na dugme Stop
            //
            topThread.Abort();
            bottomThread.Abort();

            stopwatch1.Stop();
            stopwatch2.Stop();

            topIsSorting = false;
            bottomIsSorting = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            topArray.notifySubscribers();
            bottomArray.notifySubscribers();
        }

        private void setStartButtons()
        {
            speedTrackBar.Enabled = false;
            sizeTrackBar.Enabled = false;
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            btnSortingAlgorithm1.Enabled = false;
            btnSortingAlgorithm2.Enabled = false;
        }

        private void setPauseButtons()
        {
            speedTrackBar.Enabled = false;
            sizeTrackBar.Enabled = false;
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = true;
            btnSortingAlgorithm1.Enabled = false;
            btnSortingAlgorithm2.Enabled = false;
        }

        private void setStopButtons()
        {
            speedTrackBar.Enabled = true;
            sizeTrackBar.Enabled = true;
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            btnStop.Enabled = false;
            btnSortingAlgorithm1.Enabled = true;
            btnSortingAlgorithm2.Enabled = true;
        }
    }
}
