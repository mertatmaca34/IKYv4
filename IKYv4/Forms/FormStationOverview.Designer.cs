﻿namespace IKYv4.Forms
{
    partial class FormStationOverview
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tESİSÖZETİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kADRODURUMUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tESİSÖZETİToolStripMenuItem,
            this.kADRODURUMUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 527);
            this.panel1.TabIndex = 1;
            // 
            // tESİSÖZETİToolStripMenuItem
            // 
            this.tESİSÖZETİToolStripMenuItem.Name = "tESİSÖZETİToolStripMenuItem";
            this.tESİSÖZETİToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.tESİSÖZETİToolStripMenuItem.Text = "TESİS ÖZETİ";
            // 
            // kADRODURUMUToolStripMenuItem
            // 
            this.kADRODURUMUToolStripMenuItem.Name = "kADRODURUMUToolStripMenuItem";
            this.kADRODURUMUToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.kADRODURUMUToolStripMenuItem.Text = "KADRO DURUMU";
            // 
            // FormStationOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStationOverview";
            this.Text = "FormStationOverview";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem tESİSÖZETİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kADRODURUMUToolStripMenuItem;
    }
}