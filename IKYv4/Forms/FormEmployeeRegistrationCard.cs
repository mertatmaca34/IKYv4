﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        bool tiklandi = false;
        bool isItNew = true;

        private Personel _personel = new Personel();

        public FormEmployeeRegistrationCard(IPersonelManager personelManager, IMudurlukManager mudurlukManager, ISeflikManager seflikManager, ITesisManager tesisManager, ICalismaSaatleriManager calismaSaatleriManager)
        {
            InitializeComponent();

            _personelManager = personelManager;
            _mudurlukManager = mudurlukManager;
            _seflikManager = seflikManager;
            _tesisManager = tesisManager;
            _calismaSaatleriManager = calismaSaatleriManager;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var resPersonsel = _personelManager.GetAll(p=> p.TCKimlikNo == TextBoxUserId.Text);

            if(resPersonsel.Data.Count > 0)
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
            _personel.MK = double.Parse(TextBoxMk.Text);
            _personel.PK = double.Parse(TextBoxPk.Text);
            _personel.ToplamKatsayi = double.Parse(TextBoxTotalK.Text);
            _personel.CalisiyorMu = true;

            var res = _personelManager.Add(_personel);

            AssignDefaultShifts();

            MessageBox.Show(res.Message);

            this.Close();
        }

        private void AssignDefaultShifts()
        {
            if(isItNew)
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
            var res = _mudurlukManager.GetAll();

            if (res.Data.Count > 0)
            {
                foreach (var item in res.Data)
                {
                    ComboBoxDirectorate.Items.Add(item.MudurlukAdi);
                }
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
    }
}
