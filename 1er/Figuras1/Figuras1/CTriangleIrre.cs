using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras1
{
    internal class CTriangleIrre
    {
        
        private float mLado1;
        private float mLado2;
        private float mLado3;
        private float mPerimetro;
        private float mArea;

        // objeto que activa el modo gráfico
        private Graphics mGraph;
        // Constante scale factor (Zoom in/ Zoom out).
        private const float SF = 20;
        // Objeto boligrafo que dibuja o escribe en un lienzo (canvas).
        private Pen mPen;

        // Constructor sin parámetros
        public CTriangleIrre()
        {
            mLado1 = 0.0f;
            mLado2 = 0.0f;
            mLado3 = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
        }

        // Leer los lados desde cajas de texto  
        public void ReadData(TextBox txtLado1, TextBox txtLado2, TextBox txtLado3)
        {
            try
            {
                mLado1 = float.Parse(txtLado1.Text);
                mLado2 = float.Parse(txtLado2.Text);
                mLado3 = float.Parse(txtLado3.Text);

                if (mLado1 <= 0 || mLado2 <= 0 || mLado3 <= 0)
                {
                    throw new ArgumentException("Los lados no pueden ser negativos o cero.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ingreso no válido. Verifique los datos. {ex.Message}");
            }
        }

        //inicializa los datos
        public void InitializeData(TextBox txtLado1, TextBox txtLado2, TextBox txtLado3,
                                    TextBox txtPerimeter, TextBox txtArea,
                                    PictureBox picCanvas)
        {
            // Inicializar los lados
            mLado1 = 0.0f;
            mLado2 = 0.0f;
            mLado3 = 0.0f;
            // Inicializar el perímetro y el área
            mPerimetro = 0.0f;
            mArea = 0.0f;
            // Limpiar los cuadros de texto
            txtLado1.Clear();
            txtLado2.Clear();
            txtLado3.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            // Limpiar el canvas
            picCanvas.Refresh();
        }


        // Verificar los lados
        public bool EsTrianguloValido()
        {
            return (mLado1 + mLado2 > mLado3) &&
                   (mLado1 + mLado3 > mLado2) &&
                   (mLado2 + mLado3 > mLado1);
        }

        // Calcular el perimetro
        public void PerimeterTriangle()
        {
            if (EsTrianguloValido())
                mPerimetro = mLado1 + mLado2 + mLado3;
            else
                MessageBox.Show("No es un triángulo válido.");
        }

        // Calcular el área usando la fórmula de Herón
        public void AreaTriangle()
        {
            if (EsTrianguloValido())
            {
                float s = mPerimetro / 2;
                mArea = (float)Math.Sqrt(s * (s - mLado1) * (s - mLado2) * (s - mLado3));
            }
            else
                MessageBox.Show("No es un triángulo válido.");
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            // Primero, verificamos si es un triángulo válido
            if (!EsTrianguloValido())
            {
                MessageBox.Show("No es un triángulo válido.");
                return;
            }

            // Calcular las coordenadas de los tres vértices
            PointF p1 = new PointF(0, 0); // Primer vértice en (0, 0)
            PointF p2 = new PointF(mLado1 * SF, 0); // Segundo vértice en función del lado1
            PointF p3 = CalcularTercerVertice(p1, p2, mLado2, mLado3);

            // Calcular el centro del triángulo
            float minX = Math.Min(p1.X, Math.Min(p2.X, p3.X));
            float minY = Math.Min(p1.Y, Math.Min(p2.Y, p3.Y));
            float maxX = Math.Max(p1.X, Math.Max(p2.X, p3.X));
            float maxY = Math.Max(p1.Y, Math.Max(p2.Y, p3.Y));

            float triangleWidth = maxX - minX;
            float triangleHeight = maxY - minY;

            float offsetX = (picCanvas.Width - triangleWidth) / 2 - minX;
            float offsetY = (picCanvas.Height - triangleHeight) / 2 - minY;

            // Ajustar las coordenadas para centrar el triángulo
            p1 = new PointF(p1.X + offsetX, p1.Y + offsetY);
            p2 = new PointF(p2.X + offsetX, p2.Y + offsetY);
            p3 = new PointF(p3.X + offsetX, p3.Y + offsetY);

            // Dibujar el triángulo con los puntos ajustados
            mGraph.DrawLine(mPen, p1, p2);
            mGraph.DrawLine(mPen, p2, p3);
            mGraph.DrawLine(mPen, p3, p1);
        }

        // Método para calcular el tercer vértice usando la ley de cosenos
        private PointF CalcularTercerVertice(PointF p1, PointF p2, float lado2, float lado3)
        {
            // Usamos la ley de cosenos para calcular el ángulo entre los lados
            float angle = (float)Math.Acos((Math.Pow(lado2, 2) + Math.Pow(lado3, 2) - Math.Pow(mLado1, 2)) / (2 * lado2 * lado3));

            // Calcular la coordenada X y Y del tercer vértice
            float x3 = p2.X - lado3 * SF * (float)Math.Cos(angle);
            float y3 = p2.Y - lado3 * SF * (float)Math.Sin(angle);

            return new PointF(x3, y3);
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            // Mostrar los resultados del perímetro y área en los TextBox correspondientes
            txtPerimeter.Text = mPerimetro.ToString("F2"); // "F2" para mostrar 2 decimales
            txtArea.Text = mArea.ToString("F2"); // "F2" para mostrar 2 decimales
        }
    }
}


