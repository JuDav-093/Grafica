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
    public partial class frmDecagon : Form
    {
        //Definición de un objeto tipo CDecagon regular
        private CDecagon ObjDecagon = new CDecagon();
        public frmDecagon()
        {
            InitializeComponent();
        }

        private void frmDecagon_Load(object sender, EventArgs e)
        {
            //Inicializa los datos y controles
            //llamada a la función InitializeData
            ObjDecagon.InitializeData(txtLado, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos - llamada a la función ReadData
            ObjDecagon.ReadData(txtLado);
            //Cálculo perimetro -  llamada a la función PerimetreDecagon
            ObjDecagon.PerimeterDecagon();
            //Cálculo área - llamada a la función AreaDecagon
            ObjDecagon.AreaDecagon();
            //impresión de datos - llamada a función PintData
            ObjDecagon.PrintData(txtPerimeter, txtArea);
            //Graficación del decágono - llamada función PlotShape
            //ObjPentagon.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //inicialización de datos y controles - llamada a fun InitializeData
            ObjDecagon.InitializeData(txtLado, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
