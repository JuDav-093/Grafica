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
    public partial class frmPentagon : Form
    {
        //definición de un objeto tipo CPentagono
        private CPentagon ObjPentagon = new CPentagon();
        public frmPentagon()
        {
            InitializeComponent();
        }

        private void frmPentagon_Load(object sender, EventArgs e)
        {
            //inicialización de los datos y controles
            //llamada a la función InitializeData
            ObjPentagon.InitializeData(txtLado, txtPerimeter, txtArea, picCanvas);

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos - llamada a la funcion ReadData
            ObjPentagon.ReadData(txtLado);
            //cálculo perimetro -  llamada a la funcion PerimetrePentagon
            ObjPentagon.PerimeterPentagon();
            //Cálculo area - llamada a la func AreaPentagon
            ObjPentagon.AreaPentagon();
            //impresión de datos - llamada a func PintData
            ObjPentagon.PrintData(txtPerimeter, txtArea);
            //Graficación del pentágono - llamada fun PlotShape
            //ObjPentagon.PlotShape(picCanvas);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //inicialización de datos y controles - llamada a fun InitializeData
            ObjPentagon.InitializeData(txtLado, txtPerimeter, txtArea, picCanvas);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
