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
    public partial class frmCircle : Form
    {
        //definicion de un obj tipo CRectangle
        private CCircle ObjCircle = new CCircle();
        public frmCircle()
        {
            InitializeComponent();
        }

        private void frmCircle_Load(object sender, EventArgs e)
        {
            //Inicialización de los datos y controles
            //llamada a la funcion InitializeData
            ObjCircle.InitializeData(txtRadio, txtPerimeter,
                                      txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos - llamada a la funcion ReadData
            ObjCircle.ReadData(txtRadio);
            //calculo perimetro -  llamada a la funcion PerimetreRectangle
            ObjCircle.PerimeterCircle();
            //Calculo area - llamada a la func AreaRectangle
            ObjCircle.AreaCircle();
            //impresion de datos - llamada a func PintData
            ObjCircle.PrintData(txtPerimeter, txtArea);
            //Graficacion del Rectangulo - llamada fun PlotShape
            ObjCircle.PlotShape(picCanvas);

        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierra la ventana
            this.Close();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ObjCircle.InitializeData(txtRadio, txtPerimeter, txtArea, picCanvas);
        }
    }
}
