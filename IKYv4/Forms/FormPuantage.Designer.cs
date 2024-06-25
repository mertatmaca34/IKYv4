namespace IKYv4.Forms
{
    partial class FormPuantage
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonSetPuantage = new System.Windows.Forms.Button();
            this.DateTimePickerPuantageMonth = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "IKYv4.Reports.ReportTimesheet30.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1258, 495);
            this.reportViewer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 551);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.03497F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.96502F));
            this.tableLayoutPanel2.Controls.Add(this.ButtonSetPuantage, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.DateTimePickerPuantageMonth, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1258, 44);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ButtonSetPuantage
            // 
            this.ButtonSetPuantage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonSetPuantage.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonSetPuantage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSetPuantage.FlatAppearance.BorderSize = 0;
            this.ButtonSetPuantage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSetPuantage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonSetPuantage.ForeColor = System.Drawing.Color.White;
            this.ButtonSetPuantage.Location = new System.Drawing.Point(1052, 4);
            this.ButtonSetPuantage.Margin = new System.Windows.Forms.Padding(0, 0, 5, 3);
            this.ButtonSetPuantage.Name = "ButtonSetPuantage";
            this.ButtonSetPuantage.Size = new System.Drawing.Size(201, 32);
            this.ButtonSetPuantage.TabIndex = 5;
            this.ButtonSetPuantage.Text = "Puantajı Güncelle";
            this.ButtonSetPuantage.UseVisualStyleBackColor = false;
            this.ButtonSetPuantage.Click += new System.EventHandler(this.ButtonSetPuantage_Click);
            // 
            // DateTimePickerPuantageMonth
            // 
            this.DateTimePickerPuantageMonth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DateTimePickerPuantageMonth.CustomFormat = "yyyy MMMM";
            this.DateTimePickerPuantageMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerPuantageMonth.Location = new System.Drawing.Point(909, 12);
            this.DateTimePickerPuantageMonth.Name = "DateTimePickerPuantageMonth";
            this.DateTimePickerPuantageMonth.Size = new System.Drawing.Size(120, 20);
            this.DateTimePickerPuantageMonth.TabIndex = 6;
            // 
            // FormPuantage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPuantage";
            this.Text = "FormPuantage";
            this.Load += new System.EventHandler(this.FormPuantage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ButtonSetPuantage;
        private System.Windows.Forms.DateTimePicker DateTimePickerPuantageMonth;
    }
}