using Business.Abstract;
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
    public partial class FormNewTahsil : Form
    {
        private readonly ITahsilManager _tahsilManager;
        public int _personelId;
        Tahsil _tahsil;

        public FormNewTahsil(ITahsilManager tahsilManager, int personelId)
        {
            _tahsilManager = tahsilManager;
            _personelId = personelId;

            InitializeComponent();
        }

        public FormNewTahsil(ITahsilManager tahsilManager, Tahsil tahsil)
        {
            _tahsilManager = tahsilManager;
            _tahsil = tahsil;

            InitializeComponent();

            ComboBoxTahsilTuru.Text = tahsil.TahsilTuru;
            TextBoxSchoolName.Text = tahsil.OkulAdi;
            TextBoxDepartmentName.Text = tahsil.BolumAdi;
            DateTimePickerGraduationTime.Value = tahsil.MezuniyetTarihi;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Tahsil tahsil = _tahsil != null
                ? new Tahsil
                {
                    Id = _tahsil.Id,
                    PersonelId = _tahsil.PersonelId,
                    TahsilTuru = ComboBoxTahsilTuru.Text,
                    OkulAdi = TextBoxSchoolName.Text,
                    BolumAdi = TextBoxDepartmentName.Text,
                    MezuniyetTarihi = DateTimePickerGraduationTime.Value
                }
                : new Tahsil()
                {
                    PersonelId = _personelId,
                    TahsilTuru = ComboBoxTahsilTuru.Text,
                    OkulAdi = TextBoxSchoolName.Text,
                    BolumAdi = TextBoxDepartmentName.Text,
                    MezuniyetTarihi = DateTimePickerGraduationTime.Value
                };

            var res = _tahsilManager.Add(tahsil);

            MessageBox.Show(res.Message);

            this.Close();
        }
    }
}
