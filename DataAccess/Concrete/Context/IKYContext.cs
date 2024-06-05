using Entities.Concrete;
using System.Data.Entity;

namespace DataAccess.Concrete.Context
{
    public class IKYContext : DbContext
    {
        DbSet<Personel> Personeller { get; set; }
        DbSet<Nufus> Nufuslar { get; set; }
        DbSet<Sertifika> Sertifikalar { get; set; }
        DbSet<Nakil> Nakiller { get; set; }
        DbSet<Tahsil> Tahsiller { get; set; }
        DbSet<Iletisim> Iletisimler { get; set; }
        DbSet<Kullanici> Kullanicilar { get; set; }
        DbSet<Mudurluk> Mudurlukler { get; set; }
        DbSet<Seflik> Seflikler { get; set; }
        DbSet<Tesis> Tesisler { get; set; }
        DbSet<UnvanGrubu> UnvanGuruplari { get; set; }
        DbSet<Unvan> Unvanlar { get; set; }
        DbSet<Izin> Izinler { get; set; }
    }
}