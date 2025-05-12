using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras1
{
    internal class CCircle
    {
        //Datos Miembro (atributos)

        //Ancho rect
        private float mradio;
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

        //funciones miembros (METODOS)
        //Constructor sin parametros

        public CCircle()
        {
            mradio = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        //Función que lee los datos de entrada del circulo
        public void ReadData(TextBox txtradio)
        {
            try
            {
                mradio = float.Parse(txtradio.Text);
                if (mradio < 0)
                {
                    throw new ArgumentException("El radio no puede ser negativo.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Mensaje error");
                mradio = 0.0f; // Reinicia el valor del radio
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje error");
                mradio = 0.0f; // Reinicia el valor del radio
            }
        }
        //Función que calcula perimetro
        public void PerimeterCircle()
        {
            mPerimeter = 2 * (float)Math.PI * mradio;
        }
        //Función que calcula area circulo
        public void AreaCircle()
        {
            mArea = (float)Math.PI * mradio * mradio;
        }
        //Funcion que inicializa datos y controles
        public void InitializeData(TextBox txtradio, TextBox txtPerimeter,
                                   TextBox txtArea, PictureBox picCanvas)
        {
            //se inicializan los datos
            mradio = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            txtradio.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtradio.Focus();
            picCanvas.Refresh();
        }

        //Funcion que imprime datos
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        //Funcion que grafica el circulo
        public void PlotShape(PictureBox picCanvas)
        {
            //se activa el modo grafico
            mGraph = picCanvas.CreateGraphics();
            //se inicializa el boligrafo
            mPen = new Pen(Color.Green, 2);
            //se dibuja el circulo
            mGraph.DrawEllipse(mPen, 0, 0, mradio * SF, mradio * SF);
        }
        //Funcion cierra Formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }


    }
}
