using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AlgorithmBasic
{
    public partial class FrmFloodFill : Form
    {
        private Bitmap canvasBitmap;
        private FloodFill floodFill = new FloodFill();
        private List<Point> hexCenters = new List<Point>();
        private float radio = 0;
        private bool paintMode = false;

        public FrmFloodFill()
        {
            InitializeComponent();
        }

        

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (paintMode)
            {
                Color target = canvasBitmap.GetPixel(e.X, e.Y);
                floodFill.Flood(new Point(e.X, e.Y), canvasBitmap, target, Color.Lime, picCanvas);
                // Corrección para CS0019
                lblTotalPoints.Text = "Total: " + floodFill.GetPixels().Count();
                lstPoints.Items.Clear();
                foreach (Point pt in floodFill.GetPixels())
                    lstPoints.Items.Add($"({pt.X}, {pt.Y})");
            }
            else
            {
                if (!float.TryParse(txtRadio.Text, out radio) || radio <= 0)
                {
                    MessageBox.Show("Ingrese un radio válido.");
                    return;
                }

                hexCenters.Add(e.Location);
                using (Graphics g = Graphics.FromImage(canvasBitmap))
                {
                    floodFill.PlotHexagon(g, e.Location, radio);
                }
                picCanvas.Invalidate();
            }
        }


        private void FrmFloodFill_Load_1(object sender, EventArgs e)
        {
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = canvasBitmap;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void btnPaint_Click_1(object sender, EventArgs e)
        {
            paintMode = true;
        }
    }
}
