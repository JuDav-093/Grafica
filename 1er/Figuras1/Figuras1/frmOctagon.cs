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
    public partial class frmOctagon : Form
    {
        //Definición de un objeto tipo COctagon regular
        private COctagon ObjOctagon = new COctagon();
        public frmOctagon()
        {
            InitializeComponent();
        }

        private void frmOctagon_Load(object sender, EventArgs e)
        {
            //Inicialización de los datos y controles
            //llamada a la función InitializeData
            ObjOctagon.InitializeData(txtLado, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos - llamada a la función ReadData
            ObjOctagon.ReadData(txtLado);
            //Cálculo perimetro -  llamada a la función PerimetreOctagon
            ObjOctagon.PerimeterOctagon();
            //Cálculo área - llamada a la función AreaOctagon
            ObjOctagon.AreaOctagon();
            //impresión de datos - llamada a función PintData
            ObjOctagon.PrintData(txtPerimeter, txtArea);
            //Graficación del octágono - llamada función PlotShape
            //ObjPentagon.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //inicialización de datos y controles - llamada a fun InitializeData
            ObjOctagon.InitializeData(txtLado, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
