using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras1
{
    internal class CSquare
    {
        //Datos Miembro (atributos)

        //Ancho lado
        private float mLado;
        //perímetro rect
        private float mPerimeter;
        //área rect
        private float mArea;
        //objeto que activa modo gráfico
        private Graphics mGraph;
        //contante scale factor (Zoom in/Zoom out)
        private const float SF = 20;
        //Objeto bolígrafo que dibuja
        private Pen mPen;

        //Funciones miembros (MÉTODOS)

        //Constructor sin parámetros
        public CSquare()
        {
            mLado = 0.0f; 
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Función que lee los datos de entrada del cuadrado
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
                mLado = 0.0f; // Reiniciar el valor en caso de error
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje error");
                mLado = 0.0f; // Reiniciar el valor en caso de error
            }
        }
        //Funcián que calcula perímetro
        public void PerimeterSquare()
        {
            mPerimeter = 4 * mLado;
        }
        //Función que calcula área cuadrado
        public void AreaSquare()
        {
            mArea = mLado * mLado;
        }

        //Función que imprime datos 
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        //Función que grafica el cuadrado
        public void PlotShape(PictureBox picCanvas)
        {
            //se activa el modo gráfico
            mGraph = picCanvas.CreateGraphics();
            //se inicializa el bolígrafo
            mPen = new Pen(Color.Pink, 2);
            //se dibuja el cuadrado
            mGraph.DrawRectangle(mPen, 0, 0, mLado * SF, mLado * SF);
        }
        //Función que inicializa los datos y controles
        public void InitializeData(TextBox txtLado, TextBox txtPerimeter,
                                   TextBox txtArea, PictureBox picCanvas)
        {
            //se inicializan los datos
            mLado = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            //se limpian los controles
            txtLado.Clear(); txtPerimeter.Clear(); txtArea.Clear();
            //se limpia el canvas
            picCanvas.Refresh();
        }
        //Función que cierra el formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

    }
}
