using Business.Abstract;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormNewNakil : Form
    {
        readonly INakilManager _nakilManager;
        public int _personelId;
        Nakil _nakil;

        public FormNewNakil(INakilManager nakilManager, int personelId)
        {
            _nakilManager = nakilManager;
            _personelId = personelId;

            InitializeComponent();
        }

        public FormNewNakil(INakilManager nakilManager, Nakil nakil)
        {
            _nakilManager = nakilManager;
            _nakil = nakil;

            InitializeComponent();

            TextBoxKurumAdi.Text = nakil.KurumAdi;
            TextBoxBirim.Text = nakil.BirimAdi;
            TextBoxGorev.Text = nakil.Gorev;
            DateTimePickerStartDate.Value = nakil.BaslangicTarihi;
            DateTimePickerTerminationTime.Value = nakil.AyrilisTarihi;
            TextBoxDescription.Text = nakil.Aciklama;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Nakil nakil = _nakil != null
                ? new Nakil
                {
                    Id = _nakil.Id,
                    PersonelId = _nakil.PersonelId,
                    KurumAdi = TextBoxKurumAdi.Text,
                    BirimAdi = TextBoxBirim.Text,
                    Gorev = TextBoxGorev.Text,
                    BaslangicTarihi = Convert.ToDateTime(DateTimePickerStartDate.Text),
                    AyrilisTarihi = Convert.ToDateTime(DateTimePickerTerminationTime.Text),
                    Aciklama = TextBoxDescription.Text
                }
                :
                new Nakil
                {
                    PersonelId = _personelId,
                    KurumAdi = TextBoxKurumAdi.Text,
                    BirimAdi = TextBoxBirim.Text,
                    Gorev = TextBoxGorev.Text,
                    BaslangicTarihi = Convert.ToDateTime(DateTimePickerStartDate.Text),
                    AyrilisTarihi = Convert.ToDateTime(DateTimePickerTerminationTime.Text),
                    Aciklama = TextBoxDescription.Text
                };


            var res = _nakilManager.Add(nakil);

            MessageBox.Show(res.Message);

            this.Close();
        }
    }
}
