using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace IKYv4.Forms
{
    public partial class FormEmployeeVacation : Form
    {
        Dictionary<string, string> izinler = new Dictionary<string, string>();
        Personel SecilmisPersonel { get; set; }

        IPersonelManager _personelManager;
        IMudurlukManager _mudurlukManager;
        ISeflikManager _seflikManager;
        ITesisManager _tesisManager;
        IIzinManager _izinManager;
        IPuantajManager _puantajManager;

        public FormEmployeeVacation(IPersonelManager personelManager, IMudurlukManager mudurlukManager, ISeflikManager seflikManager, ITesisManager tesisManager, IIzinManager izinManager, IPuantajManager puantajManager)
        {
            InitializeComponent();

            _personelManager = personelManager;
            _mudurlukManager = mudurlukManager;
            _seflikManager = seflikManager;
            _tesisManager = tesisManager;
            _izinManager = izinManager;
            _puantajManager = puantajManager;

            izinler.Add("ÇALIŞILAN GÜN", "X");
            izinler.Add("RAPOR İZNİ", "R");
            izinler.Add("MAZERET İZNİ", "M");
            izinler.Add("ÜCRETLİ İZİN", "İ");
            izinler.Add("ÜCRETSİZ İZİN", "Üİ");
            izinler.Add("YILLIK İZİN", "Yİ");
            izinler.Add("HAFTALIK TATİL", "T");
            izinler.Add("İŞTEN ÇIKIŞ", "Ç");
            izinler.Add("İŞE BAŞLAMADI", "O");
            izinler.Add("RESMİ TATİL", "RT");
            izinler.Add("İDARİ DİSİPLİN CEZASI", "İC");
        }

        private void ButtonEmployeeChoose_Click(object sender, EventArgs e)
        {
            FormEmployeeChoose formEmpployeeChose = new FormEmployeeChoose(_personelManager);
            formEmpployeeChose.ShowDialog();

            if (formEmpployeeChose.SeciliPersonel != null)
            {
                SecilmisPersonel = formEmpployeeChose.SeciliPersonel;
                TextBoxEmployee.Text = $"{formEmpployeeChose.SeciliPersonel.Adi} {formEmpployeeChose.SeciliPersonel.Soyadi}";
            }
        }

        private string GetIzinValue(Dictionary<string, string> izinler, string key)
        {
            if (izinler.TryGetValue(key, out string value))
            {
                return value;
            }

            return "X";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (SecilmisPersonel != null)
            {
                var puantajRes = _puantajManager.GetAll(p => p.PersonelId == SecilmisPersonel.Id);

                if (puantajRes.Data != null)
                {
                    var puantaj = puantajRes.Data.FindAll(p => p.YilAy.Month == DateTimePickerVacationStart.Value.Month).FirstOrDefault();

                    var gunler = new List<string>
                {
                    nameof(puantaj.Gun1),
                    nameof(puantaj.Gun2),
                    nameof(puantaj.Gun3),
                    nameof(puantaj.Gun4),
                    nameof(puantaj.Gun5),
                    nameof(puantaj.Gun6),
                    nameof(puantaj.Gun7),
                    nameof(puantaj.Gun8),
                    nameof(puantaj.Gun9),
                    nameof(puantaj.Gun10),
                    nameof(puantaj.Gun11),
                    nameof(puantaj.Gun12),
                    nameof(puantaj.Gun13),
                    nameof(puantaj.Gun14),
                    nameof(puantaj.Gun15),
                    nameof(puantaj.Gun16),
                    nameof(puantaj.Gun17),
                    nameof(puantaj.Gun18),
                    nameof(puantaj.Gun19),
                    nameof(puantaj.Gun20),
                    nameof(puantaj.Gun21),
                    nameof(puantaj.Gun22),
                    nameof(puantaj.Gun23),
                    nameof(puantaj.Gun24),
                    nameof(puantaj.Gun25),
                    nameof(puantaj.Gun26),
                    nameof(puantaj.Gun27),
                    nameof(puantaj.Gun28),
                    nameof(puantaj.Gun29),
                    nameof(puantaj.Gun30),
                    nameof(puantaj.Gun31)
                };

                    // DateTimePickerVacationStart.Value.Day ile ilgili günü al
                    int startDay = DateTimePickerVacationStart.Value.Day;
                    int endDay = DateTimePickerVacationEnd.Value.Day;

                    // Günü dizin olarak kullanarak uygun property'yi ayarla
                    if (startDay >= 1 && startDay <= gunler.Count)
                    {
                        for (int i = startDay; i <= endDay; i++)
                        {
                            var property = puantaj.GetType().GetProperty(gunler[i - 1]);
                            if (property != null && property.CanWrite)
                            {
                                property.SetValue(puantaj, GetIzinValue(izinler, ComboBoxVacationType.Text));
                            }
                        }
                    }

                    DateTime start = DateTimePickerVacationStart.Value;
                    DateTime end = DateTimePickerVacationEnd.Value;

                    DateTime vacationStart = new DateTime(start.Year, start.Month, start.Day);
                    DateTime vacationEnd = new DateTime(end.Year, end.Month, end.Day);

                    Izin izin = new Izin
                    {
                        IzinBaslama = vacationStart,
                        IzinBitis = vacationEnd,
                        PersonelId = SecilmisPersonel.Id,
                        IzinTuru = ComboBoxVacationType.Text
                    };

                    var res = _izinManager.Add(izin);
                    _puantajManager.Add(puantaj);

                    MessageBox.Show(res.Message);

                }
            }

            this.Close();
        }

        private void TextBoxEmployee_TextChanged(object sender, EventArgs e)
        {
            if (SecilmisPersonel != null)
            {
                var res = _izinManager.GetAll(p => p.PersonelId == SecilmisPersonel.Id);

                if (res.Data.Count > 0)
                {
                    #region Yıllık İzin

                    var kullanilanYillikIzin = res.Data.FindAll(x => x.IzinTuru == "YILLIK İZİN");

                    TimeSpan toplamGun = new TimeSpan(0,0,0,0);

                    foreach (var izin in kullanilanYillikIzin)
                    {
                        toplamGun = izin.IzinBitis - izin.IzinBaslama;
                    }

                    LabelYillikIzinKullanilan.Text = toplamGun.Days.ToString();
                    LabelYillikIzinKalan.Text = SecilmisPersonel.KalanYillikIzinSayisi.ToString();

                    #endregion
                }
            }
        }
    }
}