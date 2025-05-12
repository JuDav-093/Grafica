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
    public partial class frmRombo : Form
    {
        //definicion de un obj tipo CRectangle
        private CRombo ObjRombo = new CRombo();
        public frmRombo()
        {
            InitializeComponent();
        }

        private void frmRombo_Load(object sender, EventArgs e)
        {
            //Inicialización de los datos y controles
            //llamada a la funcion InitializeData
            ObjRombo.InitializeData(txtLado, txtAltura,
                                        txtPerimeter, txtArea,
                                        picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos - llamada a la funcion ReadData
            ObjRombo.ReadData(txtLado, txtAltura);
            //calculo perimetro -  llamada a la funcion PerimetreRombo
            ObjRombo.PerimeterRombo();
            //Calculo area - llamada a la func AreaRombo
            ObjRombo.AreaRombo();
            //impresion de datos - llamada a func PintData
            ObjRombo.PrintData(txtPerimeter, txtArea);
            //Graficacion del Rectangulo - llamada fun PlotShape
            ObjRombo.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de datos y controles - llamada a fun InitializeData
            ObjRombo.InitializeData(txtLado, txtAltura,
                                        txtPerimeter, txtArea,
                                        picCanvas);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
