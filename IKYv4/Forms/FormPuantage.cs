using Business.Abstract;
using Entities.Concrete;
using IKYv4.Utilities.Extensions;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormPuantage : Form
    {
        private readonly IPersonelManager _personelManager;
        private readonly IPuantajManager _puantajManager;
        private readonly IUnvanGrubuManager _unvanGrubuManager;

        public FormPuantage(IPersonelManager personelManager, IPuantajManager puantajManager, IUnvanGrubuManager unvanGrubuManager)
        {
            InitializeComponent();

            _personelManager = personelManager;
            _puantajManager = puantajManager;
            _unvanGrubuManager = unvanGrubuManager;
        }

        private void FormPuantage_Load(object sender, EventArgs e)
        {
            var personelDatas = _personelManager.GetAll().Data;
            var puantajDatas = _puantajManager.GetAll().Data;
            var unvanGruplariDatas = _unvanGrubuManager.GetAll().Data;

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Personeller", personelDatas));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("UnvanGruplari", unvanGruplariDatas));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Puantajlar", puantajDatas));

            this.reportViewer1.RefreshReport();

            SetReportViewer();
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

        private void ButtonSetPuantage_Click(object sender, EventArgs e)
        {
            var personelDatas = _personelManager.GetAll().Data;
            var puantajDatas = _puantajManager.GetAll().Data;
            var unvanGruplariDatas = _unvanGrubuManager.GetAll().Data;

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Personeller", personelDatas));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("UnvanGruplari", unvanGruplariDatas));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Puantajlar", puantajDatas));

            this.reportViewer1.RefreshReport();

            DateTime YilAy = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            if (personelDatas.Count > 0)
            {
                foreach (var item in personelDatas)
                {
                    var personelPuantaj = puantajDatas.Find(x => x.PersonelId == item.Id);

                    Puantaj puantaj = new Puantaj
                    {
                        PersonelId = item.Id,
                        AdiSoyadi = item.Adi + " " + item.Soyadi,
                        YilAy = YilAy,
                        Gun1 =  personelPuantaj.Gun1.DidTheyWork(),
                        Gun2 =  personelPuantaj.Gun2.DidTheyWork(),
                        Gun3 =  personelPuantaj.Gun3.DidTheyWork(),
                        Gun4 =  personelPuantaj.Gun4.DidTheyWork(),
                        Gun5 =  personelPuantaj.Gun5.DidTheyWork(),
                        Gun6 =  personelPuantaj.Gun6.DidTheyWork(),
                        Gun7 =  personelPuantaj.Gun7.DidTheyWork(),
                        Gun8 =  personelPuantaj.Gun8.DidTheyWork(),
                        Gun9 =  personelPuantaj.Gun9.DidTheyWork(),
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
                    };

                    _puantajManager.Add(puantaj);
                }
            }

            SetReportViewer();
        }
    }
}
