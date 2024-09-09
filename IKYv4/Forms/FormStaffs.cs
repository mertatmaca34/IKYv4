using Business.Abstract;
using Business.Constants;
using Core.Constants;
using Entities.Concrete;
using Entities.Enums;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormStaffs : Form
    {
        private readonly IMudurlukManager _mudurlukManager;
        private readonly ISeflikManager _seflikManager;
        private readonly IKadroDurumlariManager _kadroDurumlariManager;

        public FormStaffs(IMudurlukManager mudurlukManager, ISeflikManager seflikManager, IKadroDurumlariManager kadroDurumlariManager)
        {
            InitializeComponent();

            _mudurlukManager = mudurlukManager;
            _seflikManager = seflikManager;
            _kadroDurumlariManager = kadroDurumlariManager;
        }

        private void FrormStaffs_Load(object sender, EventArgs e)
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

        }

        private void ButtonSaveStaff_Click(object sender, EventArgs e)
        {
            if (ComboBoxSeflikFilter.Text != "ŞEFLİK")
            {
                var seflikId = _seflikManager.GetAll(x => x.SeflikAdi == ComboBoxSeflikFilter.Text).Data.FirstOrDefault().Id;

                foreach (var item in TableLayoutPanelKadrolar.Controls)
                {
                    if (item is TextBox textBox)
                    {
                        int.TryParse(textBox.Text, out var kadroSayisi);

                        KadroDurumlari kadroDurumlari = new KadroDurumlari
                        {
                            SeflikId = seflikId,
                            UnvanGrubuId = GetUnvanId(textBox),
                            KadroSayisi = kadroSayisi,
                        };

                        var res = _kadroDurumlariManager.GetAll(x => x.SeflikId == kadroDurumlari.SeflikId && x.UnvanGrubuId == kadroDurumlari.UnvanGrubuId).Data.FirstOrDefault();

                        if (res != null)
                        {
                            kadroDurumlari.Id = res.Id;
                        }

                        _kadroDurumlariManager.Add(kadroDurumlari);
                    }
                }

                MessageBox.Show(Messages.KadroDurumlariAdded, Captions.Info, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int GetUnvanId(TextBox textBox)
        {
            switch (textBox.Name)
            {
                case "TextBoxDeneyimliMuhendis":
                    return (int)UnvanGruplari.DeneyimliMuhendis;
                case "TextBoxMuhendis":
                    return (int)UnvanGruplari.Muhendis;
                case "TextBoxScadaSorumlusu":
                    return (int)UnvanGruplari.ScadaSorumlusu;
                case "TextBoxLaboratuvarAnalizcisi":
                    return (int)UnvanGruplari.LaboratuvarAnalizcisi;
                case "TextBoxFormen":
                    return (int)UnvanGruplari.Formen;
                case "TextBoxCamurVardiyaAmiri":
                    return (int)UnvanGruplari.CamirVardiyaAmiri;
                case "TextBoxBolgeScadaSistemBakim":
                    return (int)UnvanGruplari.BolgeScadaSistemBakim;
                case "TextBoxNumuneAlmaAnalizGorevlisi":
                    return (int)UnvanGruplari.NumuneAlmaAnalizGorevlisi;
                case "TextBoxBakimOperatoru":
                    return (int)UnvanGruplari.BakimOperatoru;
                case "TextBoxInsanKaynaklari":
                    return (int)UnvanGruplari.InsanKaynaklari;
                case "TextBoxTerfiMerkezOperatorleri":
                    return (int)UnvanGruplari.TerfiMerkeziOperatorleri;
                case "TextBoxSofor":
                    return (int)UnvanGruplari.Sofor;
                case "TextBoxGenelHizmetliPersoenl":
                    return (int)UnvanGruplari.GenelHizmetliPersonel;
                case "TextBoxKoyMahallePersoneli":
                    return (int)UnvanGruplari.KoyMahallePersoneli;
                case "TextBoxKoyMahalleOperatoru":
                    return (int)UnvanGruplari.KoyMahalleOperatoru;
                default:
                    return 0;
            }
        }
    }
}