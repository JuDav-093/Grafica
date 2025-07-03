using GraphicsAlgorithmVisualizer.Algorithms.Fill;
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
    public partial class FrmScanline : Form
    {
        bool paint = false;
        int caso;
        Point px, py;
        Bitmap bm;
        Graphics g;
        Pen p = new Pen(Color.Black, 2);
        Pen eraser = new Pen(Color.White, 5);
        int x, y, sX, sY, cX, cY; // Variables para coordenadas
        Stack<Bitmap> undoStack = new Stack<Bitmap>();
        Stack<Bitmap> redoStack = new Stack<Bitmap>();
        ColorDialog cd = new ColorDialog();
        Color newColor;
        Linea drawingFunctions; // Instancia de la nueva clase para funciones de dibujo
        ScanlineFill fillShape; // Para llenar formas
        public FrmScanline()
        {
            InitializeComponent();
            this.Width = 950;
            this.Height = 700;
            bm = new Bitmap(pictuCanva.Width, pictuCanva.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictuCanva.Image = bm;

            p.Width = 5; // Grosor inicial del lápiz
            eraser.Width = 5; // Grosor inicial del borrador

            drawingFunctions = new Linea(g, p); // Inicializar DrawingFunctions

            fillShape = new ScanlineFill();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (caso == 7)
            {
                Point point = set_point(pictuCanva, e.Location);
                Fill(bm, point.X, point.Y, newColor);
                pictuCanva.Image = bm; // Asegúrate de actualizar la imagen
                GuardarEstado();
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color newColor)
        {
            Color oldColor = bm.GetPixel(x, y);
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

            // Mostrar los píxeles pintados en el ListBox
            listBox.Items.Clear();
            foreach (var paintedPixel in paintedPixels)
            {
                listBox.Items.Add($"({paintedPixel.X}, {paintedPixel.Y})");
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location; // Guardamos la ubicación inicial
            cX = e.X; // Coordenadas iniciales
            cY = e.Y;
            GuardarEstado(); // Guarda el estado inicial
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            {
                if (paint)
                {
                    if (caso == 1) // Lápiz
                    {
                        px = e.Location;
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Suaviza el trazo
                        g.FillEllipse(new SolidBrush(p.Color), px.X - p.Width / 2, px.Y - p.Width / 2, p.Width, p.Width); // Dibuja un círculo sólido en cada punto
                        py = px;
                    }
                    // Solo refrescamos para vista previa de ciertas formas
                    if (caso == 3 || caso == 4 || caso == 5 || caso == 8) // Formas como círculo, rectángulo, línea, estrella
                    {
                        pictuCanva.Refresh(); // Esto llama al evento Paint para mostrar la vista previa
                    }
                    else if (caso == 1 || caso == 2) // Lápiz o borrador
                    {
                        px = e.Location;
                        if (caso == 1) g.DrawLine(p, px, py); // Dibuja directamente para lápiz
                        if (caso == 2) g.DrawLine(eraser, px, py); // Dibuja directamente para borrador
                        py = px;
                    }
                    if (paint)
                    {
                        using (Graphics tempGraphics = Graphics.FromImage(bm)) // Usa Graphics directamente del Bitmap
                        {
                            tempGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Suavizado
                            if (caso == 1) // Lápiz
                            {
                                tempGraphics.DrawLine(p, py, e.Location); // Dibuja la línea directamente
                            }
                            else if (caso == 2) // Borrador
                            {
                                tempGraphics.DrawLine(eraser, py, e.Location); // Borrador
                            }
                        }

                        py = e.Location; // Actualiza la posición previa
                        pictuCanva.Invalidate(new Rectangle(e.X - 20, e.Y - 20, 40, 40)); // Actualiza solo una región pequeña
                    }
                }
                // Actualizamos las coordenadas para usar en el MouseUp
                x = e.X;
                y = e.Y;
                sX = e.X - cX;
                sY = e.Y - cY;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX;
            sY = y - cY;

            // Llamamos al método de dibujo final
            drawingFunctions.DrawShape(caso, cX, cY, sX, sY, x, y);
            pictuCanva.Image = bm; // Actualizamos la imagen del PictureBox
            GuardarEstado(); // Guardamos el estado para deshacer
            pictuCanva.Refresh(); // Asegura que el PictureBox refleje los cambios
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Obtenemos los gráficos del evento

            if (paint)
            {
                drawingFunctions.DrawPreview(g, caso, cX, cY, sX, sY, x, y); // Vista previa usando DrawingFunctions
            }
            if (!paint) return; // Solo dibuja la vista previa si se está pintando

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (caso == 3 || caso == 4 || caso == 5 || caso == 8) // Formas geométricas
            {
                drawingFunctions.DrawPreview(g, caso, cX, cY, sX, sY, x, y);
            }
        }
        static Point set_point(PictureBox picture, Point pt)
        {
            float pX = 1f * picture.Image.Width / picture.Width;
            float pY = 1f * picture.Image.Height / picture.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void BtnLine_Click(object sender, EventArgs e)
        {
            caso = 5; // Establece el caso para dibujar una línea
            paint = true; // Activa el modo de dibujo
            x = y = sX = sY = cX = cY = 0; // Reinicia las coordenadas
            pictuCanva.Cursor = Cursors.Cross; // Cambia el cursor a cruz

        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            LimpiarPictureBox();
        }

        private void LimpiarPictureBox()
        {
            g.Clear(Color.White); // Limpia el gráfico con color blanco
            pictuCanva.Image = bm; // Actualiza la imagen del PictureBox
            GuardarEstado(); // Guarda el estado para deshacer
        }

        private void GuardarEstado()
        {
            Bitmap copia = new Bitmap(bm); // Copia del bitmap
            undoStack.Push(copia); // La agregamos a la pila de deshacer
            redoStack.Clear(); // Limpiamos la pila de rehacer
        }

        private void rellenar_Click(object sender, EventArgs e)
        {
            caso = 7;
            pictuCanva.Image = bm;
        }

        private void BtnColorSet_Click(object sender, EventArgs e)
        {
            cd.ShowDialog(); // Mostramos el diálogo de color
            newColor = cd.Color;
            pic_color.BackColor = cd.Color; // Cambiamos el color de fondo del PictureBox
            p.Color = cd.Color; // Cambiamos el color del lápiz
        }

        private void pic_color_Click(object sender, EventArgs e)
        {

        }
    }
}
