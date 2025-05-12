using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Figuras1
{
    internal class CHexagon
    {
        //datos miembros (atributos)
        //Ancho hexagono regular
        private float mLado;
        //perimetro hexagono
        private float mPerimeter;
        //Área hexagono
        private float mArea;
        //objeto que activa modo grafico
        private Graphics mGraph;
        //constante scale factor (Zoom in/Zoom out)
        private const float SF = 20;
        //Objeto bolígrafo que dibuja
        private Pen mPen;

        //Funciones miembros (METODOS)
        //Constructor sin parametros
        public CHexagon()
        {
            mLado = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Función que lee los datos de entrada del hexágono regular
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
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...",
                                "Mensaje error");
            }
        }

        //Función que calcula perímetro hexágono regular
        public void PerimeterHexagon()
        {
            mPerimeter = 6 * mLado;
        }
        //función calcula el área del hexágono regular
        public void AreaHexagon()
        {
            mArea = (float)(2.59808 * Math.Pow(mLado, 2));
        }
        //Función que imprime los datos calculados
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        //Función que inicializa los datos y controles
        public void InitializeData(TextBox txtLado, TextBox txtPerimeter,
                                   TextBox txtArea, PictureBox picCanvas)
        {
            //inicializa los datos
            mLado = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            //inicializa los controles
            txtLado.Text = ""; txtPerimeter.Text = ""; txtArea.Text = "";
            //inicializa el objeto gráfico
            mGraph = picCanvas.CreateGraphics();
            //inicializa el objeto bolígrafo
            mPen = new Pen(Color.Black);
        }
        //Función que grafica el hexagono regular
        //función que limpia canvas
        public void ClearCanvas(PictureBox picCanvas)
        {
            //Limpia el canvas
            mGraph.Clear(picCanvas.BackColor);
        }
        //FUncion que cierra el form
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
