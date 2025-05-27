using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras1
{
    internal class CRomboide
    {
        //Datos miembro (atributos)
        //Lado Base
        private float mLadoB;
        //Altura
        private float mAltura;
        //perimetro
        private float mPerimeter;
        //area
        private float mArea;
        //Objeto que activa modo gráfico
        private Graphics mGraph;
        //contante scale factor (Zoom in/Zoom out)
        private const float SF = 20;
        //Objeto boligrafo que dibuja
        private Pen mPen;

        //Funciones miembros (MÉTODOS)
        //Constructor sin parámetros
        public CRomboide()
        {
            mLadoB = 0.0f; mAltura = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Función que lee los datos de entrada del romboide
        public void ReadData(TextBox txtLadoB, TextBox txtAltura)
        {
            try
            {
                mLadoB = float.Parse(txtLadoB.Text);
                mAltura = float.Parse(txtAltura.Text);
                if (mLadoB < 0 || mAltura < 0)
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

        //Función que calcula el perímetro del romboide
        public void PerimeterRomboide()
        {
            mPerimeter = 2 * (mLadoB + mAltura);
        }
        //Función que calcula el área del romboide
        public void AreaRomboide()
        {
            mArea = mLadoB * mAltura;
        }
        //Función que imprime los resultados del cálculo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Función que inicializa los datos y controles
        public void InitializeData(TextBox txtLadoB, TextBox txtAltura,
                                    TextBox txtPerimeter, TextBox txtArea,
                                    PictureBox picCanvas)
        {
            //Inicializa los datos  
            mLadoB = 0.0f; mAltura = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            //Inicializa los controles
            txtLadoB.Text = ""; txtAltura.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            //Limpia el canvas  
            txtLadoB.Focus();
            picCanvas.Refresh();
        }
        //Función que grafica el romboide
        public void PlotShape(PictureBox picCanvas)
        {
            //Limpia el canvas  
            picCanvas.Refresh();
            //Activa el modo gráfico  
            mGraph = picCanvas.CreateGraphics();
            //Crea el boligrafo que dibuja  
            mPen = new Pen(Color.Blue, 2);
            //Dibuja el romboide  
            PointF[] points = new PointF[4];
            points[0] = new PointF(0, 0);
            points[1] = new PointF(mLadoB * SF, 0);
            points[2] = new PointF(mLadoB * SF + mAltura * SF, mAltura * SF);
            points[3] = new PointF(mAltura * SF, mAltura * SF);
            mGraph.DrawPolygon(mPen, points);
        }
        //Función que limpia el canvas
        public void ClearCanvas(PictureBox picCanvas)
        {
            //Limpia el canvas  
            picCanvas.Refresh();
            //Desactiva el modo gráfico  
            mGraph.Dispose();
        }
        //Función que cierra el programa
        public void CloseForm(Form ObjForm)
        {
            //Cierra el programa  
            ObjForm.Close();
        }
    }
}
