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
    public partial class FrmAlgorithmBresenham : Form
    {
        private AlgorithmBresenham algorithmBresenham = new AlgorithmBresenham();
        public FrmAlgorithmBresenham()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            algorithmBresenham.ReadData(txtX1, txtY1, txtX2, txtY2);
            algorithmBresenham.PlotShape(picCanvas.CreateGraphics());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            algorithmBresenham.InitializeData(txtX1, txtY1, txtX2, txtY2, picCanvas);
        }
    }
}
