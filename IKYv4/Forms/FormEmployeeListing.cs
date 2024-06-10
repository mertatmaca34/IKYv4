﻿using Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormEmployeeListing : Form
    {
        IPersonelManager _personelManager;
        IMudurlukManager _mudurlukManager;
        ISeflikManager _seflikManager;
        ITesisManager _tesisManager;

        public FormEmployeeListing(IPersonelManager personelManager, IMudurlukManager mudurlukManager, ISeflikManager seflikManager, ITesisManager tesisManager)
        {
            InitializeComponent();

            _personelManager = personelManager;
            _mudurlukManager = mudurlukManager;
            _seflikManager = seflikManager;
            _tesisManager = tesisManager;

            DataGridViewCustomization();
        }

        private void ButtonNewEmployee_Click(object sender, EventArgs e)
        {
            FormEmployeeRegistrationCard formEmployeeRegistrationCard = new FormEmployeeRegistrationCard(_personelManager, _mudurlukManager, _seflikManager, _tesisManager);

            formEmployeeRegistrationCard.ShowDialog();

            DataGridViewCustomization();
        }

        private void DataGridViewCustomization()
        {
            DataGridViewEmployees.DataSource = _personelManager.GetAll().Data.ToList();
            DataGridViewEmployees.Refresh();

            DataGridViewEmployees.Columns[1].Visible = false;

            (DataGridViewEmployees.Columns[2] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewEmployees.Columns[2].HeaderText = "Fotoğraf";
            DataGridViewEmployees.Columns[3].HeaderText = "TC Kimlik No";
            DataGridViewEmployees.Columns[4].HeaderText = "Adı";
            DataGridViewEmployees.Columns[5].HeaderText = "Soyadı";
            DataGridViewEmployees.Columns[6].HeaderText = "İşe Giriş Tarihi";
            DataGridViewEmployees.Columns[7].HeaderText = "Müdürlük";
            DataGridViewEmployees.Columns[8].HeaderText = "Şeflik";
            DataGridViewEmployees.Columns[9].HeaderText = "Görev Yeri";
            DataGridViewEmployees.Columns[10].HeaderText = "Pozisyon";
            DataGridViewEmployees.Columns[11].HeaderText = "Maaş Katsayısı";
            DataGridViewEmployees.Columns[12].HeaderText = "Prim Katsayısı";
            DataGridViewEmployees.Columns[13].HeaderText = "Toplam Katsayısı";
            DataGridViewEmployees.Columns[14].HeaderText = "Çalışma Durumu";
        }
    }
}
