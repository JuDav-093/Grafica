namespace GraphicsAlgorithmVisualizer.Forms
{
    partial class FrmScanline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScanline));
            this.pictuCanva = new System.Windows.Forms.PictureBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.BtnLine = new System.Windows.Forms.Button();
            this.rellenar = new System.Windows.Forms.Button();
            this.btnLimpiarTodo = new System.Windows.Forms.Button();
            this.ColorBox = new System.Windows.Forms.GroupBox();
            this.pic_color = new System.Windows.Forms.Button();
            this.BtnColorSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictuCanva)).BeginInit();
            this.ColorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictuCanva
            // 
            this.pictuCanva.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictuCanva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictuCanva.Location = new System.Drawing.Point(163, 111);
            this.pictuCanva.Margin = new System.Windows.Forms.Padding(5);
            this.pictuCanva.Name = "pictuCanva";
            this.pictuCanva.Size = new System.Drawing.Size(514, 281);
            this.pictuCanva.TabIndex = 2;
            this.pictuCanva.TabStop = false;
            this.pictuCanva.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictuCanva.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictuCanva.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictuCanva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictuCanva.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Black;
            this.listBox.ForeColor = System.Drawing.Color.Pink;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(16, 188);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(121, 196);
            this.listBox.TabIndex = 50;
            // 
            // BtnLine
            // 
            this.BtnLine.BackColor = System.Drawing.Color.LightPink;
            this.BtnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLine.Location = new System.Drawing.Point(549, 49);
            this.BtnLine.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(66, 53);
            this.BtnLine.TabIndex = 51;
            this.BtnLine.Text = "Dibujar";
            this.BtnLine.UseVisualStyleBackColor = false;
            this.BtnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // rellenar
            // 
            this.rellenar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rellenar.BackgroundImage")));
            this.rellenar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rellenar.Location = new System.Drawing.Point(57, 133);
            this.rellenar.Margin = new System.Windows.Forms.Padding(4);
            this.rellenar.Name = "rellenar";
            this.rellenar.Size = new System.Drawing.Size(53, 47);
            this.rellenar.TabIndex = 52;
            this.rellenar.UseVisualStyleBackColor = true;
            this.rellenar.Click += new System.EventHandler(this.rellenar_Click);
            // 
            // btnLimpiarTodo
            // 
            this.btnLimpiarTodo.BackColor = System.Drawing.Color.LightPink;
            this.btnLimpiarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiarTodo.Location = new System.Drawing.Point(624, 50);
            this.btnLimpiarTodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarTodo.Name = "btnLimpiarTodo";
            this.btnLimpiarTodo.Size = new System.Drawing.Size(57, 50);
            this.btnLimpiarTodo.TabIndex = 53;
            this.btnLimpiarTodo.Text = "Borrar";
            this.btnLimpiarTodo.UseVisualStyleBackColor = false;
            this.btnLimpiarTodo.Click += new System.EventHandler(this.btnLimpiarTodo_Click);
            // 
            // ColorBox
            // 
            this.ColorBox.Controls.Add(this.pic_color);
            this.ColorBox.Controls.Add(this.BtnColorSet);
            this.ColorBox.ForeColor = System.Drawing.Color.Pink;
            this.ColorBox.Location = new System.Drawing.Point(15, 57);
            this.ColorBox.Margin = new System.Windows.Forms.Padding(4);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Padding = new System.Windows.Forms.Padding(4);
            this.ColorBox.Size = new System.Drawing.Size(136, 68);
            this.ColorBox.TabIndex = 54;
            this.ColorBox.TabStop = false;
            this.ColorBox.Text = "Colores";
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.Black;
            this.pic_color.Location = new System.Drawing.Point(7, 21);
            this.pic_color.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(53, 39);
            this.pic_color.TabIndex = 32;
            this.pic_color.UseVisualStyleBackColor = false;
            this.pic_color.Click += new System.EventHandler(this.pic_color_Click);
            // 
            // BtnColorSet
            // 
            this.BtnColorSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnColorSet.BackgroundImage")));
            this.BtnColorSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnColorSet.Location = new System.Drawing.Point(70, 18);
            this.BtnColorSet.Margin = new System.Windows.Forms.Padding(4);
            this.BtnColorSet.Name = "BtnColorSet";
            this.BtnColorSet.Size = new System.Drawing.Size(61, 44);
            this.BtnColorSet.TabIndex = 10;
            this.BtnColorSet.UseVisualStyleBackColor = true;
            this.BtnColorSet.Click += new System.EventHandler(this.BtnColorSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightPink;
            this.label1.Location = new System.Drawing.Point(175, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "Elige un color para dibujar y otro para rellenar ";
            // 
            // FrmScanline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.btnLimpiarTodo);
            this.Controls.Add(this.rellenar);
            this.Controls.Add(this.BtnLine);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.pictuCanva);
            this.Name = "FrmScanline";
            this.Text = "FrmScanline";
            ((System.ComponentModel.ISupportInitialize)(this.pictuCanva)).EndInit();
            this.ColorBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictuCanva;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button BtnLine;
        private System.Windows.Forms.Button rellenar;
        private System.Windows.Forms.Button btnLimpiarTodo;
        private System.Windows.Forms.GroupBox ColorBox;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button BtnColorSet;
        private System.Windows.Forms.Label label1;
    }
}