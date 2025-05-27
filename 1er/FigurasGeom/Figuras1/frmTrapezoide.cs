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
    }
}
