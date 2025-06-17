namespace AlgorithmBasic
{
    partial class FrmIndex
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
            this.dDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.circle1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.floodfillToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDAToolStripMenuItem,
            this.bresenhamToolStripMenuItem2,
            this.circle1ToolStripMenuItem1,
            this.floodfillToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dDAToolStripMenuItem
            // 
            this.dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            this.dDAToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.dDAToolStripMenuItem.Text = "DDA";
            this.dDAToolStripMenuItem.Click += new System.EventHandler(this.dDAToolStripMenuItem_Click_1);
            // 
            // bresenhamToolStripMenuItem2
            // 
            this.bresenhamToolStripMenuItem2.Name = "bresenhamToolStripMenuItem2";
            this.bresenhamToolStripMenuItem2.Size = new System.Drawing.Size(96, 24);
            this.bresenhamToolStripMenuItem2.Text = "Bresenham";
            this.bresenhamToolStripMenuItem2.Click += new System.EventHandler(this.bresenhamToolStripMenuItem2_Click);
            // 
            // circle1ToolStripMenuItem1
            // 
            this.circle1ToolStripMenuItem1.Name = "circle1ToolStripMenuItem1";
            this.circle1ToolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.circle1ToolStripMenuItem1.Text = "Circle";
            this.circle1ToolStripMenuItem1.Click += new System.EventHandler(this.circle1ToolStripMenuItem1_Click);
            // 
            // floodfillToolStripMenuItem1
            // 
            this.floodfillToolStripMenuItem1.Name = "floodfillToolStripMenuItem1";
            this.floodfillToolStripMenuItem1.Size = new System.Drawing.Size(84, 24);
            this.floodfillToolStripMenuItem1.Text = "Flood Fill";
            this.floodfillToolStripMenuItem1.Click += new System.EventHandler(this.floodfillToolStripMenuItem1_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelContenedor.Controls.Add(this.lblName);
            this.panelContenedor.Controls.Add(this.lblWelcome);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 28);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(812, 475);
            this.panelContenedor.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(348, 230);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(338, 27);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(65, 16);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 503);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmIndex";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dDAToolStripMenuItem;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolStripMenuItem bresenhamToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem circle1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem floodfillToolStripMenuItem1;
    }
}