using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAlgorithmVisualizer.Algorithms.Fill
{
    internal class Linea
    {
        private Graphics g;
        private Pen p;

        public Linea(Graphics g, Pen p)
        {
            this.g = g;
            this.p = p;
        }

        public void DrawShape(int index, int cX, int cY, int sX, int sY, int x, int y)
        {
            if (index == 5) g.DrawLine(p, cX, cY, x, y);
        }

        public void DrawPreview(Graphics g, int index, int cX, int cY, int sX, int sY, int x, int y)
        {
            if (index == 5) g.DrawLine(p, cX, cY, x, y);
        }
    }
}

