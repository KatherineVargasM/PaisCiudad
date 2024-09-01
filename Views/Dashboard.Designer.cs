namespace PaisCiudad.Views
{
    partial class Dashboard
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
            this.lISTACIUDADESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTAPAISESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lISTACIUDADESToolStripMenuItem,
            this.lISTAPAISESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lISTACIUDADESToolStripMenuItem
            // 
            this.lISTACIUDADESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lISTACIUDADESToolStripMenuItem.Name = "lISTACIUDADESToolStripMenuItem";
            this.lISTACIUDADESToolStripMenuItem.Size = new System.Drawing.Size(162, 29);
            this.lISTACIUDADESToolStripMenuItem.Text = "LISTA CIUDADES";
            this.lISTACIUDADESToolStripMenuItem.Click += new System.EventHandler(this.lISTACIUDADESToolStripMenuItem_Click);
            // 
            // lISTAPAISESToolStripMenuItem
            // 
            this.lISTAPAISESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lISTAPAISESToolStripMenuItem.Name = "lISTAPAISESToolStripMenuItem";
            this.lISTAPAISESToolStripMenuItem.Size = new System.Drawing.Size(131, 29);
            this.lISTAPAISESToolStripMenuItem.Text = "LISTA PAISES";
            this.lISTAPAISESToolStripMenuItem.Click += new System.EventHandler(this.lISTAPAISESToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 191);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lISTACIUDADESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTAPAISESToolStripMenuItem;
    }
}