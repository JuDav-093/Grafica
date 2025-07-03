namespace GraphicsAlgorithmVisualizer.Forms
{
    partial class FrmSutherlandH
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
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnPintar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
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
            this.label5.Location = new System.Drawing.Point(113, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(473, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Con el mouse forme un polígono de mínimo 3 vértices";
            // 
            // btnCortar
            // 
            this.btnCortar.BackColor = System.Drawing.Color.Pink;
            this.btnCortar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCortar.ForeColor = System.Drawing.Color.Black;
            this.btnCortar.Location = new System.Drawing.Point(23, 198);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(90, 50);
            this.btnCortar.TabIndex = 15;
            this.btnCortar.Text = "Cortar";
            this.btnCortar.UseVisualStyleBackColor = false;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.BackColor = System.Drawing.Color.Pink;
            this.btnResetear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetear.ForeColor = System.Drawing.Color.Black;
            this.btnResetear.Location = new System.Drawing.Point(128, 198);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(90, 50);
            this.btnResetear.TabIndex = 14;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = false;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnPintar
            // 
            this.btnPintar.BackColor = System.Drawing.Color.Pink;
            this.btnPintar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPintar.ForeColor = System.Drawing.Color.Black;
            this.btnPintar.Location = new System.Drawing.Point(73, 281);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(90, 50);
            this.btnPintar.TabIndex = 13;
            this.btnPintar.Text = "Pintar";
            this.btnPintar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtY0);
            this.groupBox1.Controls.Add(this.txtX0);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Pink;
            this.groupBox1.Location = new System.Drawing.Point(65, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 112);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Último punto";
            // 
            // txtY0
            // 
            this.txtY0.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtY0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY0.ForeColor = System.Drawing.SystemColors.Info;
            this.txtY0.Location = new System.Drawing.Point(51, 60);
            this.txtY0.Name = "txtY0";
            this.txtY0.Size = new System.Drawing.Size(48, 22);
            this.txtY0.TabIndex = 2;
            // 
            // txtX0
            // 
            this.txtX0.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX0.ForeColor = System.Drawing.SystemColors.Info;
            this.txtX0.Location = new System.Drawing.Point(51, 29);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(48, 24);
            this.txtX0.TabIndex = 1;
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
            this.groupBox3.Location = new System.Drawing.Point(268, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 380);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.Location = new System.Drawing.Point(22, 21);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(375, 338);
            this.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // FrmSutherlandH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCortar);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnPintar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmSutherlandH";
            this.Text = "FrmSutherlandH";
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
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnPintar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}