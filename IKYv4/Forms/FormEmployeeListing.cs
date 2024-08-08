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
                                   INakilManager nakilManager)
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
            _sertifikaManager = sertifikaManager;
            _iletisimManager = iletisimManager;
            _nakilManager = nakilManager;

            DataGridViewCustomization();
        }

        private void ButtonNewEmployee_Click(object sender, EventArgs e)
        {
            FormEmployeeRegistrationCard formEmployeeRegistrationCard = new FormEmployeeRegistrationCard(_personelManager, _mudurlukManager, _seflikManager, _tesisManager, _calismaSaatleriManager, _unvanGrubuManager, _unvanManager, _nufusManager, _tahsilManager, _nakilManager, _sertifikaManager, _iletisimManager);

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

                FormEmployeeRegistrationCard formEmployeeRegistrationCard = new FormEmployeeRegistrationCard(_personelManager, _mudurlukManager, _seflikManager, _tesisManager, _calismaSaatleriManager, _unvanGrubuManager, _unvanManager, _nufusManager, _tahsilManager, _nakilManager, _sertifikaManager, _iletisimManager);

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
                    formEmployeeRegistrationCard.RadioButtonMaried.Checked = selectedPersonelNufus.MedeniHali == "EVLİ";
                    formEmployeeRegistrationCard.TextBoxSpouseName.Text = selectedPersonelNufus.EsAdi;
                    formEmployeeRegistrationCard.RadioButtonSpouseWorks.Checked = selectedPersonelNufus.EsCalismaDurumu == "ÇALIŞIYOR";
                    formEmployeeRegistrationCard.RadioButtonSpouseNotWorks.Checked = selectedPersonelNufus.EsCalismaDurumu == "ÇALIŞMIYOR";
                    formEmployeeRegistrationCard.TextBoxSpouseJob.Text = selectedPersonelNufus.EsMeslegi;
                    formEmployeeRegistrationCard.TextBoxChildrenCount.Text = selectedPersonelNufus.CocukSayisi.ToString();
                    formEmployeeRegistrationCard.TextBoxWhereSpouseWorks.Text = selectedPersonelNufus.EsCalistigiKurumAdi;
                }

                var selectedPersonelTahsil = _tahsilManager.GetAll(x => x.PersonelId == selectedPersonel.Id).Data.FirstOrDefault();

                if (selectedPersonelTahsil != null)
                {
                    formEmployeeRegistrationCard.ComboBoxEducation1.SelectedItem = selectedPersonelTahsil.TahsilAdi1;
                    formEmployeeRegistrationCard.ComboBoxEducation2.SelectedItem = selectedPersonelTahsil.TahsilAdi2;
                    formEmployeeRegistrationCard.ComboBoxEducation3.SelectedItem = selectedPersonelTahsil.TahsilAdi3;
                    formEmployeeRegistrationCard.ComboBoxEducation4.SelectedItem = selectedPersonelTahsil.TahsilAdi4;
                    formEmployeeRegistrationCard.ComboBoxEducation5.SelectedItem = selectedPersonelTahsil.TahsilAdi5;
                    formEmployeeRegistrationCard.TextBoxSchool1.Text = selectedPersonelTahsil.OkulAdi1;
                    formEmployeeRegistrationCard.TextBoxSchool2.Text = selectedPersonelTahsil.OkulAdi2;
                    formEmployeeRegistrationCard.TextBoxSchool3.Text = selectedPersonelTahsil.OkulAdi3;
                    formEmployeeRegistrationCard.TextBoxSchool4.Text = selectedPersonelTahsil.OkulAdi4;
                    formEmployeeRegistrationCard.TextBoxSchool5.Text = selectedPersonelTahsil.OkulAdi5;
                    formEmployeeRegistrationCard.DateTimePickerGraduation1.Value = selectedPersonelTahsil.MezuniyetTarihi1.Value;
                    formEmployeeRegistrationCard.DateTimePickerGraduation2.Value = selectedPersonelTahsil.MezuniyetTarihi2.Value;
                    formEmployeeRegistrationCard.DateTimePickerGraduation3.Value = selectedPersonelTahsil.MezuniyetTarihi3.Value;
                    formEmployeeRegistrationCard.DateTimePickerGraduation4.Value = selectedPersonelTahsil.MezuniyetTarihi4.Value;
                    formEmployeeRegistrationCard.DateTimePickerGraduation5.Value = selectedPersonelTahsil.MezuniyetTarihi5.Value;
                }

                var selectedPersonelSertifika = _sertifikaManager.GetAll(p => p.PersonelId == selectedPersonel.Id).Data.FirstOrDefault();

                if (selectedPersonelSertifika != null)
                {
                    formEmployeeRegistrationCard.TextBoxSertificate1.Text = selectedPersonelSertifika.SertifikaAdi1;
                    formEmployeeRegistrationCard.TextBoxSertificate2.Text = selectedPersonelSertifika.SertifikaAdi2;
                    formEmployeeRegistrationCard.TextBoxSertificate3.Text = selectedPersonelSertifika.SertifikaAdi3;
                    formEmployeeRegistrationCard.TextBoxSertificate4.Text = selectedPersonelSertifika.SertifikaAdi4;
                    formEmployeeRegistrationCard.TextBoxSertificate5.Text = selectedPersonelSertifika.SertifikaAdi5;
                    formEmployeeRegistrationCard.TextBoxSertificate6.Text = selectedPersonelSertifika.SertifikaAdi6;
                }

                var selectedPersonelNakil = _nakilManager.GetAll(p => p.PersonelId == selectedPersonel.Id).Data.FirstOrDefault();

                if (selectedPersonelNakil != null)
                {
                    formEmployeeRegistrationCard.TextBoxInstitution1.Text = selectedPersonelNakil.Kurum1;
                    formEmployeeRegistrationCard.TextBoxInstitution2.Text = selectedPersonelNakil.Kurum2;
                    formEmployeeRegistrationCard.TextBoxInstitution3.Text = selectedPersonelNakil.Kurum3;
                    formEmployeeRegistrationCard.TextBoxInstitution4.Text = selectedPersonelNakil.Kurum4;
                    formEmployeeRegistrationCard.TextBoxInstitution5.Text = selectedPersonelNakil.Kurum5;
                    formEmployeeRegistrationCard.TextBoxInstitution6.Text = selectedPersonelNakil.Kurum6;
                    formEmployeeRegistrationCard.TextBoxDivision1.Text = selectedPersonelNakil.Birim1;
                    formEmployeeRegistrationCard.TextBoxDivision2.Text = selectedPersonelNakil.Birim2;
                    formEmployeeRegistrationCard.TextBoxDivision3.Text = selectedPersonelNakil.Birim3;
                    formEmployeeRegistrationCard.TextBoxDivision4.Text = selectedPersonelNakil.Birim4;
                    formEmployeeRegistrationCard.TextBoxDivision5.Text = selectedPersonelNakil.Birim5;
                    formEmployeeRegistrationCard.TextBoxDivision6.Text = selectedPersonelNakil.Birim6;
                    formEmployeeRegistrationCard.TextBoxJob1.Text = selectedPersonelNakil.Gorev1;
                    formEmployeeRegistrationCard.TextBoxJob2.Text = selectedPersonelNakil.Gorev2;
                    formEmployeeRegistrationCard.TextBoxJob3.Text = selectedPersonelNakil.Gorev3;
                    formEmployeeRegistrationCard.TextBoxJob4.Text = selectedPersonelNakil.Gorev4;
                    formEmployeeRegistrationCard.TextBoxJob5.Text = selectedPersonelNakil.Gorev5;
                    formEmployeeRegistrationCard.TextBoxJob6.Text = selectedPersonelNakil.Gorev6;
                    formEmployeeRegistrationCard.DateTimePickerStartDate1.Value = selectedPersonelNakil.BaslangicTarihi1;
                    formEmployeeRegistrationCard.DateTimePickerStartDate2.Value = selectedPersonelNakil.BaslangicTarihi2;
                    formEmployeeRegistrationCard.DateTimePickerStartDate3.Value = selectedPersonelNakil.BaslangicTarihi3;
                    formEmployeeRegistrationCard.DateTimePickerStartDate4.Value = selectedPersonelNakil.BaslangicTarihi4;
                    formEmployeeRegistrationCard.DateTimePickerStartDate5.Value = selectedPersonelNakil.BaslangicTarihi5;
                    formEmployeeRegistrationCard.DateTimePickerStartDate6.Value = selectedPersonelNakil.BaslangicTarihi6;
                    formEmployeeRegistrationCard.TextBoxDescription1.Text = selectedPersonelNakil.Aciklama1;
                    formEmployeeRegistrationCard.TextBoxDescription2.Text = selectedPersonelNakil.Aciklama2;
                    formEmployeeRegistrationCard.TextBoxDescription3.Text = selectedPersonelNakil.Aciklama3;
                    formEmployeeRegistrationCard.TextBoxDescription4.Text = selectedPersonelNakil.Aciklama4;
                    formEmployeeRegistrationCard.TextBoxDescription5.Text = selectedPersonelNakil.Aciklama5;
                    formEmployeeRegistrationCard.TextBoxDescription6.Text = selectedPersonelNakil.Aciklama6;
                }

                var selectedPersonelIletisim = _iletisimManager.GetAll(P => P.PersonelId == selectedPersonel.Id).Data.FirstOrDefault();

                if (selectedPersonelIletisim != null)
                {
                    formEmployeeRegistrationCard.TextBoxNeighbourhood.Text = selectedPersonelIletisim.Mahalle;
                    formEmployeeRegistrationCard.TextBoxStreet.Text = selectedPersonelIletisim.Sokak;
                    formEmployeeRegistrationCard.TextBoxDoorNumber.Text = selectedPersonelIletisim.KapiNo1;
                    formEmployeeRegistrationCard.TextBoxDistrict.Text = selectedPersonelIletisim.Ilce;
                    formEmployeeRegistrationCard.TextBoxCity.Text = selectedPersonelIletisim.Il;
                    formEmployeeRegistrationCard.TextBoxPhoneNumber.Text = selectedPersonelIletisim.CepTelNo1;
                    formEmployeeRegistrationCard.TextBoxPhoneNumber2.Text = selectedPersonelIletisim.CepTelNo2;
                    formEmployeeRegistrationCard.TextBoxMailAdress.Text = selectedPersonelIletisim.EMailAdresi;
                }

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


            ComboBoxCities.Items.Insert(0, "İL");
            ComboBoxCities.SelectedIndex = 0;

            ComboBoxCities.Text = ComboBoxCities.SelectedIndex < 0 ? "İL"
                : ComboBoxCities.Text = ComboBoxCities.SelectedText;


            ComboBoxDistricts.Items.Insert(0, "İLÇE");
            ComboBoxDistricts.SelectedIndex = 0;

            ComboBoxDistricts.Text = ComboBoxDistricts.SelectedIndex < 0 ? "İLÇE"
                : ComboBoxDistricts.Text = ComboBoxDistricts.SelectedText;

            AssignCities();
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

            var resNufus = _nufusManager.GetAll(filterNufus).Data;

            var nufusPersonelIds = new HashSet<int>(resNufus.Select(n => n.PersonelId));

            res = res.Where(p => nufusPersonelIds.Contains(p.Id)).ToList();

            DataGridViewEmployees.DataSource = res;
            DataGridViewEmployees.Refresh();
        }
    }
}
