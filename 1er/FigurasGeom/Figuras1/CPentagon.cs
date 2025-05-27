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
        //offset para centrar el pentágono en el canvas
        private float offsetX, offsetY;
        //Angulo
        private float angulo;
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
            mLado = 0.0f; mPerimeter = 0.0f; mArea = 0.0f; offsetX = 0; offsetY = 0; angulo = 0;
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
        public void InitializeData(TextBox txtLado, TextBox txtPerimeter,
                                    TextBox txtArea,
                                    PictureBox picCanvas)
        {
            //Inicializa los datos
            mLado = 0.0f; mPerimeter = 0.0f; mArea = 0.0f; 
            offsetX = 0; offsetY = 0; angulo = 0;
            
            txtLado.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            //Limpia el canvas
            txtLado.Focus();
            picCanvas.Refresh();
        }

        //Funcion que mueve el pentágono regular
        public void Mover(string direccion)
        {
            float paso = 10;

            switch (direccion)
            {
                case "arriba": offsetY -= paso; break;
                case "abajo": offsetY += paso; break;
                case "izquierda": offsetX -= paso; break;
                case "derecha": offsetX += paso; break;
            }
        }

        public void Rotar(string sentido)
        {
            float paso = 10;
            if (sentido == "horario")
                angulo += paso;
            else if (sentido == "antihorario")
                angulo -= paso;
        }


        //Función que grafica el pentágono regular y permite rotar y mover el pentágono
        public void PlotShape(PictureBox picCanvas)
        {
            // Activa el modo gráfico
            mGraph = picCanvas.CreateGraphics();
            // Crea un bolígrafo
            mPen = new Pen(Color.Red, 2);
            // Limpia el canvas
            picCanvas.Refresh();

            // Calcula el centro del PictureBox
            float centerX = picCanvas.Width / 2f + offsetX;
            float centerY = picCanvas.Height / 2f + offsetY;

            // Calcula el radio del pentágono para que quepa en el PictureBox
            float radio = Math.Min(picCanvas.Width, picCanvas.Height) * 0.4f;

            // Dibuja el pentágono regular
            PointF[] pentagon = new PointF[5];
            for (int i = 0; i < 5; i++)
            {
                float angle = angulo + (i * 2 * (float)Math.PI / 5);
                pentagon[i] = new PointF(
                    centerX + radio * (float)Math.Cos(angle),
                    centerY + radio * (float)Math.Sin(angle)
                );
            }
            mGraph.DrawPolygon(mPen, pentagon);
        }

        //Función que limpia el canvas
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
