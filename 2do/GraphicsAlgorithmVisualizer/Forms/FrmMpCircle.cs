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
    public partial class FrmMpCircle : Form
    {
        private MidpointCircle midpointRounding = new MidpointCircle();
        public FrmMpCircle()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            midpointRounding.ReadData(txtRadius, picCanvas);
            midpointRounding.PlotShape(picCanvas.CreateGraphics());
            listP.Items.Clear();
            foreach (Point pt in midpointRounding.GetCirclePoints())
            {
                listP.Items.Add($"({pt.X}, {pt.Y})");
            }

            lblTotalPoints.Visible = true;
            lblTotalPoints.Text = "Total: " + listP.Items.Count.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            midpointRounding.InitializeData(txtRadius, picCanvas);
            listP.Items.Clear();
            lblTotalPoints.Visible = false;
        }
    }
}
