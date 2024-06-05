using Core.Entities;

namespace Entities.Concrete
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }
        public string GirisKullaniciAdi { get; set; }
        public string GirisSifre { get; set; }
        public string GirisAdi { get; set; }
        public string GirisSoyadi { get; set; }
        public string Seflik { get; set; }
        public string GirisGorevi { get; set; }
        public string GirisYetki { get; set; }
    }
}