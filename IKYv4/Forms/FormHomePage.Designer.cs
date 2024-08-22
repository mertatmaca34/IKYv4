namespace IKYv4.Forms
{
    partial class FormHomePage
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
            this.PanelContent = new System.Windows.Forms.Panel();
            this.GmapControlStations = new GMap.NET.WindowsForms.GMapControl();
            this.PanelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.GmapControlStations);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 0);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1264, 551);
            this.PanelContent.TabIndex = 0;
            // 
            // GmapControlStations
            // 
            this.GmapControlStations.Bearing = 0F;
            this.GmapControlStations.CanDragMap = true;
            this.GmapControlStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GmapControlStations.EmptyTileColor = System.Drawing.Color.Navy;
            this.GmapControlStations.GrayScaleMode = false;
            this.GmapControlStations.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GmapControlStations.LevelsKeepInMemmory = 5;
            this.GmapControlStations.Location = new System.Drawing.Point(0, 0);
            this.GmapControlStations.MarkersEnabled = true;
            this.GmapControlStations.MaxZoom = 15;
            this.GmapControlStations.MinZoom = 8;
            this.GmapControlStations.MouseWheelZoomEnabled = true;
            this.GmapControlStations.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GmapControlStations.Name = "GmapControlStations";
            this.GmapControlStations.NegativeMode = false;
            this.GmapControlStations.PolygonsEnabled = true;
            this.GmapControlStations.RetryLoadTile = 0;
            this.GmapControlStations.RoutesEnabled = true;
            this.GmapControlStations.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GmapControlStations.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GmapControlStations.ShowTileGridLines = false;
            this.GmapControlStations.Size = new System.Drawing.Size(1264, 551);
            this.GmapControlStations.TabIndex = 2;
            this.GmapControlStations.Zoom = 0D;
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 551);
            this.Controls.Add(this.PanelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHomePage";
            this.Load += new System.EventHandler(this.FormHomePage_Load);
            this.PanelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContent;
        private GMap.NET.WindowsForms.GMapControl GmapControlStations;
    }
}