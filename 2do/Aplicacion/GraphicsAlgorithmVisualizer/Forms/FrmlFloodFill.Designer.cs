namespace GraphicsAlgorithmVisualizer.Forms
{
    partial class FrmlFloodFill
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPaint = new System.Windows.Forms.Button();
            this.groupBoxPoints = new System.Windows.Forms.GroupBox();
            this.lblTotalPoints = new System.Windows.Forms.Label();
            this.lstPoints = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.GBoxEntradas = new System.Windows.Forms.GroupBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.groupBoxPoints.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.GBoxEntradas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Pink;
            this.label2.Location = new System.Drawing.Point(162, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 24);
            this.label2.TabIndex = 66;
            this.label2.Text = "2. Elija pintar y de clic donde quiera iniciar a colorear";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Pink;
            this.label1.Location = new System.Drawing.Point(90, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "1. Ingrese el radio del polígono y de un clic donde quiera dibujar el objeto";
            // 
            // btnPaint
            // 
            this.btnPaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaint.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaint.ForeColor = System.Drawing.Color.Pink;
            this.btnPaint.Location = new System.Drawing.Point(65, 170);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(87, 33);
            this.btnPaint.TabIndex = 61;
            this.btnPaint.Text = "Paint";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // groupBoxPoints
            // 
            this.groupBoxPoints.Controls.Add(this.lblTotalPoints);
            this.groupBoxPoints.Controls.Add(this.lstPoints);
            this.groupBoxPoints.ForeColor = System.Drawing.Color.Pink;
            this.groupBoxPoints.Location = new System.Drawing.Point(15, 209);
            this.groupBoxPoints.Name = "groupBoxPoints";
            this.groupBoxPoints.Size = new System.Drawing.Size(194, 229);
            this.groupBoxPoints.TabIndex = 64;
            this.groupBoxPoints.TabStop = false;
            this.groupBoxPoints.Text = "Points";
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.AutoSize = true;
            this.lblTotalPoints.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPoints.Location = new System.Drawing.Point(6, 192);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(72, 20);
            this.lblTotalPoints.TabIndex = 13;
            this.lblTotalPoints.Text = "Total: ";
            this.lblTotalPoints.Visible = false;
            // 
            // lstPoints
            // 
            this.lstPoints.BackColor = System.Drawing.Color.Black;
            this.lstPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPoints.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPoints.ForeColor = System.Drawing.Color.Pink;
            this.lstPoints.FormattingEnabled = true;
            this.lstPoints.ItemHeight = 22;
            this.lstPoints.Location = new System.Drawing.Point(22, 35);
            this.lstPoints.Name = "lstPoints";
            this.lstPoints.Size = new System.Drawing.Size(143, 154);
            this.lstPoints.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picCanvas);
            this.groupBox1.ForeColor = System.Drawing.Color.Pink;
            this.groupBox1.Location = new System.Drawing.Point(234, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 342);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graphic:";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(15, 21);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(473, 309);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // GBoxEntradas
            // 
            this.GBoxEntradas.Controls.Add(this.txtRadio);
            this.GBoxEntradas.Controls.Add(this.lblRadio);
            this.GBoxEntradas.ForeColor = System.Drawing.Color.Pink;
            this.GBoxEntradas.Location = new System.Drawing.Point(15, 92);
            this.GBoxEntradas.Name = "GBoxEntradas";
            this.GBoxEntradas.Size = new System.Drawing.Size(197, 63);
            this.GBoxEntradas.TabIndex = 62;
            this.GBoxEntradas.TabStop = false;
            this.GBoxEntradas.Text = "Input Section";
            // 
            // txtRadio
            // 
            this.txtRadio.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtRadio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRadio.ForeColor = System.Drawing.Color.Lime;
            this.txtRadio.Location = new System.Drawing.Point(100, 24);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(52, 22);
            this.txtRadio.TabIndex = 1;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadio.Location = new System.Drawing.Point(18, 25);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(70, 22);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Radio:";
            // 
            // FrmlFloodFill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxPoints);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBoxEntradas);
            this.Name = "FrmlFloodFill";
            this.Text = "FrmlFloodFill";
            this.groupBoxPoints.ResumeLayout(false);
            this.groupBoxPoints.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.GBoxEntradas.ResumeLayout(false);
            this.GBoxEntradas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.GroupBox groupBoxPoints;
        private System.Windows.Forms.Label lblTotalPoints;
        private System.Windows.Forms.ListBox lstPoints;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox GBoxEntradas;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label lblRadio;
    }
}