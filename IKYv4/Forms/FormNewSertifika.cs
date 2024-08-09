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

        public FormNewSertifika(ISertifikaManager sertifikaManager, int personelId)
        {
            _sertifikaManager = sertifikaManager;
            _personelId = personelId;

            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Sertifika sertifika = new Sertifika
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