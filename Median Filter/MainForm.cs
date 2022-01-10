using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace MedianFilter
{
    public partial class MainForm : Form
    {
        Thread TimeThread, MainThread;
        List<Thread> Threads;
        Bitmap OutPic;
        Color[,] pixIn, pixOut;

        public MainForm()
        {
            InitializeComponent();
            edgeCB.SelectedIndex = 1;
            pNCB.SelectedIndex = 1;
            this.FormClosing += new FormClosingEventHandler((object s, FormClosingEventArgs e) => KillAllThreads());
        }

        private void KillAllThreads()
        {
            if (TimeThread != null) TimeThread.Abort();
            if (Threads != null) foreach (Thread T in Threads) T.Abort();
            if (MainThread != null) MainThread.Abort(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edge = Convert.ToInt32(edgeCB.Items[edgeCB.SelectedIndex]), pN = Convert.ToInt32(pNCB.Items[pNCB.SelectedIndex]); 
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                KillAllThreads();
                pictureBoxIn.Image = new Bitmap(openFileDialog1.FileName);
                MainThread = new Thread(() =>
                {
                    TimeThread = new Thread(() =>
                    {
                        Stopwatch t = new Stopwatch();
                        t.Start();
                        while (MainThread.IsAlive) Invoke(new Action(() => TimerTB.Text = string.Format("{0:00}:{1:00}:{2:00}", t.Elapsed.Minutes, t.Elapsed.Seconds, t.Elapsed.Milliseconds / 10)));
                    });
                    TimeThread.Start();
                    OutPic = new Bitmap(openFileDialog1.FileName);
                    pixIn = new Color[OutPic.Height, OutPic.Width];
                    pixOut = new Color[OutPic.Height, OutPic.Width];
                    for (int i = 0; i < pixIn.GetLength(0); i++) for (int j = 0; j < pixIn.GetLength(1); j++) pixIn[i, j] = OutPic.GetPixel(j, i);
                    MedianFilterParallel(edge, pN);
                });
                MainThread.Start();
            }
        }

        public Bitmap MedianFilter(Bitmap pic, int edge)
        {
            int W = pic.Width, H = pic.Height, CellLen = edge * edge;
            int m = CellLen / 2, n = edge / 2;
            for (int i = n; i < H - n; i++)
            {
                for (int j = n; j < W - n; j++)
                {
                    int[] R = new int[CellLen], G = new int[CellLen], B = new int[CellLen];
                    for (int k = i - n; k <= i + n; k++) for (int l = j - n; l <= j + n; l++) { Color clr = pic.GetPixel(k, l); int p = (k - i + n) * edge + l - j + n; R[p] = clr.R; G[p] = clr.G; B[p] = clr.B; }
                    Array.Sort(R); Array.Sort(G); Array.Sort(B);
                    pic.SetPixel(i, j, Color.FromArgb(R[m], G[m], B[m]));
                }
            }
            return pic;
        }

        private void MedianFilterParallel(int edge, int pN)
        {

            Threads = new List<Thread>();
            int HP = 1, VP = 1, n = edge - 1;
            switch (pN)
            {
                case 2: { VP = 2; break; }
                case 4: { HP = 2; VP = 2; break; }
                case 8: { HP = 2; VP = 4; break; }
            }
            int H = (OutPic.Height - n) / VP, W = (OutPic.Width - n) / HP;
            n /= 2;
            for (int i = 0; i < VP; i++)
            {
                for (int j = 0; j < HP; j++)
                {
                    int stRow = n + i * H, stCol = n + j * W, endRow = stRow + H - 1, endCol = stCol + W - 1;
                    Thread T = new Thread(() => MedianFilterOnRectangle(edge, stRow, stCol, endRow, endCol));
                    Threads.Add(T);
                    T.Start();
                }
            }
            for (int i = 0; i < Threads.Count; i++) Threads[i].Join();
            for (int i = 0; i < pixOut.GetLength(0); i++) for (int j = 0; j < pixOut.GetLength(1); j++) OutPic.SetPixel(j, i, pixOut[i, j]);
            Invoke(new Action(() => { pictureBoxOut.Image = OutPic; }));
        }

        private void MedianFilterOnRectangle(int edge, int stRow, int stCol, int endRow, int endCol)
        {
            int CellLen = edge * edge;
            int m = CellLen / 2, n = edge / 2;
            for (int i = stRow; i <= endRow; i++)
            {
                for (int j = stCol; j <= endCol; j++)
                {
                    int[] R = new int[CellLen], G = new int[CellLen], B = new int[CellLen];
                    for (int k = i - n; k <= i + n; k++) for (int l = j - n; l <= j + n; l++) { int p = (k - i + n) * edge + l - j + n; R[p] = pixIn[k, l].R; G[p] = pixIn[k, l].G; B[p] = pixIn[k, l].B; }
                    Array.Sort(R); Array.Sort(G); Array.Sort(B);
                    pixOut[i,j] = Color.FromArgb(R[m], G[m], B[m]);
                }
            }
        }
    }
}
