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
    public partial class frmRectangulo : Form
    {
        //definicion de un obj tipo CRectangle
        private CRectangle ObjRectangle = new CRectangle();
        public frmRectangulo()
        {
            InitializeComponent();
        }

        private void frmRectangle_Load(object sender, EventArgs e)
        {
            //Inicialización de los datos y controles
            //llamada a la funcion InitializeData
            ObjRectangle.InitializeData(txtWidth, txtHeight,
                                        txtPerimeter, txtArea,
                                        picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos - llamada a la funcion ReadData
            ObjRectangle.ReadData(txtWidth, txtHeight);
            //calculo perimetro -  llamada a la funcion PerimetreRectangle
            ObjRectangle.PerimeterRectangle();
            //Calculo area - llamada a la func AreaRectangle
            ObjRectangle.AreaRectangle();
            //impresion de datos - llamada a func PintData
            ObjRectangle.PrintData(txtPerimeter, txtArea); 
            //Graficacion del Rectangulo - llamada fun PlotShape
            ObjRectangle.PlotShape(picCanvas);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de datos y controles - llamada a fun InitializeData
            ObjRectangle.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
