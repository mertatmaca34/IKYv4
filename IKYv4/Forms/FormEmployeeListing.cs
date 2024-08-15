using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.TurkeyModel;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormEmployeeListing : Form
    {
        public Personel ChoosedPersonel { get; set; }

        List<City> _cities = new List<City>();
        List<District> _districts = new List<District>();
        List<Neighbourhood> _neighbourhoods = new List<Neighbourhood>();

        List<City> _homeTownCities = new List<City>();
        List<Personel> _personeller;

        IPersonelManager _personelManager;
        IMudurlukManager _mudurlukManager;
        ISeflikManager _seflikManager;
        ITesisManager _tesisManager;
        ICalismaSaatleriManager _calismaSaatleriManager;
        IUnvanGrubuManager _unvanGrubuManager;
        IUnvanManager _unvanManager;
        INufusManager _nufusManager;
        ITahsilManager _tahsilManager;
        ISertifikaManager _sertifikaManager;
        IIletisimManager _iletisimManager;
        INakilManager _nakilManager;
        ICocukManager _cocukManager;

        public FormEmployeeListing(IPersonelManager personelManager,
                                   IMudurlukManager mudurlukManager,
                                   ISeflikManager seflikManager,
                                   ITesisManager tesisManager,
                                   ICalismaSaatleriManager calismaSaatleriManager,
                                   IUnvanGrubuManager unvanGrubuManager,
                                   IUnvanManager unvanManager,
                                   INufusManager nufusManager,
                                   ITahsilManager tahsilManager,
                                   ISertifikaManager sertifikaManager,
                                   IIletisimManager iletisimManager,
                                   INakilManager nakilManager,
                                   ICocukManager cocukManager)
        {
            InitializeComponent();

            _cocukManager = cocukManager;
            _personelManager = personelManager;
            _mudurlukManager = mudurlukManager;
            _seflikManager = seflikManager;
            _tesisManager = tesisManager;
            _calismaSaatleriManager = calismaSaatleriManager;
            _unvanGrubuManager = unvanGrubuManager;
            _unvanManager = unvanManager;
            _nufusManager = nufusManager;
            _tahsilManager = tahsilManager;
            _sertifikaManager = sertifikaManager;
            _iletisimManager = iletisimManager;
            _nakilManager = nakilManager;

            _personeller = _personelManager.GetAll().Data.ToList();

            DataGridViewCustomization();
        }

        private void ButtonNewEmployee_Click(object sender, EventArgs e)
        {
            FormEmployeeRegistrationCard formEmployeeRegistrationCard = new FormEmployeeRegistrationCard(_personelManager, _mudurlukManager, _seflikManager, _tesisManager, _calismaSaatleriManager, _unvanGrubuManager, _unvanManager, _nufusManager, _tahsilManager, _nakilManager, _sertifikaManager, _iletisimManager, _cocukManager);

            formEmployeeRegistrationCard.ShowDialog();

            DataGridViewCustomization();
        }

        private void DataGridViewCustomization()
        {
            DataGridViewEmployees.DataSource = _personelManager.GetAll().Data.ToList();
            DataGridViewEmployees.Refresh();

            DataGridViewEmployees.Columns[2].Visible = false;
            DataGridViewEmployees.Columns[12].Visible = false;
            DataGridViewEmployees.Columns[14].Visible = false;
            DataGridViewEmployees.Columns[15].Visible = false;
            DataGridViewEmployees.Columns[17].Visible = false;
            DataGridViewEmployees.Columns[18].Visible = false;

            (DataGridViewEmployees.Columns[3] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewEmployees.Columns[3].HeaderText = "Fotoğraf";
            DataGridViewEmployees.Columns[4].HeaderText = "TC Kimlik No";
            DataGridViewEmployees.Columns[5].HeaderText = "Sicil No";
            DataGridViewEmployees.Columns[6].HeaderText = "Adı";
            DataGridViewEmployees.Columns[7].HeaderText = "Soyadı";
            DataGridViewEmployees.Columns[8].HeaderText = "İşe Giriş Tarihi";
            DataGridViewEmployees.Columns[9].HeaderText = "Müdürlük";
            DataGridViewEmployees.Columns[10].HeaderText = "Şeflik";
            DataGridViewEmployees.Columns[11].HeaderText = "Görev Yeri";
            DataGridViewEmployees.Columns[12].HeaderText = "Ünvanı";
            DataGridViewEmployees.Columns[13].HeaderText = "Pozisyonu";
            DataGridViewEmployees.Columns[14].HeaderText = "Maaş Katsayısı";
            DataGridViewEmployees.Columns[15].HeaderText = "Prim Katsayısı";
            DataGridViewEmployees.Columns[16].HeaderText = "Toplam Katsayısı";
            DataGridViewEmployees.Columns[17].HeaderText = "Çalışma Durumu";
            DataGridViewEmployees.Columns[18].HeaderText = "Yıllık İzin Sayısı";
        }

        private void DataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var row = DataGridViewEmployees.Rows[e.RowIndex];

                int selectedPersonelId = Convert.ToInt16(row.Cells[2].Value);

                var selectedPersonel = _personelManager.GetAll(p => p.Id == selectedPersonelId).Data.FirstOrDefault();

                FormEmployeeRegistrationCard formEmployeeRegistrationCard = new FormEmployeeRegistrationCard(_personelManager, _mudurlukManager, _seflikManager, _tesisManager, _calismaSaatleriManager, _unvanGrubuManager, _unvanManager, _nufusManager, _tahsilManager, _nakilManager, _sertifikaManager, _iletisimManager, _cocukManager);

                formEmployeeRegistrationCard.ComboBoxConducting.Enabled = true;
                formEmployeeRegistrationCard.ComboBoxDirectorate.Enabled = true;
                formEmployeeRegistrationCard.ComboBoxDutyStation.Enabled = true;

                formEmployeeRegistrationCard._personel.Id = selectedPersonelId;
                formEmployeeRegistrationCard.TextBoxName.Text = selectedPersonel.Adi;
                formEmployeeRegistrationCard.TextBoxSurname.Text = selectedPersonel.Soyadi;
                formEmployeeRegistrationCard.TextBoxUserId.Text = selectedPersonel.TCKimlikNo;
                formEmployeeRegistrationCard.TextBoxSicilNo.Text = selectedPersonel.SicilNo;
                formEmployeeRegistrationCard.DateTimePickerStartDate.Value = selectedPersonel.IseGirisTarihi;
                formEmployeeRegistrationCard.ComboBoxDirectorate.Text = selectedPersonel.Mudurluk;
                formEmployeeRegistrationCard.ComboBoxConducting.Text = selectedPersonel.Seflik;
                formEmployeeRegistrationCard.ComboBoxDutyStation.Text = selectedPersonel.GorevYeri;
                formEmployeeRegistrationCard.ComboBoxTitle.SelectedItem = selectedPersonel.Unvani;
                formEmployeeRegistrationCard.ComboBoxPosition.SelectedItem = selectedPersonel.Pozisyonu;
                formEmployeeRegistrationCard.ComboBoxStaff.SelectedItem = selectedPersonel.Kadrosu;
                formEmployeeRegistrationCard.ComboBoxEytDurumu.SelectedItem = selectedPersonel.EytDurumu;
                formEmployeeRegistrationCard.TextBoxMk.Text = selectedPersonel.MK.ToString();
                formEmployeeRegistrationCard.TextBoxPk.Text = selectedPersonel.PK.ToString();
                formEmployeeRegistrationCard.TextBoxTotalK.Text = selectedPersonel.ToplamKatsayi.ToString();

                var selectedPersonelNufus = _nufusManager.GetAll(x => x.PersonelId == selectedPersonel.Id).Data.FirstOrDefault();

                if (selectedPersonelNufus != null)
                {
                    formEmployeeRegistrationCard.RadioButtonMan.Checked = selectedPersonelNufus.Cinsiyet == "ERKEK" ? true : false;
                    formEmployeeRegistrationCard.DateTimePickerBirthDate.Value = selectedPersonelNufus.DogumTarihi.Value;
                    formEmployeeRegistrationCard.TextBoxBirthPlace.Text = selectedPersonelNufus.DogumYeri;
                    formEmployeeRegistrationCard.TextBoxMotherName.Text = selectedPersonelNufus.AnneAdi;
                    formEmployeeRegistrationCard.TextBoxFatherName.Text = selectedPersonelNufus.BabaAdi;
                    formEmployeeRegistrationCard.ComboBoxBloodGroup.SelectedItem = selectedPersonelNufus.KanGrubu;
                    formEmployeeRegistrationCard.TextBoxResidance.Text = selectedPersonelNufus.NufusaKayitliOlduguIl;
                    formEmployeeRegistrationCard.ComboBoxMilitaryState.Text = selectedPersonelNufus.Askerlik;
                    formEmployeeRegistrationCard.RadioButtonSingle.Checked = selectedPersonelNufus.MedeniHali == "BEKAR";
                    formEmployeeRegistrationCard.RadioButtonSingle.Checked = selectedPersonelNufus.MedeniHali == "EVLİ";
                    formEmployeeRegistrationCard.TextBoxSpouseName.Text = selectedPersonelNufus.EsAdi;
                    formEmployeeRegistrationCard.RadioButtonSpouseWorks.Checked = selectedPersonelNufus.EsCalismaDurumu == "ÇALIŞIYOR";
                    formEmployeeRegistrationCard.RadioButtonSpouseNotWorks.Checked = selectedPersonelNufus.EsCalismaDurumu == "ÇALIŞMIYOR";
                    formEmployeeRegistrationCard.TextBoxSpouseJob.Text = selectedPersonelNufus.EsMeslegi;
                    formEmployeeRegistrationCard.TextBoxWhereSpouseWorks.Text = selectedPersonelNufus.EsCalistigiKurumAdi;
                }

                var selectedPersonelTahsil = _tahsilManager.GetAll(x => x.PersonelId == selectedPersonel.Id).Data;

                formEmployeeRegistrationCard.DataGridViewTahsil.DataSource = selectedPersonelTahsil;
                formEmployeeRegistrationCard.DataGridViewTahsil.Update();

                if (selectedPersonelTahsil != null)
                {

                }

                var selectedPersonelSertifika = _sertifikaManager.GetAll(p => p.PersonelId == selectedPersonel.Id).Data;

                if (selectedPersonelSertifika != null)
                {
                    formEmployeeRegistrationCard.DataGridViewSertifikalar.DataSource = selectedPersonelSertifika;
                    formEmployeeRegistrationCard.DataGridViewSertifikalar.Refresh();
                }

                var selectedPersonelNakil = _nakilManager.GetAll(p => p.PersonelId == selectedPersonel.Id).Data;

                if (selectedPersonelNakil != null)
                {
                    formEmployeeRegistrationCard.DataGridViewNakiller.DataSource = selectedPersonelNakil;
                    formEmployeeRegistrationCard.DataGridViewSertifikalar.Refresh();
                }

                var selectedPersonelIletisim = _iletisimManager.GetAll(P => P.PersonelId == selectedPersonel.Id).Data.FirstOrDefault();

                if (selectedPersonelIletisim != null)
                {
                    formEmployeeRegistrationCard.ComboBoxContactCity.Text = selectedPersonelIletisim.Il;
                    formEmployeeRegistrationCard.ComboBoxContactDistrict.Text = selectedPersonelIletisim.Ilce;
                    formEmployeeRegistrationCard.ComboBoxContactNeighbourhood.Text = selectedPersonelIletisim.Mahalle;
                    formEmployeeRegistrationCard.TextBoxContactAddressDetail.Text = selectedPersonelIletisim.AdresDetay;
                    formEmployeeRegistrationCard.TextBoxPhoneNumber.Text = selectedPersonelIletisim.CepTelNo1;
                    formEmployeeRegistrationCard.TextBoxPhoneNumber2.Text = selectedPersonelIletisim.CepTelNo2;
                    formEmployeeRegistrationCard.TextBoxMailAdress.Text = selectedPersonelIletisim.EMailAdresi;
                }

                var selectedPersonelCocuklar = _cocukManager.GetAll(p => p.PersonelId == selectedPersonel.Id).Data;

                formEmployeeRegistrationCard.DataGridViewChild.DataSource = selectedPersonelCocuklar;
                formEmployeeRegistrationCard.DataGridViewChild.Update();

                Bitmap bmp;

                if (selectedPersonel.ImageData != null)
                {
                    using (var ms = new MemoryStream(selectedPersonel.ImageData))
                    {
                        bmp = new Bitmap(ms);
                    }

                    formEmployeeRegistrationCard.PictureBoxEmployeePicture.Image = bmp;
                }

                formEmployeeRegistrationCard.ShowDialog();

                DataGridViewCustomization();
            }

            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                var row = DataGridViewEmployees.Rows[e.RowIndex];

                int selectedPersonelId = Convert.ToInt16(row.Cells[2].Value);
                var selectedPersonel = _personelManager.GetAll(p => p.Id == selectedPersonelId).Data.FirstOrDefault();
                var selectedPersonelShifts = _calismaSaatleriManager.GetAll(p => p.PersonelId == selectedPersonelId).Data.FirstOrDefault();

                FormEmployeeShifts formEmployeeShifts = new FormEmployeeShifts(_calismaSaatleriManager, selectedPersonelShifts);

                formEmployeeShifts.TextBoxEmployee.Text = $"{selectedPersonel.Adi} {selectedPersonel.Soyadi}";
                formEmployeeShifts.ComboBoxMondayStart.Text = selectedPersonelShifts.PazartesiBaslama.ToString();
                formEmployeeShifts.ComboBoxMondayEnd.Text = selectedPersonelShifts.PazartesiBitme.ToString();
                formEmployeeShifts.ComboBoxTuesdayStart.Text = selectedPersonelShifts.SaliBaslama.ToString();
                formEmployeeShifts.ComboBoxTuesdayEnd.Text = selectedPersonelShifts.SaliBitme.ToString();
                formEmployeeShifts.ComboBoxWednesdayStart.Text = selectedPersonelShifts.CarsambaBaslama.ToString();
                formEmployeeShifts.ComboBoxWednesdayEnd.Text = selectedPersonelShifts.CarsambaBitme.ToString();
                formEmployeeShifts.ComboBoxThursdayStart.Text = selectedPersonelShifts.PersembeBaslama.ToString();
                formEmployeeShifts.ComboBoxThursdayEnd.Text = selectedPersonelShifts.PersembeBitme.ToString();
                formEmployeeShifts.ComboBoxFridayStart.Text = selectedPersonelShifts.CumaBaslama.ToString();
                formEmployeeShifts.ComboBoxFridayEnd.Text = selectedPersonelShifts.CumaBitme.ToString();
                formEmployeeShifts.ComboBoxSaturdayStart.Text = selectedPersonelShifts.CumartesiBaslama.ToString();
                formEmployeeShifts.ComboBoxSaturdayEnd.Text = selectedPersonelShifts.CumartesiBitme.ToString();
                formEmployeeShifts.ComboBoxSundayStart.Text = selectedPersonelShifts.PazarBaslama.ToString();
                formEmployeeShifts.ComboBoxSundayEnd.Text = selectedPersonelShifts.PazarBitme.ToString();

                formEmployeeShifts.ButtonEmployeeChoose.Dispose();
                formEmployeeShifts.TableLayoutPanelMain.SetColumnSpan(formEmployeeShifts.TextBoxEmployee, 2);

                formEmployeeShifts.ShowDialog();
            }
        }

        private void FormEmployeeListing_Load(object sender, EventArgs e)
        {
            #region Müdürlük ComboBox'ına default değerlerin atanması
            var resMudurlukler = _mudurlukManager.GetAll().Data;

            foreach (var mudurluk in resMudurlukler)
            {
                ComboBoxMudurlukFilter.Items.Add(mudurluk.MudurlukAdi);
            }

            ComboBoxMudurlukFilter.Items.Insert(0, "MÜDÜRLÜK");
            ComboBoxMudurlukFilter.SelectedIndex = 0;

            ComboBoxMudurlukFilter.Text = ComboBoxMudurlukFilter.SelectedIndex < 0 ? "MÜDÜRLÜK"
                : ComboBoxMudurlukFilter.Text = ComboBoxMudurlukFilter.SelectedText;
            #endregion

            #region Görev ComboBox'ına default değerlerin atanması
            var resUnvanGrubu = _unvanGrubuManager.GetAll().Data;

            foreach (var unvanGrubu in resUnvanGrubu)
            {
                ComboBoxUnvanGrubu.Items.Add(unvanGrubu.UnvanGrubuAdi);
            }

            ComboBoxUnvanGrubu.Items.Insert(0, "ÜNVAN GRUBU");
            ComboBoxUnvanGrubu.SelectedIndex = 0;

            ComboBoxUnvanGrubu.Text = ComboBoxUnvanGrubu.SelectedIndex < 0 ? "ÜNVAN GRUBU"
                : ComboBoxUnvanGrubu.Text = ComboBoxUnvanGrubu.SelectedText;
            #endregion

            #region Kan Grubu ComboBox'ının özelleştirilmesi
            ComboBoxKanGrubu.Items.Insert(0, "KAN GRUBU");
            ComboBoxKanGrubu.SelectedIndex = 0;

            ComboBoxKanGrubu.Text = ComboBoxKanGrubu.SelectedIndex < 0 ? "KAN GRUBU"
                : ComboBoxKanGrubu.Text = ComboBoxKanGrubu.SelectedText;
            #endregion

            #region İkamergah ComboBox Atamaları

            ComboBoxCities.Items.Insert(0, "İL");
            ComboBoxCities.SelectedIndex = 0;

            ComboBoxCities.Text = ComboBoxCities.SelectedIndex < 0 ? "İL"
                : ComboBoxCities.Text = ComboBoxCities.SelectedText;

            ComboBoxDistricts.Items.Insert(0, "İLÇE");
            ComboBoxDistricts.SelectedIndex = 0;

            ComboBoxDistricts.Text = ComboBoxDistricts.SelectedIndex < 0 ? "İLÇE"
                : ComboBoxDistricts.Text = ComboBoxDistricts.SelectedText;

            #endregion

            #region Memleket ComboBox Atamaları

            ComboBoxHomeTownCity.Items.Insert(0, "İL");
            ComboBoxHomeTownCity.SelectedIndex = 0;

            ComboBoxHomeTownCity.Text = ComboBoxHomeTownCity.SelectedIndex < 0 ? "İL"
                : ComboBoxHomeTownCity.Text = ComboBoxHomeTownCity.SelectedText;

            #endregion

            #region EYT ComboBox Atamaları

            ComboBoxEyt.Items.Insert(0, "SEÇİN");
            ComboBoxEyt.SelectedIndex = 0;

            ComboBoxEyt.Text = ComboBoxEyt.SelectedIndex < 0 ? "SEÇİN"
                : ComboBoxEyt.Text = ComboBoxEyt.SelectedText;

            #endregion

            AssignCities();
            AssignHomeTownCities();
        }

        private void ComboBoxMudurlukFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxSeflikFilter.Items.Clear();

            if (!ComboBoxSeflikFilter.Items.Contains("ŞEFLİK"))
            {
                ComboBoxSeflikFilter.Items.Insert(0, "ŞEFLİK");
                ComboBoxSeflikFilter.SelectedIndex = 0;
            }

            ComboBoxSeflikFilter.Enabled = ComboBoxMudurlukFilter.Text == "MÜDÜRLÜK" ? false
                : true;

            if (ComboBoxMudurlukFilter.Text != "MÜDÜRLÜK")
            {
                var resSeflikler = _seflikManager.GetAll(s => s.MudurlukAdi == ComboBoxMudurlukFilter.Text).Data;

                if (ComboBoxSeflikFilter.Items.Count > 0)
                    ComboBoxSeflikFilter.SelectedIndex = ComboBoxMudurlukFilter.Text == "MÜDÜRLÜK" ? 0
                        : ComboBoxSeflikFilter.SelectedIndex;

                foreach (var seflik in resSeflikler)
                {
                    ComboBoxSeflikFilter.Items.Add(seflik.SeflikAdi);
                }

                ComboBoxMudurlukFilter.Text = ComboBoxMudurlukFilter.SelectedIndex < 0 ? "ŞEFLİK"
                    : ComboBoxMudurlukFilter.Text = ComboBoxMudurlukFilter.SelectedText;
            }
        }

        private void ComboBoxSeflikFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxTesisFilter.Items.Clear();

            if (!ComboBoxTesisFilter.Items.Contains("TESİS"))
            {
                ComboBoxTesisFilter.Items.Insert(0, "TESİS");
                ComboBoxTesisFilter.SelectedIndex = 0;
            }

            ComboBoxTesisFilter.Enabled = ComboBoxSeflikFilter.Text == "ŞEFLİK" ? false
                : true;

            if (ComboBoxSeflikFilter.Text != "ŞEFLİK")
            {
                var resTesisler = _tesisManager.GetAll(s => s.SeflikAdi == ComboBoxSeflikFilter.Text).Data;

                if (ComboBoxTesisFilter.Items.Count > 0)
                    ComboBoxTesisFilter.SelectedIndex = ComboBoxSeflikFilter.Text == "ŞEFLİK" ? 0
                        : ComboBoxTesisFilter.SelectedIndex;

                foreach (var tesis in resTesisler)
                {
                    ComboBoxTesisFilter.Items.Add(tesis.TesisAdi);
                }

                ComboBoxSeflikFilter.Text = ComboBoxSeflikFilter.SelectedIndex < 0 ? "TESİS"
                    : ComboBoxSeflikFilter.Text = ComboBoxSeflikFilter.SelectedText;
            }
        }

        private void ComboBoxUnvanGrubu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxPozisyon.Items.Clear();

            if (!ComboBoxPozisyon.Items.Contains("POZİSYON"))
            {
                ComboBoxPozisyon.Items.Insert(0, "POZİSYON");
                ComboBoxPozisyon.SelectedIndex = 0;
            }

            ComboBoxPozisyon.Enabled = ComboBoxUnvanGrubu.Text == "ÜNVAN GRUBU" ? false
                : true;

            if (ComboBoxUnvanGrubu.Text != "ÜNVAN GRUBU")
            {
                var resUnvanGrubu = _unvanGrubuManager.GetAll(x => x.UnvanGrubuAdi == ComboBoxUnvanGrubu.Text).Data.FirstOrDefault();
                var resPozisyonlar = _unvanManager.GetAll(u => u.UnvanGrubuId == resUnvanGrubu.Id).Data;

                if (ComboBoxPozisyon.Items.Count > 0)
                    ComboBoxPozisyon.SelectedIndex = ComboBoxUnvanGrubu.Text == "ÜNVAN GRUBU" ? 0
                        : ComboBoxPozisyon.SelectedIndex;

                foreach (var pozisyon in resPozisyonlar)
                {
                    ComboBoxPozisyon.Items.Add(pozisyon.UnvanAdi);
                }

                ComboBoxUnvanGrubu.Text = ComboBoxUnvanGrubu.SelectedIndex < 0 ? "POZİSYON"
                    : ComboBoxUnvanGrubu.Text = ComboBoxUnvanGrubu.SelectedText;
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void ButtonSearchFooter_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void AssignHomeTownCities()
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
                _homeTownCities = JsonSerializer.Deserialize<List<City>>(jsonContent, options);
            }

            foreach (var item in _homeTownCities)
            {
                if (item.sehir_title != null)
                {
                    ComboBoxHomeTownCity.Items.Add(item.sehir_title);
                }
            }
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
                    ComboBoxCities.Items.Add(item.sehir_title);
                }
            }
        }

        private void AssignDistricts(string sehir_key)
        {
            ComboBoxDistricts.Items.Clear();

            ComboBoxDistricts.Items.Insert(0, "İLÇE");
            ComboBoxDistricts.SelectedIndex = 0;

            ComboBoxDistricts.Text = ComboBoxDistricts.SelectedIndex < 0 ? "İLÇE"
                : ComboBoxDistricts.Text = ComboBoxDistricts.SelectedText;

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
                    ComboBoxDistricts.Items.Add(item.ilce_title);
                }
            }
        }

        private void ComboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = ComboBoxCities.SelectedItem.ToString();
            var res = _cities.FirstOrDefault(x => x.sehir_title == selectedCity);

            if (res != null)
            {
                ComboBoxDistricts.Enabled = true;

                AssignDistricts(res.sehir_key);
            }

            ComboBoxDistricts.Enabled = ComboBoxCities.Text == "İL" ? false : true;
        }

        private void Search()
        {
            _personeller = _personelManager.GetAll().Data.ToList();
            var nufuslar = _nufusManager.GetAll().Data.ToList();

            Expression<Func<Personel, bool>> filterPersonel = null;
            Expression<Func<Nufus, bool>> filterNufus = null;

            Expression<Func<Personel, bool>> filterBirim = null;
            Expression<Func<Personel, bool>> filterUnvan = null;
            Expression<Func<Personel, bool>> filterEyt = null;
            Expression<Func<Personel, bool>> filterEskiCalisan = null;
            Expression<Func<Personel, bool>> filterCalismaYilAraligi = null;
            Expression<Func<Nufus, bool>> filterNufusKanGrubu = null;
            Expression<Func<Nufus, bool>> filterCinsiyet = null;
            Expression<Func<Nufus, bool>> filterYas = null;
            Expression<Func<Nufus, bool>> filterMedeniHal = null;
            Expression<Func<Nufus, bool>> filterEsCalismaDurumu = null;
            Expression<Func<Nufus, bool>> filterCocukSayisi = null;
            Expression<Func<Nufus, bool>> filterMemleket = null;
            Expression<Func<Iletisim, bool>> filterIkametgah = null;
            Expression<Func<Tahsil, bool>> filterTahsilLisansUstu = null;
            Expression<Func<Tahsil, bool>> filterTahsilLisans = null;
            Expression<Func<Tahsil, bool>> filterTahsilOnLisans = null;
            Expression<Func<Tahsil, bool>> filterTahsilLise = null;
            Expression<Func<Tahsil, bool>> filterTahsilOrtaokul = null;
            Expression<Func<Tahsil, bool>> filterTahsilIlokul = null;
            Expression<Func<Tahsil, bool>> filterTahsil = null;

            #region Birim Filtresi

            if (ComboBoxTesisFilter.Text != "TESİS")
            {
                filterBirim = x => x.GorevYeri == ComboBoxTesisFilter.Text;
            }
            else if (ComboBoxSeflikFilter.Text != "ŞEFLİK")
            {
                filterBirim = x => x.Seflik == ComboBoxSeflikFilter.Text;
            }
            else if (ComboBoxMudurlukFilter.Text != "MÜDÜRLÜK")
            {
                filterBirim = x => x.Mudurluk == ComboBoxMudurlukFilter.Text;
            }

            #endregion

            #region Pozisyon Filtresi

            if (ComboBoxPozisyon.Text != "POZİSYON")
            {
                filterUnvan = x => x.Pozisyonu == ComboBoxPozisyon.Text;
            }
            else if (ComboBoxUnvanGrubu.Text != "ÜNVAN GRUBU")
            {
                filterUnvan = x => x.Unvani == ComboBoxUnvanGrubu.Text;
            }

            filterPersonel = filterBirim != null && filterUnvan != null ? PredicateBuilder.And(filterBirim, filterUnvan)
                : filterBirim != null && filterUnvan == null ? filterBirim
                : filterUnvan != null && filterBirim == null ? filterUnvan
                : null;

            _personeller = _personelManager.GetAll(filterPersonel).Data.ToList();

            #endregion

            #region Eski Çalışan Filtresi

            if (CheckBoxEskiCalisan.Checked)
            {
                filterEskiCalisan = x => x.CalisiyorMu == false;

                filterPersonel = filterEskiCalisan != null && filterPersonel != null ? PredicateBuilder.And(filterEskiCalisan, filterPersonel)
                : filterEskiCalisan != null && filterPersonel == null ? filterEskiCalisan
                : filterPersonel != null && filterEskiCalisan == null ? filterPersonel
                : null;

                _personeller = _personelManager.GetAll(filterPersonel).Data.ToList();
            }

            #endregion

            #region Eyt Filtresi

            if (ComboBoxEyt.Text != "SEÇİN")
            {
                if (ComboBoxEyt.Text == "YOK")
                {
                    filterEyt = x => x.EytDurumu == ComboBoxEyt.Text;
                }
                else if (ComboBoxEyt.Text == "HAK SAHİBİ")
                {
                    filterEyt = x => x.EytDurumu == ComboBoxEyt.Text;
                }
                else if (ComboBoxEyt.Text == "EMEKLİ")
                {
                    filterEyt = x => x.EytDurumu == ComboBoxEyt.Text;
                }
            }

            filterPersonel = filterPersonel != null && filterEyt != null ? PredicateBuilder.And(filterPersonel, filterEyt)
                : filterPersonel != null && filterEyt == null ? filterPersonel
                : filterPersonel == null && filterEyt != null ? filterEyt
                : null;

            _personeller = _personelManager.GetAll(filterPersonel).Data.ToList();

            #endregion

            #region Çalışma Yılı Aralığı

            if (!string.IsNullOrEmpty(TextBoxMinExpYear.Text) && !string.IsNullOrEmpty(TextBoxMaxExpYear.Text))
            {
                if (int.TryParse(TextBoxMinExpYear.Text, out int minYear))
                {
                    DateTime newDate = DateTime.Now.AddYears(-minYear);

                    if (int.TryParse(TextBoxMaxExpYear.Text, out int maxYear))
                    {
                        DateTime oldDate = DateTime.Now.AddYears(-maxYear);

                        filterCalismaYilAraligi = x => x.IseGirisTarihi > oldDate && x.IseGirisTarihi < newDate;

                        filterPersonel = filterPersonel != null && filterCalismaYilAraligi != null ? PredicateBuilder.And(filterPersonel, filterCalismaYilAraligi)
                            : filterPersonel != null && filterCalismaYilAraligi == null ? filterPersonel
                            : filterPersonel == null && filterCalismaYilAraligi != null ? filterCalismaYilAraligi
                            : null;

                        _personeller = _personelManager.GetAll(filterPersonel).Data.ToList();
                    }
                }
            }

            #endregion

            #region Kan Grubu Filtresi

            if (ComboBoxKanGrubu.Text != "KAN GRUBU")
            {
                filterNufusKanGrubu = x => x.KanGrubu == ComboBoxKanGrubu.Text;
            }

            #endregion

            #region Cinsiyet Filtresi

            if (RadioButtonMale.Checked || RadioButtonFemale.Checked)
            {
                var cinsiyet = RadioButtonMale.Checked ? RadioButtonMale.Text : RadioButtonFemale.Text;

                filterCinsiyet = x => x.Cinsiyet == cinsiyet;
            }

            #endregion

            filterNufus = filterNufusKanGrubu != null && filterCinsiyet != null ? PredicateBuilder.And(filterNufusKanGrubu, filterCinsiyet)
                : filterNufusKanGrubu != null && filterCinsiyet == null ? filterNufusKanGrubu
                : filterCinsiyet != null && filterNufusKanGrubu == null ? filterCinsiyet
                : null;

            #region Yaş Filtresi

            if (int.TryParse(TextBoxMinAge.Text, out var minAge))
            {
                if (int.TryParse(TextBoxMaxAge.Text, out var maxAge))
                {
                    var minAgeDt = DateTime.Now.AddYears(-minAge);

                    var maxAgeDt = DateTime.Now.AddYears(-maxAge);

                    filterYas = x => x.DogumTarihi > maxAgeDt && x.DogumTarihi < minAgeDt;
                }
            }

            filterNufus = filterYas != null && filterNufus != null ? PredicateBuilder.And(filterNufus, filterYas)
                : filterYas != null && filterNufus == null ? filterYas
                : filterNufus != null && filterYas == null ? filterNufus
                : null;

            #endregion

            #region Medeni Hal Filtresi

            if (RadioButtonMarried.Checked || RadioButtonSingle.Checked)
            {
                string medeniHal = RadioButtonMarried.Checked ? RadioButtonMarried.Text : RadioButtonSingle.Text;

                filterMedeniHal = x => x.MedeniHali == medeniHal;
            }

            filterNufus = filterMedeniHal != null && filterNufus != null ? PredicateBuilder.And(filterNufus, filterMedeniHal)
                : filterMedeniHal != null && filterNufus == null ? filterMedeniHal
                : filterNufus != null && filterMedeniHal == null ? filterNufus
                : null;

            #endregion

            #region Eş Çalışma Durumu Filtresi

            if (RadioButtonSpouseWorking.Checked || RadioButtonSpouseNotWorking.Checked)
            {
                string esCalismaDurumu = RadioButtonSpouseWorking.Checked ? RadioButtonSpouseWorking.Text : RadioButtonSpouseNotWorking.Text;

                filterEsCalismaDurumu = x => x.EsCalismaDurumu == esCalismaDurumu;
            }

            filterNufus = filterEsCalismaDurumu != null && filterNufus != null ? PredicateBuilder.And(filterNufus, filterEsCalismaDurumu)
                : filterEsCalismaDurumu != null && filterNufus == null ? filterEsCalismaDurumu
                : filterNufus != null && filterEsCalismaDurumu == null ? filterNufus
                : null;

            #endregion

            #region Çocuk Sayısı Filtre

            if (int.TryParse(TextBoxMinKid.Text, out int minKid))
            {
                if (int.TryParse(TextBoxMaxKid.Text, out int maxKid))
                {
                    var _cocuklar = _cocukManager.GetAll().Data;

                    var existPersoneller = _cocuklar.GroupBy(c => c.PersonelId).Where(c => c.Count() >= minKid && c.Count() <= maxKid).Select(g => g.Key).ToList();

                    _personeller = _personeller.Where(p => existPersoneller.Contains(p.Id)).ToList();
                }
            }

            filterNufus = filterCocukSayisi != null && filterNufus != null ? PredicateBuilder.And(filterNufus, filterCocukSayisi)
                : filterCocukSayisi != null && filterNufus == null ? filterCocukSayisi
                : filterNufus != null && filterCocukSayisi == null ? filterNufus
                : null;

            #endregion

            #region Tahsil Filtresi

            if (CheckBoxYuksekLisans.Checked || CheckBoxLisans.Checked || CheckBoxOnLisans.Checked || CheckBoxLise.Checked || CheckBoxOrtaokul.Checked || CheckBoxIlkokul.Checked)
            {
                bool yuksekLisans = CheckBoxYuksekLisans.Checked;
                bool lisans = CheckBoxLisans.Checked;
                bool onLisans = CheckBoxOnLisans.Checked;
                bool lise = CheckBoxLise.Checked;
                bool ortaOkul = CheckBoxOrtaokul.Checked;
                bool ilkOkul = CheckBoxIlkokul.Checked;

                if (yuksekLisans == true)
                {
                    filterTahsilLisansUstu = t => t.TahsilTuru == "YÜKSEK LİSANS" || t.TahsilTuru == "DOKTORA";
                }
                else if (lisans == true)
                {
                    filterTahsilLisans = t => t.TahsilTuru == CheckBoxYuksekLisans.Text;
                }
                else if (onLisans == true)
                {
                    filterTahsilOnLisans = t => t.TahsilTuru == CheckBoxOnLisans.Text;
                }
                else if (lise == true)
                {
                    filterTahsilLise = t => t.TahsilTuru == CheckBoxLise.Text;
                }
                else if (ortaOkul == true)
                {
                    filterTahsilOrtaokul = t => t.TahsilTuru == CheckBoxOrtaokul.Text;
                }
                else if (ilkOkul == true)
                {
                    filterTahsilIlokul = t => t.TahsilTuru == CheckBoxIlkokul.Text;
                }

                filterTahsil = filterTahsilLisansUstu != null && filterTahsilLisans != null ? PredicateBuilder.And(filterTahsilLisansUstu, filterTahsilLisans)
                    : filterTahsilLisansUstu != null && filterTahsilLisans == null ? filterTahsilLisansUstu
                    : filterTahsilLisans != null && filterTahsilLisansUstu == null ? filterTahsilLisans
                    : null;

                filterTahsil = filterTahsilLise != null && filterTahsil != null ? PredicateBuilder.And(filterTahsilLise, filterTahsil)
                    : filterTahsilLise != null && filterTahsil == null ? filterTahsilLise
                    : filterTahsilLise == null && filterTahsil != null ? filterTahsil
                    : null;

                filterTahsil = filterTahsilOrtaokul != null && filterTahsil != null ? PredicateBuilder.And(filterTahsilOrtaokul, filterTahsil)
                    : filterTahsilOrtaokul != null && filterTahsil == null ? filterTahsilOrtaokul
                    : filterTahsilOrtaokul == null && filterTahsil != null ? filterTahsil
                    : null;

                filterTahsil = filterTahsilIlokul != null && filterTahsil != null ? PredicateBuilder.And(filterTahsilIlokul, filterTahsil)
                    : filterTahsilIlokul != null && filterTahsil == null ? filterTahsilIlokul
                    : filterTahsilIlokul == null && filterTahsil != null ? filterTahsil
                    : null;
            }

            #endregion

            #region İkametgah Filtresi

            if (ComboBoxCities.Text != "İL")
            {
                filterIkametgah = x => x.Il == ComboBoxCities.Text;

                if (ComboBoxDistricts.Text != "İLÇE")
                {
                    filterIkametgah = x => x.Ilce == ComboBoxDistricts.Text;
                }
            }

            #endregion

            #region Memleket Filtresi

            if (ComboBoxHomeTownCity.Text != "İL")
            {
                filterMemleket = x => x.NufusaKayitliOlduguIl == ComboBoxHomeTownCity.Text;
            }

            filterNufus = filterMemleket != null && filterNufus != null ? PredicateBuilder.And(filterNufus, filterMemleket)
                : filterMemleket != null && filterNufus == null ? filterMemleket
                : filterNufus != null && filterMemleket == null ? filterNufus
                : null;

            #endregion

            var resTahsil = _tahsilManager.GetAll(filterTahsil).Data;
            var resNufus = _nufusManager.GetAll(filterNufus).Data;
            var resIletisim = _iletisimManager.GetAll(filterIkametgah).Data;

            var nufusPersonelIds = new HashSet<int>(resNufus.Select(n => n.PersonelId));
            var tahsilPersonelIds = new HashSet<int>(resTahsil.Select(t => t.PersonelId));
            var iletisimPersonelIds = new HashSet<int>(resIletisim.Select(i => i.PersonelId));

            _personeller = _personeller.Where(p => nufusPersonelIds.Contains(p.Id)).ToList();
            _personeller = _personeller.Where(p => iletisimPersonelIds.Contains(p.Id)).ToList();

            if (resTahsil.Count != 0)
            {
                _personeller = _personeller.Where(p => tahsilPersonelIds.Contains(p.Id)).ToList();
            }

            DataGridViewEmployees.DataSource = _personeller;
            DataGridViewEmployees.Refresh();
        }

        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSort.Text == "İsme Göre A-Z ↓")
            {
                _personeller = _personeller.OrderBy(p => p.Adi).ToList();
            }
            else if (ComboBoxSort.Text == "İsme Göre Z-A ↓")
            {
                _personeller = _personeller.OrderByDescending(p => p.Adi).ToList();
            }
            else if (ComboBoxSort.Text == "Girişe Göre Yeni ↓")
            {
                _personeller = _personeller.OrderBy(p => p.IseGirisTarihi).ToList();
            }
            else if (ComboBoxSort.Text == "Girişe Göre Eski ↓")
            {
                _personeller = _personeller.OrderByDescending(p => p.IseGirisTarihi).ToList();
            }
            else if (ComboBoxSort.Text == "Birime Göre A-Z ↓")
            {
                _personeller = _personeller.OrderByDescending(p => p.Seflik).ToList();
            }
            else if (ComboBoxSort.Text == "Birime Göre Z-A ↓")
            {
                _personeller = _personeller.OrderByDescending(p => p.Seflik).ToList();
            }

            DataGridViewEmployees.DataSource = _personeller;
            DataGridViewEmployees.Refresh();
        }

        private void TextBoxSmartFilter_TextChanged(object sender, EventArgs e)
        {
            var filteredPersonels = _personeller.Where(entity =>
            {
                foreach (PropertyInfo property in entity.GetType().GetProperties())
                {
                    var value = property.GetValue(entity);

                    if (value != null && value.ToString().IndexOf(TextBoxSmartFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        return true;
                    }
                }

                return false;
            }).ToList();

            DataGridViewEmployees.DataSource = filteredPersonels.ToList();
            DataGridViewEmployees.Refresh();
        }
    }
}
