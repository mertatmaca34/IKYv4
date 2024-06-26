using Business.Abstract;
using Entities.Concrete;
using IKYv4.Utilities.Extensions;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormPuantage : Form
    {
        private readonly IPersonelManager _personelManager;
        private readonly IPuantajManager _puantajManager;
        private readonly IUnvanGrubuManager _unvanGrubuManager;

        private List<Personel> _personelData;
        private List<Puantaj> _puantajData;
        private List<UnvanGrubu> _unvanGrubuData;

        public FormPuantage(IPersonelManager personelManager, IPuantajManager puantajManager, IUnvanGrubuManager unvanGrubuManager)
        {
            _personelManager = personelManager;
            _puantajManager = puantajManager;
            _unvanGrubuManager = unvanGrubuManager;

            _personelData = _personelManager.GetAll().Data;
            _puantajData = _puantajManager.GetAll().Data;
            _unvanGrubuData = _unvanGrubuManager.GetAll().Data;

            UpdatePuantageTable();

            InitializeComponent();

            AddPuantageToReportViewer();
        }

        private void FormPuantage_Load(object sender, EventArgs e)
        {
            UpdatePuantageTable();
            AddPuantageToReportViewer();
        }

        private void ButtonSetPuantage_Click(object sender, EventArgs e)
        {
            UpdatePuantageTable();
            AddPuantageToReportViewer();
        }

        private void UpdatePuantageTable()
        {
            DateTime YilAy = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            if (_personelData.Count > 0)
            {
                foreach (var item in _personelData)
                {
                    var personelPuantaj = _puantajData.Find(x => x.PersonelId == item.Id) ?? new Puantaj();

                    var zeroPuantaj = new Puantaj();

                    var gunler = new List<string>
                    {
                        nameof(personelPuantaj.Gun1),
                        nameof(personelPuantaj.Gun2),
                        nameof(personelPuantaj.Gun3),
                        nameof(personelPuantaj.Gun4),
                        nameof(personelPuantaj.Gun5),
                        nameof(personelPuantaj.Gun6),
                        nameof(personelPuantaj.Gun7),
                        nameof(personelPuantaj.Gun8),
                        nameof(personelPuantaj.Gun9),
                        nameof(personelPuantaj.Gun10),
                        nameof(personelPuantaj.Gun11),
                        nameof(personelPuantaj.Gun12),
                        nameof(personelPuantaj.Gun13),
                        nameof(personelPuantaj.Gun14),
                        nameof(personelPuantaj.Gun15),
                        nameof(personelPuantaj.Gun16),
                        nameof(personelPuantaj.Gun17),
                        nameof(personelPuantaj.Gun18),
                        nameof(personelPuantaj.Gun19),
                        nameof(personelPuantaj.Gun20),
                        nameof(personelPuantaj.Gun21),
                        nameof(personelPuantaj.Gun22),
                        nameof(personelPuantaj.Gun23),
                        nameof(personelPuantaj.Gun24),
                        nameof(personelPuantaj.Gun25),
                        nameof(personelPuantaj.Gun26),
                        nameof(personelPuantaj.Gun27),
                        nameof(personelPuantaj.Gun28),
                        nameof(personelPuantaj.Gun29),
                        nameof(personelPuantaj.Gun30),
                        nameof(personelPuantaj.Gun31)
                    };

                    for (int i = 1; i <= 31; i++)
                    {
                        var property = personelPuantaj.GetType().GetProperty(gunler[i - 1]);

                        if ((string)property.GetValue(property) == "X")
                        {
                            zeroPuantaj.CalisilanGun += 1;
                        }
                        else if ((string)property.GetValue(property) == "R")
                        {
                            zeroPuantaj.RaporluGun += 1;
                        }
                        else if ((string)property.GetValue(property) == "M")
                        {
                            zeroPuantaj.MazeretliGun += 1;
                        }
                        else if ((string)property.GetValue(property) == "İ")
                        {
                            zeroPuantaj.UcretliIzin += 1;
                        }
                        else if ((string)property.GetValue(property) == "Üİ")
                        {
                            zeroPuantaj.UcretsizIzin += 1;
                        }
                        else if ((string)property.GetValue(property) == "Yİ")
                        {
                            zeroPuantaj.YillikIzin += 1;
                        }
                        else if ((string)property.GetValue(property) == "T")
                        {
                            zeroPuantaj.HaftalikTatil += 1;
                        }
                        else if ((string)property.GetValue(property) == "RT")
                        {
                            zeroPuantaj.ResmiTatil += 1;
                        }
                        else if ((string)property.GetValue(property) == "İC")
                        {
                            zeroPuantaj.IdariDisiplinCezasi += 1;
                        }
                    }

                    zeroPuantaj.ToplamGun = gunler.Count;

                    Puantaj puantaj = new Puantaj
                    {
                        PersonelId = item.Id,
                        AdiSoyadi = item.Adi + " " + item.Soyadi,
                        YilAy = YilAy,
                        Gun1 = personelPuantaj.Gun1.DidTheyWork(),
                        Gun2 = personelPuantaj.Gun2.DidTheyWork(),
                        Gun3 = personelPuantaj.Gun3.DidTheyWork(),
                        Gun4 = personelPuantaj.Gun4.DidTheyWork(),
                        Gun5 = personelPuantaj.Gun5.DidTheyWork(),
                        Gun6 = personelPuantaj.Gun6.DidTheyWork(),
                        Gun7 = personelPuantaj.Gun7.DidTheyWork(),
                        Gun8 = personelPuantaj.Gun8.DidTheyWork(),
                        Gun9 = personelPuantaj.Gun9.DidTheyWork(),
                        Gun10 = personelPuantaj.Gun10.DidTheyWork(),
                        Gun11 = personelPuantaj.Gun11.DidTheyWork(),
                        Gun12 = personelPuantaj.Gun12.DidTheyWork(),
                        Gun13 = personelPuantaj.Gun13.DidTheyWork(),
                        Gun14 = personelPuantaj.Gun14.DidTheyWork(),
                        Gun15 = personelPuantaj.Gun15.DidTheyWork(),
                        Gun16 = personelPuantaj.Gun16.DidTheyWork(),
                        Gun17 = personelPuantaj.Gun17.DidTheyWork(),
                        Gun18 = personelPuantaj.Gun18.DidTheyWork(),
                        Gun19 = personelPuantaj.Gun19.DidTheyWork(),
                        Gun20 = personelPuantaj.Gun20.DidTheyWork(),
                        Gun21 = personelPuantaj.Gun21.DidTheyWork(),
                        Gun22 = personelPuantaj.Gun22.DidTheyWork(),
                        Gun23 = personelPuantaj.Gun23.DidTheyWork(),
                        Gun24 = personelPuantaj.Gun24.DidTheyWork(),
                        Gun25 = personelPuantaj.Gun25.DidTheyWork(),
                        Gun26 = personelPuantaj.Gun26.DidTheyWork(),
                        Gun27 = personelPuantaj.Gun27.DidTheyWork(),
                        Gun28 = personelPuantaj.Gun28.DidTheyWork(),
                        Gun29 = personelPuantaj.Gun29.DidTheyWork(),
                        Gun30 = personelPuantaj.Gun30.DidTheyWork(),
                        Gun31 = personelPuantaj.Gun31.DidTheyWork(),
                        CalisilanGun = zeroPuantaj.CalisilanGun,
                        RaporluGun = zeroPuantaj.RaporluGun,
                        MazeretliGun = zeroPuantaj.MazeretliGun,
                        UcretsizIzin = zeroPuantaj.UcretsizIzin,
                        YillikIzin = zeroPuantaj.YillikIzin,
                        UcretliIzin = zeroPuantaj.UcretliIzin,
                        HaftalikTatil = zeroPuantaj.HaftalikTatil,
                        ResmiTatil = zeroPuantaj.ResmiTatil,
                        IdariDisiplinCezasi = zeroPuantaj.IdariDisiplinCezasi,
                        ToplamGun = zeroPuantaj.ToplamGun,
                        MaasOdemeYapilmamasinaEsasGun = zeroPuantaj.MaasOdemeYapilmamasinaEsasGun,
                        MaasOdemesineEsasGun = zeroPuantaj.MaasOdemesineEsasGun,
                        YolOdemesineEsasGun = zeroPuantaj.YolOdemesineEsasGun,
                        YemekOdemesineEsasGun = zeroPuantaj.YemekOdemesineEsasGun,
                        UlBayVeGenResTatCalisilanGun = zeroPuantaj.UlBayVeGenResTatCalisilanGun,
                        FazlCalismaSaati = zeroPuantaj.FazlCalismaSaati,

                    };

                    _puantajManager.Add(puantaj);
                }
            }
        }

        private void AddPuantageToReportViewer()
        {
            _personelData = _personelManager.GetAll().Data;
            _puantajData = _puantajManager.GetAll().Data;
            _unvanGrubuData = _unvanGrubuManager.GetAll().Data;

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Personeller", _personelData));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("UnvanGruplari", _unvanGrubuData));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Puantajlar", _puantajData));

            SetReportViewer();

            this.reportViewer1.RefreshReport();
        }

        private void SetReportViewer()
        {
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;

            PaperSize paperSize = new PaperSize("A3", 297, 420)
            {
                Width = (int)(297 / 25.4 * 100), // 297 mm to hundredths of an inch
                Height = (int)(420 / 25.4 * 100) // 420 mm to hundredths of an inch
            };

            // Sayfa ayarlarını tanımlayın
            PageSettings pageSettings = new PageSettings
            {
                PaperSize = paperSize,
                Landscape = true,
                Margins = new Margins(38, 38, 38, 38) // 1 cm = 40 hundredths of an inch
            };

            // ReportViewer'a sayfa ayarlarını uygulayın
            reportViewer1.SetPageSettings(pageSettings);
        }
    }
}
