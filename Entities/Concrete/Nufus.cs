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
        public int? CocukSayisi { get; set; }
        public string EsCalismaDurumu { get; set; }
        public string EsCalistigiKurumAdi { get; set; }
        public string CocukAdi1 { get; set; }
        public string CocukAdi2 { get; set; }
        public string CocukAdi3 { get; set; }
        public string CocukAdi4 { get; set; }
        public string CocukAdi5 { get; set; }
        public string CocukAdi6 { get; set; }
        public string CocukCinsiyeti1 { get; set; }
        public string CocukCinsiyeti2 { get; set; }
        public string CocukCinsiyeti3 { get; set; }
        public string CocukCinsiyeti4 { get; set; }
        public string CocukCinsiyeti5 { get; set; }
        public string CocukCinsiyeti6 { get; set; }
        public DateTime? CocukDogumTarihi1 { get; set; }
        public DateTime? CocukDogumTarihi2 { get; set; }
        public DateTime? CocukDogumTarihi3 { get; set; }
        public DateTime? CocukDogumTarihi4 { get; set; }
        public DateTime? CocukDogumTarihi5 { get; set; }
        public DateTime? CocukDogumTarihi6 { get; set; }
        public string CocukHakkinda1 { get; set; }
        public string CocukHakkinda2 { get; set; }
        public string CocukHakkinda3 { get; set; }
        public string CocukHakkinda4 { get; set; }
        public string CocukHakkinda5 { get; set; }
        public string CocukHakkinda6 { get; set; }
    }
}