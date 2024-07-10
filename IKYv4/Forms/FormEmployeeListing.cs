using Business.Abstract;
using Entities.Concrete;
using LinqKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IKYv4.Forms
{
    public partial class FormEmployeeListing : Form
    {
        public Personel ChoosedPersonel { get; set; }

        IPersonelManager _personelManager;
        IMudurlukManager _mudurlukManager;
        ISeflikManager _seflikManager;
        ITesisManager _tesisManager;
        ICalismaSaatleriManager _calismaSaatleriManager;
        IUnvanGrubuManager _unvanGrubuManager;
        IUnvanManager _unvanManager;

        public FormEmployeeListing(IPersonelManager personelManager, IMudurlukManager mudurlukManager, ISeflikManager seflikManager, ITesisManager tesisManager, ICalismaSaatleriManager calismaSaatleriManager, IUnvanGrubuManager unvanGrubuManager, IUnvanManager unvanManager)
        {
            InitializeComponent();

            _personelManager = personelManager;
            _mudurlukManager = mudurlukManager;
            _seflikManager = seflikManager;
            _tesisManager = tesisManager;
            _calismaSaatleriManager = calismaSaatleriManager;
            _unvanGrubuManager = unvanGrubuManager;
            _unvanManager = unvanManager;

            DataGridViewCustomization();
        }

        private void ButtonNewEmployee_Click(object sender, EventArgs e)
        {
            FormEmployeeRegistrationCard formEmployeeRegistrationCard = new FormEmployeeRegistrationCard(_personelManager, _mudurlukManager, _seflikManager, _tesisManager, _calismaSaatleriManager, _unvanGrubuManager, _unvanManager);

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

                FormEmployeeRegistrationCard formEmployeeRegistrationCard = new FormEmployeeRegistrationCard(_personelManager, _mudurlukManager, _seflikManager, _tesisManager, _calismaSaatleriManager, _unvanGrubuManager, _unvanManager);

                formEmployeeRegistrationCard.ComboBoxConducting.Enabled = true;
                formEmployeeRegistrationCard.ComboBoxDirectorate.Enabled = true;
                formEmployeeRegistrationCard.ComboBoxDutyStation.Enabled = true;

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

                Bitmap bmp;

                if(selectedPersonel.ImageData != null)
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

            if(ComboBoxMudurlukFilter.Text != "MÜDÜRLÜK")
            {
                var resSeflikler = _seflikManager.GetAll(s=> s.MudurlukAdi == ComboBoxMudurlukFilter.Text).Data;

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
                var resUnvanGrubu = _unvanGrubuManager.GetAll(x=> x.UnvanGrubuAdi == ComboBoxUnvanGrubu.Text).Data.FirstOrDefault();
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
            Expression<Func<Personel, bool>> filterText = null;
            Expression<Func<Personel, bool>> filterBirim = null;
            Expression<Func<Personel, bool>> filterUnvan = null;
            Expression<Func<Nufus, bool>> filterNufusKanGrubu = null;
            Expression<Func<Personel, bool>> filterKanGrubu = null;

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

            if (ComboBoxPozisyon.Text != "POZİSYON")
            {
                filterUnvan = x => x.Pozisyonu == ComboBoxPozisyon.Text;
            }
            else if (ComboBoxUnvanGrubu.Text != "ÜNVAN GRUBU")
            {
                filterUnvan = x => x.Unvani == ComboBoxUnvanGrubu.Text;
            }

            if(ComboBoxKanGrubu.Text != "KAN GRUBU")
            {
                filterNufusKanGrubu = x=> x.KanGrubu == ComboBoxKanGrubu.Text;

                var resNufus = _nufusManager.GetAll();
            }

            filterText = filterBirim != null && filterUnvan != null ? PredicateBuilder.And(filterBirim, filterUnvan)
                : filterBirim != null && filterUnvan == null ? filterBirim
                : filterUnvan != null && filterBirim == null ? filterUnvan : null;

            var res = _personelManager.GetAll(filterText).Data.ToList();

            DataGridViewEmployees.DataSource = res;
            DataGridViewEmployees.Refresh();
        }
    }
}
