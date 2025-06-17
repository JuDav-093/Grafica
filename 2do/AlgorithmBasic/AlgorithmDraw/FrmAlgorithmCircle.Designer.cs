namespace AlgorithmBasic
{
    partial class FrmAlgorithmCircle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxPoit = new System.Windows.Forms.GroupBox();
            this.lblTotalPoints = new System.Windows.Forms.Label();
            this.listP = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.groupBoxDraw = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxPoit.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.groupBoxPoit);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.groupBoxInput);
            this.panel1.Controls.Add(this.groupBoxDraw);
            this.panel1.Controls.Add(this.btnDraw);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxPoit
            // 
            this.groupBoxPoit.Controls.Add(this.lblTotalPoints);
            this.groupBoxPoit.Controls.Add(this.listP);
            this.groupBoxPoit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBoxPoit.Location = new System.Drawing.Point(9, 154);
            this.groupBoxPoit.Name = "groupBoxPoit";
            this.groupBoxPoit.Size = new System.Drawing.Size(257, 278);
            this.groupBoxPoit.TabIndex = 12;
            this.groupBoxPoit.TabStop = false;
            this.groupBoxPoit.Text = "Points";
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.AutoSize = true;
            this.lblTotalPoints.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPoints.Location = new System.Drawing.Point(7, 249);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(72, 20);
            this.lblTotalPoints.TabIndex = 15;
            this.lblTotalPoints.Text = "Total: ";
            this.lblTotalPoints.Visible = false;
            // 
            // listP
            // 
            this.listP.BackColor = System.Drawing.Color.Black;
            this.listP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listP.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listP.ForeColor = System.Drawing.Color.DodgerBlue;
            this.listP.FormattingEnabled = true;
            this.listP.ItemHeight = 22;
            this.listP.Location = new System.Drawing.Point(9, 20);
            this.listP.Name = "listP";
            this.listP.Size = new System.Drawing.Size(225, 220);
            this.listP.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClear.Location = new System.Drawing.Point(139, 96);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 38);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.label1);
            this.groupBoxInput.Controls.Add(this.txtRadius);
            this.groupBoxInput.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBoxInput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(220, 78);
            this.groupBoxInput.TabIndex = 10;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Inputs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Radius:";
            // 
            // txtRadius
            // 
            this.txtRadius.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtRadius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRadius.ForeColor = System.Drawing.Color.Lime;
            this.txtRadius.Location = new System.Drawing.Point(100, 40);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 7;
            // 
            // groupBoxDraw
            // 
            this.groupBoxDraw.Controls.Add(this.picCanvas);
            this.groupBoxDraw.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBoxDraw.Location = new System.Drawing.Point(272, 12);
            this.groupBoxDraw.Name = "groupBoxDraw";
            this.groupBoxDraw.Size = new System.Drawing.Size(516, 426);
            this.groupBoxDraw.TabIndex = 9;
            this.groupBoxDraw.TabStop = false;
            this.groupBoxDraw.Text = "Graphic";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(19, 21);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(491, 399);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDraw.Location = new System.Drawing.Point(12, 96);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(93, 38);
            this.btnDraw.TabIndex = 8;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // FrmAlgorithmCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAlgorithmCircle";
            this.Text = "Circle";
            this.panel1.ResumeLayout(false);
            this.groupBoxPoit.ResumeLayout(false);
            this.groupBoxPoit.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxDraw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.GroupBox groupBoxDraw;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.GroupBox groupBoxPoit;
        private System.Windows.Forms.Label lblTotalPoints;
        private System.Windows.Forms.ListBox listP;
    }
}