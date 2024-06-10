using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormLogin : Form
    {
        IKullaniciManager _kullaniciManager;
        FormMain _formMain;

        public FormLogin(IKullaniciManager kullaniciManager, FormMain formMain)
        {
            InitializeComponent();

            _kullaniciManager = kullaniciManager;
            _formMain = formMain;
        }

        private void ButtonHidePassword_Click(object sender, EventArgs e)
        {
            TextBoxPassword.UseSystemPasswordChar = !TextBoxPassword.UseSystemPasswordChar;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici()
            {
                GirisKullaniciAdi = TextBoxUserName.Text,
                GirisSifre = TextBoxPassword.Text,
            };

            var res = _kullaniciManager.GetAll(k => k.GirisKullaniciAdi == kullanici.GirisKullaniciAdi && k.GirisSifre == kullanici.GirisSifre);

            if (res.Success == false || kullanici.GirisKullaniciAdi == "" || kullanici.GirisSifre == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();

                _formMain.LabelUserName.Text = res.Data[0].GirisAdi;
                _formMain.ShowEmployeeListingForm();
            }
        }
    }
}
