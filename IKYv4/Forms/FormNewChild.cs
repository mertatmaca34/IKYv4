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
    public partial class FormNewChild : Form
    {
        ICocukManager _cocukManager;
        public int _personelId;
        public Cocuk _cocuk;

        public FormNewChild(ICocukManager cocukManager, int personelId)
        {
            _cocukManager = cocukManager;
            _personelId = personelId;

            InitializeComponent();
        }

        public FormNewChild(ICocukManager cocukManager, Cocuk cocuk)
        {
            _cocukManager = cocukManager;
            _personelId = cocuk.PersonelId;
            _cocuk = cocuk;

            InitializeComponent();

            TextBoxChildName.Text = cocuk.CocukAdi;
            DateTimePickerChildBirthDate.Value = cocuk.DogumTarihi;
            RadioButtonMan.Checked = cocuk.CocukCinsiyeti == "ERKEK";
            RadioButtonWoman.Checked = cocuk.CocukCinsiyeti == "KADIN";
            TextBoxAboutChild.Text = cocuk.Hakkinda;

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(_cocuk != null)
            {
                Cocuk updatedCocuk = new Cocuk
                {
                    Id = _cocuk.Id,
                    PersonelId = _personelId,
                    CocukAdi = TextBoxChildName.Text,
                    CocukCinsiyeti = RadioButtonMan.Checked ? RadioButtonMan.Text : RadioButtonWoman.Text,
                    DogumTarihi = DateTimePickerChildBirthDate.Value,
                    Hakkinda = TextBoxAboutChild.Text,
                };

                var resUpdatedCocuk = _cocukManager.Add(updatedCocuk);

                MessageBox.Show(resUpdatedCocuk.Message);

                this.Close();
            }

            else
            {
                Cocuk cocuk = new Cocuk
                {
                    PersonelId = _personelId,
                    CocukAdi = TextBoxChildName.Text,
                    CocukCinsiyeti = RadioButtonMan.Checked ? RadioButtonMan.Text : RadioButtonWoman.Text,
                    DogumTarihi = DateTimePickerChildBirthDate.Value,
                    Hakkinda = TextBoxAboutChild.Text,
                };

                var res = _cocukManager.Add(cocuk);

                MessageBox.Show(res.Message);

                this.Close();
            }
        }
    }
}
