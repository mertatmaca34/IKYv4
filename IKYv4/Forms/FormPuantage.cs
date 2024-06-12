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
        public FormPuantage()
        {
            InitializeComponent();
        }

        private void FormPuantage_Load(object sender, EventArgs e)
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
                Margins = new Margins(40, 40, 40, 40) // 1 cm = 40 hundredths of an inch
            };

            // ReportViewer'a sayfa ayarlarını uygulayın
            reportViewer1.SetPageSettings(pageSettings);
        }
    }
}
