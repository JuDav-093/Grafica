using AlgorithmBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmBasic
{
    public partial class FrmAlgorithmCircle : Form
    {
        private AlgorithmCircle algorithmCircle = new AlgorithmCircle();
        public FrmAlgorithmCircle()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            algorithmCircle.ReadData(txtRadius, picCanvas);
            algorithmCircle.PlotShape(picCanvas.CreateGraphics());
            listP.Items.Clear();
            foreach (Point pt in algorithmCircle.GetCirclePoints())
            {
                listP.Items.Add($"({pt.X}, {pt.Y})");
            }
            
            lblTotalPoints.Visible = true;
            lblTotalPoints.Text = "Total: " + listP.Items.Count.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            algorithmCircle.InitializeData(txtRadius, picCanvas);
            listP.Items.Clear();
            lblTotalPoints.Visible = false;
        }
    }
}
