namespace GraphicsAlgorithmVisualizer
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpRenderization = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBSpline = new System.Windows.Forms.Button();
            this.btnCurvesB = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClipPoligon = new System.Windows.Forms.Button();
            this.btnClipLine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnScanline = new System.Windows.Forms.Button();
            this.btnFloodFill = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBElipses = new System.Windows.Forms.Button();
            this.btnPmCirc = new System.Windows.Forms.Button();
            this.btnBLine = new System.Windows.Forms.Button();
            this.btnRDDA = new System.Windows.Forms.Button();
            this.lblInformation2 = new System.Windows.Forms.Label();
            this.lblInformation1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpRenderization.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRenderization
            // 
            this.grpRenderization.Controls.Add(this.groupBox4);
            this.grpRenderization.Controls.Add(this.groupBox3);
            this.grpRenderization.Controls.Add(this.groupBox1);
            this.grpRenderization.Controls.Add(this.groupBox2);
            this.grpRenderization.Controls.Add(this.lblInformation2);
            this.grpRenderization.Location = new System.Drawing.Point(1, 0);
            this.grpRenderization.Name = "grpRenderization";
            this.grpRenderization.Size = new System.Drawing.Size(282, 549);
            this.grpRenderization.TabIndex = 0;
            this.grpRenderization.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBSpline);
            this.groupBox4.Controls.Add(this.btnCurvesB);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(21, 425);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 99);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Curvas P";
            // 
            // btnBSpline
            // 
            this.btnBSpline.BackColor = System.Drawing.Color.Black;
            this.btnBSpline.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnBSpline.Location = new System.Drawing.Point(32, 61);
            this.btnBSpline.Name = "btnBSpline";
            this.btnBSpline.Size = new System.Drawing.Size(160, 30);
            this.btnBSpline.TabIndex = 4;
            this.btnBSpline.Text = "B-splines ";
            this.btnBSpline.UseVisualStyleBackColor = false;
            this.btnBSpline.Click += new System.EventHandler(this.btnBSpline_Click);
            // 
            // btnCurvesB
            // 
            this.btnCurvesB.BackColor = System.Drawing.Color.Black;
            this.btnCurvesB.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnCurvesB.Location = new System.Drawing.Point(32, 25);
            this.btnCurvesB.Name = "btnCurvesB";
            this.btnCurvesB.Size = new System.Drawing.Size(160, 30);
            this.btnCurvesB.TabIndex = 3;
            this.btnCurvesB.Text = "Curvas de Bézier";
            this.btnCurvesB.UseVisualStyleBackColor = false;
            this.btnCurvesB.Click += new System.EventHandler(this.btnCurvesB_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClipPoligon);
            this.groupBox3.Controls.Add(this.btnClipLine);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(22, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 92);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recorte";
            // 
            // btnClipPoligon
            // 
            this.btnClipPoligon.BackColor = System.Drawing.Color.Black;
            this.btnClipPoligon.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnClipPoligon.Location = new System.Drawing.Point(32, 56);
            this.btnClipPoligon.Name = "btnClipPoligon";
            this.btnClipPoligon.Size = new System.Drawing.Size(160, 29);
            this.btnClipPoligon.TabIndex = 3;
            this.btnClipPoligon.Text = "Recorte de Polígonos";
            this.btnClipPoligon.UseVisualStyleBackColor = false;
            this.btnClipPoligon.Click += new System.EventHandler(this.btnClipPoligon_Click);
            // 
            // btnClipLine
            // 
            this.btnClipLine.BackColor = System.Drawing.Color.Black;
            this.btnClipLine.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnClipLine.Location = new System.Drawing.Point(31, 21);
            this.btnClipLine.Name = "btnClipLine";
            this.btnClipLine.Size = new System.Drawing.Size(160, 29);
            this.btnClipLine.TabIndex = 2;
            this.btnClipLine.Text = "Recorte de Líneas";
            this.btnClipLine.UseVisualStyleBackColor = false;
            this.btnClipLine.Click += new System.EventHandler(this.btnClipLine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnScanline);
            this.groupBox1.Controls.Add(this.btnFloodFill);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(23, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 89);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relleno";
            // 
            // btnScanline
            // 
            this.btnScanline.BackColor = System.Drawing.Color.Black;
            this.btnScanline.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnScanline.Location = new System.Drawing.Point(31, 56);
            this.btnScanline.Name = "btnScanline";
            this.btnScanline.Size = new System.Drawing.Size(160, 26);
            this.btnScanline.TabIndex = 2;
            this.btnScanline.Text = "Scanline";
            this.btnScanline.UseVisualStyleBackColor = false;
            this.btnScanline.Click += new System.EventHandler(this.btnScanline_Click);
            // 
            // btnFloodFill
            // 
            this.btnFloodFill.BackColor = System.Drawing.Color.Black;
            this.btnFloodFill.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnFloodFill.Location = new System.Drawing.Point(30, 21);
            this.btnFloodFill.Name = "btnFloodFill";
            this.btnFloodFill.Size = new System.Drawing.Size(160, 29);
            this.btnFloodFill.TabIndex = 1;
            this.btnFloodFill.Text = "Flood Fill";
            this.btnFloodFill.UseVisualStyleBackColor = false;
            this.btnFloodFill.Click += new System.EventHandler(this.btnFloodFill_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBElipses);
            this.groupBox2.Controls.Add(this.btnPmCirc);
            this.groupBox2.Controls.Add(this.btnBLine);
            this.groupBox2.Controls.Add(this.btnRDDA);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(23, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 170);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renderización";
            // 
            // btnBElipses
            // 
            this.btnBElipses.BackColor = System.Drawing.Color.Black;
            this.btnBElipses.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnBElipses.Location = new System.Drawing.Point(30, 129);
            this.btnBElipses.Name = "btnBElipses";
            this.btnBElipses.Size = new System.Drawing.Size(160, 30);
            this.btnBElipses.TabIndex = 3;
            this.btnBElipses.Text = "Bresenham Elipses";
            this.btnBElipses.UseVisualStyleBackColor = false;
            this.btnBElipses.Click += new System.EventHandler(this.btnBElipses_Click);
            // 
            // btnPmCirc
            // 
            this.btnPmCirc.BackColor = System.Drawing.Color.Black;
            this.btnPmCirc.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnPmCirc.Location = new System.Drawing.Point(30, 93);
            this.btnPmCirc.Name = "btnPmCirc";
            this.btnPmCirc.Size = new System.Drawing.Size(160, 30);
            this.btnPmCirc.TabIndex = 2;
            this.btnPmCirc.Text = "Punto Medio Circunf";
            this.btnPmCirc.UseVisualStyleBackColor = false;
            this.btnPmCirc.Click += new System.EventHandler(this.btnPmCirc_Click);
            // 
            // btnBLine
            // 
            this.btnBLine.BackColor = System.Drawing.Color.Black;
            this.btnBLine.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnBLine.Location = new System.Drawing.Point(29, 57);
            this.btnBLine.Name = "btnBLine";
            this.btnBLine.Size = new System.Drawing.Size(160, 30);
            this.btnBLine.TabIndex = 1;
            this.btnBLine.Text = " Bresenham Líneas";
            this.btnBLine.UseVisualStyleBackColor = false;
            this.btnBLine.Click += new System.EventHandler(this.btnBLine_Click);
            // 
            // btnRDDA
            // 
            this.btnRDDA.BackColor = System.Drawing.Color.Black;
            this.btnRDDA.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnRDDA.Location = new System.Drawing.Point(30, 21);
            this.btnRDDA.Name = "btnRDDA";
            this.btnRDDA.Size = new System.Drawing.Size(160, 30);
            this.btnRDDA.TabIndex = 0;
            this.btnRDDA.Text = "DDA Línea";
            this.btnRDDA.UseVisualStyleBackColor = false;
            this.btnRDDA.Click += new System.EventHandler(this.btnRDDA_Click);
            // 
            // lblInformation2
            // 
            this.lblInformation2.AllowDrop = true;
            this.lblInformation2.AutoSize = true;
            this.lblInformation2.BackColor = System.Drawing.Color.Black;
            this.lblInformation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation2.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblInformation2.Location = new System.Drawing.Point(23, 12);
            this.lblInformation2.Name = "lblInformation2";
            this.lblInformation2.Size = new System.Drawing.Size(226, 18);
            this.lblInformation2.TabIndex = 4;
            this.lblInformation2.Text = "Que te gustaría graficar hoy?";
            // 
            // lblInformation1
            // 
            this.lblInformation1.AutoSize = true;
            this.lblInformation1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblInformation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation1.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblInformation1.Location = new System.Drawing.Point(471, 6);
            this.lblInformation1.Name = "lblInformation1";
            this.lblInformation1.Size = new System.Drawing.Size(313, 20);
            this.lblInformation1.TabIndex = 5;
            this.lblInformation1.Text = "Visualizador de Algoritmos Gráficos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(297, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(717, 508);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1045, 558);
            this.Controls.Add(this.lblInformation1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpRenderization);
            this.Name = "MainForm";
            this.Text = "Computación Gráfica";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpRenderization.ResumeLayout(false);
            this.grpRenderization.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRenderization;
        private System.Windows.Forms.Button btnCurvesB;
        private System.Windows.Forms.Button btnClipLine;
        private System.Windows.Forms.Button btnFloodFill;
        private System.Windows.Forms.Button btnRDDA;
        private System.Windows.Forms.Label lblInformation2;
        private System.Windows.Forms.Label lblInformation1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBElipses;
        private System.Windows.Forms.Button btnPmCirc;
        private System.Windows.Forms.Button btnBLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnScanline;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBSpline;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClipPoligon;
    }
}

