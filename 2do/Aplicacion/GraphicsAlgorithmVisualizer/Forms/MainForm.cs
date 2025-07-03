using GraphicsAlgorithmVisualizer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsAlgorithmVisualizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBLine_Click(object sender, EventArgs e)
        {
            FrmRBLine frmbline = new FrmRBLine();
            frmbline.TopLevel = false; // Permite que el formulario se anide dentro de otro control
            frmbline.Dock = DockStyle.Fill; // Asegura que el formulario ocupe todo el espacio disponible
            frmbline.FormBorderStyle = FormBorderStyle.None; // Elimina bordes y barra de título
            pictureBox1.Controls.Add(frmbline);
            pictureBox1.Tag = frmbline; // Guarda una referencia al formulario en el Tag del PictureBox
            frmbline.BringToFront(); // Asegura que el formulario esté al frente
            frmbline.Show(); // Muestra el formulario anidado
        }

        private void btnRDDA_Click(object sender, EventArgs e)
        {
            FrmRDDA frmrdda = new FrmRDDA();
            frmrdda.TopLevel = false; // Permite que el formulario se anide dentro de otro control
            frmrdda.Dock = DockStyle.Fill; // Asegura que el formulario ocupe todo el espacio disponible
            frmrdda.FormBorderStyle = FormBorderStyle.None; // Elimina bordes y barra de título
            pictureBox1.Controls.Add(frmrdda);
            pictureBox1.Tag = frmrdda; // Guarda una referencia al formulario en el Tag del PictureBox
            frmrdda.BringToFront(); // Asegura que el formulario esté al frente
            frmrdda.Show(); // Muestra el formulario anidado
        }

        private void btnPmCirc_Click(object sender, EventArgs e)
        {
            FrmMpCircle frmCircle = new FrmMpCircle();
            frmCircle.TopLevel = false; // Permite que el formulario se anide dentro de otro control
            frmCircle.Dock = DockStyle.Fill; // Asegura que el formulario ocupe todo el espacio disponible
            frmCircle.FormBorderStyle = FormBorderStyle.None; // Elimina bordes y barra de título
            pictureBox1.Controls.Add(frmCircle);
            pictureBox1.Tag = frmCircle; // Guarda una referencia al formulario en el Tag del PictureBox
            frmCircle.BringToFront(); // Asegura que el formulario esté al frente
            frmCircle.Show(); // Muestra el formulario anidado
        }

        private void btnBElipses_Click(object sender, EventArgs e)
        {
            FrmRBCirculo frmrbcirculo = new FrmRBCirculo();
            frmrbcirculo.TopLevel = false; // Permite que el formulario se anide dentro de otro control
            frmrbcirculo.Dock = DockStyle.Fill; // Asegura que el formulario ocupe todo el espacio disponible
            frmrbcirculo.FormBorderStyle = FormBorderStyle.None; // Elimina bordes y barra de título
            pictureBox1.Controls.Add(frmrbcirculo);
            pictureBox1.Tag = frmrbcirculo; // Guarda una referencia al formulario en el Tag del PictureBox
            frmrbcirculo.BringToFront(); // Asegura que el formulario esté al frente
            frmrbcirculo.Show(); // Muestra el formulario anidado
        }

        private void btnFloodFill_Click(object sender, EventArgs e)
        {
            FrmlFloodFill frmfloodfill = new FrmlFloodFill();
            frmfloodfill.TopLevel = false; // Permite que el formulario se anide dentro de otro control
            frmfloodfill.Dock = DockStyle.Fill; // Asegura que el formulario ocupe todo el espacio disponible
            frmfloodfill.FormBorderStyle = FormBorderStyle.None; // Elimina bordes y barra de título
            pictureBox1.Controls.Add(frmfloodfill);
            pictureBox1.Tag = frmfloodfill; // Guarda una referencia al formulario en el Tag del PictureBox
            frmfloodfill.BringToFront(); // Asegura que el formulario esté al frente
            frmfloodfill.Show(); // Muestra el formulario anidado
        }

        private void btnScanline_Click(object sender, EventArgs e)
        {
            FrmScanline frmscanline = new FrmScanline();
            frmscanline.TopLevel = false; // Permite que el formulario se anide dentro de otro control
            frmscanline.Dock = DockStyle.Fill; // Asegura que el formulario ocupe todo el espacio disponible
            frmscanline.FormBorderStyle = FormBorderStyle.None; // Elimina bordes y barra de título
            pictureBox1.Controls.Add(frmscanline);
            pictureBox1.Tag = frmscanline; // Guarda una referencia al formulario en el Tag del PictureBox
            frmscanline.BringToFront(); // Asegura que el formulario esté al frente
            frmscanline.Show(); // Muestra el formulario anidado
        }

        private void btnClipLine_Click(object sender, EventArgs e)
        {
            FrmCohenSutherland frmcohenS = new FrmCohenSutherland();
            frmcohenS.TopLevel = false; // Permite que el formulario se anide dentro de otro control
            frmcohenS.Dock = DockStyle.Fill; // Asegura que el formulario ocupe todo el espacio disponible
            frmcohenS.FormBorderStyle = FormBorderStyle.None; // Elimina bordes y barra de título
            pictureBox1.Controls.Add(frmcohenS);
            pictureBox1.Tag = frmcohenS; // Guarda una referencia al formulario en el Tag del PictureBox
            frmcohenS.BringToFront(); // Asegura que el formulario esté al frente
            frmcohenS.Show(); // Muestra el formulario anidado
        }

        private void btnClipPoligon_Click(object sender, EventArgs e)
        {
            FrmSutherlandH frmsutherlanh = new FrmSutherlandH();
            frmsutherlanh.TopLevel = false; // Permite que el formulario se anide dentro de otro control
            frmsutherlanh.Dock = DockStyle.Fill; // Asegura que el formulario ocupe todo el espacio disponible
            frmsutherlanh.FormBorderStyle = FormBorderStyle.None; // Elimina bordes y barra de título
            pictureBox1.Controls.Add(frmsutherlanh);
            pictureBox1.Tag = frmsutherlanh; // Guarda una referencia al formulario en el Tag del PictureBox
            frmsutherlanh.BringToFront(); // Asegura que el formulario esté al frente
            frmsutherlanh.Show(); // Muestra el formulario anidado
        }

        private void btnCurvesB_Click(object sender, EventArgs e)
        {
            FrmCurvasBezier frmcurvesb = new FrmCurvasBezier();
            frmcurvesb.TopLevel = false; // Permite que el formulario se anide dentro de otro control
            frmcurvesb.Dock = DockStyle.Fill; // Asegura que el formulario ocupe todo el espacio disponible
            frmcurvesb.FormBorderStyle = FormBorderStyle.None; // Elimina bordes y barra de título
            pictureBox1.Controls.Add(frmcurvesb);
            pictureBox1.Tag = frmcurvesb; // Guarda una referencia al formulario en el Tag del PictureBox
            frmcurvesb.BringToFront(); // Asegura que el formulario esté al frente
            frmcurvesb.Show(); // Muestra el formulario anidado
        }

        private void btnBSpline_Click(object sender, EventArgs e)
        {
            FrmBSpline frmbspline = new FrmBSpline();
            frmbspline.TopLevel = false; // Permite que el formulario se anide dentro de otro control
            frmbspline.Dock = DockStyle.Fill; // Asegura que el formulario ocupe todo el espacio disponible
            frmbspline.FormBorderStyle = FormBorderStyle.None; // Elimina bordes y barra de título
            pictureBox1.Controls.Add(frmbspline);
            pictureBox1.Tag = frmbspline; // Guarda una referencia al formulario en el Tag del PictureBox
            frmbspline.BringToFront(); // Asegura que el formulario esté al frente
            frmbspline.Show(); // Muestra el formulario anidado
        }
    }
}
