﻿using Business.Abstract;
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
            var personeller = _personelManager.GetAll().Data.ToList();
            var nufuslar = _nufusManager.GetAll().Data.ToList();

            Expression<Func<Personel, bool>> filterPersonel = null;
            Expression<Func<Nufus, bool>> filterNufus = null;

            Expression<Func<Personel, bool>> filterBirim = null;
            Expression<Func<Personel, bool>> filterUnvan = null;
            Expression<Func<Nufus, bool>> filterNufusKanGrubu = null;
            Expression<Func<Nufus, bool>> filterCinsiyet = null;
            Expression<Func<Nufus, bool>> filterYas = null;
            Expression<Func<Nufus, bool>> filterMedeniHal = null;
            Expression<Func<Nufus, bool>> filterEsCalismaDurumu = null;
            Expression<Func<Nufus, bool>> filterCocukSayisi = null;
            Expression<Func<Nufus, bool>> filterMemleket = null;
            Expression<Func<Iletisim, bool>> filterIkametgah = null;

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

            #endregion

            filterPersonel = filterBirim != null && filterUnvan != null ? PredicateBuilder.And(filterBirim, filterUnvan)
                : filterBirim != null && filterUnvan == null ? filterBirim
                : filterUnvan != null && filterBirim == null ? filterUnvan
                : null;

            var res = _personelManager.GetAll(filterPersonel).Data.ToList();

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
                    filterCocukSayisi = x => x.CocukSayisi >= minKid && x.CocukSayisi <= maxKid;
                }
            }

            filterNufus = filterCocukSayisi != null && filterNufus != null ? PredicateBuilder.And(filterNufus, filterCocukSayisi)
                : filterCocukSayisi != null && filterNufus == null ? filterCocukSayisi
                : filterNufus != null && filterCocukSayisi == null ? filterNufus
                : null;

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

            var resNufus = _nufusManager.GetAll(filterNufus).Data;
            var resIletisim = _iletisimManager.GetAll(filterIkametgah).Data;

            var nufusPersonelIds = new HashSet<int>(resNufus.Select(n => n.PersonelId));

            var iletisimPersonelIds = new HashSet<int>(resIletisim.Select(i => i.PersonelId));

            res = res.Where(p => nufusPersonelIds.Contains(p.Id)).ToList();
            res = res.Where(p => iletisimPersonelIds.Contains(p.Id)).ToList();

            DataGridViewEmployees.DataSource = res;
            DataGridViewEmployees.Refresh();
        }
    }
}
