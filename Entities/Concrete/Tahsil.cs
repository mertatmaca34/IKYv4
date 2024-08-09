using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Tahsil : IEntity
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public string TahsilTuru { get; set; }
        public string OkulAdi { get; set; }
        public string BolumAdi { get; set; }
        public DateTime MezuniyetTarihi { get; set; }
    }
}