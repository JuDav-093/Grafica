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
            mBaseMen = 0.0f; mBaseMay = 0.0f;
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
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje error");
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
            //Inicializa los datos y controles
            txtBaseMen.Text = "";
            txtBaseMay.Text = "";
            txtAltura.Text = "";
            txtPerimeter.Text = "0";
            txtArea.Text = "0";
            picCanvas.Refresh();
        }
        //Función que grafica el trapezoide
        public void PlotShape(PictureBox picCanvas)
        {
            //Crea el objeto Graphics
            mGraph = picCanvas.CreateGraphics();
            //Crea el objeto Pen
            mPen = new Pen(Color.Red, 2);
            //Limpia el canvas
            picCanvas.Refresh();
            //Dibuja el trapezoide
            PointF[] points = new PointF[4];
            points[0] = new PointF(0, 0);
            points[1] = new PointF(mBaseMen * SF, 0);
            points[2] = new PointF(mBaseMay * SF, mAltura * SF);
            points[3] = new PointF(0, mAltura * SF);
            mGraph.DrawPolygon(mPen, points);
        }

        //funcion que limpia el camvas
        public void ClearCanvas(PictureBox picCanvas)
        {
            //Limpia el canvas
            picCanvas.Refresh();
            //Libera los recursos
            mGraph.Dispose();
            mPen.Dispose();
        }
        //Función que cierra el formulario
        public void CloseForm(Form form)
        {
            //Cierra el formulario
            form.Close();
        }

    }
}
