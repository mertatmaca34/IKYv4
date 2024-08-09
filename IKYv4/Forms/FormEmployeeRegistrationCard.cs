using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.TurkeyModel;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.Json;
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
        readonly INakilManager _nakilManager;
        readonly ISertifikaManager _sertifikaManager;
        readonly IIletisimManager _iletisimManager;

        bool tiklandi = false;
        bool isItNew = true;

        public Personel _personel = new Personel();
        private Nufus _nufus = new Nufus();

        private List<City> _cities = new List<City>();
        private List<District> _districts = new List<District>();
        private List<Neighbourhood> _neighbourhoods = new List<Neighbourhood>();

        public FormEmployeeRegistrationCard(IPersonelManager personelManager,
                                            IMudurlukManager mudurlukManager,
                                            ISeflikManager seflikManager,
                                            ITesisManager tesisManager,
                                            ICalismaSaatleriManager calismaSaatleriManager,
                                            IUnvanGrubuManager unvanGrubuManager,
                                            IUnvanManager unvanManager,
                                            INufusManager nufusManager,
                                            ITahsilManager tahsilManager,
                                            INakilManager nakilManager,
                                            ISertifikaManager sertifikaManager,
                                            IIletisimManager iletisimManager)
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
            _nakilManager = nakilManager;
            _sertifikaManager = sertifikaManager;
            _iletisimManager = iletisimManager;

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

            ComboBoxContactCity.Items.Insert(0, "İL");
            ComboBoxContactCity.SelectedIndex = 0;

            ComboBoxContactCity.Text = ComboBoxContactCity.SelectedIndex < 0 ? "İL"
                : ComboBoxContactCity.Text = ComboBoxContactCity.SelectedText;

            ComboBoxContactDistrict.Items.Insert(0, "İLÇE");
            ComboBoxContactDistrict.SelectedIndex = 0;

            ComboBoxContactDistrict.Text = ComboBoxContactDistrict.SelectedIndex < 0 ? "İLÇE"
                : ComboBoxContactDistrict.Text = ComboBoxContactDistrict.SelectedText;

            ComboBoxContactNeighbourhood.Items.Insert(0, "MAHALLE");
            ComboBoxContactNeighbourhood.SelectedIndex = 0;

            ComboBoxContactNeighbourhood.Text = ComboBoxContactNeighbourhood.SelectedIndex < 0 ? "MAHALLE"
                : ComboBoxContactNeighbourhood.Text = ComboBoxContactNeighbourhood.SelectedText;

            AssignCities();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            #region Genel Sayfası Atamaları

            var resPersonsel = _personelManager.GetAll(p => p.Id == _personel.Id);

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

            #endregion

            #region Nufus Sayfası Atamaları

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
            _nufus.MedeniHali = RadioButtonSingle.Checked ? RadioButtonSingle.Text : RadioButtonSingle.Text;
            _nufus.EsAdi = TextBoxSpouseName.Text;
            _nufus.EsCalismaDurumu = RadioButtonSpouseNotWorks.Checked ? RadioButtonSpouseNotWorks.Text : RadioButtonSpouseWorks.Text;
            _nufus.EsMeslegi = TextBoxSpouseJob.Text;
            _nufus.EsCalistigiKurumAdi = TextBoxWhereSpouseWorks.Text;

            var resNufus = _nufusManager.Add(_nufus);

            #endregion

            #region Tahsil Sayfası Atamaları

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

            #endregion

            #region Nakil Sayfası Atamaları

            var _nakil = _nakilManager.GetAll(p => p.PersonelId == _personel.Id).Data.FirstOrDefault();

            if(_nakil == null || _nakil.PersonelId == 0)
            {
                _nakil = new Nakil();

                _nakil.PersonelId = _personel.Id;
            }

            _nakil.Kurum1 = TextBoxInstitution1.Text;
            _nakil.Kurum2 = TextBoxInstitution2.Text;
            _nakil.Kurum3 = TextBoxInstitution3.Text;
            _nakil.Kurum4 = TextBoxInstitution4.Text;
            _nakil.Kurum5 = TextBoxInstitution5.Text;
            _nakil.Kurum6 = TextBoxInstitution6.Text;
            _nakil.Birim1 = TextBoxDivision1.Text;
            _nakil.Birim2 = TextBoxDivision2.Text;
            _nakil.Birim3 = TextBoxDivision3.Text;
            _nakil.Birim4 = TextBoxDivision4.Text;
            _nakil.Birim5 = TextBoxDivision5.Text;
            _nakil.Birim6 = TextBoxDivision6.Text;
            _nakil.Gorev1 = TextBoxJob1.Text;
            _nakil.Gorev2 = TextBoxJob2.Text;
            _nakil.Gorev3 = TextBoxJob3.Text;
            _nakil.Gorev4 = TextBoxJob4.Text;
            _nakil.Gorev5 = TextBoxJob5.Text;
            _nakil.Gorev6 = TextBoxJob6.Text;
            _nakil.BaslangicTarihi1 = DateTimePickerStartDate1.Value;
            _nakil.BaslangicTarihi2 = DateTimePickerStartDate2.Value;
            _nakil.BaslangicTarihi3 = DateTimePickerStartDate3.Value;
            _nakil.BaslangicTarihi4 = DateTimePickerStartDate4.Value;
            _nakil.BaslangicTarihi5 = DateTimePickerStartDate5.Value;
            _nakil.BaslangicTarihi6 = DateTimePickerStartDate6.Value;
            _nakil.AyrilisTarihi1 = DateTimePickerDepartureDate1.Value;
            _nakil.AyrilisTarihi2 = DateTimePickerDepartureDate2.Value;
            _nakil.AyrilisTarihi3 = DateTimePickerDepartureDate3.Value;
            _nakil.AyrilisTarihi4 = DateTimePickerDepartureDate4.Value;
            _nakil.AyrilisTarihi5 = DateTimePickerDepartureDate5.Value;
            _nakil.AyrilisTarihi6 = DateTimePickerDepartureDate6.Value;
            _nakil.Aciklama1 = TextBoxDescription1.Text;
            _nakil.Aciklama2 = TextBoxDescription2.Text;
            _nakil.Aciklama3 = TextBoxDescription3.Text;
            _nakil.Aciklama4 = TextBoxDescription4.Text;
            _nakil.Aciklama5 = TextBoxDescription5.Text;
            _nakil.Aciklama6 = TextBoxDescription6.Text;

            var resNakil = _nakilManager.Add(_nakil);

            #endregion

            #region Sertifika Sayfası Atamaları

            var _sertifika = _sertifikaManager.GetAll(p => p.PersonelId == _personel.Id).Data.FirstOrDefault();

            if (_sertifika == null || _sertifika.PersonelId == 0)
            {
                _sertifika = new Sertifika();

                _sertifika.PersonelId = _personel.Id;
            }

            _sertifika.SertifikaAdi1 = TextBoxSertificate1.Text;
            _sertifika.SertifikaAdi2 = TextBoxSertificate2.Text;
            _sertifika.SertifikaAdi3 = TextBoxSertificate3.Text;
            _sertifika.SertifikaAdi4 = TextBoxSertificate4.Text;
            _sertifika.SertifikaAdi5 = TextBoxSertificate5.Text;
            _sertifika.SertifikaAdi6 = TextBoxSertificate6.Text;

            var resSertifika = _sertifikaManager.Add(_sertifika);

            #endregion

            #region İletişim Sayfası Atamaları

            var _iletisim = _iletisimManager.GetAll(p => p.PersonelId == _personel.Id).Data.FirstOrDefault();

            if (_iletisim == null || _iletisim.PersonelId == 0)
            {
                _iletisim = new Iletisim();

                _iletisim.PersonelId = _personel.Id;
            }

            _iletisim.Il = ComboBoxContactCity.Text;
            _iletisim.Ilce = ComboBoxContactDistrict.Text;
            _iletisim.Mahalle = ComboBoxContactNeighbourhood.Text;
            _iletisim.AdresDetay = TextBoxContactAddressDetail.Text;
            _iletisim.CepTelNo1 = TextBoxPhoneNumber.Text;
            _iletisim.CepTelNo2 = TextBoxPhoneNumber2.Text;
            _iletisim.EMailAdresi = TextBoxMailAdress.Text;

            var resIletisim = _iletisimManager.Add(_iletisim);

            #endregion

            AssignDefaultWorkingHours();
            
            MessageBox.Show(res.Message);
            
            this.Close();
        }

        private void AssignDefaultWorkingHours()
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
            LabelSpouseWorkName.ForeColor = Color.Black;

            TextBoxSpouseName.Enabled = true;
            RadioButtonSpouseNotWorks.Enabled = true;
            RadioButtonSpouseWorks.Enabled = true;
            TextBoxSpouseJob.Enabled = true;
            TextBoxWhereSpouseWorks.Enabled = true;
        }

        private void RadioButtonSingle_CheckedChanged(object sender, EventArgs e)
        {
            LabelSpouseName.ForeColor = SystemColors.ControlDarkDark;
            LabelSpouseWorkState.ForeColor = SystemColors.ControlDarkDark;
            LabelSpouseJob.ForeColor = SystemColors.ControlDarkDark;
            LabelSpouseWorkName.ForeColor = SystemColors.ControlDarkDark;

            TextBoxSpouseName.Enabled = false;
            RadioButtonSpouseNotWorks.Enabled = false;
            RadioButtonSpouseWorks.Enabled = false;
            TextBoxSpouseJob.Enabled = false;
            TextBoxWhereSpouseWorks.Enabled = false;
        }

        private void AssignCities()
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("il.json"));

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string jsonContent = reader.ReadToEnd();
                _cities = JsonSerializer.Deserialize<List<City>>(jsonContent, options);
            }

            foreach (var item in _cities)
            {
                if (item.sehir_title != null)
                {
                    ComboBoxContactCity.Items.Add(item.sehir_title);
                }
            }
        }

        private void AssignDistricts(string sehir_key)
        {
            ComboBoxContactDistrict.Items.Clear();

            ComboBoxContactDistrict.Items.Insert(0, "İLÇE");
            ComboBoxContactDistrict.SelectedIndex = 0;

            ComboBoxContactDistrict.Text = ComboBoxContactDistrict.SelectedIndex < 0 ? "İLÇE"
                : ComboBoxContactDistrict.Text = ComboBoxContactDistrict.SelectedText;

            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("ilce.json"));

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string jsonContent = reader.ReadToEnd();
                _districts = JsonSerializer.Deserialize<List<District>>(jsonContent, options);
            }

            foreach (var item in _districts)
            {
                if (item.ilce_sehirkey == sehir_key)
                {
                    ComboBoxContactDistrict.Items.Add(item.ilce_title);
                }
            }
        }

        private void AssignNeighbourhoods(string ilce_key)
        {
            ComboBoxContactNeighbourhood.Items.Clear();

            ComboBoxContactNeighbourhood.Items.Insert(0, "MAHALLE");
            ComboBoxContactNeighbourhood.SelectedIndex = 0;

            ComboBoxContactNeighbourhood.Text = ComboBoxContactNeighbourhood.SelectedIndex < 0 ? "MAHALLE"
                : ComboBoxContactNeighbourhood.Text = ComboBoxContactNeighbourhood.SelectedText;

            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames().Single(str => str.EndsWith("mahalle.json"));

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string jsonContent = reader.ReadToEnd();
                _neighbourhoods = JsonSerializer.Deserialize<List<Neighbourhood>>(jsonContent, options);
            }

            foreach (var item in _neighbourhoods)
            {
                if (item.mahalle_ilcekey == ilce_key)
                {
                    ComboBoxContactNeighbourhood.Items.Add(item.mahalle_title);
                }
            }
        }

        private void ComboBoxContactCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = ComboBoxContactCity.SelectedItem.ToString();
            var res = _cities.FirstOrDefault(x => x.sehir_title == selectedCity);

            if (res != null)
            {
                ComboBoxContactDistrict.Enabled = true;

                AssignDistricts(res.sehir_key);
            }

            ComboBoxContactDistrict.Enabled = ComboBoxContactCity.Text == "İL" ? false : true;
        }

        private void ComboBoxContactDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDistrict = ComboBoxContactDistrict.SelectedItem.ToString();
            var res = _districts.FirstOrDefault(x => x.ilce_title == selectedDistrict);

            if (res != null)
            {
                ComboBoxContactDistrict.Enabled = true;

                AssignNeighbourhoods(res.ilce_key);
            }

            ComboBoxContactNeighbourhood.Enabled = ComboBoxContactDistrict.Text == "İLÇE" ? false : true;
        }
    }
}