using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsAlgorithmVisualizer.Algorithms.Curves
{
    internal class CurvaB2p
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }
        public Point Point4 { get; set; }
        public int SelectedPoint { get; private set; }

        public CurvaB2p()
        {
            Point1 = new Point(-1, -1);
            Point2 = new Point(-1, -1);
            Point3 = new Point(-1, -1);
            Point4 = new Point(-1, -1);
            SelectedPoint = 0;
        }

        public void SelectPoint(MouseEventArgs e)
        {
            if (Math.Abs(e.X - Point1.X) <= 5 && Math.Abs(e.Y - Point1.Y) <= 5)
                SelectedPoint = 1;
            else if (Math.Abs(e.X - Point2.X) <= 5 && Math.Abs(e.Y - Point2.Y) <= 5)
                SelectedPoint = 2;
            else if (Math.Abs(e.X - Point3.X) <= 5 && Math.Abs(e.Y - Point3.Y) <= 5)
                SelectedPoint = 3;
            else if (Math.Abs(e.X - Point4.X) <= 5 && Math.Abs(e.Y - Point4.Y) <= 5)
                SelectedPoint = 4;
            else
                SelectedPoint = 0;
        }

        public void UpdatePoint(MouseEventArgs e)
        {
            if (SelectedPoint == 1) Point1 = e.Location;
            else if (SelectedPoint == 2) Point2 = e.Location;
            else if (SelectedPoint == 3) Point3 = e.Location;
            else if (SelectedPoint == 4) Point4 = e.Location;
        }

        public void DeselectPoint()
        {
            SelectedPoint = 0;
        }
    }

    public class BezierCurve2
    {
        public List<PointF> CalculateCurve(Point p1, Point p2, Point p3, Point p4, float step = 0.01f)
        {
            List<PointF> curvePoints = new List<PointF>();
            for (float t = 0; t <= 1; t += step)
            {
                float x = (float)(Math.Pow(1 - t, 3) * p1.X + 3 * Math.Pow(1 - t, 2) * t * p2.X +
                                3 * (1 - t) * Math.Pow(t, 2) * p3.X + Math.Pow(t, 3) * p4.X);
                float y = (float)(Math.Pow(1 - t, 3) * p1.Y + 3 * Math.Pow(1 - t, 2) * t * p2.Y +
                                3 * (1 - t) * Math.Pow(t, 2) * p3.Y + Math.Pow(t, 3) * p4.Y);
                curvePoints.Add(new PointF(x, y));
            }
            return curvePoints;
        }

        public void DrawCurve(Graphics g, List<PointF> curve, Color color, int thickness = 2)
        {
            using (Pen pen = new Pen(color, thickness))
            {
                for (int i = 1; i < curve.Count; i++)
                {
                    g.DrawLine(pen, curve[i - 1], curve[i]);
                }
            }
        }
    }
}
