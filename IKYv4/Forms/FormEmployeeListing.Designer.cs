using System.Drawing;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    partial class FormEmployeeListing
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonSearchFooter = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxTesisFilter = new System.Windows.Forms.ComboBox();
            this.ComboBoxSeflikFilter = new System.Windows.Forms.ComboBox();
            this.ComboBoxMudurlukFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxPozisyon = new System.Windows.Forms.ComboBox();
            this.ComboBoxUnvanGrubu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxKanGrubu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxMaxAge = new System.Windows.Forms.TextBox();
            this.TextBoxMinAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.RadioButtonMarried = new System.Windows.Forms.RadioButton();
            this.RadioButtonSingle = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.RadioButtonSpouseWorking = new System.Windows.Forms.RadioButton();
            this.RadioButtonSpouseNotWorking = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxMaxKid = new System.Windows.Forms.TextBox();
            this.TextBoxMinKid = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxHomeTownCity = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxDistricts = new System.Windows.Forms.ComboBox();
            this.ComboBoxCities = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.CheckBoxLise = new System.Windows.Forms.CheckBox();
            this.CheckBoxYuksekLisans = new System.Windows.Forms.CheckBox();
            this.CheckBoxLisans = new System.Windows.Forms.CheckBox();
            this.CheckBoxOnLisans = new System.Windows.Forms.CheckBox();
            this.CheckBoxOrtaokul = new System.Windows.Forms.CheckBox();
            this.CheckBoxIlkokul = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxEyt = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxMaxExpYear = new System.Windows.Forms.TextBox();
            this.TextBoxMinExpYear = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.CheckBoxEskiCalisan = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonNewEmployee = new System.Windows.Forms.Button();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonEditColumns = new System.Windows.Forms.Button();
            this.ComboBoxSort = new System.Windows.Forms.ComboBox();
            this.TextBoxSmartFilter = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ButtonExportToExcel = new System.Windows.Forms.Button();
            this.DataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.EditRow = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditShifts = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.comboBox7, 0, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // comboBox7
            // 
            this.comboBox7.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox7.Enabled = false;
            this.comboBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.comboBox7.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(8, 68);
            this.comboBox7.Margin = new System.Windows.Forms.Padding(8);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(184, 23);
            this.comboBox7.TabIndex = 4;
            this.comboBox7.Text = "Tesis";
            // 
            // comboBox8
            // 
            this.comboBox8.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox8.Enabled = false;
            this.comboBox8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.comboBox8.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(8, 8);
            this.comboBox8.Margin = new System.Windows.Forms.Padding(8);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(184, 23);
            this.comboBox8.TabIndex = 3;
            this.comboBox8.Text = "Şeflik";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.comboBox9, 0, 3);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // comboBox9
            // 
            this.comboBox9.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox9.Enabled = false;
            this.comboBox9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.comboBox9.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(8, 68);
            this.comboBox9.Margin = new System.Windows.Forms.Padding(8);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(184, 23);
            this.comboBox9.TabIndex = 4;
            this.comboBox9.Text = "Tesis";
            // 
            // comboBox10
            // 
            this.comboBox10.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox10.Enabled = false;
            this.comboBox10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.comboBox10.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(8, 8);
            this.comboBox10.Margin = new System.Windows.Forms.Padding(8);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(184, 23);
            this.comboBox10.TabIndex = 3;
            this.comboBox10.Text = "Şeflik";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.textBox3, 0, 1);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel11.MaximumSize = new System.Drawing.Size(194, 142);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(194, 100);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(8, 28);
            this.textBox3.Margin = new System.Windows.Forms.Padding(8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(178, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Çocuk Sayısı";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel17, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(43, 26);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1178, 482);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonSearchFooter, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 26, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 456);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ButtonSearchFooter
            // 
            this.ButtonSearchFooter.BackColor = System.Drawing.Color.Brown;
            this.ButtonSearchFooter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearchFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonSearchFooter.FlatAppearance.BorderSize = 0;
            this.ButtonSearchFooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchFooter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonSearchFooter.ForeColor = System.Drawing.Color.White;
            this.ButtonSearchFooter.Location = new System.Drawing.Point(3, 424);
            this.ButtonSearchFooter.Name = "ButtonSearchFooter";
            this.ButtonSearchFooter.Size = new System.Drawing.Size(229, 29);
            this.ButtonSearchFooter.TabIndex = 1;
            this.ButtonSearchFooter.Text = "Ara";
            this.ButtonSearchFooter.UseVisualStyleBackColor = false;
            this.ButtonSearchFooter.Click += new System.EventHandler(this.ButtonSearchFooter_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel6);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel8);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel7);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel13);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel14);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel15);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel16);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel19);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel12);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel21);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel22);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel24);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(229, 415);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ComboBoxTesisFilter, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.ComboBoxSeflikFilter, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ComboBoxMudurlukFilter, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(211, 123);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ComboBoxTesisFilter
            // 
            this.ComboBoxTesisFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxTesisFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTesisFilter.Enabled = false;
            this.ComboBoxTesisFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComboBoxTesisFilter.FormattingEnabled = true;
            this.ComboBoxTesisFilter.Location = new System.Drawing.Point(7, 97);
            this.ComboBoxTesisFilter.Margin = new System.Windows.Forms.Padding(7);
            this.ComboBoxTesisFilter.Name = "ComboBoxTesisFilter";
            this.ComboBoxTesisFilter.Size = new System.Drawing.Size(197, 23);
            this.ComboBoxTesisFilter.TabIndex = 4;
            // 
            // ComboBoxSeflikFilter
            // 
            this.ComboBoxSeflikFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxSeflikFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSeflikFilter.Enabled = false;
            this.ComboBoxSeflikFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComboBoxSeflikFilter.FormattingEnabled = true;
            this.ComboBoxSeflikFilter.Location = new System.Drawing.Point(7, 67);
            this.ComboBoxSeflikFilter.Margin = new System.Windows.Forms.Padding(7);
            this.ComboBoxSeflikFilter.Name = "ComboBoxSeflikFilter";
            this.ComboBoxSeflikFilter.Size = new System.Drawing.Size(197, 23);
            this.ComboBoxSeflikFilter.TabIndex = 3;
            this.ComboBoxSeflikFilter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSeflikFilter_SelectedIndexChanged);
            // 
            // ComboBoxMudurlukFilter
            // 
            this.ComboBoxMudurlukFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxMudurlukFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMudurlukFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComboBoxMudurlukFilter.FormattingEnabled = true;
            this.ComboBoxMudurlukFilter.Location = new System.Drawing.Point(7, 37);
            this.ComboBoxMudurlukFilter.Margin = new System.Windows.Forms.Padding(7);
            this.ComboBoxMudurlukFilter.Name = "ComboBoxMudurlukFilter";
            this.ComboBoxMudurlukFilter.Size = new System.Drawing.Size(197, 23);
            this.ComboBoxMudurlukFilter.TabIndex = 2;
            this.ComboBoxMudurlukFilter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMudurlukFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Birim";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.ComboBoxPozisyon, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.ComboBoxUnvanGrubu, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 126);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(211, 95);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // ComboBoxPozisyon
            // 
            this.ComboBoxPozisyon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxPozisyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPozisyon.Enabled = false;
            this.ComboBoxPozisyon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComboBoxPozisyon.FormattingEnabled = true;
            this.ComboBoxPozisyon.Location = new System.Drawing.Point(7, 67);
            this.ComboBoxPozisyon.Margin = new System.Windows.Forms.Padding(7);
            this.ComboBoxPozisyon.Name = "ComboBoxPozisyon";
            this.ComboBoxPozisyon.Size = new System.Drawing.Size(197, 23);
            this.ComboBoxPozisyon.TabIndex = 3;
            // 
            // ComboBoxUnvanGrubu
            // 
            this.ComboBoxUnvanGrubu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxUnvanGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxUnvanGrubu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComboBoxUnvanGrubu.FormattingEnabled = true;
            this.ComboBoxUnvanGrubu.Location = new System.Drawing.Point(7, 37);
            this.ComboBoxUnvanGrubu.Margin = new System.Windows.Forms.Padding(7);
            this.ComboBoxUnvanGrubu.Name = "ComboBoxUnvanGrubu";
            this.ComboBoxUnvanGrubu.Size = new System.Drawing.Size(197, 23);
            this.ComboBoxUnvanGrubu.TabIndex = 2;
            this.ComboBoxUnvanGrubu.SelectedIndexChanged += new System.EventHandler(this.ComboBoxUnvanGrubu_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Görev";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.ComboBoxKanGrubu, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 224);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(211, 62);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // ComboBoxKanGrubu
            // 
            this.ComboBoxKanGrubu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxKanGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxKanGrubu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComboBoxKanGrubu.Items.AddRange(new object[] {
            "A Rh (+)",
            "A Rh (-)",
            "B Rh (+)",
            "B Rh (-)",
            "AB Rh (+)",
            "AB Rh (-)",
            "0 Rh (+)",
            "0 Rh (-)"});
            this.ComboBoxKanGrubu.Location = new System.Drawing.Point(7, 37);
            this.ComboBoxKanGrubu.Margin = new System.Windows.Forms.Padding(7);
            this.ComboBoxKanGrubu.Name = "ComboBoxKanGrubu";
            this.ComboBoxKanGrubu.Size = new System.Drawing.Size(197, 23);
            this.ComboBoxKanGrubu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kan Grubu";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.RadioButtonMale, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.RadioButtonFemale, 0, 2);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 289);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(211, 83);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cinsiyet";
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.RadioButtonMale.Location = new System.Drawing.Point(7, 33);
            this.RadioButtonMale.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(58, 19);
            this.RadioButtonMale.TabIndex = 3;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "ERKEK";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.RadioButtonFemale.Location = new System.Drawing.Point(7, 60);
            this.RadioButtonFemale.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(62, 19);
            this.RadioButtonFemale.TabIndex = 3;
            this.RadioButtonFemale.TabStop = true;
            this.RadioButtonFemale.Text = "KADIN";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 375);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(211, 67);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Yaş Aralığı";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel9.Controls.Add(this.TextBoxMaxAge, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.TextBoxMinAge, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(211, 35);
            this.tableLayoutPanel9.TabIndex = 3;
            // 
            // TextBoxMaxAge
            // 
            this.TextBoxMaxAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxMaxAge.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TextBoxMaxAge.Location = new System.Drawing.Point(95, 7);
            this.TextBoxMaxAge.Margin = new System.Windows.Forms.Padding(7);
            this.TextBoxMaxAge.Name = "TextBoxMaxAge";
            this.TextBoxMaxAge.Size = new System.Drawing.Size(59, 23);
            this.TextBoxMaxAge.TabIndex = 5;
            // 
            // TextBoxMinAge
            // 
            this.TextBoxMinAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxMinAge.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TextBoxMinAge.Location = new System.Drawing.Point(7, 7);
            this.TextBoxMinAge.Margin = new System.Windows.Forms.Padding(7);
            this.TextBoxMinAge.Name = "TextBoxMinAge";
            this.TextBoxMinAge.Size = new System.Drawing.Size(59, 23);
            this.TextBoxMinAge.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(76, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(9, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "-";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.RadioButtonMarried, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.RadioButtonSingle, 0, 2);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(0, 445);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 3;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(211, 82);
            this.tableLayoutPanel13.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(7, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Medeni Hal";
            // 
            // RadioButtonMarried
            // 
            this.RadioButtonMarried.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadioButtonMarried.AutoSize = true;
            this.RadioButtonMarried.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.RadioButtonMarried.Location = new System.Drawing.Point(7, 33);
            this.RadioButtonMarried.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.RadioButtonMarried.Name = "RadioButtonMarried";
            this.RadioButtonMarried.Size = new System.Drawing.Size(49, 19);
            this.RadioButtonMarried.TabIndex = 3;
            this.RadioButtonMarried.TabStop = true;
            this.RadioButtonMarried.Text = "EVLİ";
            this.RadioButtonMarried.UseVisualStyleBackColor = true;
            // 
            // RadioButtonSingle
            // 
            this.RadioButtonSingle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadioButtonSingle.AutoSize = true;
            this.RadioButtonSingle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.RadioButtonSingle.Location = new System.Drawing.Point(7, 59);
            this.RadioButtonSingle.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.RadioButtonSingle.Name = "RadioButtonSingle";
            this.RadioButtonSingle.Size = new System.Drawing.Size(60, 19);
            this.RadioButtonSingle.TabIndex = 3;
            this.RadioButtonSingle.TabStop = true;
            this.RadioButtonSingle.Text = "BEKAR";
            this.RadioButtonSingle.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.RadioButtonSpouseWorking, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.RadioButtonSpouseNotWorking, 0, 2);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(0, 530);
            this.tableLayoutPanel14.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 3;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(211, 85);
            this.tableLayoutPanel14.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(7, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Eş Çalışıyor Mu?";
            // 
            // RadioButtonSpouseWorking
            // 
            this.RadioButtonSpouseWorking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadioButtonSpouseWorking.AutoSize = true;
            this.RadioButtonSpouseWorking.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.RadioButtonSpouseWorking.Location = new System.Drawing.Point(7, 35);
            this.RadioButtonSpouseWorking.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.RadioButtonSpouseWorking.Name = "RadioButtonSpouseWorking";
            this.RadioButtonSpouseWorking.Size = new System.Drawing.Size(84, 18);
            this.RadioButtonSpouseWorking.TabIndex = 3;
            this.RadioButtonSpouseWorking.TabStop = true;
            this.RadioButtonSpouseWorking.Text = "ÇALIŞIYOR";
            this.RadioButtonSpouseWorking.UseVisualStyleBackColor = true;
            // 
            // RadioButtonSpouseNotWorking
            // 
            this.RadioButtonSpouseNotWorking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RadioButtonSpouseNotWorking.AutoSize = true;
            this.RadioButtonSpouseNotWorking.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.RadioButtonSpouseNotWorking.Location = new System.Drawing.Point(7, 61);
            this.RadioButtonSpouseNotWorking.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.RadioButtonSpouseNotWorking.Name = "RadioButtonSpouseNotWorking";
            this.RadioButtonSpouseNotWorking.Size = new System.Drawing.Size(95, 19);
            this.RadioButtonSpouseNotWorking.TabIndex = 3;
            this.RadioButtonSpouseNotWorking.TabStop = true;
            this.RadioButtonSpouseNotWorking.Text = "ÇALIŞMIYOR";
            this.RadioButtonSpouseNotWorking.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel20, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel15.Location = new System.Drawing.Point(0, 618);
            this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 2;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(211, 67);
            this.tableLayoutPanel15.TabIndex = 7;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 4;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel20.Controls.Add(this.TextBoxMaxKid, 2, 0);
            this.tableLayoutPanel20.Controls.Add(this.TextBoxMinKid, 0, 0);
            this.tableLayoutPanel20.Controls.Add(this.label15, 1, 0);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel20.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 1;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(211, 35);
            this.tableLayoutPanel20.TabIndex = 4;
            // 
            // TextBoxMaxKid
            // 
            this.TextBoxMaxKid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxMaxKid.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TextBoxMaxKid.Location = new System.Drawing.Point(95, 7);
            this.TextBoxMaxKid.Margin = new System.Windows.Forms.Padding(7);
            this.TextBoxMaxKid.Name = "TextBoxMaxKid";
            this.TextBoxMaxKid.Size = new System.Drawing.Size(59, 23);
            this.TextBoxMaxKid.TabIndex = 5;
            // 
            // TextBoxMinKid
            // 
            this.TextBoxMinKid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxMinKid.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TextBoxMinKid.Location = new System.Drawing.Point(7, 7);
            this.TextBoxMinKid.Margin = new System.Windows.Forms.Padding(7);
            this.TextBoxMinKid.Name = "TextBoxMinKid";
            this.TextBoxMinKid.Size = new System.Drawing.Size(59, 23);
            this.TextBoxMinKid.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(76, 3);
            this.label15.Margin = new System.Windows.Forms.Padding(3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(9, 29);
            this.label15.TabIndex = 6;
            this.label15.Text = "-";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(7, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Çocuk Sayısı";
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Controls.Add(this.ComboBoxHomeTownCity, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel16.Location = new System.Drawing.Point(0, 688);
            this.tableLayoutPanel16.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(211, 69);
            this.tableLayoutPanel16.TabIndex = 8;
            // 
            // ComboBoxHomeTownCity
            // 
            this.ComboBoxHomeTownCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxHomeTownCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxHomeTownCity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComboBoxHomeTownCity.FormattingEnabled = true;
            this.ComboBoxHomeTownCity.Location = new System.Drawing.Point(7, 37);
            this.ComboBoxHomeTownCity.Margin = new System.Windows.Forms.Padding(7);
            this.ComboBoxHomeTownCity.Name = "ComboBoxHomeTownCity";
            this.ComboBoxHomeTownCity.Size = new System.Drawing.Size(197, 23);
            this.ComboBoxHomeTownCity.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(7, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Memleket";
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel19.ColumnCount = 1;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.Controls.Add(this.ComboBoxDistricts, 0, 2);
            this.tableLayoutPanel19.Controls.Add(this.ComboBoxCities, 0, 1);
            this.tableLayoutPanel19.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel19.Location = new System.Drawing.Point(0, 760);
            this.tableLayoutPanel19.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 3;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(211, 95);
            this.tableLayoutPanel19.TabIndex = 9;
            // 
            // ComboBoxDistricts
            // 
            this.ComboBoxDistricts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxDistricts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDistricts.Enabled = false;
            this.ComboBoxDistricts.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComboBoxDistricts.FormattingEnabled = true;
            this.ComboBoxDistricts.Location = new System.Drawing.Point(7, 67);
            this.ComboBoxDistricts.Margin = new System.Windows.Forms.Padding(7);
            this.ComboBoxDistricts.Name = "ComboBoxDistricts";
            this.ComboBoxDistricts.Size = new System.Drawing.Size(197, 23);
            this.ComboBoxDistricts.TabIndex = 3;
            // 
            // ComboBoxCities
            // 
            this.ComboBoxCities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCities.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComboBoxCities.FormattingEnabled = true;
            this.ComboBoxCities.Location = new System.Drawing.Point(7, 37);
            this.ComboBoxCities.Margin = new System.Windows.Forms.Padding(7);
            this.ComboBoxCities.Name = "ComboBoxCities";
            this.ComboBoxCities.Size = new System.Drawing.Size(197, 23);
            this.ComboBoxCities.TabIndex = 2;
            this.ComboBoxCities.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCities_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(7, 7);
            this.label16.Margin = new System.Windows.Forms.Padding(7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "İkamet";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.CheckBoxLise, 0, 4);
            this.tableLayoutPanel12.Controls.Add(this.CheckBoxYuksekLisans, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.CheckBoxLisans, 0, 2);
            this.tableLayoutPanel12.Controls.Add(this.CheckBoxOnLisans, 0, 3);
            this.tableLayoutPanel12.Controls.Add(this.CheckBoxOrtaokul, 0, 5);
            this.tableLayoutPanel12.Controls.Add(this.CheckBoxIlkokul, 0, 6);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(0, 858);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 7;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(211, 188);
            this.tableLayoutPanel12.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(7, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tahsil";
            // 
            // CheckBoxLise
            // 
            this.CheckBoxLise.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckBoxLise.AutoSize = true;
            this.CheckBoxLise.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.CheckBoxLise.Location = new System.Drawing.Point(7, 111);
            this.CheckBoxLise.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.CheckBoxLise.Name = "CheckBoxLise";
            this.CheckBoxLise.Size = new System.Drawing.Size(46, 19);
            this.CheckBoxLise.TabIndex = 3;
            this.CheckBoxLise.Text = "Lise";
            this.CheckBoxLise.UseVisualStyleBackColor = true;
            // 
            // CheckBoxYuksekLisans
            // 
            this.CheckBoxYuksekLisans.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckBoxYuksekLisans.AutoSize = true;
            this.CheckBoxYuksekLisans.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.CheckBoxYuksekLisans.Location = new System.Drawing.Point(7, 33);
            this.CheckBoxYuksekLisans.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.CheckBoxYuksekLisans.Name = "CheckBoxYuksekLisans";
            this.CheckBoxYuksekLisans.Size = new System.Drawing.Size(85, 19);
            this.CheckBoxYuksekLisans.TabIndex = 3;
            this.CheckBoxYuksekLisans.Text = "Lisans Üstü";
            this.CheckBoxYuksekLisans.UseVisualStyleBackColor = true;
            // 
            // CheckBoxLisans
            // 
            this.CheckBoxLisans.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckBoxLisans.AutoSize = true;
            this.CheckBoxLisans.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.CheckBoxLisans.Location = new System.Drawing.Point(7, 59);
            this.CheckBoxLisans.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.CheckBoxLisans.Name = "CheckBoxLisans";
            this.CheckBoxLisans.Size = new System.Drawing.Size(58, 19);
            this.CheckBoxLisans.TabIndex = 3;
            this.CheckBoxLisans.Text = "Lisans";
            this.CheckBoxLisans.UseVisualStyleBackColor = true;
            // 
            // CheckBoxOnLisans
            // 
            this.CheckBoxOnLisans.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckBoxOnLisans.AutoSize = true;
            this.CheckBoxOnLisans.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.CheckBoxOnLisans.Location = new System.Drawing.Point(7, 85);
            this.CheckBoxOnLisans.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.CheckBoxOnLisans.Name = "CheckBoxOnLisans";
            this.CheckBoxOnLisans.Size = new System.Drawing.Size(77, 19);
            this.CheckBoxOnLisans.TabIndex = 3;
            this.CheckBoxOnLisans.Text = "Ön Lisans";
            this.CheckBoxOnLisans.UseVisualStyleBackColor = true;
            // 
            // CheckBoxOrtaokul
            // 
            this.CheckBoxOrtaokul.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckBoxOrtaokul.AutoSize = true;
            this.CheckBoxOrtaokul.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.CheckBoxOrtaokul.Location = new System.Drawing.Point(7, 137);
            this.CheckBoxOrtaokul.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.CheckBoxOrtaokul.Name = "CheckBoxOrtaokul";
            this.CheckBoxOrtaokul.Size = new System.Drawing.Size(72, 19);
            this.CheckBoxOrtaokul.TabIndex = 3;
            this.CheckBoxOrtaokul.Text = "Ortaokul";
            this.CheckBoxOrtaokul.UseVisualStyleBackColor = true;
            // 
            // CheckBoxIlkokul
            // 
            this.CheckBoxIlkokul.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckBoxIlkokul.AutoSize = true;
            this.CheckBoxIlkokul.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.CheckBoxIlkokul.Location = new System.Drawing.Point(7, 164);
            this.CheckBoxIlkokul.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.CheckBoxIlkokul.Name = "CheckBoxIlkokul";
            this.CheckBoxIlkokul.Size = new System.Drawing.Size(62, 19);
            this.CheckBoxIlkokul.TabIndex = 3;
            this.CheckBoxIlkokul.Text = "İlkokul";
            this.CheckBoxIlkokul.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel21.ColumnCount = 1;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Controls.Add(this.ComboBoxEyt, 0, 1);
            this.tableLayoutPanel21.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel21.Location = new System.Drawing.Point(0, 1049);
            this.tableLayoutPanel21.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 2;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(211, 69);
            this.tableLayoutPanel21.TabIndex = 11;
            // 
            // ComboBoxEyt
            // 
            this.ComboBoxEyt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxEyt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEyt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ComboBoxEyt.FormattingEnabled = true;
            this.ComboBoxEyt.Items.AddRange(new object[] {
            "YOK",
            "HAK SAHİBİ",
            "EMEKLİ"});
            this.ComboBoxEyt.Location = new System.Drawing.Point(7, 37);
            this.ComboBoxEyt.Margin = new System.Windows.Forms.Padding(7);
            this.ComboBoxEyt.Name = "ComboBoxEyt";
            this.ComboBoxEyt.Size = new System.Drawing.Size(197, 23);
            this.ComboBoxEyt.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(7, 7);
            this.label17.Margin = new System.Windows.Forms.Padding(7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "Eyt Durumu";
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel22.ColumnCount = 1;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel22.Controls.Add(this.tableLayoutPanel23, 0, 1);
            this.tableLayoutPanel22.Location = new System.Drawing.Point(0, 1121);
            this.tableLayoutPanel22.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 2;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(211, 67);
            this.tableLayoutPanel22.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(7, 7);
            this.label18.Margin = new System.Windows.Forms.Padding(7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "Çalışma Yılı Aralığı";
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.ColumnCount = 4;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel23.Controls.Add(this.TextBoxMaxExpYear, 2, 0);
            this.tableLayoutPanel23.Controls.Add(this.TextBoxMinExpYear, 0, 0);
            this.tableLayoutPanel23.Controls.Add(this.label19, 1, 0);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel23.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 1;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(211, 35);
            this.tableLayoutPanel23.TabIndex = 3;
            // 
            // TextBoxMaxExpYear
            // 
            this.TextBoxMaxExpYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxMaxExpYear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TextBoxMaxExpYear.Location = new System.Drawing.Point(95, 7);
            this.TextBoxMaxExpYear.Margin = new System.Windows.Forms.Padding(7);
            this.TextBoxMaxExpYear.Name = "TextBoxMaxExpYear";
            this.TextBoxMaxExpYear.Size = new System.Drawing.Size(59, 23);
            this.TextBoxMaxExpYear.TabIndex = 5;
            // 
            // TextBoxMinExpYear
            // 
            this.TextBoxMinExpYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxMinExpYear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TextBoxMinExpYear.Location = new System.Drawing.Point(7, 7);
            this.TextBoxMinExpYear.Margin = new System.Windows.Forms.Padding(7);
            this.TextBoxMinExpYear.Name = "TextBoxMinExpYear";
            this.TextBoxMinExpYear.Size = new System.Drawing.Size(59, 23);
            this.TextBoxMinExpYear.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(76, 3);
            this.label19.Margin = new System.Windows.Forms.Padding(3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(9, 29);
            this.label19.TabIndex = 6;
            this.label19.Text = "-";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel24.ColumnCount = 1;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel24.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel24.Controls.Add(this.CheckBoxEskiCalisan, 0, 1);
            this.tableLayoutPanel24.Location = new System.Drawing.Point(0, 1191);
            this.tableLayoutPanel24.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 2;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(211, 62);
            this.tableLayoutPanel24.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Eski Çalışanları Göster";
            // 
            // CheckBoxEskiCalisan
            // 
            this.CheckBoxEskiCalisan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckBoxEskiCalisan.AutoSize = true;
            this.CheckBoxEskiCalisan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.CheckBoxEskiCalisan.Location = new System.Drawing.Point(7, 38);
            this.CheckBoxEskiCalisan.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.CheckBoxEskiCalisan.Name = "CheckBoxEskiCalisan";
            this.CheckBoxEskiCalisan.Size = new System.Drawing.Size(60, 19);
            this.CheckBoxEskiCalisan.TabIndex = 3;
            this.CheckBoxEskiCalisan.Text = "Göster";
            this.CheckBoxEskiCalisan.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Controls.Add(this.ButtonNewEmployee, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.tableLayoutPanel18, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.DataGridViewEmployees, 0, 3);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(244, 0);
            this.tableLayoutPanel17.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 4;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(934, 482);
            this.tableLayoutPanel17.TabIndex = 2;
            // 
            // ButtonNewEmployee
            // 
            this.ButtonNewEmployee.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonNewEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNewEmployee.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonNewEmployee.FlatAppearance.BorderSize = 0;
            this.ButtonNewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNewEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonNewEmployee.ForeColor = System.Drawing.Color.White;
            this.ButtonNewEmployee.Location = new System.Drawing.Point(733, 0);
            this.ButtonNewEmployee.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ButtonNewEmployee.Name = "ButtonNewEmployee";
            this.ButtonNewEmployee.Size = new System.Drawing.Size(201, 32);
            this.ButtonNewEmployee.TabIndex = 3;
            this.ButtonNewEmployee.Text = "Yeni Personel";
            this.ButtonNewEmployee.UseVisualStyleBackColor = false;
            this.ButtonNewEmployee.Click += new System.EventHandler(this.ButtonNewEmployee_Click);
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel18.ColumnCount = 5;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel18.Controls.Add(this.ButtonEditColumns, 2, 0);
            this.tableLayoutPanel18.Controls.Add(this.ComboBoxSort, 1, 0);
            this.tableLayoutPanel18.Controls.Add(this.TextBoxSmartFilter, 4, 0);
            this.tableLayoutPanel18.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.ButtonExportToExcel, 3, 0);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel18.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 1;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(934, 35);
            this.tableLayoutPanel18.TabIndex = 0;
            // 
            // ButtonEditColumns
            // 
            this.ButtonEditColumns.BackColor = System.Drawing.Color.Brown;
            this.ButtonEditColumns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEditColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonEditColumns.FlatAppearance.BorderSize = 0;
            this.ButtonEditColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditColumns.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonEditColumns.ForeColor = System.Drawing.Color.White;
            this.ButtonEditColumns.Location = new System.Drawing.Point(247, 3);
            this.ButtonEditColumns.Name = "ButtonEditColumns";
            this.ButtonEditColumns.Size = new System.Drawing.Size(180, 29);
            this.ButtonEditColumns.TabIndex = 7;
            this.ButtonEditColumns.Text = "Sütunları Düzenle";
            this.ButtonEditColumns.UseVisualStyleBackColor = false;
            this.ButtonEditColumns.Click += new System.EventHandler(this.ButtonEditColumns_Click);
            // 
            // ComboBoxSort
            // 
            this.ComboBoxSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ComboBoxSort.FormattingEnabled = true;
            this.ComboBoxSort.Items.AddRange(new object[] {
            "İsme Göre A-Z ↓",
            "İsme Göre Z-A ↓",
            "Girişe Göre Yeni ↓",
            "Girişe Göre Eski ↓",
            "Birime Göre A-Z ↓",
            "Birime Göre Z-A ↓"});
            this.ComboBoxSort.Location = new System.Drawing.Point(76, 5);
            this.ComboBoxSort.Margin = new System.Windows.Forms.Padding(5);
            this.ComboBoxSort.Name = "ComboBoxSort";
            this.ComboBoxSort.Size = new System.Drawing.Size(163, 25);
            this.ComboBoxSort.TabIndex = 5;
            this.ComboBoxSort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSort_SelectedIndexChanged);
            // 
            // TextBoxSmartFilter
            // 
            this.TextBoxSmartFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSmartFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.TextBoxSmartFilter.Location = new System.Drawing.Point(735, 5);
            this.TextBoxSmartFilter.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxSmartFilter.Name = "TextBoxSmartFilter";
            this.TextBoxSmartFilter.Size = new System.Drawing.Size(194, 25);
            this.TextBoxSmartFilter.TabIndex = 1;
            this.TextBoxSmartFilter.TextChanged += new System.EventHandler(this.TextBoxSmartFilter_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(21, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Sırala:";
            // 
            // ButtonExportToExcel
            // 
            this.ButtonExportToExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonExportToExcel.Location = new System.Drawing.Point(629, 3);
            this.ButtonExportToExcel.Name = "ButtonExportToExcel";
            this.ButtonExportToExcel.Size = new System.Drawing.Size(98, 29);
            this.ButtonExportToExcel.TabIndex = 6;
            this.ButtonExportToExcel.Text = "Excele Aktar";
            this.ButtonExportToExcel.UseVisualStyleBackColor = true;
            this.ButtonExportToExcel.Click += new System.EventHandler(this.ButtonExportToExcel_Click);
            // 
            // DataGridViewEmployees
            // 
            this.DataGridViewEmployees.AllowUserToAddRows = false;
            this.DataGridViewEmployees.AllowUserToDeleteRows = false;
            this.DataGridViewEmployees.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewEmployees.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditRow,
            this.EditShifts});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewEmployees.EnableHeadersVisualStyles = false;
            this.DataGridViewEmployees.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewEmployees.Location = new System.Drawing.Point(0, 78);
            this.DataGridViewEmployees.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewEmployees.MultiSelect = false;
            this.DataGridViewEmployees.Name = "DataGridViewEmployees";
            this.DataGridViewEmployees.ReadOnly = true;
            this.DataGridViewEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewEmployees.RowHeadersVisible = false;
            this.DataGridViewEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewEmployees.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewEmployees.RowTemplate.DividerHeight = 10;
            this.DataGridViewEmployees.RowTemplate.Height = 50;
            this.DataGridViewEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewEmployees.Size = new System.Drawing.Size(934, 404);
            this.DataGridViewEmployees.TabIndex = 1;
            this.DataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewEmployees_CellContentClick);
            // 
            // EditRow
            // 
            this.EditRow.Description = "Düzenle";
            this.EditRow.FillWeight = 35F;
            this.EditRow.HeaderText = "";
            this.EditRow.Image = global::IKYv4.Properties.Resources.edit_row_24px;
            this.EditRow.Name = "EditRow";
            this.EditRow.ReadOnly = true;
            this.EditRow.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditRow.ToolTipText = "Düzenle";
            // 
            // EditShifts
            // 
            this.EditShifts.Description = "Mesai Saatlerini Düzenle";
            this.EditShifts.FillWeight = 35F;
            this.EditShifts.HeaderText = "";
            this.EditShifts.Image = global::IKYv4.Properties.Resources.clock_24px;
            this.EditShifts.Name = "EditShifts";
            this.EditShifts.ReadOnly = true;
            this.EditShifts.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Description = "Düzenle";
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::IKYv4.Properties.Resources.edit_row_24px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.ToolTipText = "Düzenle";
            this.dataGridViewImageColumn1.Width = 492;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.Description = "Mesai Saatlerini Düzenle";
            this.dataGridViewImageColumn2.FillWeight = 30F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::IKYv4.Properties.Resources.clock_24px;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 491;
            // 
            // FormEmployeeListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 551);
            this.Controls.Add(this.tableLayoutPanel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployeeListing";
            this.Padding = new System.Windows.Forms.Padding(43, 26, 43, 43);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmployeeListing";
            this.Load += new System.EventHandler(this.FormEmployeeListing_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel22.PerformLayout();
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel23.PerformLayout();
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel24.PerformLayout();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private TableLayoutPanel tableLayoutPanel5;
        private ComboBox comboBox9;
        private ComboBox comboBox10;
        private TableLayoutPanel tableLayoutPanel11;
        private TextBox textBox3;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel1;
        private Button ButtonSearchFooter;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox ComboBoxTesisFilter;
        private ComboBox ComboBoxSeflikFilter;
        private ComboBox ComboBoxMudurlukFilter;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox ComboBoxPozisyon;
        private ComboBox ComboBoxUnvanGrubu;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel6;
        private ComboBox ComboBoxKanGrubu;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label5;
        private RadioButton RadioButtonMale;
        private RadioButton RadioButtonFemale;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel9;
        private TextBox TextBoxMaxAge;
        private TextBox TextBoxMinAge;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel13;
        private Label label10;
        private RadioButton RadioButtonMarried;
        private RadioButton RadioButtonSingle;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label11;
        private RadioButton RadioButtonSpouseWorking;
        private RadioButton RadioButtonSpouseNotWorking;
        private TableLayoutPanel tableLayoutPanel15;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel16;
        private ComboBox ComboBoxHomeTownCity;
        private Label label13;
        private TableLayoutPanel tableLayoutPanel19;
        private ComboBox ComboBoxDistricts;
        private ComboBox ComboBoxCities;
        private Label label16;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label9;
        private CheckBox CheckBoxLise;
        private CheckBox CheckBoxYuksekLisans;
        private CheckBox CheckBoxLisans;
        private CheckBox CheckBoxOnLisans;
        private CheckBox CheckBoxOrtaokul;
        private CheckBox CheckBoxIlkokul;
        private TableLayoutPanel tableLayoutPanel17;
        private DataGridView DataGridViewEmployees;
        private TableLayoutPanel tableLayoutPanel18;
        private ComboBox ComboBoxSort;
        private TextBox TextBoxSmartFilter;
        private Label label14;
        private Button ButtonNewEmployee;
        private DataGridViewImageColumn EditRow;
        private DataGridViewImageColumn EditShifts;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private TableLayoutPanel tableLayoutPanel20;
        private TextBox TextBoxMaxKid;
        private TextBox TextBoxMinKid;
        private Label label15;
        private TableLayoutPanel tableLayoutPanel21;
        private ComboBox ComboBoxEyt;
        private Label label17;
        private TableLayoutPanel tableLayoutPanel22;
        private Label label18;
        private TableLayoutPanel tableLayoutPanel23;
        private TextBox TextBoxMaxExpYear;
        private TextBox TextBoxMinExpYear;
        private Label label19;
        private TableLayoutPanel tableLayoutPanel24;
        private Label label7;
        private CheckBox CheckBoxEskiCalisan;
        private Button ButtonExportToExcel;
        private Button ButtonEditColumns;
    }
}