using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using IKYv4.Utilities.Extensions;
using System;
using System.Collections.Generic;
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
        ICalismaSaatleriManager _calismaSaatleriManager;

        public FormEmployeeVacation(IPersonelManager personelManager, IMudurlukManager mudurlukManager, ISeflikManager seflikManager, ITesisManager tesisManager, IIzinManager izinManager, IPuantajManager puantajManager, ICalismaSaatleriManager calismaSaatleriManager)
        {
            InitializeComponent();

            _personelManager = personelManager;
            _mudurlukManager = mudurlukManager;
            _seflikManager = seflikManager;
            _tesisManager = tesisManager;
            _izinManager = izinManager;
            _puantajManager = puantajManager;
            _calismaSaatleriManager = calismaSaatleriManager;

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

                var izinBaslamaAy = DateTimePickerVacationStart.Value.Month;
                var izinBitmeAy = DateTimePickerVacationEnd.Value.Month;



                //    UpdatePuantageTable();

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

        private void UpdatePuantageTable(DateTime dateTime)
        {
            DateTime YilAy = new DateTime(dateTime.Year, dateTime.Month, 1);

            var _puantajData = _puantajManager.GetAll().Data;

            var personelPuantaj = _puantajData.Find(x => x.PersonelId == SecilmisPersonel.Id && x.YilAy.Month == YilAy.Month) ?? new Puantaj();

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

            var resCalismaSaatleri = _calismaSaatleriManager.GetAll(p => p.PersonelId == SecilmisPersonel.Id).Data.FirstOrDefault();

            Puantaj puantaj = new Puantaj
            {
                PersonelId = SecilmisPersonel.Id,
                AdiSoyadi = SecilmisPersonel.Adi + " " + SecilmisPersonel.Soyadi,
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

        private void TextBoxEmployee_TextChanged(object sender, EventArgs e)
        {
            if (SecilmisPersonel != null)
            {
                var res = _izinManager.GetAll(p => p.PersonelId == SecilmisPersonel.Id);

                if (res.Data.Count > 0)
                {
                    #region Predicates

                    Predicate<Izin> predicateYillikIzin = x => x.IzinTuru == "YILLIK İZİN";
                    Predicate<Izin> predicateUcretliIzin = x => x.IzinTuru == "ÜCRETLİ İZİN";
                    Predicate<Izin> predicateUcretsizIzin = x => x.IzinTuru == "ÜCRETSİZ İZİN";
                    Predicate<Izin> predicateBabalikIzni = x => x.IzinTuru == "BABALIK İZNİ";
                    Predicate<Izin> predicateDogumIzni = x => x.IzinTuru == "DOĞUM İZNİ";
                    Predicate<Izin> predicateEvlilikIzni = x => x.IzinTuru == "EVLİLİK İZNİ";
                    Predicate<Izin> predicateOlumIzni = x => x.IzinTuru == "ÖLÜM İZNİ";
                    Predicate<Izin> predicateRaporIzni = x => x.IzinTuru == "RAPOR İZNİ";

                    #endregion

                    LabelYillikIzinKullanilan.Text = CalculateTotalVacationTime(res, predicateYillikIzin);
                    LabelYillikIzinKalan.Text = SecilmisPersonel.KalanYillikIzinSayisi.ToString();

                    LabelUcretliIzinKullanilan.Text = CalculateTotalVacationTime(res, predicateUcretliIzin);
                }
            }
        }

        private string CalculateTotalVacationTime(IDataResult<List<Izin>> res, Predicate<Izin> predicate)
        {
            var kullanilanIzin = res.Data.FindAll(predicate);

            TimeSpan toplamGun = new TimeSpan(0, 0, 0, 0);

            foreach (var izin in kullanilanIzin)
            {
                toplamGun = izin.IzinBitis - izin.IzinBaslama;

                toplamGun = toplamGun.Add(new TimeSpan(1, 0, 0, 0));
            }

            return toplamGun.Days.ToString();
        }
    }
}