using Business.Abstract;
using Entities.Concrete;
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
                    Puantaj puantaj = new Puantaj
                    {
                        PersonelId = item.Id,
                        AdiSoyadi = item.Adi + " " + item.Soyadi,
                        YilAy = YilAy,
                        Gun1 = "X",
                        Gun2 = "X",
                        Gun3 = "X",
                        Gun4 = "X",
                        Gun5 = "X",
                        Gun6 = "X",
                        Gun7 = "X",
                        Gun8 = "X",
                        Gun9 = "X",
                        Gun10 = "X",
                        Gun11 = "X",
                        Gun12 = "X",
                        Gun13 = "X",
                        Gun14 = "X",
                        Gun15 = "X",
                        Gun16 = "X",
                        Gun17 = "X",
                        Gun18 = "X",
                        Gun19 = "X",
                        Gun20 = "X",
                        Gun21 = "X",
                        Gun22 = "X",
                        Gun23 = "X",
                        Gun24 = "X",
                        Gun25 = "X",
                        Gun26 = "X",
                        Gun27 = "X",
                        Gun28 = "X",
                        Gun29 = "X",
                        Gun30 = "X",
                        Gun31 = "X",
                    };

                    _puantajManager.Add(puantaj);
                }
            }

            SetReportViewer();
        }
    }
}
