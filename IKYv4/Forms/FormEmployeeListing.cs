using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormEmployeeListing : Form
    {
        public Personel ChoosedPersonel { get; set; }

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

            DataGridViewEmployees.Columns[2].Visible = false;

            (DataGridViewEmployees.Columns[3] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewEmployees.Columns[3].HeaderText = "Fotoğraf";
            DataGridViewEmployees.Columns[4].HeaderText = "TC Kimlik No";
            DataGridViewEmployees.Columns[5].HeaderText = "Adı";
            DataGridViewEmployees.Columns[6].HeaderText = "Soyadı";
            DataGridViewEmployees.Columns[7].HeaderText = "Müdürlük";
            DataGridViewEmployees.Columns[8].HeaderText = "Şeflik";
            DataGridViewEmployees.Columns[9].HeaderText = "Görev Yeri";
            DataGridViewEmployees.Columns[10].HeaderText = "Pozisyon";
            DataGridViewEmployees.Columns[11].HeaderText = "Maaş Katsayısı";
            DataGridViewEmployees.Columns[12].HeaderText = "Prim Katsayısı";
            DataGridViewEmployees.Columns[13].HeaderText = "Toplam Katsayısı";
            DataGridViewEmployees.Columns[14].HeaderText = "Çalışma Durumu";
            DataGridViewEmployees.Columns[15].HeaderText = "İşe Giriş Tarihi";
        }

        private void DataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var row = DataGridViewEmployees.Rows[e.RowIndex];

                int selectedPersonelId = Convert.ToInt16(row.Cells[2].Value);

                var selectedPersonel = _personelManager.GetAll(p => p.Id == selectedPersonelId).Data.FirstOrDefault();

                FormEmployeeRegistrationCard formEmployeeRegistrationCard = new FormEmployeeRegistrationCard(_personelManager, _mudurlukManager, _seflikManager, _tesisManager);

                formEmployeeRegistrationCard.TextBoxName.Text = selectedPersonel.Adi;
                formEmployeeRegistrationCard.TextBoxSurname.Text = selectedPersonel.Soyadi;
                formEmployeeRegistrationCard.TextBoxUserId.Text = selectedPersonel.TCKimlikNo;
                formEmployeeRegistrationCard.TextBoxSicilNo.Text = selectedPersonel.SicilNo;
                formEmployeeRegistrationCard.DateTimePickerStartDate.Value = selectedPersonel.IseGirisTarihi;
                formEmployeeRegistrationCard.ComboBoxDirectorate.Text = selectedPersonel.Mudurluk;
                formEmployeeRegistrationCard.ComboBoxConducting.Text = selectedPersonel.Seflik;
                formEmployeeRegistrationCard.ComboBoxDutyStation.Text = selectedPersonel.GorevYeri;
                formEmployeeRegistrationCard.ComboBoxTitle.Text = selectedPersonel.Unvani;
                formEmployeeRegistrationCard.ComboBoxPosition.Text = selectedPersonel.Pozisyonu;
                formEmployeeRegistrationCard.TextBoxMk.Text = selectedPersonel.MK.ToString();
                formEmployeeRegistrationCard.TextBoxPk.Text = selectedPersonel.PK.ToString();
                formEmployeeRegistrationCard.TextBoxTotalK.Text = selectedPersonel.ToplamKatsayi.ToString();

                Bitmap bmp;

                if(selectedPersonel.ImageData != null)
                {
                    using (var ms = new MemoryStream(selectedPersonel.ImageData))
                    {
                        bmp = new Bitmap(ms);
                    }

                    formEmployeeRegistrationCard.PictureBoxEmployeePicture.Image = bmp;
                }

                formEmployeeRegistrationCard.ShowDialog();
            }

            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                var row = DataGridViewEmployees.Rows[e.RowIndex];

                int selectedPersonelId = Convert.ToInt16(row.Cells[2].Value);

                var selectedPersonel = _personelManager.GetAll(p => p.Id == selectedPersonelId).Data.FirstOrDefault();

                FormEmployeeRegistrationCard formEmployeeRegistrationCard = new FormEmployeeRegistrationCard(_personelManager, _mudurlukManager, _seflikManager, _tesisManager);

                formEmployeeRegistrationCard.TextBoxName.Text = selectedPersonel.Adi;
                formEmployeeRegistrationCard.TextBoxSurname.Text = selectedPersonel.Soyadi;
                formEmployeeRegistrationCard.TextBoxUserId.Text = selectedPersonel.TCKimlikNo;
                formEmployeeRegistrationCard.TextBoxSicilNo.Text = selectedPersonel.SicilNo;
                formEmployeeRegistrationCard.DateTimePickerStartDate.Value = selectedPersonel.IseGirisTarihi;
                formEmployeeRegistrationCard.ComboBoxDirectorate.Text = selectedPersonel.Mudurluk;
                formEmployeeRegistrationCard.ComboBoxConducting.Text = selectedPersonel.Seflik;
                formEmployeeRegistrationCard.ComboBoxDutyStation.Text = selectedPersonel.GorevYeri;
                formEmployeeRegistrationCard.ComboBoxTitle.Text = selectedPersonel.Unvani;
                formEmployeeRegistrationCard.ComboBoxPosition.Text = selectedPersonel.Pozisyonu;
                formEmployeeRegistrationCard.TextBoxMk.Text = selectedPersonel.MK.ToString();
                formEmployeeRegistrationCard.TextBoxPk.Text = selectedPersonel.PK.ToString();
                formEmployeeRegistrationCard.TextBoxTotalK.Text = selectedPersonel.ToplamKatsayi.ToString();

                Bitmap bmp;

                if(selectedPersonel.ImageData != null)
                {
                    using (var ms = new MemoryStream(selectedPersonel.ImageData))
                    {
                        bmp = new Bitmap(ms);
                    }

                    formEmployeeRegistrationCard.PictureBoxEmployeePicture.Image = bmp;
                }

                formEmployeeRegistrationCard.ShowDialog();
            }
        }
    }
}
