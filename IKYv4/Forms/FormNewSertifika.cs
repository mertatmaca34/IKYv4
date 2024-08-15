using Business.Abstract;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormNewSertifika : Form
    {
        ISertifikaManager _sertifikaManager;
        public int _personelId;
        readonly Sertifika _sertifika;

        public FormNewSertifika(ISertifikaManager sertifikaManager, int personelId)
        {
            _sertifikaManager = sertifikaManager;
            _personelId = personelId;

            InitializeComponent();
        }
        public FormNewSertifika(ISertifikaManager sertifikaManager, Sertifika sertifika)
        {
            _sertifikaManager = sertifikaManager;
            _sertifika = sertifika;

            InitializeComponent();

            TextBoxSertifika.Text = sertifika.SertifikaAdi;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Sertifika sertifika = _sertifika != null
                ? new Sertifika()
                {
                    Id = _sertifika.Id,
                    PersonelId = _sertifika.PersonelId,
                    SertifikaAdi = TextBoxSertifika.Text
                }
                : new Sertifika()
                {
                    PersonelId = _personelId,
                    SertifikaAdi = TextBoxSertifika.Text
                };

            var res = _sertifikaManager.Add(sertifika);

            MessageBox.Show(res.Message);

            this.Close();
        }
    }
}