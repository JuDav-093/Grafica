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
    public partial class FrmCBLineal : Form
    {
        private List<PointF> controlPoints = new List<PointF>();
        private const int pointRadius = 5;


        private Point point1;
        private Point point2;
        private bool isSelectingPoint1 = true;
        private bool isPointSelected = false;
        private bool isDraggingPoint1 = false;
        private bool isDraggingPoint2 = false;
        private BezierCurve bezierController;
        public FrmCBLineal()
        {
            InitializeComponent();
            bezierController = new BezierCurve();
        }
                

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            bezierController.HandleMouseDown(e);
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            bezierController.HandleMouseMove(e);
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            bezierController.HandleMouseUp();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            bezierController.Draw(e.Graphics);
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            bezierController.HandleMouseClick(e);
            picCanvas.Invalidate();
        }
    }
}
