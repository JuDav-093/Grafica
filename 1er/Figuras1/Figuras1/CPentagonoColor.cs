using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras1
{
    internal class CPentagonoColor
    {
        //datos miembros (atributos)
        //Ancho pentagono regular interno
        private float mLado;
        //radio pentagono regular global
        private float mRadio;
        //apotema pentagono regular
        private float mApotema;
        //objeto que activa modo grafico
        private Graphics mGraph;
        //contante scale factor (Zoom in/Zoom out)
        private const float SF = 20;
        //Objeto bolígrafo que dibuja
        private Pen mPen;
        //Objeto brocha que pinta
        private SolidBrush mBrush;

        //Funciones miembros (METODOS)
        //Constructor sin parametros

        public CPentagonoColor()
        {
            mLado = 0.0f; mRadio = 0.0f; mApotema = 0.0f;
            mPen = new Pen(Color.Black, 2);
            mBrush = new SolidBrush(Color.Red);
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
        //Función que calcula radio pentágono regular
        public void RadioPentagon()
        {
            mRadio = (float)(mLado / (2 * Math.Sin(Math.PI / 5)));
        }
        //Función que calcula apotema pentágono regular
        public void ApotemaPentagon()
        {
            mApotema = (float)(mLado / (2 * Math.Tan(Math.PI / 5)));
        }
        //funcion que inicializa los datos y controles 

        public void InitializeData(TextBox txtLado, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            //se limpian los controles
            txtLado.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();
            //se limpian el canvas
            mGraph = picCanvas.CreateGraphics();
            mGraph.Clear(Color.White);
            //se inicializan los valores de los atributos
            mLado = 0.0f; mRadio = 0.0f; mApotema = 0.0f;
        }

        //funcion que dibuja el pentagono regular en el centro del canvas con la punta hacia abajo
        public void PlotShape(PictureBox picCanvas)
        {
            //se activa el modo grafico
            mGraph = picCanvas.CreateGraphics();
            //se limpia el canvas
            mGraph.Clear(Color.White);
            //se dibuja el pentágono regular
            PointF[] pentagon = new PointF[5];
            for (int i = 0; i < 5; i++)
            {
                float angle = (float)(i * 2 * Math.PI / 5);
                pentagon[i] = new PointF(
                    picCanvas.Width / 2 + mRadio * (float)Math.Cos(angle),
                    picCanvas.Height / 2 + mRadio * (float)Math.Sin(angle));
            }
            mGraph.FillPolygon(mBrush, pentagon);
            mGraph.DrawPolygon(mPen, pentagon);
        }




    }
}
