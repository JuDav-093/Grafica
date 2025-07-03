using GraphicsAlgorithmVisualizer.Algorithms.Curves;
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
    public partial class FrmCB1p : Form
    {
        private CurvaB1p pointManager;
        private BezierCurve1 bezierCurve1;
        private AnimationHandler animationHandler;
        private bool isCurveReady;
        private PointF animatedPoint;

        public FrmCB1p()
        {
            InitializeComponent();
            pointManager = new CurvaB1p();
            bezierCurve1 = new BezierCurve1();
            animationHandler = new AnimationHandler();
            isCurveReady = false;
            animatedPoint = PointF.Empty;
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            pointManager.SelectPoint(e);

            if (pointManager.SelectedPoint == 0)
            {
                if (pointManager.Point1.X == -1) pointManager.Point1 = e.Location;
                else if (pointManager.Point2.X == -1) pointManager.Point2 = e.Location;
                else if (pointManager.Point3.X == -1)
                {
                    pointManager.Point3 = e.Location;
                    isCurveReady = true;
                }
            }

            picCanvas.Invalidate();
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            pointManager.UpdatePoint(e);
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            pointManager.DeselectPoint();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Dibujar la curva si está lista
            if (isCurveReady)
            {
                var curve = bezierCurve1.CalculateCurve(pointManager.Point1, pointManager.Point2, pointManager.Point3);
                bezierCurve1.DrawCurve(g, curve, Color.Orange);

                // Dibujar el punto animado
                if (!animatedPoint.IsEmpty)
                {
                    using (Brush brush = new SolidBrush(Color.Green))
                    {
                        g.FillEllipse(brush, animatedPoint.X - 5, animatedPoint.Y - 5, 10, 10);
                    }
                }
            }

            // Dibujar los puntos de control
            using (Brush brush = new SolidBrush(Color.Cyan))
            {
                if (pointManager.Point1.X != -1) g.FillEllipse(brush, pointManager.Point1.X - 5, pointManager.Point1.Y - 5, 10, 10);
                if (pointManager.Point2.X != -1) g.FillEllipse(brush, pointManager.Point2.X - 5, pointManager.Point2.Y - 5, 10, 10);
                if (pointManager.Point3.X != -1) g.FillEllipse(brush, pointManager.Point3.X - 5, pointManager.Point3.Y - 5, 10, 10);
            }
        }

        private void btnAnimar_Click(object sender, EventArgs e)
        {
            if (isCurveReady)
            {
                var curve = bezierCurve1.CalculateCurve(pointManager.Point1, pointManager.Point2, pointManager.Point3);
                animationHandler.StartAnimation(curve, point =>
                {
                    animatedPoint = point;
                    picCanvas.Invalidate();
                });
            }
        }
    }
}
