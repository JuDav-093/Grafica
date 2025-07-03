namespace GraphicsAlgorithmVisualizer.Forms
{
    partial class FrmRDDA
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
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.groupBoxDraw = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.Points = new System.Windows.Forms.ListBox();
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
            this.panel1.Size = new System.Drawing.Size(800, 466);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxPoit
            // 
            this.groupBoxPoit.Controls.Add(this.Points);
            this.groupBoxPoit.Controls.Add(this.lblTotalPoints);
            this.groupBoxPoit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBoxPoit.Location = new System.Drawing.Point(7, 176);
            this.groupBoxPoit.Name = "groupBoxPoit";
            this.groupBoxPoit.Size = new System.Drawing.Size(164, 278);
            this.groupBoxPoit.TabIndex = 8;
            this.groupBoxPoit.TabStop = false;
            this.groupBoxPoit.Text = "Points";
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.AutoSize = true;
            this.lblTotalPoints.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPoints.Location = new System.Drawing.Point(6, 254);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(72, 20);
            this.lblTotalPoints.TabIndex = 13;
            this.lblTotalPoints.Text = "Total: ";
            this.lblTotalPoints.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Pink;
            this.btnClear.Location = new System.Drawing.Point(97, 125);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 38);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.label4);
            this.groupBoxInput.Controls.Add(this.label3);
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Controls.Add(this.label1);
            this.groupBoxInput.Controls.Add(this.txtY2);
            this.groupBoxInput.Controls.Add(this.txtX1);
            this.groupBoxInput.Controls.Add(this.txtX2);
            this.groupBoxInput.Controls.Add(this.txtY1);
            this.groupBoxInput.ForeColor = System.Drawing.Color.Pink;
            this.groupBoxInput.Location = new System.Drawing.Point(7, 7);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(164, 100);
            this.groupBoxInput.TabIndex = 6;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Inputs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "y2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "(x2:,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "y1)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "(x1,";
            // 
            // txtY2
            // 
            this.txtY2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtY2.ForeColor = System.Drawing.Color.Magenta;
            this.txtY2.Location = new System.Drawing.Point(115, 61);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(32, 22);
            this.txtY2.TabIndex = 10;
            // 
            // txtX1
            // 
            this.txtX1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtX1.ForeColor = System.Drawing.Color.Magenta;
            this.txtX1.Location = new System.Drawing.Point(77, 28);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(32, 22);
            this.txtX1.TabIndex = 7;
            // 
            // txtX2
            // 
            this.txtX2.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtX2.ForeColor = System.Drawing.Color.Magenta;
            this.txtX2.Location = new System.Drawing.Point(77, 61);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(32, 22);
            this.txtX2.TabIndex = 9;
            // 
            // txtY1
            // 
            this.txtY1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtY1.ForeColor = System.Drawing.Color.Magenta;
            this.txtY1.Location = new System.Drawing.Point(117, 28);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(32, 22);
            this.txtY1.TabIndex = 8;
            // 
            // groupBoxDraw
            // 
            this.groupBoxDraw.Controls.Add(this.picCanvas);
            this.groupBoxDraw.ForeColor = System.Drawing.Color.Pink;
            this.groupBoxDraw.Location = new System.Drawing.Point(180, 7);
            this.groupBoxDraw.Name = "groupBoxDraw";
            this.groupBoxDraw.Size = new System.Drawing.Size(516, 447);
            this.groupBoxDraw.TabIndex = 1;
            this.groupBoxDraw.TabStop = false;
            this.groupBoxDraw.Text = "Graphic";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(12, 21);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(491, 399);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // btnDraw
            // 
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.ForeColor = System.Drawing.Color.Pink;
            this.btnDraw.Location = new System.Drawing.Point(7, 125);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(74, 38);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Points
            // 
            this.Points.BackColor = System.Drawing.Color.Black;
            this.Points.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Points.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points.ForeColor = System.Drawing.Color.Pink;
            this.Points.FormattingEnabled = true;
            this.Points.ItemHeight = 22;
            this.Points.Location = new System.Drawing.Point(12, 31);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(135, 220);
            this.Points.TabIndex = 13;
            // 
            // FrmRDDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRDDA";
            this.Text = "FrmRDDA";
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
        private System.Windows.Forms.GroupBox groupBoxPoit;
        private System.Windows.Forms.Label lblTotalPoints;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.GroupBox groupBoxDraw;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.ListBox Points;
    }
}