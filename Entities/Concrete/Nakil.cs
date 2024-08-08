using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Nakil : IEntity
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public DateTime BaslangicTarihi1 { get; set; }
        public DateTime BaslangicTarihi2 { get; set; }
        public DateTime BaslangicTarihi3 { get; set; }
        public DateTime BaslangicTarihi4 { get; set; }
        public DateTime BaslangicTarihi5 { get; set; }
        public DateTime BaslangicTarihi6 { get; set; }
        public DateTime AyrilisTarihi1 { get; set; }
        public DateTime AyrilisTarihi2 { get; set; }
        public DateTime AyrilisTarihi3 { get; set; }
        public DateTime AyrilisTarihi4 { get; set; }
        public DateTime AyrilisTarihi5 { get; set; }
        public DateTime AyrilisTarihi6 { get; set; }
        public string Kurum1 { get; set; }
        public string Kurum2 { get; set; }
        public string Kurum3 { get; set; }
        public string Kurum4 { get; set; }
        public string Kurum5 { get; set; }
        public string Kurum6 { get; set; }
        public string Birim1 { get; set; }
        public string Birim2 { get; set; }
        public string Birim3 { get; set; }
        public string Birim4 { get; set; }
        public string Birim5 { get; set; }
        public string Birim6 { get; set; }
        public string Gorev1 { get; set; }
        public string Gorev2 { get; set; }
        public string Gorev3 { get; set; }
        public string Gorev4 { get; set; }
        public string Gorev5 { get; set; }
        public string Gorev6 { get; set; }
        public string Aciklama1 { get; set; }
        public string Aciklama2 { get; set; }
        public string Aciklama3 { get; set; }
        public string Aciklama4 { get; set; }
        public string Aciklama5 { get; set; }
        public string Aciklama6 { get; set; }
    }
}