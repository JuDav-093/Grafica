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
            picCanvas.MouseClick += picCanvas_MouseClick; // ✅ correcto

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            algorithmCircle.ReadData(txtRadius, picCanvas);
            algorithmCircle.PlotShape(picCanvas.CreateGraphics());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            algorithmCircle.InitializeData(txtRadius, picCanvas);
        }

                           
        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickedPoint = e.Location;
            algorithmCircle.FloodFillRecursiveVisible(picCanvas.CreateGraphics(), picCanvas, clickedPoint);
        }

        private void bntPintar_Click(object sender, EventArgs e)
        {
            Point center = new Point(picCanvas.Width / 2, picCanvas.Height / 2);
            algorithmCircle.FloodFillRecursiveVisible(picCanvas.CreateGraphics(), picCanvas, center);
        }
    }
}

