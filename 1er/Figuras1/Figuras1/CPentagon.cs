using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras1
{
    internal class CPentagon
    {
        //datos miembros (atributos)
        //Ancho pentagono regular
        private float mLado;
        //perímetro pentagono
        private float mPerimeter;
        //área pentagono
        private float mArea;
        //objeto que activa modo grafico
        private Graphics mGraph;
        //contante scale factor (Zoom in/Zoom out)
        private const float SF = 20;
        //Objeto bolígrafo que dibuja
        private Pen mPen;
        // Agrega estos campos para el factor de escala
        private float mScaleX = 1.0f;
        private float mScaleY = 1.0f;

        //Funciones miembros (METODOS)
        //Constructor sin parametros
        public CPentagon()
        {
            mLado = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        //Función que lee los datos de entrada del pentagono regular
        public void ReadData(TextBox txtLado)
        {
            try
            {
                mLado = float.Parse(txtLado.Text);
                if (mLado < 0)
                {
                    throw new ArgumentException("El valor no puede ser negativo.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Mensaje error");
                mLado = 0.0f; // Reinicia el valor en caso de error
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje error");
                mLado = 0.0f; // Reinicia el valor en caso de error
            }
        }
        //Función que calcula perimetro pentágono regular
        public void PerimeterPentagon()
        {
            mPerimeter = 5 * mLado;
        }
        //función calcula el área del pentágono regular
        public void AreaPentagon()
        {
            mArea = (float)(1.720477 * Math.Pow(mLado, 2));
        }
        //Función que imprime los datos calculados
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Función que inicializa los datos y controles
        public void InitializeData(TextBox txtLado,
                                    TextBox txtPerimeter,
                                    TextBox txtArea,
                                    PictureBox picCanvas)
        {
            //Inicializa los datos
            mLado = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            txtLado.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            picCanvas.Refresh();
        }

        //Función que grafica el pentágono regular
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 2);
            // Centro del PictureBox
            float centerX = picCanvas.Width / 2f;
            float centerY = picCanvas.Height / 2f;
            // Radio del pentágono
            float r = (mLado * SF) / (2 * (float)Math.Sin(Math.PI / 5));
            // Calcula los puntos del pentágono
            PointF[] points = new PointF[5];
            for (int i = 0; i < 5; i++)
            {
                double angle = -Math.PI / 2 + i * 2 * Math.PI / 5;
                float x = centerX + (float)(r * Math.Cos(angle)) * mScaleX;
                float y = centerY + (float)(r * Math.Sin(angle)) * mScaleY;
                points[i] = new PointF(x, y);
            }
            mGraph.Clear(picCanvas.BackColor);
            mGraph.DrawPolygon(mPen, points);
        }

        //Función que limpia el canvas
        public void ClearCanvas(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mGraph.Clear(picCanvas.BackColor);
        }
        //Funcion que cierra el Form
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

        // Método para cambiar la escala según la tecla presionada
        public void ChangeScale(Keys key)
        {
            const float scaleStep = 0.1f; // Incremento/decremento de escala
            switch (key)
            {
                case Keys.Up:
                    mScaleY += scaleStep;
                    break;
                case Keys.Down:
                    mScaleY = Math.Max(0.1f, mScaleY - scaleStep);
                    break;
                case Keys.Right:
                    mScaleX += scaleStep;
                    break;
                case Keys.Left:
                    mScaleX = Math.Max(0.1f, mScaleX - scaleStep);
                    break;
            }
        }

        // Método para graficar el pentágono regular con escala
        public void DrawPentagon(PictureBox picCanvas)
        {
            if (mLado <= 0) return;

            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 2);

            // Centro del PictureBox
            float centerX = picCanvas.Width / 2f;
            float centerY = picCanvas.Height / 2f;

            // Radio del pentágono
            float r = (mLado * SF) / (2 * (float)Math.Sin(Math.PI / 5));

            // Calcula los puntos del pentágono
            PointF[] points = new PointF[5];
            for (int i = 0; i < 5; i++)
            {
                double angle = -Math.PI / 2 + i * 2 * Math.PI / 5;
                float x = centerX + (float)(r * Math.Cos(angle)) * mScaleX;
                float y = centerY + (float)(r * Math.Sin(angle)) * mScaleY;
                points[i] = new PointF(x, y);
            }

            mGraph.Clear(picCanvas.BackColor);
            mGraph.DrawPolygon(mPen, points);
        }
    }
}
