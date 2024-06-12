using Business.Abstract;
using Entities.Concrete;
using IKYv4.Utilities;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormMain : Form
    {
        private readonly IPersonelManager _personelManager;
        private readonly IKullaniciManager _kullaniciManager;
        private readonly IMudurlukManager _mudurlukManager;
        private readonly ISeflikManager _seflikManager;
        private readonly ITesisManager _tesisManager;
        private readonly IIzinManager _izinManager;
        private readonly IUnvanGrubuManager _unvanGrubuManager;

        public FormMain(
            IPersonelManager personelManager,
            IKullaniciManager kullaniciManager,
            IMudurlukManager mudurlukManager,
            ISeflikManager seflikManager,
            ITesisManager tesisManager,
            IIzinManager izinManager,
            IUnvanGrubuManager unvanGrubuManager)
        {
            _personelManager = personelManager;
            _kullaniciManager = kullaniciManager;
            _mudurlukManager = mudurlukManager;
            _seflikManager = seflikManager;
            _tesisManager = tesisManager;
            _izinManager = izinManager;
            _unvanGrubuManager = unvanGrubuManager;

            InitializeComponent();
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            foreach (Form activeForm in PanelContent.Controls)
            {
                activeForm.Size = PanelContent.Size;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new FormLogin(_kullaniciManager, this));
            AddAdminToSystem();
        }


        private void ButtonEmployeeListing_Click(object sender, EventArgs e)
        {
            if (LabelUserName.Text != "Adı Soyadı")
            {
                PageChange.Change(PanelContent, this, new FormEmployeeListing(_personelManager, _mudurlukManager, _seflikManager, _tesisManager));
            }
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            FormEmployeeRegistrationCard formEmployeeRegistrationCard = new FormEmployeeRegistrationCard(_personelManager, _mudurlukManager, _seflikManager, _tesisManager);
            formEmployeeRegistrationCard.Show();
        }

        public void ShowEmployeeListingForm()
        {
            PageChange.Change(PanelContent, this, new FormEmployeeListing(_personelManager, _mudurlukManager, _seflikManager, _tesisManager));
        }

        private void AddAdminToSystem()
        {
            var isSystemAdminExist = _kullaniciManager.GetAll(k => k.GirisKullaniciAdi == "admin");

            if (isSystemAdminExist.Data.Count == 0)
            {
                Kullanici kullanici = new Kullanici()
                {
                    GirisAdi = "iski",
                    GirisSifre = "1Q2w3e",
                    GirisKullaniciAdi = "admin",
                    GirisSoyadi = "admin",
                    Seflik = "admin",
                    GirisGorevi = "admin",
                    GirisYetki = "admin",
                };

                _kullaniciManager.Add(kullanici);
            }
        }

        private void ButtonMainPage_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new FormLogin(_kullaniciManager, this));
            LabelUserName.Text = "Adı Soyadı";
        }

        private void LabelUserName_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPuantage_Click(object sender, EventArgs e)
        {
            var unvanGrubuData = _unvanGrubuManager.GetAll().Data;

            FormPuantage formPuantage = new FormPuantage();

            formPuantage.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("UnvanGruplariDataSet", unvanGrubuData));

            PageChange.Change(PanelContent, this, formPuantage);
        }

        private void ButtonEmployeVacation_Click(object sender, EventArgs e)
        {
            FormEmployeeVacation formEmployeeVacation = new FormEmployeeVacation(_personelManager, _mudurlukManager, _seflikManager, _tesisManager);
            formEmployeeVacation.ShowDialog();
        }
    }
}
