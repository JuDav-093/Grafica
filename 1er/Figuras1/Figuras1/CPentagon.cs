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
    }
}
