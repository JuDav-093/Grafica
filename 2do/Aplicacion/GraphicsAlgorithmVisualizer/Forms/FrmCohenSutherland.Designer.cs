namespace GraphicsAlgorithmVisualizer.Forms
{
    partial class FrmCohenSutherland
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnCortar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnResetear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Pink;
            this.label5.Location = new System.Drawing.Point(97, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(477, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Seleccione los puntos de la línea con el click del mouse";
            // 
            // btnCortar
            // 
            this.btnCortar.BackColor = System.Drawing.Color.Pink;
            this.btnCortar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCortar.ForeColor = System.Drawing.Color.Black;
            this.btnCortar.Location = new System.Drawing.Point(21, 221);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(101, 50);
            this.btnCortar.TabIndex = 14;
            this.btnCortar.Text = "Cortar";
            this.btnCortar.UseVisualStyleBackColor = false;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.txtY1);
            this.groupBox1.Controls.Add(this.txtY0);
            this.groupBox1.Controls.Add(this.txtX1);
            this.groupBox1.Controls.Add(this.txtX0);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Pink;
            this.groupBox1.Location = new System.Drawing.Point(21, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 112);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "puntos de líneas";
            // 
            // txtY1
            // 
            this.txtY1.BackColor = System.Drawing.Color.Black;
            this.txtY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY1.ForeColor = System.Drawing.Color.Pink;
            this.txtY1.Location = new System.Drawing.Point(143, 61);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(47, 24);
            this.txtY1.TabIndex = 4;
            // 
            // txtY0
            // 
            this.txtY0.BackColor = System.Drawing.Color.Black;
            this.txtY0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY0.ForeColor = System.Drawing.Color.Pink;
            this.txtY0.Location = new System.Drawing.Point(53, 60);
            this.txtY0.Name = "txtY0";
            this.txtY0.Size = new System.Drawing.Size(50, 22);
            this.txtY0.TabIndex = 2;
            // 
            // txtX1
            // 
            this.txtX1.BackColor = System.Drawing.Color.Black;
            this.txtX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX1.ForeColor = System.Drawing.Color.Pink;
            this.txtX1.Location = new System.Drawing.Point(143, 30);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(47, 22);
            this.txtX1.TabIndex = 3;
            // 
            // txtX0
            // 
            this.txtX0.BackColor = System.Drawing.Color.Black;
            this.txtX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX0.ForeColor = System.Drawing.Color.Pink;
            this.txtX0.Location = new System.Drawing.Point(53, 29);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(50, 24);
            this.txtX0.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Y1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y0 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "X1 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "X0 :";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.picCanvas);
            this.groupBox3.ForeColor = System.Drawing.Color.Pink;
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox3.Location = new System.Drawing.Point(273, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 355);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.Location = new System.Drawing.Point(22, 21);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(336, 312);
            this.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // btnResetear
            // 
            this.btnResetear.BackColor = System.Drawing.Color.Pink;
            this.btnResetear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetear.ForeColor = System.Drawing.Color.Black;
            this.btnResetear.Location = new System.Drawing.Point(133, 221);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(116, 50);
            this.btnResetear.TabIndex = 12;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = false;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // FrmCohenSutherland
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCortar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnResetear);
            this.Name = "FrmCohenSutherland";
            this.Text = "FrmCohenSutherland";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCortar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnResetear;
    }
}