using System.Drawing;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    partial class FormEmployeeVacation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dateTimePicker23 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker22 = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dateTimePicker21 = new System.Windows.Forms.DateTimePicker();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditRow = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1164, 604);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.tableLayoutPanel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1156, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "YENİ İZİN";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.07974F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.33618F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.58408F));
            this.tableLayoutPanel5.Controls.Add(this.panel9, 0, 8);
            this.tableLayoutPanel5.Controls.Add(this.dateTimePicker23, 1, 7);
            this.tableLayoutPanel5.Controls.Add(this.dateTimePicker22, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.label19, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.label18, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.dateTimePicker21, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.panel8, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.textBox5, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.dateTimePicker2, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.label17, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.comboBox6, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label20, 0, 9);
            this.tableLayoutPanel5.Controls.Add(this.textBox9, 1, 9);
            this.tableLayoutPanel5.Controls.Add(this.label21, 0, 10);
            this.tableLayoutPanel5.Controls.Add(this.textBox10, 1, 10);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(26, 26, 26, 26);
            this.tableLayoutPanel5.RowCount = 11;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50016F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50016F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50016F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50016F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50016F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50016F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50016F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49891F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1150, 570);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel5.SetColumnSpan(this.panel9, 2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(29, 411);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(494, 2);
            this.panel9.TabIndex = 18;
            // 
            // dateTimePicker23
            // 
            this.dateTimePicker23.CalendarForeColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker23.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker23.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker23.Location = new System.Drawing.Point(234, 354);
            this.dateTimePicker23.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dateTimePicker23.Name = "dateTimePicker23";
            this.dateTimePicker23.Size = new System.Drawing.Size(285, 29);
            this.dateTimePicker23.TabIndex = 16;
            // 
            // dateTimePicker22
            // 
            this.dateTimePicker22.CalendarForeColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker22.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker22.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker22.Location = new System.Drawing.Point(234, 232);
            this.dateTimePicker22.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dateTimePicker22.Name = "dateTimePicker22";
            this.dateTimePicker22.Size = new System.Drawing.Size(285, 29);
            this.dateTimePicker22.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(81, 367);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(143, 21);
            this.label19.TabIndex = 14;
            this.label19.Text = "İZİN BİTME SAATİ";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(54, 245);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(170, 21);
            this.label18.TabIndex = 13;
            this.label18.Text = "İZİN BAŞLAMA SAATİ";
            // 
            // dateTimePicker21
            // 
            this.dateTimePicker21.CalendarForeColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker21.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker21.Location = new System.Drawing.Point(234, 293);
            this.dateTimePicker21.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dateTimePicker21.Name = "dateTimePicker21";
            this.dateTimePicker21.Size = new System.Drawing.Size(285, 29);
            this.dateTimePicker21.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel5.SetColumnSpan(this.panel8, 2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(29, 159);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(494, 2);
            this.panel8.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel5.SetColumnSpan(this.panel5, 2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(29, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(494, 2);
            this.panel5.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(134, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "PERSONEL";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(134, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "İZİN TÜRÜ";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox5.Location = new System.Drawing.Point(234, 42);
            this.textBox5.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(225, 29);
            this.textBox5.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(47, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "İZİN BAŞLAMA TARİHİ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Location = new System.Drawing.Point(234, 171);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(285, 29);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(74, 306);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(150, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "İZİN BİTME TARİHİ";
            // 
            // comboBox6
            // 
            this.comboBox6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox6.ForeColor = System.Drawing.Color.DarkRed;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "YAPILMADI",
            "YAPILDI",
            "TECİLLİ",
            "MUAF"});
            this.comboBox6.Location = new System.Drawing.Point(234, 111);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(225, 29);
            this.comboBox6.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(76, 436);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(148, 21);
            this.label20.TabIndex = 14;
            this.label20.Text = "İZİNLİ GÜN SAYISI";
            // 
            // textBox9
            // 
            this.textBox9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox9.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox9.Location = new System.Drawing.Point(234, 432);
            this.textBox9.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(225, 29);
            this.textBox9.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(74, 500);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(150, 21);
            this.label21.TabIndex = 14;
            this.label21.Text = "KALAN YILLIK İZİN";
            // 
            // textBox10
            // 
            this.textBox10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox10.Enabled = false;
            this.textBox10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox10.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox10.Location = new System.Drawing.Point(234, 496);
            this.textBox10.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(225, 29);
            this.textBox10.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.Controls.Add(this.panel10, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel11, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label23, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label24, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.label25, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.label26, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.label22, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label27, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.label28, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.label56, 0, 7);
            this.tableLayoutPanel6.Controls.Add(this.label57, 0, 8);
            this.tableLayoutPanel6.Controls.Add(this.label58, 0, 9);
            this.tableLayoutPanel6.Controls.Add(this.label59, 0, 10);
            this.tableLayoutPanel6.Controls.Add(this.label60, 0, 11);
            this.tableLayoutPanel6.Controls.Add(this.label63, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.label64, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.label65, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.label66, 1, 7);
            this.tableLayoutPanel6.Controls.Add(this.label67, 1, 8);
            this.tableLayoutPanel6.Controls.Add(this.label68, 1, 9);
            this.tableLayoutPanel6.Controls.Add(this.label69, 1, 10);
            this.tableLayoutPanel6.Controls.Add(this.label70, 1, 11);
            this.tableLayoutPanel6.Controls.Add(this.label71, 2, 11);
            this.tableLayoutPanel6.Controls.Add(this.label72, 2, 10);
            this.tableLayoutPanel6.Controls.Add(this.label73, 2, 9);
            this.tableLayoutPanel6.Controls.Add(this.label74, 2, 8);
            this.tableLayoutPanel6.Controls.Add(this.label75, 2, 7);
            this.tableLayoutPanel6.Controls.Add(this.label76, 2, 6);
            this.tableLayoutPanel6.Controls.Add(this.label77, 2, 5);
            this.tableLayoutPanel6.Controls.Add(this.label78, 2, 4);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(668, 26);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 12;
            this.tableLayoutPanel5.SetRowSpan(this.tableLayoutPanel6, 11);
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00262F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999624F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999626F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999624F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999626F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999626F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999624F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999624F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(456, 518);
            this.tableLayoutPanel6.TabIndex = 20;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel6.SetColumnSpan(this.panel10, 3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 53);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(450, 2);
            this.panel10.TabIndex = 21;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel6.SetColumnSpan(this.panel11, 3);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(3, 111);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(450, 2);
            this.panel11.TabIndex = 20;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(30, 72);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 21);
            this.label23.TabIndex = 0;
            this.label23.Text = "İZİN TÜRÜ";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(172, 72);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(109, 21);
            this.label24.TabIndex = 0;
            this.label24.Text = "KULLANILAN";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(348, 72);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 21);
            this.label25.TabIndex = 0;
            this.label25.Text = "KALAN";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(29, 130);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(93, 21);
            this.label26.TabIndex = 0;
            this.label26.Text = "YILLIK İZİN";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.label22, 3);
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(98, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(259, 21);
            this.label22.TabIndex = 0;
            this.label22.Text = "2024 PERSONELİN İZİN TABLOSU";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(20, 180);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(110, 21);
            this.label27.TabIndex = 0;
            this.label27.Text = "ÜCRETLİ İZİN";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(15, 230);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(121, 21);
            this.label28.TabIndex = 0;
            this.label28.Text = "ÜCRETSİZ İZİN";
            // 
            // label56
            // 
            this.label56.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label56.Location = new System.Drawing.Point(19, 280);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(112, 21);
            this.label56.TabIndex = 0;
            this.label56.Text = "BABALIK İZNİ";
            // 
            // label57
            // 
            this.label57.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label57.Location = new System.Drawing.Point(21, 330);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(109, 21);
            this.label57.TabIndex = 0;
            this.label57.Text = "DOĞUM İZNİ";
            // 
            // label58
            // 
            this.label58.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label58.Location = new System.Drawing.Point(24, 380);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(103, 21);
            this.label58.TabIndex = 0;
            this.label58.Text = "EVLİLİK İZNİ";
            // 
            // label59
            // 
            this.label59.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label59.Location = new System.Drawing.Point(28, 430);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(94, 21);
            this.label59.TabIndex = 0;
            this.label59.Text = "ÖLÜM İZNİ";
            // 
            // label60
            // 
            this.label60.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label60.Location = new System.Drawing.Point(25, 481);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(100, 21);
            this.label60.TabIndex = 0;
            this.label60.Text = "RAPOR İZNİ";
            // 
            // label63
            // 
            this.label63.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label63.Location = new System.Drawing.Point(219, 130);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(16, 21);
            this.label63.TabIndex = 0;
            this.label63.Text = "-";
            // 
            // label64
            // 
            this.label64.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label64.Location = new System.Drawing.Point(219, 180);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(16, 21);
            this.label64.TabIndex = 0;
            this.label64.Text = "-";
            // 
            // label65
            // 
            this.label65.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label65.Location = new System.Drawing.Point(219, 230);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(16, 21);
            this.label65.TabIndex = 0;
            this.label65.Text = "-";
            // 
            // label66
            // 
            this.label66.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label66.Location = new System.Drawing.Point(219, 280);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(16, 21);
            this.label66.TabIndex = 0;
            this.label66.Text = "-";
            // 
            // label67
            // 
            this.label67.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label67.Location = new System.Drawing.Point(219, 330);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(16, 21);
            this.label67.TabIndex = 0;
            this.label67.Text = "-";
            // 
            // label68
            // 
            this.label68.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label68.Location = new System.Drawing.Point(219, 380);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(16, 21);
            this.label68.TabIndex = 0;
            this.label68.Text = "-";
            // 
            // label69
            // 
            this.label69.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label69.Location = new System.Drawing.Point(219, 430);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(16, 21);
            this.label69.TabIndex = 0;
            this.label69.Text = "-";
            // 
            // label70
            // 
            this.label70.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label70.Location = new System.Drawing.Point(219, 481);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(16, 21);
            this.label70.TabIndex = 0;
            this.label70.Text = "-";
            // 
            // label71
            // 
            this.label71.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label71.Location = new System.Drawing.Point(371, 481);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(16, 21);
            this.label71.TabIndex = 0;
            this.label71.Text = "-";
            // 
            // label72
            // 
            this.label72.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label72.Location = new System.Drawing.Point(371, 430);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(16, 21);
            this.label72.TabIndex = 0;
            this.label72.Text = "-";
            // 
            // label73
            // 
            this.label73.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label73.Location = new System.Drawing.Point(371, 380);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(16, 21);
            this.label73.TabIndex = 0;
            this.label73.Text = "-";
            // 
            // label74
            // 
            this.label74.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label74.Location = new System.Drawing.Point(371, 330);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(16, 21);
            this.label74.TabIndex = 0;
            this.label74.Text = "-";
            // 
            // label75
            // 
            this.label75.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label75.Location = new System.Drawing.Point(371, 280);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(16, 21);
            this.label75.TabIndex = 0;
            this.label75.Text = "-";
            // 
            // label76
            // 
            this.label76.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label76.Location = new System.Drawing.Point(371, 230);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(16, 21);
            this.label76.TabIndex = 0;
            this.label76.Text = "-";
            // 
            // label77
            // 
            this.label77.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label77.Location = new System.Drawing.Point(371, 180);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(16, 21);
            this.label77.TabIndex = 0;
            this.label77.Text = "-";
            // 
            // label78
            // 
            this.label78.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label78.Location = new System.Drawing.Point(371, 130);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(16, 21);
            this.label78.TabIndex = 0;
            this.label78.Text = "-";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TÜM İZİNLER";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditRow});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.DividerHeight = 10;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(953, 431);
            this.dataGridView1.TabIndex = 2;
            // 
            // EditRow
            // 
            this.EditRow.Description = "Düzenle";
            this.EditRow.FillWeight = 30F;
            this.EditRow.HeaderText = "";
            this.EditRow.Image = global::IKYv4.Properties.Resources.edit_row_24px;
            this.EditRow.Name = "EditRow";
            this.EditRow.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditRow.ToolTipText = "Düzenle";
            // 
            // FormEmployeeVacation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1188, 628);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormEmployeeVacation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployeeVacation";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label16;
        private Label label11;
        private TextBox textBox5;
        private TabPage tabPage2;
        private Panel panel5;
        private Panel panel8;
        private Label label15;
        private Label label17;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker21;
        private Label label18;
        private Label label19;
        private DateTimePicker dateTimePicker22;
        private DateTimePicker dateTimePicker23;
        private ComboBox comboBox6;
        private Panel panel9;
        private Label label20;
        private TextBox textBox9;
        private Label label21;
        private TextBox textBox10;
        private Label label22;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label23;
        private Label label24;
        private Label label25;
        private Panel panel11;
        private Label label26;
        private Panel panel10;
        private Label label27;
        private Label label28;
        private Label label56;
        private Label label57;
        private Label label58;
        private Label label59;
        private Label label60;
        private Label label63;
        private Label label64;
        private Label label65;
        private Label label66;
        private Label label67;
        private Label label68;
        private Label label69;
        private Label label70;
        private Label label71;
        private Label label72;
        private Label label73;
        private Label label74;
        private Label label75;
        private Label label76;
        private Label label77;
        private Label label78;
        private DataGridView dataGridView1;
        private DataGridViewImageColumn EditRow;
    }
}