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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EditRow = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.DateTimePickerVacationEnd = new System.Windows.Forms.DateTimePicker();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DateTimePickerVacationStart = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.ComboBoxVacationType = new System.Windows.Forms.ComboBox();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxEmployee = new System.Windows.Forms.TextBox();
            this.ButtonEmployeeChoose = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1156, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TÜM İZİNLER";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditRow});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DividerHeight = 10;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 570);
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
            this.tableLayoutPanel5.Controls.Add(this.panel9, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.DateTimePickerVacationEnd, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.panel8, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.DateTimePickerVacationStart, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.label17, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.ComboBoxVacationType, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label20, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.textBox9, 1, 7);
            this.tableLayoutPanel5.Controls.Add(this.label21, 0, 8);
            this.tableLayoutPanel5.Controls.Add(this.textBox10, 1, 8);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.ButtonSave, 3, 9);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(26);
            this.tableLayoutPanel5.RowCount = 11;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1150, 570);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel5.SetColumnSpan(this.panel9, 2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(29, 285);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(494, 2);
            this.panel9.TabIndex = 18;
            // 
            // DateTimePickerVacationEnd
            // 
            this.DateTimePickerVacationEnd.CalendarForeColor = System.Drawing.Color.DarkRed;
            this.DateTimePickerVacationEnd.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.DateTimePickerVacationEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimePickerVacationEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerVacationEnd.Location = new System.Drawing.Point(234, 229);
            this.DateTimePickerVacationEnd.Margin = new System.Windows.Forms.Padding(7);
            this.DateTimePickerVacationEnd.Name = "DateTimePickerVacationEnd";
            this.DateTimePickerVacationEnd.Size = new System.Drawing.Size(285, 29);
            this.DateTimePickerVacationEnd.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel5.SetColumnSpan(this.panel8, 2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(29, 157);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(494, 2);
            this.panel8.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel5.SetColumnSpan(this.panel5, 2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(29, 89);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(494, 2);
            this.panel5.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(134, 45);
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
            this.label11.Location = new System.Drawing.Point(134, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "İZİN TÜRÜ";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(47, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "İZİN BAŞLAMA TARİHİ";
            // 
            // DateTimePickerVacationStart
            // 
            this.DateTimePickerVacationStart.CalendarForeColor = System.Drawing.Color.DarkRed;
            this.DateTimePickerVacationStart.CalendarTitleForeColor = System.Drawing.Color.DarkRed;
            this.DateTimePickerVacationStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimePickerVacationStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerVacationStart.Location = new System.Drawing.Point(234, 169);
            this.DateTimePickerVacationStart.Margin = new System.Windows.Forms.Padding(7);
            this.DateTimePickerVacationStart.Name = "DateTimePickerVacationStart";
            this.DateTimePickerVacationStart.Size = new System.Drawing.Size(285, 29);
            this.DateTimePickerVacationStart.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(74, 241);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(150, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "İZİN BİTME TARİHİ";
            // 
            // ComboBoxVacationType
            // 
            this.ComboBoxVacationType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ComboBoxVacationType.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ComboBoxVacationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxVacationType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBoxVacationType.ForeColor = System.Drawing.Color.DarkRed;
            this.ComboBoxVacationType.FormattingEnabled = true;
            this.ComboBoxVacationType.Items.AddRange(new object[] {
            "ÇALIŞILAN GÜN",
            "RAPOR İZNİ",
            "MAZERET İZNİ",
            "ÜCRETLİ İZİN",
            "ÜCRETSİZ İZİN",
            "YILLIK İZİN",
            "HAFTALIK TATİL",
            "İŞTEN ÇIKIŞ",
            "İŞE BAŞLAMADI",
            "RESMİ TATİL",
            "İDARİ DİSİPLİN CEZASI"});
            this.ComboBoxVacationType.Location = new System.Drawing.Point(234, 109);
            this.ComboBoxVacationType.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.ComboBoxVacationType.Name = "ComboBoxVacationType";
            this.ComboBoxVacationType.Size = new System.Drawing.Size(225, 29);
            this.ComboBoxVacationType.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(76, 309);
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
            this.textBox9.Location = new System.Drawing.Point(234, 305);
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
            this.label21.Location = new System.Drawing.Point(74, 369);
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
            this.textBox10.Location = new System.Drawing.Point(234, 365);
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
            this.tableLayoutPanel5.SetRowSpan(this.tableLayoutPanel6, 9);
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
            this.tableLayoutPanel6.Size = new System.Drawing.Size(456, 384);
            this.tableLayoutPanel6.TabIndex = 20;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel6.SetColumnSpan(this.panel10, 3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 39);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(450, 2);
            this.panel10.TabIndex = 21;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel6.SetColumnSpan(this.panel11, 3);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(3, 83);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(450, 2);
            this.panel11.TabIndex = 20;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(30, 51);
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
            this.label24.Location = new System.Drawing.Point(172, 51);
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
            this.label25.Location = new System.Drawing.Point(348, 51);
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
            this.label26.Location = new System.Drawing.Point(29, 95);
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
            this.label22.Location = new System.Drawing.Point(98, 7);
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
            this.label27.Location = new System.Drawing.Point(20, 131);
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
            this.label28.Location = new System.Drawing.Point(15, 167);
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
            this.label56.Location = new System.Drawing.Point(19, 203);
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
            this.label57.Location = new System.Drawing.Point(21, 239);
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
            this.label58.Location = new System.Drawing.Point(24, 275);
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
            this.label59.Location = new System.Drawing.Point(28, 311);
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
            this.label60.Location = new System.Drawing.Point(25, 351);
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
            this.label63.Location = new System.Drawing.Point(219, 95);
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
            this.label64.Location = new System.Drawing.Point(219, 131);
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
            this.label65.Location = new System.Drawing.Point(219, 167);
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
            this.label66.Location = new System.Drawing.Point(219, 203);
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
            this.label67.Location = new System.Drawing.Point(219, 239);
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
            this.label68.Location = new System.Drawing.Point(219, 275);
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
            this.label69.Location = new System.Drawing.Point(219, 311);
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
            this.label70.Location = new System.Drawing.Point(219, 351);
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
            this.label71.Location = new System.Drawing.Point(371, 351);
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
            this.label72.Location = new System.Drawing.Point(371, 311);
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
            this.label73.Location = new System.Drawing.Point(371, 275);
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
            this.label74.Location = new System.Drawing.Point(371, 239);
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
            this.label75.Location = new System.Drawing.Point(371, 203);
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
            this.label76.Location = new System.Drawing.Point(371, 167);
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
            this.label77.Location = new System.Drawing.Point(371, 131);
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
            this.label78.Location = new System.Drawing.Point(371, 95);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(16, 21);
            this.label78.TabIndex = 0;
            this.label78.Text = "-";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.91126F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.08874F));
            this.tableLayoutPanel1.Controls.Add(this.TextBoxEmployee, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonEmployeeChoose, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(230, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 54);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // TextBoxEmployee
            // 
            this.TextBoxEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBoxEmployee.BackColor = System.Drawing.Color.White;
            this.TextBoxEmployee.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxEmployee.Enabled = false;
            this.TextBoxEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxEmployee.ForeColor = System.Drawing.Color.DarkRed;
            this.TextBoxEmployee.Location = new System.Drawing.Point(7, 12);
            this.TextBoxEmployee.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.TextBoxEmployee.Name = "TextBoxEmployee";
            this.TextBoxEmployee.Size = new System.Drawing.Size(225, 29);
            this.TextBoxEmployee.TabIndex = 1;
            // 
            // ButtonEmployeeChoose
            // 
            this.ButtonEmployeeChoose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonEmployeeChoose.Location = new System.Drawing.Point(245, 11);
            this.ButtonEmployeeChoose.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonEmployeeChoose.Name = "ButtonEmployeeChoose";
            this.ButtonEmployeeChoose.Size = new System.Drawing.Size(43, 31);
            this.ButtonEmployeeChoose.TabIndex = 2;
            this.ButtonEmployeeChoose.Text = "Seç";
            this.ButtonEmployeeChoose.UseVisualStyleBackColor = true;
            this.ButtonEmployeeChoose.Click += new System.EventHandler(this.ButtonEmployeeChoose_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.Location = new System.Drawing.Point(927, 425);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(197, 40);
            this.ButtonSave.TabIndex = 22;
            this.ButtonSave.Text = "Kaydet";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
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
            // FormEmployeeVacation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1188, 628);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FormEmployeeVacation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployeeVacation";
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewImageColumn EditRow;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel9;
        private DateTimePicker DateTimePickerVacationEnd;
        private Panel panel8;
        private Panel panel5;
        private Label label16;
        private Label label11;
        private Label label15;
        private DateTimePicker DateTimePickerVacationStart;
        private Label label17;
        private ComboBox ComboBoxVacationType;
        private Label label20;
        private TextBox textBox9;
        private Label label21;
        private TextBox textBox10;
        private TableLayoutPanel tableLayoutPanel6;
        private Panel panel10;
        private Panel panel11;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label22;
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
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox TextBoxEmployee;
        private Button ButtonEmployeeChoose;
        private Button ButtonSave;
        private TabControl tabControl1;
    }
}