namespace Sorting_Visualizer_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Sorting_Visualizer_2.utility.Painter painter1 = new Sorting_Visualizer_2.utility.Painter();
            Sorting_Visualizer_2.utility.Painter painter2 = new Sorting_Visualizer_2.utility.Painter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnSortingAlgorithm2 = new System.Windows.Forms.ToolStripSplitButton();
            this.bubbleSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertinSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quicksortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.labelTime2 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSortingAlgorithm1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.bubbleSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertionSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quicksortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.labelTime1 = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.speedBox = new System.Windows.Forms.GroupBox();
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.SizeBox = new System.Windows.Forms.GroupBox();
            this.sizeTrackBar = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.picBoxArray2 = new Sorting_Visualizer_2.views.ArrayPictureBox();
            this.picBoxArray1 = new Sorting_Visualizer_2.views.ArrayPictureBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.speedBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            this.SizeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArray2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArray1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStart,
            this.toolStripSeparator3,
            this.btnPause,
            this.toolStripSeparator4,
            this.btnStop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(711, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnStart
            // 
            this.btnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(35, 22);
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPause
            // 
            this.btnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPause.Enabled = false;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(42, 22);
            this.btnPause.Text = "Pause";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStop.Enabled = false;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(35, 22);
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 113);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(711, 416);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.picBoxArray2);
            this.panel2.Controls.Add(this.toolStrip3);
            this.panel2.Location = new System.Drawing.Point(3, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 202);
            this.panel2.TabIndex = 3;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSortingAlgorithm2,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.labelTime2});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip3.Size = new System.Drawing.Size(705, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnSortingAlgorithm2
            // 
            this.btnSortingAlgorithm2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSortingAlgorithm2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bubbleSortToolStripMenuItem1,
            this.insertinSortToolStripMenuItem,
            this.quicksortToolStripMenuItem1,
            this.mergeSortToolStripMenuItem1});
            this.btnSortingAlgorithm2.Image = ((System.Drawing.Image)(resources.GetObject("btnSortingAlgorithm2.Image")));
            this.btnSortingAlgorithm2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSortingAlgorithm2.Name = "btnSortingAlgorithm2";
            this.btnSortingAlgorithm2.Size = new System.Drawing.Size(118, 22);
            this.btnSortingAlgorithm2.Text = "Sorting Algorithm";
            // 
            // bubbleSortToolStripMenuItem1
            // 
            this.bubbleSortToolStripMenuItem1.Name = "bubbleSortToolStripMenuItem1";
            this.bubbleSortToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.bubbleSortToolStripMenuItem1.Text = "Bubble sort";
            this.bubbleSortToolStripMenuItem1.Click += new System.EventHandler(this.algo2ToolStripMenuItem_Click);
            // 
            // insertinSortToolStripMenuItem
            // 
            this.insertinSortToolStripMenuItem.Name = "insertinSortToolStripMenuItem";
            this.insertinSortToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.insertinSortToolStripMenuItem.Text = "Insertion sort";
            this.insertinSortToolStripMenuItem.Click += new System.EventHandler(this.algo2ToolStripMenuItem_Click);
            // 
            // quicksortToolStripMenuItem1
            // 
            this.quicksortToolStripMenuItem1.Name = "quicksortToolStripMenuItem1";
            this.quicksortToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.quicksortToolStripMenuItem1.Text = "Quicksort";
            this.quicksortToolStripMenuItem1.Click += new System.EventHandler(this.algo2ToolStripMenuItem_Click);
            // 
            // mergeSortToolStripMenuItem1
            // 
            this.mergeSortToolStripMenuItem1.Name = "mergeSortToolStripMenuItem1";
            this.mergeSortToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.mergeSortToolStripMenuItem1.Text = "Merge sort";
            this.mergeSortToolStripMenuItem1.Click += new System.EventHandler(this.algo2ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel3.Text = "Time elapsed: ";
            // 
            // labelTime2
            // 
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(28, 22);
            this.labelTime2.Text = "0:00";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.picBoxArray1);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 202);
            this.panel1.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSortingAlgorithm1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.labelTime1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(705, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnSortingAlgorithm1
            // 
            this.btnSortingAlgorithm1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSortingAlgorithm1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bubbleSortToolStripMenuItem,
            this.insertionSortToolStripMenuItem,
            this.quicksortToolStripMenuItem,
            this.mergeSortToolStripMenuItem});
            this.btnSortingAlgorithm1.Image = ((System.Drawing.Image)(resources.GetObject("btnSortingAlgorithm1.Image")));
            this.btnSortingAlgorithm1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSortingAlgorithm1.Name = "btnSortingAlgorithm1";
            this.btnSortingAlgorithm1.Size = new System.Drawing.Size(115, 22);
            this.btnSortingAlgorithm1.Text = "Sorting Algorithm";
            this.btnSortingAlgorithm1.ToolTipText = "Sorting Algorithm";
            // 
            // bubbleSortToolStripMenuItem
            // 
            this.bubbleSortToolStripMenuItem.Name = "bubbleSortToolStripMenuItem";
            this.bubbleSortToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.bubbleSortToolStripMenuItem.Text = "Bubble sort";
            this.bubbleSortToolStripMenuItem.Click += new System.EventHandler(this.algo1ToolStripMenuItem_Click);
            // 
            // insertionSortToolStripMenuItem
            // 
            this.insertionSortToolStripMenuItem.Name = "insertionSortToolStripMenuItem";
            this.insertionSortToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.insertionSortToolStripMenuItem.Text = "Insertion sort";
            this.insertionSortToolStripMenuItem.Click += new System.EventHandler(this.algo1ToolStripMenuItem_Click);
            // 
            // quicksortToolStripMenuItem
            // 
            this.quicksortToolStripMenuItem.Name = "quicksortToolStripMenuItem";
            this.quicksortToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.quicksortToolStripMenuItem.Text = "Quicksort";
            this.quicksortToolStripMenuItem.Click += new System.EventHandler(this.algo1ToolStripMenuItem_Click);
            // 
            // mergeSortToolStripMenuItem
            // 
            this.mergeSortToolStripMenuItem.Name = "mergeSortToolStripMenuItem";
            this.mergeSortToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.mergeSortToolStripMenuItem.Text = "Merge sort";
            this.mergeSortToolStripMenuItem.Click += new System.EventHandler(this.algo1ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel1.Text = "Time elapsed: ";
            // 
            // labelTime1
            // 
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(28, 22);
            this.labelTime1.Text = "0:00";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.Controls.Add(this.speedBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SizeBox, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(711, 79);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // speedBox
            // 
            this.speedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedBox.Controls.Add(this.speedTrackBar);
            this.speedBox.Location = new System.Drawing.Point(447, 3);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(261, 73);
            this.speedBox.TabIndex = 2;
            this.speedBox.TabStop = false;
            this.speedBox.Text = "Sorting speed";
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedTrackBar.Location = new System.Drawing.Point(15, 19);
            this.speedTrackBar.Maximum = 500;
            this.speedTrackBar.Minimum = 10;
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.speedTrackBar.RightToLeftLayout = true;
            this.speedTrackBar.Size = new System.Drawing.Size(240, 45);
            this.speedTrackBar.TabIndex = 0;
            this.speedTrackBar.TickFrequency = 10;
            this.speedTrackBar.Value = 50;
            // 
            // SizeBox
            // 
            this.SizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeBox.Controls.Add(this.sizeTrackBar);
            this.SizeBox.Location = new System.Drawing.Point(3, 3);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(438, 73);
            this.SizeBox.TabIndex = 1;
            this.SizeBox.TabStop = false;
            this.SizeBox.Text = "Array size: 10";
            // 
            // sizeTrackBar
            // 
            this.sizeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeTrackBar.Location = new System.Drawing.Point(8, 19);
            this.sizeTrackBar.Maximum = 1000;
            this.sizeTrackBar.Minimum = 10;
            this.sizeTrackBar.Name = "sizeTrackBar";
            this.sizeTrackBar.Size = new System.Drawing.Size(408, 45);
            this.sizeTrackBar.TabIndex = 0;
            this.sizeTrackBar.Value = 10;
            this.sizeTrackBar.ValueChanged += new System.EventHandler(this.sizeTrackBar_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // picBoxArray2
            // 
            this.picBoxArray2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxArray2.ArrayModel = null;
            this.picBoxArray2.BackColor = System.Drawing.Color.White;
            this.picBoxArray2.Location = new System.Drawing.Point(4, 28);
            this.picBoxArray2.Name = "picBoxArray2";
            painter1.imgSize = new System.Drawing.Size(0, 0);
            this.picBoxArray2.painter = painter1;
            this.picBoxArray2.Size = new System.Drawing.Size(698, 171);
            this.picBoxArray2.TabIndex = 1;
            this.picBoxArray2.TabStop = false;
            // 
            // picBoxArray1
            // 
            this.picBoxArray1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxArray1.ArrayModel = null;
            this.picBoxArray1.BackColor = System.Drawing.Color.White;
            this.picBoxArray1.Location = new System.Drawing.Point(4, 29);
            this.picBoxArray1.Name = "picBoxArray1";
            painter2.imgSize = new System.Drawing.Size(0, 0);
            this.picBoxArray1.painter = painter2;
            this.picBoxArray1.Size = new System.Drawing.Size(698, 173);
            this.picBoxArray1.TabIndex = 1;
            this.picBoxArray1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 529);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sorting Algorithms Visualizer";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.speedBox.ResumeLayout(false);
            this.speedBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            this.SizeBox.ResumeLayout(false);
            this.SizeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArray2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArray1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnStart;
        private System.Windows.Forms.ToolStripButton btnPause;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private views.ArrayPictureBox picBoxArray2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripSplitButton btnSortingAlgorithm2;
        private System.Windows.Forms.ToolStripMenuItem bubbleSortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertinSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quicksortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mergeSortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel labelTime2;
        private System.Windows.Forms.Panel panel1;
        private views.ArrayPictureBox picBoxArray1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton btnSortingAlgorithm1;
        private System.Windows.Forms.ToolStripMenuItem bubbleSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertionSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quicksortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel labelTime1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox speedBox;
        private System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.GroupBox SizeBox;
        private System.Windows.Forms.TrackBar sizeTrackBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

