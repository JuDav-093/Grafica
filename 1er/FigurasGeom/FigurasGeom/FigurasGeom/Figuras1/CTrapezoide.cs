using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras1
{
    internal class CTrapezoide
    {
        //Datos Miembro (atributos)
        //Base menor
        private float mBaseMen;
        //Base mayor
        private float mBaseMay;
        //Altura
        private float mAltura;
        //offset para centrar el trapezoide en el canvas
        private float offsetX, offsetY;
        //Angulo
        private float angulo;
        //Perimetro trapezoide
        private float mPerimeter;
        //Area trapezoide
        private float mArea;
        //Objeto que activa modo grafico
        private Graphics mGraph;
        //Contante scale factor (Zoom in/Zoom out)
        private const float SF = 20;
        //Objeto boligrafo que dibuja
        private Pen mPen;

        //Funciones miembros (MÉTODOS)
        //Constructor sin parámetros
        
        public CTrapezoide()
        {
            mBaseMen = 0.0f; mBaseMay = 0.0f; offsetX = 0; offsetY = 0; angulo = 0;
            mAltura = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        //Función que lee los datos de entrada del trapezoide
        public void ReadData(TextBox txtBaseMenor, TextBox txtBaseMayor, TextBox txtAltura)
        {
            try
            {
                mBaseMen = float.Parse(txtBaseMenor.Text);
                mBaseMay = float.Parse(txtBaseMayor.Text);
                mAltura = float.Parse(txtAltura.Text);
                if (mBaseMen < 0 || mBaseMay < 0 || mAltura < 0)
                {
                    throw new ArgumentException("Los valores no pueden ser negativos.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Mensaje error");
                mBaseMen = 0.0f; mBaseMay = 0.0f; mAltura = 0.0f; // Reinicia los valores en caso de error
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje error");
                mBaseMen = 0.0f; mBaseMay = 0.0f; mAltura = 0.0f; // Reinicia los valores en caso de error
            }
        }

        
        //Función que calcula el perimetro del trapezoide
        public void PerimeterTrapezoide()
        {
            mPerimeter = mBaseMen + mBaseMay + (2 * mAltura);
        }

        //Función que calcula el area del trapezoide
        public void AreaTrapezoide()
        {
            mArea = ((mBaseMen + mBaseMay) * mAltura) / 2;
        }
        //Función que imprime los resultados
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        //Función que inicializa los datos y controles
        public void InitializeData(TextBox txtBaseMen, TextBox txtBaseMay,
                                    TextBox txtAltura, TextBox txtPerimeter,
                                    TextBox txtArea, PictureBox picCanvas)
        {
            //Inicializa los datos
            mBaseMen = 0.0f; mBaseMay = 0.0f;
            mAltura = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            offsetX = 0; offsetY = 0; angulo = 0;
            //Inicializa los datos y controles
            txtBaseMen.Text = "";
            txtBaseMay.Text = "";
            txtAltura.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            //Limpia el canvas
            txtBaseMay.Focus();
            picCanvas.Refresh();
        }

        //Función mueve y función rota Trapezoide
        public void Mover(string direccion)
        {
            float paso = 10;

            switch (direccion)
            {
                case "arriba": offsetY -= paso; break;
                case "abajo": offsetY += paso; break;
                case "izquierda": offsetX -= paso; break;
                case "derecha": offsetX += paso; break;
            }
        }

        public void Rotar(string sentido)
        {
            float paso = 10;
            if (sentido == "horario")
                angulo += paso;
            else if (sentido == "antihorario")
                angulo -= paso;
        }

        //Función que grafica el trapezoide en el centro de dos lados iguales
        public void PlotShape(PictureBox picCanvas)
        {
            //Activa el modo grafico
            mGraph = picCanvas.CreateGraphics();
            //Crea un bolígrafo para dibujar
            mPen = new Pen(Color.Black, 2);
            //Calcula las coordenadas del trapezoide
            PointF[] points = new PointF[4];
            points[0] = new PointF(offsetX + (picCanvas.Width / 2) - (mBaseMen / 2) * SF, offsetY + (picCanvas.Height / 2) - (mAltura / 2) * SF);
            points[1] = new PointF(offsetX + (picCanvas.Width / 2) + (mBaseMen / 2) * SF, offsetY + (picCanvas.Height / 2) - (mAltura / 2) * SF);
            points[2] = new PointF(offsetX + (picCanvas.Width / 2) + (mBaseMay / 2) * SF, offsetY + (picCanvas.Height / 2) + (mAltura / 2) * SF);
            points[3] = new PointF(offsetX + (picCanvas.Width / 2) - (mBaseMay / 2) * SF, offsetY + (picCanvas.Height / 2) + (mAltura / 2) * SF);
            //Dibuja el trapezoide
            mGraph.DrawPolygon(mPen, points);
        }


        //Función que limpia el canvas
        public void ClearCanvas(PictureBox picCanvas)
        {
            //Limpia el canvas  
            picCanvas.Refresh();
            //Desactiva el modo grafico  
            mGraph.Dispose();
        }

        //Función que cierra el formulario
        public void CloseForm(Form form)
        {
            //Cierra el formulario
            form.Close();
        }

    }
}
