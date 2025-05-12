using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Figuras1
{
    internal class COvalo
    {
        //datos miembros (atributos)
        //Radio menor
        private float mMenor;
        //Radio mayor
        private float mMayor;
        //Distancia entre vertices
        private float mDistancia;
        //perímetro Óvalo
        private float mPerimeter;
        //área Óvalo
        private float mArea;
        //objeto que activa modo gráfico
        private Graphics mGraph;
        //contante scale factor (Zoom in/Zoom out)
        private const float SF = 20;
        //Objeto bolígrafo que dibuja
        private Pen mPen;

        //Funciones miembros (MÉTODOS)
        //Constructor sin parámetros
        public COvalo()
        {
            mMenor = 0.0f;
            mMayor = 0.0f;
            mDistancia = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }
        //Función que lee los datos de entrada del Óvalo
        public void ReadData(TextBox txtRadio1, TextBox txtRadio2, TextBox txtDistancia)
        {
            try
            {
                mMenor = float.Parse(txtRadio1.Text);
                mMayor = float.Parse(txtRadio2.Text);
                mDistancia = float.Parse(txtDistancia.Text);
                if (mMenor < 0 || mMayor < 0 || mDistancia < 0)
                {
                    throw new ArgumentException("El radio menor, mayor y la distancia no pueden ser negativos.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Mensaje error");
                mMenor = 0.0f; // Reinicia el valor del radio menor
                mMayor = 0.0f; // Reinicia el valor del radio mayor
                mDistancia = 0.0f; // Reinicia el valor de la distancia
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje error");
                mMenor = 0.0f; // Reinicia el valor del radio menor
                mMayor = 0.0f; // Reinicia el valor del radio mayor
                mDistancia = 0.0f; // Reinicia el valor de la distancia
            }
        }
        //Función que calcula perímetro Óvalo irregular
        public void PerimeterOvalo()
        {
            // Fórmula: P = π(R1 + R2) + 2L
            mPerimeter = (float)(Math.PI * (mMenor + mMayor) + 2 * mDistancia);
        }

        //Función que calcula área Óvalo irregular
        public void AreaOvalo()
        {
            // Fórmula:A= π/2​ ((R1*R1)+(R2*R2)) + L(R1 +R2)
            mArea = (float)(Math.PI / 2 * ((mMenor * mMenor) + (mMayor * mMayor)) + mDistancia * (mMenor + mMayor));

        }
        //Función que imprime los datos de salida
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }
        //Función que inicializa los datos y controles
        public void InitializeData(TextBox txtRadio1, TextBox txtRadio2, TextBox txtDistancia,
                                    TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            //Inicializa los datos
            mMenor = 0.0f;
            mMayor = 0.0f;
            mDistancia = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            //Inicializa los controles
            txtRadio1.Text = "0.0";
            txtRadio2.Text = "0.0";
            txtDistancia.Text = "0.0";
            txtPerimeter.Text = "0.0";
            txtArea.Text = "0.0";
            //Limpia el canvas
            picCanvas.Refresh();
        }
        //Función que dibuja el Óvalo irregular
        //Función que cierra el formulario
        public void CloseForm(Form ObjForm)
        {
            //Cierra el formulario
            ObjForm.Close();
        }

    }
}
