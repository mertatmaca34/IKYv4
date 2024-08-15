using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Nufus : IEntity
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public string Cinsiyet { get; set; }
        public string AnneAdi { get; set; }
        public string BabaAdi { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string DogumYeri { get; set; }
        public string NufusaKayitliOlduguIl { get; set; }
        public string Askerlik { get; set; }
        public string KanGrubu { get; set; }
        public string MedeniHali { get; set; }
        public string EsAdi { get; set; }
        public string EsMeslegi { get; set; }
        public string EsCalismaDurumu { get; set; }
        public string EsCalistigiKurumAdi { get; set; }
    }
}