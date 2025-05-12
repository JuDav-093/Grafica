using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras1
{
    internal class CRectangle
    {
        //Datos Miembro (atributos)

        //Ancho rect
        private float mWidht;
        //Largo rect
        private float mHeight;
        //perimetro rect
        private float mPerimeter;
        //area rect
        private float mArea;
        //objeto que activa modo grafico
        private Graphics mGraph;
        //contante scale factor (Zoom in/Zoom out)
        private const float SF = 20;
        //Objeto boligrafo que dibuja
        private Pen mPen;

        //Funciones miembros (METODOS)

        //Constructor sin parametros
        public CRectangle()
        {
            mWidht = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        //Función que lee los datos de entrada del rectangulo
        public void ReadData(TextBox txtWidth, TextBox txtHeight)
        {
            try
            {
                mWidht = float.Parse(txtWidth.Text);
                mHeight = float.Parse(txtHeight.Text);

                if (mWidht < 0 || mHeight < 0)
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

        //Funcion que calcula perimetro 
        public void PerimeterRectangle()
        {
            mPerimeter = 2 * mWidht + 2 * mHeight;
        }

        //Funcion que calcula area rectangulo
        public void AreaRectangle()
        {
            mArea = mWidht * mHeight;
        }

        //Funcion imprime perimetro y Area rectangulo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = txtPerimeter.ToString();
            txtArea.Text = txtArea.ToString();
        }

        //Funcion que inicializa los datos y controles rectng
        public void InitializeData(TextBox txtWidth, TextBox txtHeight,
                                    TextBox txtPerimeter, TextBox txtArea,
                                    PictureBox picCanvas)
        {
            //Limpia los datos
            mWidht = 0.0f; mHeight= 0.0f;
            mPerimeter = 0.0f;mArea = 0.0f;
            //Limpia los controles
            txtWidth.Text = ""; txtHeight.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            //Mantiene el cursor titilando en una caja de texto
            txtWidth.Focus();
            picCanvas.Refresh();
        }

        //Funcion que Grafica un rectangulo
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un rectang
            mGraph.DrawRectangle(mPen, 0, 0, mWidht * SF, mHeight * SF);

        }

        //Funcion Cierra Formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

    }
}
