namespace Figuras1
{
    partial class frmRombo
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
            this.grblnputs = new System.Windows.Forms.GroupBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblDiagonal = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.GRbOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grblnputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.GRbOutputs.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // grblnputs
            // 
            this.grblnputs.Controls.Add(this.txtAltura);
            this.grblnputs.Controls.Add(this.lblDiagonal);
            this.grblnputs.Controls.Add(this.txtLado);
            this.grblnputs.Controls.Add(this.lblLado);
            this.grblnputs.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grblnputs.Location = new System.Drawing.Point(2, 35);
            this.grblnputs.Name = "grblnputs";
            this.grblnputs.Size = new System.Drawing.Size(311, 148);
            this.grblnputs.TabIndex = 3;
            this.grblnputs.TabStop = false;
            this.grblnputs.Text = "Entradas";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(128, 81);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(150, 32);
            this.txtAltura.TabIndex = 5;
            // 
            // lblDiagonal
            // 
            this.lblDiagonal.AutoSize = true;
            this.lblDiagonal.Location = new System.Drawing.Point(6, 84);
            this.lblDiagonal.Name = "lblDiagonal";
            this.lblDiagonal.Size = new System.Drawing.Size(109, 26);
            this.lblDiagonal.TabIndex = 4;
            this.lblDiagonal.Text = "Diagonal:";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(128, 37);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(147, 32);
            this.txtLado.TabIndex = 2;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(10, 43);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(75, 26);
            this.lblLado.TabIndex = 0;
            this.lblLado.Text = "Lado :";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbProcess.Location = new System.Drawing.Point(2, 189);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(311, 87);
            this.grbProcess.TabIndex = 4;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(231, 42);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(109, 41);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 30);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(3, 41);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 30);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // GRbOutputs
            // 
            this.GRbOutputs.Controls.Add(this.txtArea);
            this.GRbOutputs.Controls.Add(this.txtPerimeter);
            this.GRbOutputs.Controls.Add(this.lblArea);
            this.GRbOutputs.Controls.Add(this.lblPerimeter);
            this.GRbOutputs.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRbOutputs.Location = new System.Drawing.Point(2, 282);
            this.GRbOutputs.Name = "GRbOutputs";
            this.GRbOutputs.Size = new System.Drawing.Size(311, 107);
            this.GRbOutputs.TabIndex = 5;
            this.GRbOutputs.TabStop = false;
            this.GRbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(125, 65);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(150, 32);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(125, 30);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(150, 32);
            this.txtPerimeter.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(7, 68);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(68, 26);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Área:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(6, 36);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(120, 26);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perímetro:";
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCanvas.Location = new System.Drawing.Point(330, 35);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(473, 341);
            this.grbCanvas.TabIndex = 6;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(7, 35);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(460, 291);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // frmRombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.GRbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grblnputs);
            this.Name = "frmRombo";
            this.Text = "Rombo";
            this.Load += new System.EventHandler(this.frmRombo_Load);
            this.grblnputs.ResumeLayout(false);
            this.grblnputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.GRbOutputs.ResumeLayout(false);
            this.GRbOutputs.PerformLayout();
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grblnputs;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox GRbOutputs;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblDiagonal;
        private System.Windows.Forms.TextBox txtAltura;
    }
}