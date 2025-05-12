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
    public partial class frmEnneagon : Form
    {
        //Definición de un objeto tipo CEnneagon regular
        private CEnneagon ObjEnneagon = new CEnneagon();
        public frmEnneagon()
        {
            InitializeComponent();
        }

        private void frmEnneagon_Load(object sender, EventArgs e)
        {
            //Inicialización de los datos y controles
            //llamada a la función InitializeData
            ObjEnneagon.InitializeData(txtLado, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos - llamada a la función ReadData
            ObjEnneagon.ReadData(txtLado);
            //Cálculo perimetro -  llamada a la función PerimetreEnneagon
            ObjEnneagon.PerimeterEnneagon();
            //Cálculo área - llamada a la función AreaEnneagon
            ObjEnneagon.AreaEnneagon();
            //impresión de datos - llamada a función PintData
            ObjEnneagon.PrintData(txtPerimeter, txtArea);
            //Graficación del enneágono - llamada función PlotShape
            //ObjPentagon.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //inicialización de datos y controles - llamada a fun InitializeData
            ObjEnneagon.InitializeData(txtLado, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
