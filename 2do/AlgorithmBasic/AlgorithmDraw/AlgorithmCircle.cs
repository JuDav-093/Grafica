using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace AlgorithmBasic
{
    internal class AlgorithmCircle
    {
        private int radius;
        private List<Point> circlePoints;
        private Point center;

        public AlgorithmCircle()
        {
            radius = 0;
            center = new Point(0, 0);
            circlePoints = new List<Point>();
        }

        public void ReadData(TextBox txtRadius, PictureBox picCanvas)
        {
            if (string.IsNullOrWhiteSpace(txtRadius.Text) )
            {
                MessageBox.Show("Radius field must be filled.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtRadius.Text, out radius) || radius <= 0)
            {
                MessageBox.Show("Please enter a positive integer for the radius.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            center = new Point(picCanvas.Height /2, picCanvas.Width /2); 
        }

        public void InitializeData(TextBox txtRadius, PictureBox picCanvas)
        {
            txtRadius.Text = "";
            picCanvas.Refresh();  // borra solo si hay un fondo o controles, pero no limpia el área gráfica

            radius = 0;
            center = new Point(0, 0);
            circlePoints = new List<Point>();

            //limpiar completamente el gráfico
            using (Graphics g = picCanvas.CreateGraphics())
            {
                g.Clear(Color.Black);  //usa el color de fondo que prefieras
            }
        }

        // Calcula los puntos del círculo usando simetría de 8 octantes
        private void CalculateCircle()
        {
            circlePoints.Clear();

            int x = 0;
            int y = radius;
            int d = 3 - 2 * radius;

            while (x <= y)
            {
                AddSymmetricPoints(center.X, center.Y, x, y);
                if (d < 0)
                {
                    d += 2 * x + 3;
                }
                else
                {
                    d += 2 * (x - y) + 5;
                    y--;
                }
                x++;
            }
        }

        // Agrega los 8 puntos simétricos del círculo
        private void AddSymmetricPoints(int cx, int cy, int x, int y)
        {
            circlePoints.Add(new Point(cx + x, cy + y));
            circlePoints.Add(new Point(cx - x, cy + y));
            circlePoints.Add(new Point(cx + x, cy - y));
            circlePoints.Add(new Point(cx - x, cy - y));
            circlePoints.Add(new Point(cx + y, cy + x));
            circlePoints.Add(new Point(cx - y, cy + x));
            circlePoints.Add(new Point(cx + y, cy - x));
            circlePoints.Add(new Point(cx - y, cy - x));
        }

        // Dibuja los puntos del círculo
        public void PlotShape(Graphics g)
        {
            CalculateCircle();

            foreach (var pt in circlePoints)
            {
                g.FillRectangle(Brushes.Lime, pt.X, pt.Y, 1, 1);
            }
        }

        // Verifica si un punto está dentro del círculo
        private bool IsInsideCircle(Point p)
        {
            int dx = p.X - center.X;
            int dy = p.Y - center.Y;
            return dx * dx + dy * dy <= radius * radius;
        }

        // Relleno por inundación visible desde un punto semilla
        public void FloodFillRecursiveVisible(Graphics g, PictureBox picCanvas, Point seed)
        {
            int width = picCanvas.Width;
            int height = picCanvas.Height;
            Bitmap bmp = new Bitmap(width, height);

            using (Graphics tempG = Graphics.FromImage(bmp))
            {
                tempG.Clear(Color.Black);
                PlotShape(tempG);
            }

            if (!IsInsideCircle(seed))
                return; // Solo rellenar si está dentro del círculo

            Color targetColor = bmp.GetPixel(seed.X, seed.Y);
            Color fillColor = Color.Red;

            if (targetColor.ToArgb() == fillColor.ToArgb())
                return;

            FloodRecursive(seed.X, seed.Y, targetColor, fillColor, bmp, g, width, height);
        }

        private void FloodRecursive(int x, int y, Color targetColor, Color fillColor, Bitmap bmp, Graphics g, int width, int height)
        {
            // Límites de canvas
            if (x < 0 || x >= width || y < 0 || y >= height)
                return;

            // Si el color actual no es el objetivo, no se pinta
            if (bmp.GetPixel(x, y).ToArgb() != targetColor.ToArgb())
                return;

            // Pinta el píxel
            bmp.SetPixel(x, y, fillColor);
            g.FillRectangle(new SolidBrush(fillColor), x, y, 1, 1);

            Thread.Sleep(4);           // Retardo visual
            Application.DoEvents();   // Refresca UI

            // Orden: arriba, derecha, abajo, izquierda
            FloodRecursive(x, y - 1, targetColor, fillColor, bmp, g, width, height); // arriba
            FloodRecursive(x + 1, y, targetColor, fillColor, bmp, g, width, height); // derecha
            FloodRecursive(x, y + 1, targetColor, fillColor, bmp, g, width, height); // abajo
            FloodRecursive(x - 1, y, targetColor, fillColor, bmp, g, width, height); // izquierda
        }

        //
        public void FloodFill(Graphics g)
        {
            int width = (int)g.VisibleClipBounds.Width;
            int height = (int)g.VisibleClipBounds.Height;
            Bitmap bmp = new Bitmap(width, height);

            using (Graphics tempG = Graphics.FromImage(bmp))
            {
                // Dibujar el círculo en el bitmap
                tempG.Clear(Color.Black); // fondo negro como el PictureBox
                PlotShape(tempG);
            }

            Point seed = center;
            Color targetColor = bmp.GetPixel(seed.X, seed.Y);
            Color fillColor = Color.Red;

            if (targetColor.ToArgb() == fillColor.ToArgb())
                return;

            FloodFillRecursive(bmp, seed.X, seed.Y, targetColor, fillColor);

            g.DrawImage(bmp, 0, 0);
        }


        // Flood fill recursivo
        private void FloodFillRecursive(Bitmap bmp, int x, int y, Color targetColor, Color fillColor)
        {
            if (x < 0 || x >= bmp.Width || y < 0 || y >= bmp.Height)
                return;

            if (bmp.GetPixel(x, y).ToArgb() != targetColor.ToArgb())
                return;

            bmp.SetPixel(x, y, fillColor);

            FloodFillRecursive(bmp, x + 1, y, targetColor, fillColor);
            FloodFillRecursive(bmp, x - 1, y, targetColor, fillColor);
            FloodFillRecursive(bmp, x, y + 1, targetColor, fillColor);
            FloodFillRecursive(bmp, x, y - 1, targetColor, fillColor);
        }
    }
}
