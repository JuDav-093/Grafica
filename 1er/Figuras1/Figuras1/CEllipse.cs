using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras1
{
    internal class CEllipse
    {
        //datos miembros (atributos)
        //Ancho elipse
        private float mMayor;
        //Alto elipse
        private float mMenor;
        //perímetro elipse
        private float mPerimeter;
        //área elipse
        private float mArea;
        //objeto que activa modo gráfico
        //private Graphics mGraph;
        //contante scale factor (Zoom in/Zoom out)
        private const float SF = 20;
        //Objeto bolígrafo que dibuja
        //private Pen mPen;
        
        //Funciones miembros (MÉTODOS)
        //Constructor sin parámetros
        public CEllipse()
        {
            mMayor = 0.0f; 
            mMenor = 0.0f; 
            mPerimeter = 0.0f; 
            mArea = 0.0f;
        }
        //Función que lee los datos de entrada de la elipse
        public void ReadData(TextBox txtRadio1, TextBox txtRadio2)
        {
            try
            {
                mMayor = float.Parse(txtRadio2.Text);
                mMenor = float.Parse(txtRadio1.Text);
                if (mMayor < 0 || mMenor < 0)
                {
                    throw new ArgumentException("El ancho y el alto no pueden ser negativos.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Mensaje error");
                mMayor = 0.0f; // Reinicia el valor del ancho
                mMenor = 0.0f; // Reinicia el valor del alto
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje error");
                mMayor = 0.0f; // Reinicia el valor del ancho
                mMenor = 0.0f; // Reinicia el valor del alto
            }
        }
        //Función que calcula perímetro elipse
        public void PerimeterEllipse()
        {
            mPerimeter = (float)(Math.PI * (3 * (mMayor + mMenor) - Math.Sqrt((3 * mMayor + mMenor) * (mMayor + 3 * mMenor))));
        }
        //Función calcula el área de la elipse
        public void AreaEllipse()
        {
            mArea = (float)(Math.PI * mMayor * mMenor);
        }
        //Función que imprime los datos calculados
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Función que inicializa datos y controles
        public void InitializeData(TextBox txtRadio1, TextBox txtRadio2, TextBox txtPerimeter,
                                    TextBox txtArea, PictureBox picCanvas)
        {
            //se inicializa los datos
            mMayor = 0.0f;
            mMenor = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            //se inicializan los controles
            txtRadio1.Text = "";
            txtRadio2.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            picCanvas.Refresh();
        }

        //Función que dibuja la elipse

        //Funcion que Cierra el formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

    }
}
