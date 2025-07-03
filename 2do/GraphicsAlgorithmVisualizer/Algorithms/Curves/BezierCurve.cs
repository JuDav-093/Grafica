using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsAlgorithmVisualizer.Algorithms.Curves
{
    internal class BezierCurve
    {
        private List<PointF> controlPoints = new List<PointF>();
        private Point point1;
        private Point point2;
        private bool isSelectingPoint1 = true;
        private bool isPointSelected = false;
        private bool isDraggingPoint1 = false;
        private bool isDraggingPoint2 = false;

        public BezierCurve()
        {
            point1 = new Point(-1, -1);
            point2 = new Point(-1, -1);
        }

        public void Draw(Graphics g)
        {
            // Dibuja la línea si los puntos están seleccionados
            if (isPointSelected)
            {
                using (Pen pen = new Pen(Color.Orange, 2))
                {
                    g.DrawLine(pen, point1, point2);
                }
            }

            // Dibuja los puntos seleccionados
            using (Brush brush = new SolidBrush(Color.Violet))
            {
                if (point1.X != -1 && point1.Y != -1)
                {
                    g.FillEllipse(brush, point1.X - 5, point1.Y - 5, 10, 10);
                }
                if (point2.X != -1 && point2.Y != -1)
                {
                    g.FillEllipse(brush, point2.X - 5, point2.Y - 5, 10, 10);
                }
            }
        }

        public void HandleMouseClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                controlPoints.Add(new PointF(e.X, e.Y));
            }
            else if (e.Button == MouseButtons.Right)
            {
                controlPoints.Clear();
            }
        }

        public void HandleMouseDown(MouseEventArgs e)
        {
            if (Math.Abs(e.X - point1.X) <= 5 && Math.Abs(e.Y - point1.Y) <= 5)
            {
                isDraggingPoint1 = true;
            }
            else if (Math.Abs(e.X - point2.X) <= 5 && Math.Abs(e.Y - point2.Y) <= 5)
            {
                isDraggingPoint2 = true;
            }
            else
            {
                if (isSelectingPoint1)
                {
                    point1 = e.Location;
                    isSelectingPoint1 = false;
                }
                else
                {
                    point2 = e.Location;
                    isPointSelected = true;
                    isSelectingPoint1 = true;
                }
            }
        }

        public void HandleMouseMove(MouseEventArgs e)
        {
            if (isDraggingPoint1)
            {
                point1 = e.Location;
            }
            else if (isDraggingPoint2)
            {
                point2 = e.Location;
            }
        }

        public void HandleMouseUp()
        {
            isDraggingPoint1 = false;
            isDraggingPoint2 = false;
        }

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
}
