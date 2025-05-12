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
    public partial class frmHome : Form
    {
        private static frmHome _instance;
        public frmHome()
        {
            InitializeComponent();
        }

        public static frmHome Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new frmHome();
                }
                return _instance;
            }
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRectangulo rectangulo = new frmRectangulo();
            rectangulo.MdiParent = this;
            rectangulo.Show();
        }

        private void cuadrangulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsquare square = new frmsquare();
            square.MdiParent = this;
            square.Show();
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCircle circle = new frmCircle();
            circle.MdiParent = this;
            circle.Show();
        }

        

        private void trianguloToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmTriangle triangle = new frmTriangle();
            triangle.MdiParent = this;
            triangle.Show();
        }

        private void triánguloIrregToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTriangleIrreg trianguloIrreg = new frmTriangleIrreg();
            trianguloIrreg.MdiParent = this;
            trianguloIrreg.Show();
        }

        private void romboToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRombo rombo = new frmRombo();
            rombo.MdiParent = this;
            rombo.Show();
        }

        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPentagon pentagon = new frmPentagon();
            pentagon.MdiParent = this;
            pentagon.Show();

        }

        private void hexagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHexagon hexagon = new frmHexagon();
            hexagon.MdiParent = this;
            hexagon.Show();

        }

        private void heptágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHeptagon heptagon = new frmHeptagon();
            heptagon.MdiParent = this;
            heptagon.Show();
        }

        private void octágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOctagon octagon = new frmOctagon();
            octagon.MdiParent = this;
            octagon.Show();
        }      

        private void decágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDecagon decagon = new frmDecagon();
            decagon.MdiParent = this;
            decagon.Show();
        }

        private void eneágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnneagon enneagon = new frmEnneagon();
            enneagon.MdiParent = this;
            enneagon.Show();
        }

        private void decagonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDecagon decagon = new frmDecagon();
            decagon.MdiParent = this;
            decagon.Show();
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEllipse elipse = new frmEllipse();
            elipse.MdiParent = this;
            elipse.Show();
        }

        private void ovaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOvalo ovalo = new frmOvalo();
            ovalo.MdiParent = this;
            ovalo.Show();
        }
    }

}
