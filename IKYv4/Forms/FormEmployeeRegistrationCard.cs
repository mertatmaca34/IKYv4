using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormEmployeeRegistrationCard : Form
    {
        readonly IPersonelManager _personelManager;
        readonly IMudurlukManager _mudurlukManager;
        readonly ISeflikManager _seflikManager;
        readonly ITesisManager _tesisManager;
        readonly ICalismaSaatleriManager _calismaSaatleriManager;
        readonly IUnvanGrubuManager _unvanGrubuManager;
        readonly IUnvanManager _unvanManager;
        readonly INufusManager _nufusManager;
        readonly ITahsilManager _tahsilManager;

        bool tiklandi = false;
        bool isItNew = true;

        private Personel _personel = new Personel();
        private Nufus _nufus = new Nufus();

        public FormEmployeeRegistrationCard(IPersonelManager personelManager, IMudurlukManager mudurlukManager, ISeflikManager seflikManager, ITesisManager tesisManager, ICalismaSaatleriManager calismaSaatleriManager, IUnvanGrubuManager unvanGrubuManager, IUnvanManager unvanManager, INufusManager nufusManager, ITahsilManager tahsilManager)
        {
            InitializeComponent();

            _personelManager = personelManager;
            _mudurlukManager = mudurlukManager;
            _seflikManager = seflikManager;
            _tesisManager = tesisManager;
            _calismaSaatleriManager = calismaSaatleriManager;
            _unvanGrubuManager = unvanGrubuManager;
            _unvanManager = unvanManager;
            _nufusManager = nufusManager;
            _tahsilManager = tahsilManager;

            var res = _mudurlukManager.GetAll();

            if (res.Data.Count > 0)
            {
                foreach (var item in res.Data)
                {
                    ComboBoxDirectorate.Items.Add(item.MudurlukAdi);
                }
            }

            var resUnvanGrubu = _unvanGrubuManager.GetAll().Data;

            if (string.IsNullOrEmpty(ComboBoxTitle.Text))
            {
                foreach (var unvanGrubu in resUnvanGrubu)
                {
                    ComboBoxTitle.Items.Add(unvanGrubu.UnvanGrubuAdi);
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var resPersonsel = _personelManager.GetAll(p => p.TCKimlikNo == TextBoxUserId.Text);

            if (resPersonsel.Data.Count > 0)
            {
                _personel.Id = resPersonsel.Data.FirstOrDefault().Id;

                isItNew = false;

                if (resPersonsel.Data.FirstOrDefault().ImageData != null && tiklandi == false)
                {
                    _personel.ImageData = resPersonsel.Data.FirstOrDefault().ImageData;
                }
            }

            _personel.Adi = TextBoxName.Text;
            _personel.Soyadi = TextBoxSurname.Text;
            _personel.TCKimlikNo = TextBoxUserId.Text;
            _personel.SicilNo = TextBoxSicilNo.Text;
            _personel.IseGirisTarihi = DateTimePickerStartDate.Value;
            _personel.Mudurluk = ComboBoxDirectorate.Text;
            _personel.Seflik = ComboBoxConducting.Text;
            _personel.GorevYeri = ComboBoxDutyStation.Text;
            _personel.Unvani = ComboBoxTitle.Text;
            _personel.Pozisyonu = ComboBoxPosition.Text;
            _personel.MK = TextBoxMk.Text;
            _personel.PK = TextBoxPk.Text;
            _personel.ToplamKatsayi = TextBoxTotalK.Text;
            _personel.CalisiyorMu = true;

            var res = _personelManager.Add(_personel);

            var _nufus = _nufusManager.GetAll(p => p.PersonelId == _personel.Id).Data.FirstOrDefault();

            if (_nufus == null || _nufus.PersonelId == 0)
            {
                _nufus = new Nufus();

                _nufus.PersonelId = _personel.Id;
            }
            
            _nufus.Cinsiyet = RadioButtonMan.Checked ? RadioButtonMan.Text : RadioButtonWoman.Text;
            _nufus.DogumTarihi = DateTimePickerBirthDate.Value;
            _nufus.DogumYeri = TextBoxBirthPlace.Text;
            _nufus.NufusaKayitliOlduguIl = TextBoxResidance.Text;
            _nufus.AnneAdi = TextBoxMotherName.Text;
            _nufus.BabaAdi = TextBoxFatherName.Text;
            _nufus.KanGrubu = ComboBoxBloodGroup.Text;
            _nufus.Askerlik = ComboBoxMilitaryState.Text;
            _nufus.MedeniHali = RadioButtonMaried.Checked ? RadioButtonMaried.Text : RadioButtonSingle.Text;
            _nufus.EsAdi = TextBoxSpouseName.Text;
            _nufus.EsCalismaDurumu = RadioButtonSpouseNotWorks.Checked ? RadioButtonSpouseNotWorks.Text : RadioButtonSpouseWorks.Text;
            _nufus.EsMeslegi = TextBoxSpouseJob.Text;
            _nufus.CocukSayisi = TextBoxChildrenCount.Text;
            _nufus.EsCalistigiKurumAdi = TextBoxWhereSpouseWorks.Text;

            var resNufus = _nufusManager.Add(_nufus);

            var _tahsil = _tahsilManager.GetAll(p => p.PersonelId == _personel.Id).Data.FirstOrDefault();

            if (_tahsil == null || _tahsil.PersonelId == 0)
            {
                _tahsil = new Tahsil();

                _tahsil.PersonelId = _personel.Id;
            }

            _tahsil.TahsilAdi1 = ComboBoxEducation1.Text;
            _tahsil.TahsilAdi2 = ComboBoxEducation2.Text;
            _tahsil.TahsilAdi3 = ComboBoxEducation3.Text;
            _tahsil.TahsilAdi4 = ComboBoxEducation4.Text;
            _tahsil.TahsilAdi5 = ComboBoxEducation5.Text;
            _tahsil.OkulAdi1 = TextBoxSchool1.Text;
            _tahsil.OkulAdi2 = TextBoxSchool2.Text;
            _tahsil.OkulAdi3 = TextBoxSchool3.Text;
            _tahsil.OkulAdi4 = TextBoxSchool4.Text;
            _tahsil.OkulAdi5 = TextBoxSchool5.Text;
            _tahsil.MezuniyetTarihi1 = DateTimePickerGraduation1.Value;
            _tahsil.MezuniyetTarihi2 = DateTimePickerGraduation2.Value;
            _tahsil.MezuniyetTarihi3 = DateTimePickerGraduation3.Value;
            _tahsil.MezuniyetTarihi4 = DateTimePickerGraduation4.Value;
            _tahsil.MezuniyetTarihi5 = DateTimePickerGraduation5.Value;

            var resTahsil = _tahsilManager.Add(_tahsil);

            AssignDefaultShifts();
            
            MessageBox.Show(res.Message);
            
            this.Close();
        }

        private void AssignDefaultShifts()
        {
            if (isItNew)
            {
                CalismaSaatleri calismaSaatleri = new CalismaSaatleri
                {
                    PersonelId = _personel.Id,
                    PazartesiBaslama = "08:00",
                    PazartesiBitme = "18:00",
                    SaliBaslama = "08:00",
                    SaliBitme = "18:00",
                    CarsambaBaslama = "08:00",
                    CarsambaBitme = "18:00",
                    PersembeBaslama = "08:00",
                    PersembeBitme = "18:00",
                    CumaBaslama = "08:00",
                    CumaBitme = "18:00",
                    CumartesiBaslama = "HAFTA TATİLİ",
                    CumartesiBitme = "HAFTA TATİLİ",
                    PazarBaslama = "HAFTA TATİLİ",
                    PazarBitme = "HAFTA TATİLİ",
                };

                _calismaSaatleriManager.Add(calismaSaatleri);
            }
        }
        
        private void FormEmployeeRegistrationCard_Load(object sender, EventArgs e)
        {
            /*var res = _unvanGrubuManager.GetAll().Data;

            if(string.IsNullOrEmpty(ComboBoxTitle.Text))
            {
                foreach (var unvanGrubu in res)
                {
                    ComboBoxTitle.Items.Add(unvanGrubu.UnvanGrubuAdi);
                }
            }*/
        }

        private void ComboBoxDirectorate_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxConducting.Items.Clear();

            string filterParameter = ComboBoxDirectorate.Text;

            var res = _seflikManager.GetAll(s => s.MudurlukAdi == filterParameter);

            if (res.Data.Count > 0)
            {
                foreach (var item in res.Data)
                {
                    ComboBoxConducting.Items.Add(item.SeflikAdi);
                }

                ComboBoxConducting.Enabled = true;
            }
        }

        private void ComboBoxConducting_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxDutyStation.Items.Clear();

            var res = _tesisManager.GetAll(s => s.SeflikAdi == ComboBoxConducting.Text);

            if (res.Data.Count > 0)
            {
                foreach (var item in res.Data)
                {
                    ComboBoxDutyStation.Items.Add(item.TesisAdi);
                }

                ComboBoxDutyStation.Enabled = true;
            }
        }

        private void PictureBoxEmployeePicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    PictureBoxEmployeePicture.Image = Image.FromFile(selectedFilePath);

                    byte[] imageData;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        PictureBoxEmployeePicture.Image.Save(ms, PictureBoxEmployeePicture.Image.RawFormat);
                        imageData = ms.ToArray();
                    }

                    tiklandi = true;

                    _personel.ImageData = imageData;
                }
            }
        }

        private void ComboBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxPosition.Items.Clear();

            var resUnvanGrubuId = _unvanGrubuManager.GetAll(x => x.UnvanGrubuAdi == ComboBoxTitle.Text).Data.FirstOrDefault().Id;
            var resUnvan = _unvanManager.GetAll(x => x.UnvanGrubuId == resUnvanGrubuId).Data;

            foreach (var unvan in resUnvan)
            {
                ComboBoxPosition.Items.Add(unvan.UnvanAdi);
            }

            var res = _unvanGrubuManager.GetAll(x=> x.UnvanGrubuAdi == ComboBoxTitle.Text).Data.FirstOrDefault();

            TextBoxMk.Text = res.MK.ToString();
            TextBoxPk.Text = res.PK.ToString();
            TextBoxTotalK.Text = res.TK.ToString();
        }

        private void RadioButtonMaried_CheckedChanged(object sender, EventArgs e)
        {
            LabelSpouseName.ForeColor = Color.Black;
            LabelSpouseWorkState.ForeColor = Color.Black;
            LabelSpouseJob.ForeColor = Color.Black;
            LabelChildrenCount.ForeColor = Color.Black;
            LabelSpouseWorkName.ForeColor = Color.Black;

            TextBoxSpouseName.Enabled = true;
            RadioButtonSpouseNotWorks.Enabled = true;
            RadioButtonSpouseWorks.Enabled = true;
            TextBoxSpouseJob.Enabled = true;
            TextBoxChildrenCount.Enabled = true;
            TextBoxWhereSpouseWorks.Enabled = true;
        }

        private void RadioButtonSingle_CheckedChanged(object sender, EventArgs e)
        {
            LabelSpouseName.ForeColor = SystemColors.ControlDarkDark;
            LabelSpouseWorkState.ForeColor = SystemColors.ControlDarkDark;
            LabelSpouseJob.ForeColor = SystemColors.ControlDarkDark;
            LabelChildrenCount.ForeColor = SystemColors.ControlDarkDark;
            LabelSpouseWorkName.ForeColor = SystemColors.ControlDarkDark;

            TextBoxSpouseName.Enabled = false;
            RadioButtonSpouseNotWorks.Enabled = false;
            RadioButtonSpouseWorks.Enabled = false;
            TextBoxSpouseJob.Enabled = false;
            TextBoxChildrenCount.Enabled = false;
            TextBoxWhereSpouseWorks.Enabled = false;
        }
    }
}