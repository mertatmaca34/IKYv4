using Core.Entities;

namespace Entities.Concrete
{
    public class Sertifika : IEntity
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public string Seflik { get; set; }
        public string SertifikaAdi1 { get; set; }
        public string SertifikaAdi2 { get; set; }
        public string SertifikaAdi3 { get; set; }
        public string SertifikaAdi4 { get; set; }
        public string SertifikaAdi5 { get; set; }
        public string SertifikaAdi6 { get; set; }
        public string SertifikaAdi7 { get; set; }
        public string SertifikaAdi8 { get; set; }
        public string SertifikaAdi9 { get; set; }
        public string SertifikaAdi10 { get; set; }
    }
}