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
    public partial class frmTriangleIrreg : Form
    {
        //definicion de un obj tipo CTriangleIrreg
        private CTriangleIrre ObjTriangleIrreg = new CTriangleIrre();
        public frmTriangleIrreg()
        {
            InitializeComponent();
        }

        
        private void frmTriangleIrreg_Load(object sender, EventArgs e)
        {
            //Inicialización de los datos y controles
            //llamada a la funcion InitializeData
            ObjTriangleIrreg.InitializeData(txtLado1, txtLado2, txtLado3,
                                             txtPerimeter, txtArea,
                                             picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos - llamada a la funcion ReadData
            ObjTriangleIrreg.ReadData(txtLado1, txtLado2, txtLado3);
            //calculo perimetro -  llamada a la funcion PerimetreTriangle
            ObjTriangleIrreg.PerimeterTriangle();
            //Calculo area - llamada a la func AreaTriangle
            ObjTriangleIrreg.AreaTriangle();
            //impresion de datos - llamada a func PintData
            ObjTriangleIrreg.PrintData(txtPerimeter, txtArea);
            //Graficacion del Rectangulo - llamada fun PlotShape
            ObjTriangleIrreg.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de datos y controles - llamada a fun InitializeData
            ObjTriangleIrreg.InitializeData(txtLado1, txtLado2, txtLado3,
                                             txtPerimeter, txtArea,
                                             picCanvas);

        }


    }
}
