using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Tahsil : IEntity
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public string TahsilAdi1 { get; set; }
        public string TahsilAdi2 { get; set; }
        public string TahsilAdi3 { get; set; }
        public string TahsilAdi4 { get; set; }
        public string TahsilAdi5 { get; set; }
        public string OkulAdi1 { get; set; }
        public string OkulAdi2 { get; set; }
        public string OkulAdi3 { get; set; }
        public string OkulAdi4 { get; set; }
        public string OkulAdi5 { get; set; }
        public string BolumAdi1 { get; set; }
        public string BolumAdi2 { get; set; }
        public string BolumAdi3 { get; set; }
        public string BolumAdi4 { get; set; }
        public string BolumAdi5 { get; set; }
        public DateTime? MezuniyetTarihi1 { get; set; }
        public DateTime? MezuniyetTarihi2 { get; set; }
        public DateTime? MezuniyetTarihi3 { get; set; }
        public DateTime? MezuniyetTarihi4 { get; set; }
        public DateTime? MezuniyetTarihi5 { get; set; }
    }
}