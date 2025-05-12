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
    public partial class frmEllipse : Form
    {
        //definicion de un obj tipo CEllipse
        private CEllipse ObjEllipse = new CEllipse();
        public frmEllipse()
        {
            InitializeComponent();
        }

        private void frmEllipse_Load(object sender, EventArgs e)
        {
            //Inicialización de los datos y controles
            //llamada a la funcion InitializeData
            ObjEllipse.InitializeData(txtRadio2, txtRadio1,
                                       txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos - llamada a la función ReadData
            ObjEllipse.ReadData(txtRadio2, txtRadio1);
            //cálculo perímetro -  llamada a la función PerimetreRectangle
            ObjEllipse.PerimeterEllipse();
            //Cálculo área - llamada a la func AreaRectangle
            ObjEllipse.AreaEllipse();
            //impresión de datos - llamada a func PintData
            ObjEllipse.PrintData(txtPerimeter, txtArea);
            //Graficación del Rectángulo - llamada fun PlotShape
            //ObjEllipse.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Llamada a la funcion InitializeData
            ObjEllipse.InitializeData(txtRadio2, txtRadio1,
                                       txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierra la ventana
            this.Close();
        }
    }
}
