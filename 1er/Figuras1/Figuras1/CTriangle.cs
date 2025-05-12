using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras1
{
    internal class CTriangle
    {
        //Datos Miembro (atributos)

        //Lado
        private float mLado;
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
        public CTriangle()
        {
            mLado = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Función que lee los datos de entrada del rectangulo
        public void ReadData(TextBox txtLado)
        {
            try
            {
                mLado = float.Parse(txtLado.Text);
                if (mLado < 0)
                {
                    throw new ArgumentOutOfRangeException("El valor del lado no puede ser negativo.");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Mensaje error");
            }
            catch
            {
                MessageBox.Show("Ingreso no valido...", "Mensaje error");
            }
        }

        //Funcion que calcula perimetro
        public void PerimeterTriangle()
        {
            mPerimeter = 3 * mLado;
        }

        //Funcion que calcula area Triangulo
        public void AreaTriangle()
        {
            mArea = (float)(Math.Sqrt(3) / 4 * Math.Pow(mLado, 2));
        }
        
        //Funcion que imprime datos
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Funcion que inicializa datos y controles
        public void InitializeData(TextBox txtLado,TextBox txtPerimeter,
                                        TextBox txtArea,PictureBox picCanvas)
        {
            //Inicializa los datos
            mLado = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            //Inicializa los controles
            txtLado.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            //Mantiene el cursor titilando en una caja de texto
            txtLado.Focus();
            picCanvas.Refresh();
        }
        
        //Funcion que grafica el triangulo
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 2);
            //Punto A
            PointF A = new PointF(0, 0);
            //Punto B
            PointF B = new PointF(mLado * SF, 0);
            //Punto C
            PointF C = new PointF(mLado * SF / 2, (float)(Math.Sqrt(3) / 2 * mLado * SF));
            //Arreglo de puntos
            PointF[] points = { A, B, C };
            mGraph.DrawPolygon(mPen, points);
        }

        //Funcion que grafica el triangulo al iniciar el programa
        public void PlotOnStart(PictureBox picCanvas)
        {
            mLado = 5.0f; // Valor predeterminado para el lado del triángulo
            PlotShape(picCanvas);
        }

        //Funcion que limpia el canvas
        public void ClearCanvas(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mGraph.Clear(picCanvas.BackColor);
        }

        //Función cierrra Formulario
        public void CloseForm()
        {
            Application.Exit();
        }



    }
}
