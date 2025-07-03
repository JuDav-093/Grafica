using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAlgorithmVisualizer.Algorithms.Fill
{
    internal class ScanlineFill
    {
        // Bitmap y gráficos
        public Bitmap CurrentBitmap { get; private set; }
        private Pen _currentPen;
        private Pen _eraser;
        Color oldColor;

        // Método para llenar una forma en la imagen
        public Bitmap Fill(Point point, Color newColor)
        {
            Color oldColor = CurrentBitmap.GetPixel(point.X, point.Y);
            if (oldColor == newColor) return CurrentBitmap; // Si el color es el mismo, no hacemos nada

            ScanlineFill1(CurrentBitmap, point.X, point.Y, oldColor, newColor);
            return CurrentBitmap;
        }

        // Método de llenado con Scanline Fill
        private void ScanlineFill1(Bitmap bm, int x, int y, Color oldColor, Color newColor)
        {
            Color color = bm.GetPixel(x, y);
            if (oldColor == newColor) return;

            List<Point> paintedPixels = new List<Point>();
            int y1;
            bool spanLeft, spanRight;
            Stack<int> coordinates = new Stack<int>();

            coordinates.Push(x);
            coordinates.Push(y);

            while (coordinates.Count > 0)
            {
                y = coordinates.Pop();
                x = coordinates.Pop();

                y1 = y;
                while (y1 >= 0 && bm.GetPixel(x, y1) == oldColor)
                    y1--;

                y1++;
                spanLeft = spanRight = false;

                while (y1 < bm.Height && bm.GetPixel(x, y1) == oldColor)
                {
                    bm.SetPixel(x, y1, newColor);
                    paintedPixels.Add(new Point(x, y1));

                    if (!spanLeft && x > 0 && bm.GetPixel(x - 1, y1) == oldColor)
                    {
                        coordinates.Push(x - 1);
                        coordinates.Push(y1);
                        spanLeft = true;
                    }
                    else if (spanLeft && x > 0 && bm.GetPixel(x - 1, y1) != oldColor)
                    {
                        spanLeft = false;
                    }

                    if (!spanRight && x < bm.Width - 1 && bm.GetPixel(x + 1, y1) == oldColor)
                    {
                        coordinates.Push(x + 1);
                        coordinates.Push(y1);
                        spanRight = true;
                    }
                    else if (spanRight && x < bm.Width - 1 && bm.GetPixel(x + 1, y1) != oldColor)
                    {
                        spanRight = false;
                    }
                    y1++;
                }
            }
        }

        // Cambia el color del lápiz
        public void SetPenColor(Color color)
        {
            _currentPen.Color = color;
        }

        // Cambia el grosor del lápiz y el borrador
        public void SetPenWidth(float width)
        {
            _currentPen.Width = width;
            _eraser.Width = width;
        }
    }
}
