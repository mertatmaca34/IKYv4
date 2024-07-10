using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
    public partial class FormEmployeeChoose : Form
    {
        public Personel SeciliPersonel { get; set; }

        readonly IPersonelManager _personelManager;

        public FormEmployeeChoose(IPersonelManager personelManager)
        {
            InitializeComponent();

            _personelManager = personelManager;
        }

        private void FormEmployeeChoose_Load(object sender, EventArgs e)
        {
            DataGridViewEmployees.DataSource = _personelManager.GetAll().Data;

            DataGridViewCustomization();
        }

        private void DataGridViewEmployees_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = DataGridViewEmployees.SelectedRows[0];

            int id = (int)row.Cells[0].Value;

            var getEmployeeData = _personelManager.GetAll(x => x.Id == id).Data.FirstOrDefault();

            if (getEmployeeData != null)
            {
                SeciliPersonel = getEmployeeData;
            }

            this.Close();
        }

        private void DataGridViewCustomization()
        {
            DataGridViewEmployees.DataSource = _personelManager.GetAll().Data.ToList();
            DataGridViewEmployees.Refresh();

            DataGridViewEmployees.Columns[0].Visible = false;
            DataGridViewEmployees.Columns[10].Visible = false;
            DataGridViewEmployees.Columns[12].Visible = false;
            DataGridViewEmployees.Columns[13].Visible = false;
            DataGridViewEmployees.Columns[15].Visible = false;
            DataGridViewEmployees.Columns[16].Visible = false;

            (DataGridViewEmployees.Columns[1] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewEmployees.Columns[1].HeaderText = "Fotoğraf";
            DataGridViewEmployees.Columns[2].HeaderText = "TC Kimlik No";
            DataGridViewEmployees.Columns[3].HeaderText = "Sicil No";
            DataGridViewEmployees.Columns[4].HeaderText = "Adı";
            DataGridViewEmployees.Columns[5].HeaderText = "Soyadı";
            DataGridViewEmployees.Columns[6].HeaderText = "İşe Giriş Tarihi";
            DataGridViewEmployees.Columns[7].HeaderText = "Müdürlük";
            DataGridViewEmployees.Columns[8].HeaderText = "Şeflik";
            DataGridViewEmployees.Columns[9].HeaderText = "Görev Yeri";
            DataGridViewEmployees.Columns[10].HeaderText = "Ünvanı";
            DataGridViewEmployees.Columns[11].HeaderText = "Pozisyonu";
            DataGridViewEmployees.Columns[12].HeaderText = "Maaş Katsayısı";
            DataGridViewEmployees.Columns[13].HeaderText = "Prim Katsayısı";
            DataGridViewEmployees.Columns[14].HeaderText = "Toplam Katsayısı";
            DataGridViewEmployees.Columns[15].HeaderText = "Çalışma Durumu";
            DataGridViewEmployees.Columns[16].HeaderText = "Yıllık İzin Sayısı";
        }
    }
}
