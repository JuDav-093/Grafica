using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras1
{
    public partial class frmTrapezoide : Form
    {
        //definicion de un obj tipo CTrapezoide
        private CTrapezoide ObjTrapezoide = new CTrapezoide();
        public frmTrapezoide()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.btnCalculate.PreviewKeyDown += Control_PreviewKeyDown;
            this.btnReset.PreviewKeyDown += Control_PreviewKeyDown;
            this.btnExit.PreviewKeyDown += Control_PreviewKeyDown;
        }

        private void Control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos - llamada a la funcion ReadData
            ObjTrapezoide.ReadData(txtBaseMen, txtBaseMay, txtAltura);
            //calculo perimetro -  llamada a la funcion PerimetreTrapezoide
            ObjTrapezoide.PerimeterTrapezoide();
            //Calculo area - llamada a la func AreaTrapezoide
            ObjTrapezoide.AreaTrapezoide();
            //impresion de datos - llamada a func PintData
            ObjTrapezoide.PrintData(txtPerimeter, txtArea);
            //Graficacion del Rectangulo - llamada fun PlotShape
            ObjTrapezoide.PlotShape(picCanvas);

        }

        private void frmTrapezoide_Load(object sender, EventArgs e)
        {
            //Inicialización de los datos y controles
            //llamada a la funcion InitializeData
            ObjTrapezoide.InitializeData(txtBaseMen, txtBaseMay, txtAltura,
                                         txtPerimeter, txtArea,
                                         picCanvas);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de datos y controles - llamada a fun InitializeData
            ObjTrapezoide.InitializeData(txtBaseMen, txtBaseMay, txtAltura,
                                         txtPerimeter, txtArea,
                                         picCanvas);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierra la ventana
            this.Close();

        }

        private void trackBar1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true; // Permite que el trackbar reciba las teclas de flecha

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int valor = trackBar1.Value;
            // Actualiza el valor del trackbar en los campos
            txtAltura.Text = valor.ToString();
            txtBaseMen.Text = valor.ToString();
            txtBaseMay.Text = valor.ToString();
            // Llama a las funciones de lectura de datos para actualizar el trapezoide
            ObjTrapezoide.ReadData(txtBaseMen, txtBaseMay, txtAltura);
            ObjTrapezoide.PerimeterTrapezoide();
            ObjTrapezoide.AreaTrapezoide();
            ObjTrapezoide.PrintData(txtPerimeter, txtArea);
            // Redibuja el trapezoide en el canvas
            ObjTrapezoide.PlotShape(picCanvas);
            this.ActiveControl = null; // Desactiva el control activo para evitar problemas de enfoque

        }

        private void trackBar1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

        }

        private void frmTrapezoide_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) 
            {
                case Keys.Up:
                    ObjTrapezoide.Mover("arriba");
                    break;
                case Keys.Down:
                    ObjTrapezoide.Mover("abajo");
                    break;
                case Keys.Left:
                    ObjTrapezoide.Mover("izquierda");
                    break;
                case Keys.Right:
                    ObjTrapezoide.Mover("derecha");
                    break;
                case Keys.R:
                    ObjTrapezoide.Rotar("horario");
                    break;
                case Keys.L:
                    ObjTrapezoide.Rotar("antihorario");
                    break;

            }
            ObjTrapezoide.PlotShape(picCanvas); // Redibuja el trapezoide en el canvas
        }
    }
}
