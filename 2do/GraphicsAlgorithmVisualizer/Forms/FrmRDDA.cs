using GraphicsAlgorithmVisualizer.Algorithms.Rasterization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsAlgorithmVisualizer.Forms
{
    public partial class FrmRDDA : Form
    {
        private DDALine ddaLine = new DDALine();
        private int clickCount = 0;
        public FrmRDDA()
        {
            InitializeComponent();
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (clickCount == 0)
            {
                txtX1.Text = e.X.ToString();
                txtY1.Text = e.Y.ToString();
                txtX2.Text = "";
                txtY2.Text = "";

                picCanvas.Refresh(); // Limpia el PictureBox

                // Dibuja el primer punto
                using (Graphics g = picCanvas.CreateGraphics())
                {
                    g.FillRectangle(Brushes.Lime, e.X, e.Y, 1, 1);
                }
                clickCount = 1;
            }
            else if (clickCount == 1)
            {
                txtX2.Text = e.X.ToString();
                txtY2.Text = e.Y.ToString();

                // Dibuja segundo punto
                using (Graphics g = picCanvas.CreateGraphics())
                {
                    g.FillRectangle(Brushes.Lime, e.X, e.Y, 1, 1);
                }
                clickCount = 0;
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            ddaLine.ReadData(txtX1, txtY1, txtX2, txtY2);
            ddaLine.PlotShape(picCanvas.CreateGraphics());
            //Points.Items.Clear();
            foreach (Point pt in ddaLine.GetLinePoints())
            {
                Points.Items.Add($"({pt.X}, {pt.Y})");
            }
            lblTotalPoints.Visible = true;
            lblTotalPoints.Text = "Total: " + Points.Items.Count.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ddaLine.InitializeData(txtX1, txtY1, txtX2, txtY2, picCanvas);
            Points.Items.Clear();
            lblTotalPoints.Visible = false;
        }
    }
}
