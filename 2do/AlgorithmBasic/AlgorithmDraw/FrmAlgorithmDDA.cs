using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmBasic
{
    public partial class FrmAlgorithmDDA : Form
    {
        private AlgorithmDDA algorithmDDA = new AlgorithmDDA();
        public FrmAlgorithmDDA()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            algorithmDDA.ReadData(txtX1, txtY1, txtX2, txtY2);
            algorithmDDA.PlotShape(picCanvas.CreateGraphics());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            algorithmDDA.InitializeData(txtX1, txtY1, txtX2, txtY2, picCanvas);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
