namespace Figuras1
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuadrangulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romboToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.romboideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapecioisóscelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapecioisóscelesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trapezoideToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deltoideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ovaloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triánguloIrregToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poligonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentagonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexagonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heptágonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.octágonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eneágonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decagonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentogoscolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuadrangulosToolStripMenuItem,
            this.circularToolStripMenuItem,
            this.triangularToolStripMenuItem,
            this.poligonosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuadrangulosToolStripMenuItem
            // 
            this.cuadrangulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectanguloToolStripMenuItem,
            this.cuadradoToolStripMenuItem,
            this.romboToolStripMenuItem,
            this.trapecioToolStripMenuItem,
            this.deltoideToolStripMenuItem});
            this.cuadrangulosToolStripMenuItem.Name = "cuadrangulosToolStripMenuItem";
            this.cuadrangulosToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.cuadrangulosToolStripMenuItem.Text = "Cuadrangulos";
            this.cuadrangulosToolStripMenuItem.Click += new System.EventHandler(this.cuadrangulosToolStripMenuItem_Click);
            // 
            // rectanguloToolStripMenuItem
            // 
            this.rectanguloToolStripMenuItem.Name = "rectanguloToolStripMenuItem";
            this.rectanguloToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.rectanguloToolStripMenuItem.Text = "Rectángulo";
            this.rectanguloToolStripMenuItem.Click += new System.EventHandler(this.rectanguloToolStripMenuItem_Click);
            // 
            // cuadradoToolStripMenuItem
            // 
            this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
            this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.cuadradoToolStripMenuItem.Text = "Cuadrado";
            this.cuadradoToolStripMenuItem.Click += new System.EventHandler(this.cuadradoToolStripMenuItem_Click);
            // 
            // romboToolStripMenuItem
            // 
            this.romboToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.romboToolStripMenuItem1,
            this.romboideToolStripMenuItem});
            this.romboToolStripMenuItem.Name = "romboToolStripMenuItem";
            this.romboToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.romboToolStripMenuItem.Text = "Rombo";
            // 
            // romboToolStripMenuItem1
            // 
            this.romboToolStripMenuItem1.Name = "romboToolStripMenuItem1";
            this.romboToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.romboToolStripMenuItem1.Text = "Rombo";
            this.romboToolStripMenuItem1.Click += new System.EventHandler(this.romboToolStripMenuItem1_Click);
            // 
            // romboideToolStripMenuItem
            // 
            this.romboideToolStripMenuItem.Name = "romboideToolStripMenuItem";
            this.romboideToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.romboideToolStripMenuItem.Text = "Romboide";
            // 
            // trapecioToolStripMenuItem
            // 
            this.trapecioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trapecioisóscelesToolStripMenuItem,
            this.trapecioisóscelesToolStripMenuItem1,
            this.trapezoideToolStripMenuItem1});
            this.trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem";
            this.trapecioToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.trapecioToolStripMenuItem.Text = "Trapecio";
            // 
            // trapecioisóscelesToolStripMenuItem
            // 
            this.trapecioisóscelesToolStripMenuItem.Name = "trapecioisóscelesToolStripMenuItem";
            this.trapecioisóscelesToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.trapecioisóscelesToolStripMenuItem.Text = "Trapecio ";
            // 
            // trapecioisóscelesToolStripMenuItem1
            // 
            this.trapecioisóscelesToolStripMenuItem1.Name = "trapecioisóscelesToolStripMenuItem1";
            this.trapecioisóscelesToolStripMenuItem1.Size = new System.Drawing.Size(221, 26);
            this.trapecioisóscelesToolStripMenuItem1.Text = "Trapecio (isósceles)";
            // 
            // trapezoideToolStripMenuItem1
            // 
            this.trapezoideToolStripMenuItem1.Name = "trapezoideToolStripMenuItem1";
            this.trapezoideToolStripMenuItem1.Size = new System.Drawing.Size(221, 26);
            this.trapezoideToolStripMenuItem1.Text = "Trapezoide";
            // 
            // deltoideToolStripMenuItem
            // 
            this.deltoideToolStripMenuItem.Name = "deltoideToolStripMenuItem";
            this.deltoideToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.deltoideToolStripMenuItem.Text = "Deltoide";
            // 
            // circularToolStripMenuItem
            // 
            this.circularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circuloToolStripMenuItem,
            this.elipseToolStripMenuItem,
            this.ovaloToolStripMenuItem});
            this.circularToolStripMenuItem.Name = "circularToolStripMenuItem";
            this.circularToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.circularToolStripMenuItem.Text = "Circular";
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.circuloToolStripMenuItem.Text = "Circulo";
            this.circuloToolStripMenuItem.Click += new System.EventHandler(this.circuloToolStripMenuItem_Click);
            // 
            // elipseToolStripMenuItem
            // 
            this.elipseToolStripMenuItem.Name = "elipseToolStripMenuItem";
            this.elipseToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.elipseToolStripMenuItem.Text = "Elipse";
            this.elipseToolStripMenuItem.Click += new System.EventHandler(this.elipseToolStripMenuItem_Click);
            // 
            // ovaloToolStripMenuItem
            // 
            this.ovaloToolStripMenuItem.Name = "ovaloToolStripMenuItem";
            this.ovaloToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.ovaloToolStripMenuItem.Text = "Ovalo";
            this.ovaloToolStripMenuItem.Click += new System.EventHandler(this.ovaloToolStripMenuItem_Click);
            // 
            // triangularToolStripMenuItem
            // 
            this.triangularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trianguloToolStripMenuItem,
            this.triánguloIrregToolStripMenuItem});
            this.triangularToolStripMenuItem.Name = "triangularToolStripMenuItem";
            this.triangularToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.triangularToolStripMenuItem.Text = "Triangular";
            // 
            // trianguloToolStripMenuItem
            // 
            this.trianguloToolStripMenuItem.Name = "trianguloToolStripMenuItem";
            this.trianguloToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.trianguloToolStripMenuItem.Text = "Triángulo";
            this.trianguloToolStripMenuItem.Click += new System.EventHandler(this.trianguloToolStripMenuItem_Click_1);
            // 
            // triánguloIrregToolStripMenuItem
            // 
            this.triánguloIrregToolStripMenuItem.Name = "triánguloIrregToolStripMenuItem";
            this.triánguloIrregToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.triánguloIrregToolStripMenuItem.Text = "Triángulo Irreg";
            this.triánguloIrregToolStripMenuItem.Click += new System.EventHandler(this.triánguloIrregToolStripMenuItem_Click);
            // 
            // poligonosToolStripMenuItem
            // 
            this.poligonosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.poligonosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pentagonoToolStripMenuItem,
            this.hexagonoToolStripMenuItem,
            this.heptágonoToolStripMenuItem,
            this.octágonoToolStripMenuItem,
            this.eneágonoToolStripMenuItem,
            this.decagonToolStripMenuItem,
            this.pentogoscolorToolStripMenuItem});
            this.poligonosToolStripMenuItem.Name = "poligonosToolStripMenuItem";
            this.poligonosToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.poligonosToolStripMenuItem.Text = "Polígonos (5 o +)";
            // 
            // pentagonoToolStripMenuItem
            // 
            this.pentagonoToolStripMenuItem.Name = "pentagonoToolStripMenuItem";
            this.pentagonoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pentagonoToolStripMenuItem.Text = "Pentágono";
            this.pentagonoToolStripMenuItem.Click += new System.EventHandler(this.pentagonoToolStripMenuItem_Click);
            // 
            // hexagonoToolStripMenuItem
            // 
            this.hexagonoToolStripMenuItem.Name = "hexagonoToolStripMenuItem";
            this.hexagonoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hexagonoToolStripMenuItem.Text = "Hexágono";
            this.hexagonoToolStripMenuItem.Click += new System.EventHandler(this.hexagonoToolStripMenuItem_Click);
            // 
            // heptágonoToolStripMenuItem
            // 
            this.heptágonoToolStripMenuItem.Name = "heptágonoToolStripMenuItem";
            this.heptágonoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.heptágonoToolStripMenuItem.Text = "Heptágono";
            this.heptágonoToolStripMenuItem.Click += new System.EventHandler(this.heptágonoToolStripMenuItem_Click);
            // 
            // octágonoToolStripMenuItem
            // 
            this.octágonoToolStripMenuItem.Name = "octágonoToolStripMenuItem";
            this.octágonoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.octágonoToolStripMenuItem.Text = "Octágono";
            this.octágonoToolStripMenuItem.Click += new System.EventHandler(this.octágonoToolStripMenuItem_Click);
            // 
            // eneágonoToolStripMenuItem
            // 
            this.eneágonoToolStripMenuItem.Name = "eneágonoToolStripMenuItem";
            this.eneágonoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eneágonoToolStripMenuItem.Text = "Eneágono";
            this.eneágonoToolStripMenuItem.Click += new System.EventHandler(this.eneágonoToolStripMenuItem_Click);
            // 
            // decagonToolStripMenuItem
            // 
            this.decagonToolStripMenuItem.Name = "decagonToolStripMenuItem";
            this.decagonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.decagonToolStripMenuItem.Text = "Decágono";
            this.decagonToolStripMenuItem.Click += new System.EventHandler(this.decagonToolStripMenuItem_Click);
            // 
            // pentogoscolorToolStripMenuItem
            // 
            this.pentogoscolorToolStripMenuItem.Name = "pentogoscolorToolStripMenuItem";
            this.pentogoscolorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pentogoscolorToolStripMenuItem.Text = "pentogos/color";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(862, 583);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.RosyBrown;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuadrangulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectanguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ovaloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trianguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poligonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romboToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem romboideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapecioisóscelesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapecioisóscelesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trapezoideToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deltoideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pentagonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexagonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heptágonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem octágonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eneágonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decagonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triánguloIrregToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pentogoscolorToolStripMenuItem;
    }
}