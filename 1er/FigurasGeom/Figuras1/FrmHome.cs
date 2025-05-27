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

      

        private void cuadrangulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRomboide romboide = new frmRomboide();
            romboide.MdiParent = this;
            romboide.Show();
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrapezoide trapezoide = new frmTrapezoide();
            trapezoide.MdiParent = this;
            trapezoide.Show();

        }
    }

}
