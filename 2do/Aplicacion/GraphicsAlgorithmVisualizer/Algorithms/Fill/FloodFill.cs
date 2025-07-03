using GraphicsAlgorithmVisualizer.Algorithms.Fill;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsAlgorithmVisualizer.Algorithms.Fill
{
    internal class FloodFill : Figure
    {
        public override void PlotShape(Graphics g, PictureBox picCanvas) { }

        public void PlotHexagon(Graphics g, Point center, float radio)
        {
            Pen pen = new Pen(Color.Lime, 2);
            PointF[] points = new PointF[6];

            for (int i = 0; i < 6; i++)
            {
                float angleDeg = 60 * i;
                float angleRad = (float)(Math.PI / 180) * angleDeg;

                float x = center.X + radio * (float)Math.Cos(angleRad);
                float y = center.Y + radio * (float)Math.Sin(angleRad);
                points[i] = new PointF(x, y);
            }

            g.DrawPolygon(pen, points);
        }

        public void Flood(Point p, Bitmap bmp, Color targetColor, Color fillColor, PictureBox canvas)
        {
            base.FloodFill(p, bmp, targetColor, fillColor, canvas);
        }
    }
}
