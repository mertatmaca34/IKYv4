using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.TurkeyModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
        readonly ICocukManager _cocukManager;

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
                                            IIletisimManager iletisimManager,
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
            IResult res = UpdateData();

            MessageBox.Show(res.Message);

            this.Close();
        }

        private IResult UpdateData()
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

            return res;
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
            if (DataGridViewChild.DataSource != null)
            {
                DataGridViewChild.Columns[2].Visible = false;
                DataGridViewChild.Columns[3].Visible = false;
            }

            if (DataGridViewTahsil.DataSource != null)
            {
                DataGridViewTahsil.Columns[2].Visible = false;
                DataGridViewTahsil.Columns[3].Visible = false;
            }

            if (DataGridViewNakiller.DataSource != null)
            {
                DataGridViewNakiller.Columns[2].Visible = false;
                DataGridViewNakiller.Columns[3].Visible = false;
            }

            if (DataGridViewSertifikalar.DataSource != null)
            {
                DataGridViewSertifikalar.Columns[2].Visible = false;
                DataGridViewSertifikalar.Columns[3].Visible = false;
            }
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

            var res = _unvanGrubuManager.GetAll(x => x.UnvanGrubuAdi == ComboBoxTitle.Text).Data.FirstOrDefault();

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

        private void ButtonNewChild_Click(object sender, EventArgs e)
        {
            UpdateData();

            FormNewChild formNewChild = new FormNewChild(_cocukManager, _personel.Id);
            formNewChild.ShowDialog();

            var resCocukData = _cocukManager.GetAll(x=> x.PersonelId == _personel.Id).Data;

            DataGridViewChild.DataSource = resCocukData;
            DataGridViewChild.Refresh();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataGridViewChild.SelectedRows.Count > 0)
            {
                if (int.TryParse(DataGridViewChild.SelectedRows[0].Cells[1].Value.ToString(), out var cocukId))
                {
                    var resCocuk = _cocukManager.GetAll(c => c.Id == cocukId).Data.FirstOrDefault();
                    var res = _cocukManager.Delete(resCocuk);

                    MessageBox.Show(res.Message);

                    var updatedChildData = _cocukManager.GetAll(x => x.PersonelId == _personel.Id).Data;
                    DataGridViewChild.DataSource = updatedChildData;
                    DataGridViewChild.Refresh();
                }
            }
        }

        private void ButtonNewTahsil_Click(object sender, EventArgs e)
        {
            FormNewTahsil formNewTahsil = new FormNewTahsil(_tahsilManager, _personel.Id);
            formNewTahsil.ShowDialog();

            var resTahsil = _tahsilManager.GetAll(x => x.PersonelId == _personel.Id).Data;
            DataGridViewTahsil.DataSource = resTahsil;

            DataGridViewTahsil.Refresh();
        }

        private void ButtonSertifikaEkle_Click(object sender, EventArgs e)
        {
            FormNewSertifika formNewSertifika = new FormNewSertifika(_sertifikaManager, _personel.Id);
            formNewSertifika.ShowDialog();

            var resSertifika = _sertifikaManager.GetAll(x => x.PersonelId == _personel.Id).Data;
            DataGridViewSertifikalar.DataSource = resSertifika;

            DataGridViewSertifikalar.Refresh();
        }

        private void ButtonNakilEkle_Click(object sender, EventArgs e)
        {
            FormNewNakil formNewNakil = new FormNewNakil(_nakilManager, _personel.Id);
            formNewNakil.ShowDialog();

            var resNakil = _nakilManager.GetAll(x => x.PersonelId == _personel.Id).Data;
            DataGridViewNakiller.DataSource = resNakil;

            DataGridViewNakiller.Refresh();
        }

        private void DataGridViewChild_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var row = DataGridViewChild.Rows[e.RowIndex];

                int selectedCocukId = Convert.ToInt16(row.Cells[2].Value);
                int selectedPersonelId = Convert.ToInt16(row.Cells[3].Value);

                var selectedChild = _cocukManager.GetAll(c => c.Id == selectedCocukId).Data.FirstOrDefault();

                FormNewChild formNewChild = new FormNewChild(_cocukManager, selectedChild);
                formNewChild.ShowDialog();
            }

            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                var res = MessageBox.Show(Messages.DeleteCocuk, Messages.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    var cocukId = Convert.ToInt16(DataGridViewChild.SelectedCells[2].Value);

                    var isCocukExist = _cocukManager.GetAll(c=> c.Id == cocukId).Data.FirstOrDefault();

                    if (isCocukExist != null)
                    {
                        var resCocukDelete = _cocukManager.Delete(isCocukExist);

                        MessageBox.Show(resCocukDelete.Message, Messages.Info, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var updatedCocukList = _cocukManager.GetAll(c=> c.PersonelId == _personel.Id).Data.ToList();

                        DataGridViewChild.DataSource = updatedCocukList;

                        DataGridViewChild.Refresh();
                    }
                }
            }
        }

        private void DataGridViewTahsil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var row = DataGridViewTahsil.Rows[e.RowIndex];

                int selectedTahsilId = Convert.ToInt16(row.Cells[2].Value);
                int selectedPersonelId = Convert.ToInt16(row.Cells[3].Value);

                var selectedTahsil = _tahsilManager.GetAll(c => c.Id == selectedTahsilId).Data.FirstOrDefault();

                FormNewTahsil formNewTahsil = new FormNewTahsil(_tahsilManager, selectedTahsil);

                formNewTahsil.ShowDialog();
            }

            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                var res = MessageBox.Show(Messages.DeleteTahsil, Messages.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    var tahsilId = Convert.ToInt16(DataGridViewTahsil.SelectedCells[2].Value);

                    var isTahsilExist = _tahsilManager.GetAll(t => t.Id == tahsilId).Data.FirstOrDefault();

                    if (isTahsilExist != null)
                    {
                        var resTahsilDelete = _tahsilManager.Delete(isTahsilExist);

                        MessageBox.Show(resTahsilDelete.Message, Messages.Info, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var updatedTahsilList = _tahsilManager.GetAll(t => t.PersonelId == _personel.Id).Data.ToList();

                        DataGridViewTahsil.DataSource = updatedTahsilList;

                        DataGridViewTahsil.Refresh();
                    }
                }
            }
        }

        private void DataGridViewSertifikalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var row = DataGridViewSertifikalar.Rows[e.RowIndex];

                int selectedSertifikaId = Convert.ToInt16(row.Cells[2].Value);
                int selectedPersonelId = Convert.ToInt16(row.Cells[3].Value);

                var selectedSertifika = _sertifikaManager.GetAll(c => c.Id == selectedSertifikaId).Data.FirstOrDefault();

                FormNewSertifika formNewSertifika = new FormNewSertifika(_sertifikaManager, selectedSertifika);

                formNewSertifika.ShowDialog();
            }

            else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                var res = MessageBox.Show(Messages.DeleteSertifika, Messages.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.Yes)
                {
                    var sertifikaId = Convert.ToInt16(DataGridViewSertifikalar.SelectedCells[2].Value);

                    var isSertifikaExist = _sertifikaManager.GetAll(t => t.Id == sertifikaId).Data.FirstOrDefault();

                    if (isSertifikaExist != null)
                    {
                        var resSertifikaDelete = _sertifikaManager.Delete(isSertifikaExist);

                        MessageBox.Show(resSertifikaDelete.Message, Messages.Info, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var updatedSertifikaList = _sertifikaManager.GetAll(t => t.PersonelId == _personel.Id).Data.ToList();

                        DataGridViewSertifikalar.DataSource = updatedSertifikaList;

                        DataGridViewSertifikalar.Refresh();
                    }
                }
            }
        }
    }
}