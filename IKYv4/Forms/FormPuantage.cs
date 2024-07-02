using Business.Abstract;
using Entities.Concrete;
using IKYv4.Utilities.Extensions;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormPuantage : Form
    {
        private readonly IPersonelManager _personelManager;
        private readonly IPuantajManager _puantajManager;
        private readonly IUnvanGrubuManager _unvanGrubuManager;
        private readonly ICalismaSaatleriManager _calismaSaatleriManager;

        private List<Personel> _personelData;
        private List<Puantaj> _puantajData;
        private List<UnvanGrubu> _unvanGrubuData;

        public FormPuantage(IPersonelManager personelManager, IPuantajManager puantajManager, IUnvanGrubuManager unvanGrubuManager, ICalismaSaatleriManager calismaSaatleriManager)
        {
            _personelManager = personelManager;
            _puantajManager = puantajManager;
            _unvanGrubuManager = unvanGrubuManager;
            _calismaSaatleriManager = calismaSaatleriManager;

            _personelData = _personelManager.GetAll().Data;
            _puantajData = _puantajManager.GetAll().Data;
            _unvanGrubuData = _unvanGrubuManager.GetAll().Data;

            UpdatePuantageTable(DateTime.Now);

            InitializeComponent();

            AddPuantageToReportViewer(DateTimePickerPuantageMonth.Value);
        }

        private void FormPuantage_Load(object sender, EventArgs e)
        {
            UpdatePuantageTable(DateTimePickerPuantageMonth.Value);
            AddPuantageToReportViewer(DateTimePickerPuantageMonth.Value);
        }

        private void ButtonSetPuantage_Click(object sender, EventArgs e)
        {
            UpdatePuantageTable(DateTimePickerPuantageMonth.Value);
            AddPuantageToReportViewer(DateTimePickerPuantageMonth.Value);
        }

        private void UpdatePuantageTable(DateTime dateTime)
        {
            DateTime YilAy = new DateTime(dateTime.Year, dateTime.Month, 1);

            if (_personelData.Count > 0)
            {
                foreach (var personel in _personelData)
                {
                    _puantajData = _puantajManager.GetAll().Data;

                    var personelPuantaj = _puantajData.Find(x=> x.YilAy.Month == YilAy.Month);

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

                        if ((string)property.GetValue(personelPuantaj) == "X")
                        {
                            zeroPuantaj.CalisilanGun += 1;
                        }
                        else if ((string)property.GetValue(personelPuantaj) == "R")
                        {
                            zeroPuantaj.RaporluGun += 1;
                        }
                        else if ((string)property.GetValue(personelPuantaj) == "M")
                        {
                            zeroPuantaj.MazeretliGun += 1;
                        }
                        else if ((string)property.GetValue(personelPuantaj) == "İ")
                        {
                            zeroPuantaj.UcretliIzin += 1;
                        }
                        else if ((string)property.GetValue(personelPuantaj) == "Üİ")
                        {
                            zeroPuantaj.UcretsizIzin += 1;
                        }
                        else if ((string)property.GetValue(personelPuantaj) == "Yİ")
                        {
                            zeroPuantaj.YillikIzin += 1;
                        }
                        else if ((string)property.GetValue(personelPuantaj) == "T")
                        {
                            zeroPuantaj.HaftalikTatil += 1;
                        }
                        else if ((string)property.GetValue(personelPuantaj) == "RT")
                        {
                            zeroPuantaj.ResmiTatil += 1;
                        }
                        else if ((string)property.GetValue(personelPuantaj) == "İC")
                        {
                            zeroPuantaj.IdariDisiplinCezasi += 1;
                        }
                    }

                    zeroPuantaj.ToplamGun = gunler.Count;

                    var ayinGunu = YilAy.AddDays(1).DayOfWeek;

                    var resCalismaSaatleri = _calismaSaatleriManager.GetAll(p => p.PersonelId == personel.Id).Data.FirstOrDefault();

                    Puantaj puantaj = new Puantaj
                    {
                        PersonelId = personel.Id,
                        AdiSoyadi = personel.Adi + " " + personel.Soyadi,
                        YilAy = YilAy,
                        Gun1 = personelPuantaj.Gun1.DidTheyWork(YilAy.DayOfWeek, resCalismaSaatleri),
                        Gun2 = personelPuantaj.Gun2.DidTheyWork(YilAy.AddDays(1).DayOfWeek, resCalismaSaatleri),
                        Gun3 = personelPuantaj.Gun3.DidTheyWork(YilAy.AddDays(2).DayOfWeek, resCalismaSaatleri),
                        Gun4 = personelPuantaj.Gun4.DidTheyWork(YilAy.AddDays(3).DayOfWeek, resCalismaSaatleri),
                        Gun5 = personelPuantaj.Gun5.DidTheyWork(YilAy.AddDays(4).DayOfWeek, resCalismaSaatleri),
                        Gun6 = personelPuantaj.Gun6.DidTheyWork(YilAy.AddDays(5).DayOfWeek, resCalismaSaatleri),
                        Gun7 = personelPuantaj.Gun7.DidTheyWork(YilAy.AddDays(6).DayOfWeek, resCalismaSaatleri),
                        Gun8 = personelPuantaj.Gun8.DidTheyWork(YilAy.AddDays(7).DayOfWeek, resCalismaSaatleri),
                        Gun9 = personelPuantaj.Gun9.DidTheyWork(YilAy.AddDays(8).DayOfWeek, resCalismaSaatleri),
                        Gun10 = personelPuantaj.Gun10.DidTheyWork(YilAy.AddDays(9).DayOfWeek, resCalismaSaatleri),
                        Gun11 = personelPuantaj.Gun11.DidTheyWork(YilAy.AddDays(10).DayOfWeek, resCalismaSaatleri),
                        Gun12 = personelPuantaj.Gun12.DidTheyWork(YilAy.AddDays(11).DayOfWeek, resCalismaSaatleri),
                        Gun13 = personelPuantaj.Gun13.DidTheyWork(YilAy.AddDays(12).DayOfWeek, resCalismaSaatleri),
                        Gun14 = personelPuantaj.Gun14.DidTheyWork(YilAy.AddDays(13).DayOfWeek, resCalismaSaatleri),
                        Gun15 = personelPuantaj.Gun15.DidTheyWork(YilAy.AddDays(14).DayOfWeek, resCalismaSaatleri),
                        Gun16 = personelPuantaj.Gun16.DidTheyWork(YilAy.AddDays(15).DayOfWeek, resCalismaSaatleri),
                        Gun17 = personelPuantaj.Gun17.DidTheyWork(YilAy.AddDays(16).DayOfWeek, resCalismaSaatleri),
                        Gun18 = personelPuantaj.Gun18.DidTheyWork(YilAy.AddDays(17).DayOfWeek, resCalismaSaatleri),
                        Gun19 = personelPuantaj.Gun19.DidTheyWork(YilAy.AddDays(18).DayOfWeek, resCalismaSaatleri),
                        Gun20 = personelPuantaj.Gun20.DidTheyWork(YilAy.AddDays(19).DayOfWeek, resCalismaSaatleri),
                        Gun21 = personelPuantaj.Gun21.DidTheyWork(YilAy.AddDays(20).DayOfWeek, resCalismaSaatleri),
                        Gun22 = personelPuantaj.Gun22.DidTheyWork(YilAy.AddDays(21).DayOfWeek, resCalismaSaatleri),
                        Gun23 = personelPuantaj.Gun23.DidTheyWork(YilAy.AddDays(22).DayOfWeek, resCalismaSaatleri),
                        Gun24 = personelPuantaj.Gun24.DidTheyWork(YilAy.AddDays(23).DayOfWeek, resCalismaSaatleri),
                        Gun25 = personelPuantaj.Gun25.DidTheyWork(YilAy.AddDays(24).DayOfWeek, resCalismaSaatleri),
                        Gun26 = personelPuantaj.Gun26.DidTheyWork(YilAy.AddDays(25).DayOfWeek, resCalismaSaatleri),
                        Gun27 = personelPuantaj.Gun27.DidTheyWork(YilAy.AddDays(26).DayOfWeek, resCalismaSaatleri),
                        Gun28 = personelPuantaj.Gun28.DidTheyWork(YilAy.AddDays(27).DayOfWeek, resCalismaSaatleri),
                        Gun29 = personelPuantaj.Gun29.DidTheyWork(YilAy.AddDays(28).DayOfWeek, resCalismaSaatleri),
                        Gun30 = personelPuantaj.Gun30.DidTheyWork(YilAy.AddDays(29).DayOfWeek, resCalismaSaatleri),
                        Gun31 = personelPuantaj.Gun31.DidTheyWork(YilAy.AddDays(30).DayOfWeek, resCalismaSaatleri),
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

        private void AddPuantageToReportViewer(DateTime yilAy)
        {
            _personelData = _personelManager.GetAll().Data;
            _puantajData = _puantajManager.GetAll(x=> x.YilAy.Month ==  yilAy.Month).Data;
            _unvanGrubuData = _unvanGrubuManager.GetAll().Data;

            if(this.reportViewer1.LocalReport.DataSources.Count >= 1)
            {
                for (int i = 0; i < reportViewer1.LocalReport.DataSources.Count; i++)
                {
                    this.reportViewer1.LocalReport.DataSources.Remove(reportViewer1.LocalReport.DataSources[i]);
                }
            }
            
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Personeller", _personelData));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("UnvanGruplari", _unvanGrubuData));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Puantajlar", _puantajData));

            SetReportViewer();

            this.reportViewer1.Refresh();
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