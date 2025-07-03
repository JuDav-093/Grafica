namespace GraphicsAlgorithmVisualizer.Forms
{
    partial class FrmCurvasBezier
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bezierLinealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezier2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezier3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bezierLinealToolStripMenuItem,
            this.bezier2ToolStripMenuItem,
            this.bezier3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(635, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bezierLinealToolStripMenuItem
            // 
            this.bezierLinealToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.bezierLinealToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bezierLinealToolStripMenuItem.Name = "bezierLinealToolStripMenuItem";
            this.bezierLinealToolStripMenuItem.Size = new System.Drawing.Size(125, 27);
            this.bezierLinealToolStripMenuItem.Text = "Bezier Lineal";
            this.bezierLinealToolStripMenuItem.Click += new System.EventHandler(this.bezierLinealToolStripMenuItem_Click);
            // 
            // bezier2ToolStripMenuItem
            // 
            this.bezier2ToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.bezier2ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bezier2ToolStripMenuItem.Name = "bezier2ToolStripMenuItem";
            this.bezier2ToolStripMenuItem.Size = new System.Drawing.Size(177, 27);
            this.bezier2ToolStripMenuItem.Text = "1 punto de Control";
            this.bezier2ToolStripMenuItem.Click += new System.EventHandler(this.bezier2ToolStripMenuItem_Click);
            // 
            // bezier3ToolStripMenuItem
            // 
            this.bezier3ToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.bezier3ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bezier3ToolStripMenuItem.Name = "bezier3ToolStripMenuItem";
            this.bezier3ToolStripMenuItem.Size = new System.Drawing.Size(184, 27);
            this.bezier3ToolStripMenuItem.Text = "2 puntos de Control";
            this.bezier3ToolStripMenuItem.Click += new System.EventHandler(this.bezier3ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 434);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCurvasBezier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(635, 514);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmCurvasBezier";
            this.Text = "FrmCurvasBezier";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bezierLinealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bezier2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bezier3ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}