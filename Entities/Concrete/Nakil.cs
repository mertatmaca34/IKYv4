using Core.Entities;
using System;
using System.Security.Policy;

namespace Entities.Concrete
{
    public class Nakil : IEntity
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public string KurumAdi { get; set; }
        public string BirimAdi { get; set; }
        public string Gorev { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime AyrilisTarihi { get; set; }
        public string Aciklama { get; set; }
    }
}