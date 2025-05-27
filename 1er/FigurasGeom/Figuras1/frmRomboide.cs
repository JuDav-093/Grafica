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
    public partial class frmRomboide : Form
    {
        private CRomboide ObjRomboide = new CRomboide();
        public frmRomboide()
        {
            InitializeComponent();
        } 

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Lectura de datos - llamada a la funcion ReadData
            ObjRomboide.ReadData(txtLadoB, txtAltura);
            //calculo perimetro -  llamada a la funcion PerimetreRomboide
            ObjRomboide.PerimeterRomboide();
            //Calculo area - llamada a la func AreaRomboide
            ObjRomboide.AreaRomboide();
            //impresion de datos - llamada a func PintData
            ObjRomboide.PrintData(txtPerimeter, txtArea);
            //Graficacion del Rectangulo - llamada fun PlotShape
            ObjRomboide.PlotShape(picCanvas);

        }

        private void frmRomboide_Load(object sender, EventArgs e)
        {
            //Inicialización de los datos y controles
            //llamada a la funcion InitializeData
            ObjRomboide.InitializeData(txtLadoB, txtAltura,
                                         txtPerimeter, txtArea,
                                         picCanvas);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Inicializacion de datos y controles - llamada a fun InitializeData
            ObjRomboide.InitializeData(txtLadoB, txtAltura,
                                         txtPerimeter, txtArea,
                                         picCanvas);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
