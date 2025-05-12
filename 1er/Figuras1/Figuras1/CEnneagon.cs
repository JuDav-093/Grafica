using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras1
{
    internal class CEnneagon
    {
        //datos miembros (atributos)
        //Ancho enneágono regular
        private float mLado;
        //perímetro enneágono
        private float mPerimeter;
        //área enneágono
        private float mArea;
        //objeto que activa modo gráfico
        private Graphics mGraph;
        //contante scale factor (Zoom in/Zoom out)
        private const float SF = 20;
        //Objeto bolígrafo que dibuja
        private Pen mPen;

        //Funciones miembros (MÉTODOS)
        //Constructor sin parámetros
        public CEnneagon()
        {
            mLado = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Función que lee los datos de entrada del enneágono regular
        public void ReadData(TextBox txtLado)
        {
            try
            {
                mLado = float.Parse(txtLado.Text);
                if (mLado < 0)
                {
                    MessageBox.Show("El valor no puede ser negativo.",
                                    "Mensaje error");
                    mLado = 0.0f; // Reinicia el valor a 0
                    txtLado.Text = "0";
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no valido...",
                                "Mensaje error");
            }
        }
        //Función que calcula perímetro enneágono regular
        public void PerimeterEnneagon()
        {
            mPerimeter = 9 * mLado;
        }
        //función calcula el área del enneágono regular
        public void AreaEnneagon() {
            mArea = (float)(2.69098 * Math.Pow(mLado, 2));
        }
        //Función que imprime los datos y controles calculados
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        //Función que inicializa los datos y controles
        public void InitializeData(TextBox txtLado, TextBox txtPerimeter,
                             TextBox txtArea, PictureBox picCanvas)
        {
            mLado = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            txtLado.Text = ""; txtPerimeter.Text = "";
            txtArea.Text = ""; 
            picCanvas.Refresh();
        }

        //Función que dibuja el enneágono regular

        //Función que limpia el canvas
        public void ClearCanvas(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mGraph.Clear(picCanvas.BackColor);            
        }
        //Función que cierra el form
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
