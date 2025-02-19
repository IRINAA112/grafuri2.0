using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace grafuri2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int raza = 20;
        List<Point> noduri = new List<Point>();
        List<Tuple<int, int>> parcurgere_muchii = new List<Tuple<int, int>>();
        bool[,] muchii = new bool[100, 100];
        bool[,] muchiiParcurse = new bool[100, 100];
        bool[] viz = new bool[100];
        int selectedNode = -1;
        int muchie_curenta = 0;

        private void DFS(int nodStart)
        {
            viz[nodStart] = true;
            for (int i = 0; i < noduri.Count; i++)
            {
                if (muchii[nodStart, i] == true && viz[i] == false)
                {
                    parcurgere_muchii.Add(new Tuple<int, int>(nodStart, i));
                    DFS(i);

                }
            }
        }
        private void BFS(int nodStart)
        {
            Queue<Tuple<int, int>> varfuri = new Queue<Tuple<int, int>>();
            varfuri.Enqueue(new Tuple<int, int>(nodStart, -1));
            while (varfuri.Count > 0)
            {
                Tuple<int, int> nod = varfuri.Dequeue();
                if (nod.Item2 != -1)
                {
                    parcurgere_muchii.Add(nod);
                }
                for (int i = 0; i < noduri.Count; i++)
                {
                    if (viz[i] == false && muchii[nod.Item1, i] == true)
                    {
                        viz[i] = true;
                        varfuri.Enqueue(new Tuple<int, int>(i, nod.Item1));
                    }
                }
            }

        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            for (int i = 0; i < noduri.Count; i++)
            {
                if ((Math.Sqrt(Math.Pow((x - noduri[i].X), 2) + Math.Pow((y - noduri[i].Y), 2))) <= 3 * raza)
                {
                    if (selectedNode == -1)
                    {
                        selectedNode = i;
                        pictureBox1.Invalidate();
                        return;
                    }
                    if (selectedNode != i)
                    {
                        muchii[selectedNode, i] = !muchii[selectedNode, i];
                        muchii[i, selectedNode] = !muchii[i, selectedNode];
                    }
                    selectedNode = -1;
                    pictureBox1.Invalidate();

                    return;
                }
            }
            noduri.Add(new Point(x, y));
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            bool[] viz2 = new bool[100];

            for (int i = 0; i < noduri.Count; i++)
            {
                for (int j = 0; j < noduri.Count; j++)
                {
                    if (muchii[i, j])
                    {
                        Pen culoare = Pens.Black;
                        g.DrawLine(culoare, noduri[i].X, noduri[i].Y, noduri[j].X, noduri[j].Y);
                    }
                }
            }

            for (int i = 0; i < muchie_curenta; i++)
            {
                Pen culoare = new Pen(Brushes.Purple, 4);

                g.DrawLine(culoare, noduri[parcurgere_muchii[i].Item1], noduri[parcurgere_muchii[i].Item2]);
                viz2[parcurgere_muchii[i].Item1] = true;
                viz2[parcurgere_muchii[i].Item2] = true;
            }

            for (int i = 0; i < noduri.Count; i++)
            {
                Pen culoare = Pens.Black;

                if (viz2[i])
                {
                    culoare = new Pen(Brushes.Purple, 4);
                }
                if (i == selectedNode)
                {
                    culoare = Pens.Red;
                }
                g.DrawEllipse(culoare, noduri[i].X - raza, noduri[i].Y - raza, raza * 2, raza * 2);

                string numText = (i + 1).ToString();
                Font font = new Font("Arial", 16);
                SizeF textSize = g.MeasureString(numText, font);
                g.DrawString(numText, font, i == selectedNode ? Brushes.Red : Brushes.Black, noduri[i].X - textSize.Width / 2, noduri[i].Y - textSize.Height / 2);
            }
        }

        private void dfs_btn_Click(object sender, EventArgs e)
        {
            viz = new bool[100];
            muchiiParcurse = new bool[100, 100];
            pictureBox1.Invalidate();
            int nodStart = -1;
            bool isnumber = int.TryParse(start_textbox.Text, out nodStart);
            if (isnumber && nodStart >= 1 && nodStart <= noduri.Count)
            {
                parcurgere_muchii.Clear();
                DFS(nodStart - 1);
                muchie_curenta = 0;
                timerDFS.Start();
            }
            else
            {
                MessageBox.Show("Introduceți un nod de start valid!");
            }
        }

        private void bfs_btn_Click(object sender, EventArgs e)
        {
            viz = new bool[100];
            muchiiParcurse = new bool[100, 100];
            pictureBox1.Invalidate();
            int nodStart = -1;
            bool isnumber = int.TryParse(start_textbox.Text, out nodStart);
            if (isnumber && nodStart >= 1 && nodStart <= noduri.Count)
            {
                parcurgere_muchii.Clear();
                BFS(nodStart - 1);
                muchie_curenta = 0;
                timerDFS.Start();
            }
            else
            {
                MessageBox.Show("Introduceți un nod de start valid!");
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            noduri.Clear();
            muchii = new bool[100, 100];
            muchiiParcurse = new bool[100, 100];
            viz = new bool[100];
            selectedNode = -1;
            muchie_curenta = 0;
            pictureBox1.Invalidate();
        }

        private void timerDFS_Tick(object sender, EventArgs e)
        {
            muchie_curenta++;
            if (muchie_curenta == parcurgere_muchii.Count)
            {
                timerDFS.Stop();
            }
            pictureBox1.Invalidate();

        }
    }
}
