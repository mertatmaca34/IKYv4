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

        public FormNewTahsil(ITahsilManager tahsilManager, int personelId)
        {
            _tahsilManager = tahsilManager;
            _personelId = personelId;
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Tahsil tahsil = new Tahsil()
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
