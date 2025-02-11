using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
        bool[,] muchii = new bool[100, 100];
        bool[,] muchiiParcurse = new bool[100, 100];
        bool[] viz = new bool[100];
        int selectedNode = -1;

        Queue<int> dfsQueue = new Queue<int>();
        Timer dfsTimer = new Timer();

        private void StartDFS(int startNode)
        {
            viz = new bool[100];
            muchiiParcurse = new bool[100, 100];
            dfsQueue.Clear();
            pictureBox1.Invalidate();

            viz[startNode] = true;
            dfsQueue.Enqueue(startNode);

            dfsTimer.Interval = 1500; 
            dfsTimer.Tick += DfsStep;
            dfsTimer.Start();
        }


        private void DfsStep(object sender, EventArgs e)
        {
            if (dfsQueue.Count == 0)
            {
                dfsTimer.Stop();
                return;
            }

            int node = dfsQueue.Dequeue();

            for (int i = 0; i < noduri.Count; i++)
            {
                if (muchii[node, i] && !viz[i])
                {
                    viz[i] = true;
                    muchiiParcurse[node, i] = true;
                    muchiiParcurse[i, node] = true;
                    dfsQueue.Enqueue(i);
                }
            }

            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X; 
            int y=e.Y;
            
            for(int i=0; i<noduri.Count; i++)
            {
                if ((Math.Sqrt(Math.Pow((x - noduri[i].X),2) + Math.Pow((y - noduri[i].Y), 2)))<=3*raza)
                {
                    if (selectedNode == -1) { 
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

            noduri.Add(new Point(x,y));

            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < noduri.Count; i++)
            {
                for (int j = 0; j < noduri.Count; j++)
                {
                    if (muchii[i, j])
                    {
                        Pen culoare = Pens.Black;
                        if (muchiiParcurse[i, j] || muchiiParcurse[j,i])
                        {
                            culoare = new Pen(Color.Blue, 3); 
                        }
                        g.DrawLine(culoare, noduri[i].X, noduri[i].Y, noduri[j].X, noduri[j].Y);
                    }
                }
            }

            for (int i = 0; i < noduri.Count; i++)
            {
                Pen culoare = Pens.Black;

                if (viz[i])
                {
                    culoare = Pens.Green; 
                }
                if (i == selectedNode)
                {
                    culoare= Pens.Red; 
                }
                g.DrawEllipse(culoare, noduri[i].X - raza, noduri[i].Y - raza, raza * 2, raza * 2);

                string numText = (i+1).ToString();
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
            nodStart = Int32.Parse(start_textbox.Text);
            if (nodStart != -1 && (nodStart >= 1 && nodStart <= noduri.Count))
            {
                StartDFS(nodStart - 1);
            }
            else
            {
                MessageBox.Show("Introduceți un nod de start valid!");
            }
        }
    }
}
