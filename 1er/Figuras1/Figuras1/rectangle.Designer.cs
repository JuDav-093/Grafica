namespace Figuras1
{
    partial class frmRectangulo
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
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GRbOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grblnputs = new System.Windows.Forms.GroupBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GRbOutputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grblnputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCanvas.Location = new System.Drawing.Point(321, 75);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(473, 341);
            this.grbCanvas.TabIndex = 5;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 291);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GRbOutputs
            // 
            this.GRbOutputs.Controls.Add(this.txtArea);
            this.GRbOutputs.Controls.Add(this.txtPerimeter);
            this.GRbOutputs.Controls.Add(this.lblArea);
            this.GRbOutputs.Controls.Add(this.lblPerimeter);
            this.GRbOutputs.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRbOutputs.Location = new System.Drawing.Point(7, 309);
            this.GRbOutputs.Name = "GRbOutputs";
            this.GRbOutputs.Size = new System.Drawing.Size(311, 107);
            this.GRbOutputs.TabIndex = 4;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Blank";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(125, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 22);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "Blank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Área:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Perímetro:";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbProcess.Location = new System.Drawing.Point(4, 198);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(311, 87);
            this.grbProcess.TabIndex = 3;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Resetear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 30);
            this.button3.TabIndex = 0;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // grblnputs
            // 
            this.grblnputs.Controls.Add(this.txtHeight);
            this.grblnputs.Controls.Add(this.txtWidth);
            this.grblnputs.Controls.Add(this.lblWidth);
            this.grblnputs.Controls.Add(this.lblHeight);
            this.grblnputs.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grblnputs.Location = new System.Drawing.Point(4, 75);
            this.grblnputs.Name = "grblnputs";
            this.grblnputs.Size = new System.Drawing.Size(311, 110);
            this.grblnputs.TabIndex = 2;
            this.grblnputs.TabStop = false;
            this.grblnputs.Text = "Entradas";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(125, 68);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(150, 32);
            this.txtHeight.TabIndex = 3;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(128, 31);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(147, 32);
            this.txtWidth.TabIndex = 2;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(7, 32);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(120, 26);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Ancho (a):";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(8, 66);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(114, 26);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Largo (b):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Blank";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Blank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ancho (a):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Largo (b):";
            // 
            // frmRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.GRbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grblnputs);
            this.Name = "frmRectangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rectangle";
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GRbOutputs.ResumeLayout(false);
            this.GRbOutputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grblnputs.ResumeLayout(false);
            this.grblnputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GRbOutputs;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox grblnputs;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}