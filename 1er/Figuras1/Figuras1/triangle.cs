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
    public partial class frmTriangle : Form
    {
        //definicion de un obj tipo CRectangle
        private CTriangle ObjTriangle = new CTriangle();
        public frmTriangle()
        {
            InitializeComponent();
        }

        private void frmTriangle_Load(object sender, EventArgs e)
        {
            //Inicialización de los datos y controles
            //llamada a la funcion InitializeData
            ObjTriangle.InitializeData(txtLado,
                                        txtPerimeter, txtArea,
                                        picCanvas);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos - llamada a la funcion ReadData
            ObjTriangle.ReadData(txtLado);
            //calculo perimetro -  llamada a la funcion PerimetreTriangle
            ObjTriangle.PerimeterTriangle();
            //Calculo area - llamada a la func AreaTriangle
            ObjTriangle.AreaTriangle();
            //impresion de datos - llamada a func PintData
            ObjTriangle.PrintData(txtPerimeter, txtArea);
            //Graficacion del Rectangulo - llamada fun PlotShape
            ObjTriangle.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de datos y controles - llamada a fun InitializeData
            ObjTriangle.InitializeData(txtLado,txtPerimeter, txtArea,picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierra la ventana
            this.Close();
        }

        
    }
}
