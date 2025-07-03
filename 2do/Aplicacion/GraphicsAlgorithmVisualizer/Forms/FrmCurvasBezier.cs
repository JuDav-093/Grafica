using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsAlgorithmVisualizer.Forms
{
    public partial class FrmCurvasBezier : Form
    {
        public FrmCurvasBezier()
        {
            InitializeComponent();
        }

        private void bezierLinealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCBLineal frmcblineal = new FrmCBLineal();
            frmcblineal.TopLevel = false; // Permite que el formulario se anide dentro de otro control
            frmcblineal.Dock = DockStyle.Fill; // Asegura que el formulario ocupe todo el espacio disponible
            frmcblineal.FormBorderStyle = FormBorderStyle.None; // Elimina bordes y barra de título
            pictureBox1.Controls.Add(frmcblineal);
            pictureBox1.Tag = frmcblineal; // Guarda una referencia al formulario en el Tag del PictureBox
            frmcblineal.BringToFront(); // Asegura que el formulario esté al frente
            frmcblineal.Show(); // Muestra el formulario anidado
        }

        private void bezier2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCB1p frmcb1p = new FrmCB1p();
            frmcb1p.TopLevel = false; // Permite que el formulario se anide dentro de otro control
            frmcb1p.Dock = DockStyle.Fill; // Asegura que el formulario ocupe todo el espacio disponible
            frmcb1p.FormBorderStyle = FormBorderStyle.None; // Elimina bordes y barra de título
            pictureBox1.Controls.Add(frmcb1p);
            pictureBox1.Tag = frmcb1p; // Guarda una referencia al formulario en el Tag del PictureBox
            frmcb1p.BringToFront(); // Asegura que el formulario esté al frente
            frmcb1p.Show(); // Muestra el formulario anidado
        }

        private void bezier3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCB2p frmcb2p = new FrmCB2p();
            frmcb2p.TopLevel = false; // Permite que el formulario se anide dentro de otro control
            frmcb2p.Dock = DockStyle.Fill; // Asegura que el formulario ocupe todo el espacio disponible
            frmcb2p.FormBorderStyle = FormBorderStyle.None; // Elimina bordes y barra de título
            pictureBox1.Controls.Add(frmcb2p);
            pictureBox1.Tag = frmcb2p; // Guarda una referencia al formulario en el Tag del PictureBox
            frmcb2p.BringToFront(); // Asegura que el formulario esté al frente
            frmcb2p.Show(); // Muestra el formulario anidado
        }
    }
}
