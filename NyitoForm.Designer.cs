namespace Autos_doga
{
    partial class NyitoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NyitoForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.autóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törölToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_Autok = new System.Windows.Forms.ListBox();
            this.panel_Marka = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // autóToolStripMenuItem
            // 
            this.autóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módosítToolStripMenuItem,
            this.törölToolStripMenuItem});
            this.autóToolStripMenuItem.Name = "autóToolStripMenuItem";
            this.autóToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.autóToolStripMenuItem.Text = "Autó";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // módosítToolStripMenuItem
            // 
            this.módosítToolStripMenuItem.Name = "módosítToolStripMenuItem";
            this.módosítToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.módosítToolStripMenuItem.Text = "Módosít";
            this.módosítToolStripMenuItem.Click += new System.EventHandler(this.módosítToolStripMenuItem_Click);
            // 
            // törölToolStripMenuItem
            // 
            this.törölToolStripMenuItem.Name = "törölToolStripMenuItem";
            this.törölToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.törölToolStripMenuItem.Text = "Töröl";
            this.törölToolStripMenuItem.Click += new System.EventHandler(this.törölToolStripMenuItem_Click);
            // 
            // listBox_Autok
            // 
            this.listBox_Autok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Autok.FormattingEnabled = true;
            this.listBox_Autok.ItemHeight = 16;
            this.listBox_Autok.Location = new System.Drawing.Point(0, 28);
            this.listBox_Autok.Name = "listBox_Autok";
            this.listBox_Autok.Size = new System.Drawing.Size(273, 532);
            this.listBox_Autok.TabIndex = 1;
            // 
            // panel_Marka
            // 
            this.panel_Marka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Marka.Location = new System.Drawing.Point(273, 28);
            this.panel_Marka.Name = "panel_Marka";
            this.panel_Marka.Size = new System.Drawing.Size(555, 532);
            this.panel_Marka.TabIndex = 2;
            // 
            // NyitoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 560);
            this.Controls.Add(this.panel_Marka);
            this.Controls.Add(this.listBox_Autok);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NyitoForm";
            this.Text = "Autó adatok";
            this.Load += new System.EventHandler(this.NyitoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem autóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosítToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törölToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Marka;
        public System.Windows.Forms.ListBox listBox_Autok;
    }
}

