using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras1
{
    internal class CRombo
    {
        //Datos Miembro (atributos)  

        //Ancho rombo
        private float mLado;
        //altura  
        private float mAltura;
        //perimetro rombo
        private float mPerimeter;
        //area rombo  
        private float mArea;
        //objeto que activa modo grafico  
        private Graphics mGraph;
        //contante scale factor (Zoom in/Zoom out)  
        private const float SF = 20;
        //Objeto boligrafo que dibuja  
        private Pen mPen;

        //Funciones miembros (METODOS)  

        //Constructor sin parametros  
        public CRombo()
        {
            mLado = 0.0f; mAltura = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Función que lee los datos de entrada del rectangulo de lados iguales  
        public void ReadData(TextBox txtLado, TextBox txtAltura)
        {
            try
            {
                mLado = float.Parse(txtLado.Text);
                mAltura = float.Parse(txtAltura.Text);

                if (mLado < 0 || mAltura < 0)
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

        //Funcion que calcula perimetro rombo de lados iguales  
        public void PerimeterRombo()
        {
            mPerimeter = 4 * mLado;
        }

        //funcion calcula el area del rombo lados iguales  
        public void AreaRombo()
        {
            mArea = mLado * mAltura;
        }

        //Funcion Imprime perimetro y area rombo lados iguales  
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Funcion que inicializa los datos y controles del rombo  
        public void InitializeData(TextBox txtLado, TextBox txtAltura, TextBox txtPerimeter,
                                        TextBox txtArea, PictureBox picCanvas)
        {
            //Inicializa los datos  
            mLado = 0.0f; mAltura = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            //Inicializa los controles  
            txtLado.Text = ""; txtAltura.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            //Limpia el canvas  
            txtLado.Focus();
            picCanvas.Refresh();
        }

        //Funcion que Grafica un rombo lados iguales  
        public void PlotShape(PictureBox picCanvas)
        {
            //Limpia el canvas  
            picCanvas.Refresh();
            //Activa el modo grafico  
            mGraph = picCanvas.CreateGraphics();
            //Dibuja el rombo lados iguales  
            mPen = new Pen(Color.Red, 2);
            PointF[] points = new PointF[4];

            // Ajustar el centro del rombo para que no comience desde la esquina superior izquierda  
            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            points[0] = new PointF(centerX, centerY - (mAltura * SF) / 2);
            points[1] = new PointF(centerX + (mLado * SF) / 2, centerY);
            points[2] = new PointF(centerX, centerY + (mAltura * SF) / 2);
            points[3] = new PointF(centerX - (mLado * SF) / 2, centerY);

            mGraph.DrawPolygon(mPen, points);
        }

        //Funcion que limpia el canvas  
        public void ClearCanvas(PictureBox picCanvas)
        {
            //Limpia el canvas  
            picCanvas.Refresh();
            //Desactiva el modo grafico  
            mGraph.Dispose();
        }

        //Funcion que cierra el Form  
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
