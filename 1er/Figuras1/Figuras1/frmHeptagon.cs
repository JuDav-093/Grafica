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
    public partial class frmHeptagon : Form
    {
        //Definición de un objeto tipo CHeptagon regular
        private CHeptagon ObjHeptagon = new CHeptagon();
        public frmHeptagon()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos - llamada a la función ReadData
            ObjHeptagon.ReadData(txtLado);
            //Cálculo perimetro -  llamada a la función PerimetreHeptagon
            ObjHeptagon.PerimeterHeptagon();
            //Cálculo área - llamada a la función AreaHeptagon
            ObjHeptagon.AreaHeptagon();
            //impresión de datos - llamada a función PintData
            ObjHeptagon.PrintData(txtPerimeter, txtArea);
            //Graficación del heptágono - llamada función PlotShape
            //ObjPentagon.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //inicialización de datos y controles - llamada a fun InitializeData
            ObjHeptagon.InitializeData(txtLado, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHeptagon_Load_1(object sender, EventArgs e)
        {
            //Inicialización de los datos y controles
            //llamada a la función InitializeData
            ObjHeptagon.InitializeData(txtLado, txtPerimeter, txtArea, picCanvas);

        }
    }
}
