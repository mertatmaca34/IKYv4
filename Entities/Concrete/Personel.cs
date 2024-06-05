using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Personel : IEntity
    {
        public int Id { get; set; }
        public byte[] ImageData { get; set; }
        public string TCKimlikNo { get; set; }
        public string SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public string Mudurluk { get; set; }
        public string Seflik { get; set; }
        public string GorevYeri { get; set; }
        public string Unvani { get; set; }
        public string Pozisyonu { get; set; }
        public double? MK { get; set; }
        public double? PK { get; set; }
        public double? ToplamKatsayi { get; set; }
        public bool? CalisiyorMu { get; set; }
        public int YillikIzinSayisi { get; set; }
    }
}