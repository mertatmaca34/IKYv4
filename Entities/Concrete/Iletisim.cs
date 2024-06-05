using Core.Entities;

namespace Entities.Concrete
{
    public class Iletisim : IEntity
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public string Seflik { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Mahalle { get; set; }
        public string Sokak { get; set; }
        public string KapiNo1 { get; set; }
        public string KapiNo2 { get; set; }
        public string Daire { get; set; }
        public string CepTelNo1 { get; set; }
        public string CepTelNo2 { get; set; }
        public string EMailAdresi { get; set; }
    }
}