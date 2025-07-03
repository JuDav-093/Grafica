using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsAlgorithmVisualizer.Algorithms.Curves
{
    internal class CurvaB1p
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }
        public int SelectedPoint { get; private set; }

        public CurvaB1p()
        {
            Point1 = new Point(-1, -1);
            Point2 = new Point(-1, -1);
            Point3 = new Point(-1, -1);
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
            else
                SelectedPoint = 0;
        }

        public void UpdatePoint(MouseEventArgs e)
        {
            if (SelectedPoint == 1) Point1 = e.Location;
            else if (SelectedPoint == 2) Point2 = e.Location;
            else if (SelectedPoint == 3) Point3 = e.Location;
        }

        public void DeselectPoint()
        {
            SelectedPoint = 0;
        }
    }

    // Clase para manejar la curva de Bézier
    public class BezierCurve1
    {
        private List<PointF> curvePoints;

        public BezierCurve1()
        {
            curvePoints = new List<PointF>();
        }

        public List<PointF> CalculateCurve(Point p1, Point p2, Point p3, float step = 0.01f)
        {
            curvePoints.Clear();
            for (float t = 0; t <= 1; t += step)
            {
                float x = (1 - t) * (1 - t) * p1.X + 2 * (1 - t) * t * p2.X + t * t * p3.X;
                float y = (1 - t) * (1 - t) * p1.Y + 2 * (1 - t) * t * p2.Y + t * t * p3.Y;
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

    // Clase para manejar animaciones
    public class AnimationHandler
    {
        private Timer timer;
        private int currentIndex;
        private List<PointF> curvePoints;

        public AnimationHandler()
        {
            timer = new Timer { Interval = 50 };
            currentIndex = 0;
            curvePoints = new List<PointF>();
        }

        public void StartAnimation(List<PointF> points, Action<PointF> onFrame)
        {
            curvePoints = points;
            currentIndex = 0;

            timer.Tick += (s, e) =>
            {
                if (currentIndex < curvePoints.Count)
                {
                    onFrame(curvePoints[currentIndex]);
                    currentIndex++;
                }
                else
                {
                    timer.Stop();
                }
            };

            timer.Start();
        }

        public void StopAnimation()
        {
            timer.Stop();
        }
    }
}
