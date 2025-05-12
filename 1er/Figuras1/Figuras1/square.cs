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
    public partial class frmsquare : Form
    {
        //definicion de un obj tipo CRectangle
        private CSquare ObjSquare = new CSquare();
        public frmsquare()
        {
            InitializeComponent();
        }


        private void frmsquare_Load(object sender, EventArgs e)
        {
            //Inicialización de los datos y controles
            //llamada a la funcion InitializeData
            ObjSquare.InitializeData(txtLado,
                                        txtPerimeter, txtArea,
                                        picCanvas);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos - llamada a la funcion ReadData
            ObjSquare.ReadData(txtLado);
            //calculo perimetro -  llamada a la funcion PerimetreSquare
            ObjSquare.PerimeterSquare();
            //Calculo area - llamada a la func AreaSquare
            ObjSquare.AreaSquare();
            //impresion de datos - llamada a func PintData
            ObjSquare.PrintData(txtPerimeter, txtArea);
            //Graficacion del Rectangulo - llamada fun PlotShape
            ObjSquare.PlotShape(picCanvas);

        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Cierra la ventana
            this.Close();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtLado, txtPerimeter, txtArea, picCanvas);
        }
    }
}
