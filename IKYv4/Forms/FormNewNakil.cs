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
    public partial class FormNewNakil : Form
    {
        readonly INakilManager _nakilManager;
        public int _personelId;

        public FormNewNakil(INakilManager nakilManager, int personelId)
        {
            _nakilManager = nakilManager;
            _personelId = personelId;

            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Nakil nakil = new Nakil
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
