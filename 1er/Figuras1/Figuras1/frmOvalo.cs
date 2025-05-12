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
    public partial class frmOvalo : Form
    {
        //definicion de un obj tipo CEllipse
        private CEllipse ObjOvalo = new CEllipse();
        public frmOvalo()
        {
            InitializeComponent();
        }

        private void frmOvalo_Load(object sender, EventArgs e)
        {
            //Inicialización de los datos y controles
            //llamada a la funcion InitializeData
            ObjOvalo.InitializeData(txtRadio2, txtRadio1,
                                        txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //llamada a la funcion ReadData
            ObjOvalo.ReadData(txtRadio1, txtRadio2);
            //cálculo perímetrp - llamada función PerimeterEllipse
            ObjOvalo.PerimeterEllipse();
            //Cálculo área - llamada a la func AreaEllipse
            ObjOvalo.AreaEllipse();
            //impresión de datos - llamada a func PrintData
            ObjOvalo.PrintData(txtPerimeter, txtArea);
            //Graficación del Rectángulo - llamada fun PlotShape
            //ObjOvalo.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Llamada a la funcion InitializeData
            ObjOvalo.InitializeData(txtRadio2, txtRadio1,
                                        txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierra la ventana
            this.Close();
        }
    }
}
