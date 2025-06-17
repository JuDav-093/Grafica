using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlgorithmBasic
{
    public partial class FrmIndex : Form
    {
        //presentación y Bienvenida
        private string textWelcome = "Implementación de Algoritmos Gráficos Básicos";
        private string textName = "by Davila Anabel";
        private int indexName = 0;
                
        private Timer timerName;

        public FrmIndex()
        {
            this.Load += FrmIndex_Load;
            InitializeComponent();
            SetFontRecursive(this, new Font("Consolas", 11F));
        }

        private void SetFontRecursive(Control control, Font font)
        {
            control.Font = font;
            control.ForeColor = Color.SkyBlue;
            control.BackColor = Color.Black;

            foreach (Control child in control.Controls)
            {
                SetFontRecursive(child, font);
            }
        }

        private void OpenForm(Form formulario)
        {
            panelContenedor.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }        
        private void FrmIndex_Load(object sender, EventArgs e)
        {
            // Configurar y centrar los labels
            lblWelcome.Text = textWelcome; // Mostrar  texto completo
            CenterLabel(lblWelcome, 100);
            lblName.Text = ""; // Se animará con el Timer

            // Configurar el Timer para lblName
            timerName = new Timer();
            timerName.Interval = 100;
            timerName.Tick += TimerName_Tick;
            timerName.Start(); // Se inicia directamente
        }

        private void TimerName_Tick(object sender, EventArgs e)
        {
            if (indexName < textName.Length)
            {
                lblName.Text += textName[indexName++];
                PositionLabelBottomRight(lblName, 100, 250); // 20px de margen inferior y derecho
            }
            else
            {
                timerName.Stop();
            }
        }

        private void PositionLabelBottomRight(Label lbl, int marginRight, int marginBottom)
        {
            lbl.Left = this.ClientSize.Width - lbl.Width - marginRight;
            lbl.Top = this.ClientSize.Height - lbl.Height - marginBottom;
            lbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        }

        private void CenterLabel(Label lbl, int top)
        {
            lbl.Left = (this.ClientSize.Width - lbl.Width) / 2;
            lbl.Top = top;
            lbl.Anchor = AnchorStyles.Top;
        }
               

        private void bresenhamToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAlgorithmBresenham());
            this.Text = "Bresenham Algorithm";
        }

        private void circle1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAlgorithmCircle());
            this.Text = "Circle Algorithm";
        }

        private void dDAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FrmAlgorithmDDA());
            this.Text = "DDA Algorithm";
        }

        private void floodfillToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmFloodFill());
            this.Text = "Flood Fill Algorithm";
        }
    }
}
