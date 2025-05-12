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
    public partial class frmHexagon : Form
    {
        //Definición de un objeto tipo CHexagon
        private CHexagon ObjHexagon = new CHexagon();
        public frmHexagon()
        {
            InitializeComponent();
        }

        private void frmHexagon_Load(object sender, EventArgs e)
        {
            //Inicialización de los datos y controles
            //llamada a la función InitializeData
            ObjHexagon.InitializeData(txtLado, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos - llamada a la funcion ReadData
            ObjHexagon.ReadData(txtLado);
            //calculo perimetro -  llamada a la funcion PerimetreHexagon
            ObjHexagon.PerimeterHexagon();
            //Calculo area - llamada a la func AreaHexagon
            ObjHexagon.AreaHexagon();
            //impresion de datos - llamada a func PintData
            ObjHexagon.PrintData(txtPerimeter, txtArea);
            //Graficacion del hexágono - llamada fun PlotShape
            //ObjPentagon.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //inicialización de datos y controles - llamada a fun InitializeData
            ObjHexagon.InitializeData(txtLado, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
    
}
