using Entities.Concrete;
using System.Data.Entity;

namespace DataAccess.Concrete.Context
{
    public class IKYContext : DbContext
    {
        public IKYContext() : base(@"Server=(localdb)\MSSQLLocalDB;Database=IKYDatabase;Trusted_Connection=True;MultipleActiveResultSets=true")
        { }

        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Nufus> Nufuslar { get; set; }
        public DbSet<Sertifika> Sertifikalar { get; set; }
        public DbSet<Nakil> Nakiller { get; set; }
        public DbSet<Tahsil> Tahsiller { get; set; }
        public DbSet<Iletisim> Iletisimler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Mudurluk> Mudurlukler { get; set; }
        public DbSet<Seflik> Seflikler { get; set; }
        public DbSet<Tesis> Tesisler { get; set; }
        public DbSet<UnvanGrubu> UnvanGuruplari { get; set; }
        public DbSet<Unvan> Unvanlar { get; set; }
        public DbSet<Izin> Izinler { get; set; }
        public DbSet<Puantaj> Puantajlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Personel>().ToTable("Personeller");
            modelBuilder.Entity<Nufus>().ToTable("Nufuslar");
            modelBuilder.Entity<Sertifika>().ToTable("Sertifikalar");
            modelBuilder.Entity<Nakil>().ToTable("Nakiller");
            modelBuilder.Entity<Tahsil>().ToTable("Tahsiller");
            modelBuilder.Entity<Iletisim>().ToTable("Iletisimler");
            modelBuilder.Entity<Kullanici>().ToTable("Kullanicilar");
            modelBuilder.Entity<Mudurluk>().ToTable("Mudurlukler");
            modelBuilder.Entity<Seflik>().ToTable("Seflikler");
            modelBuilder.Entity<Tesis>().ToTable("Tesisler");
            modelBuilder.Entity<UnvanGrubu>().ToTable("UnvanGuruplari");
            modelBuilder.Entity<Unvan>().ToTable("Unvanlar");
            modelBuilder.Entity<Izin>().ToTable("Izinler");
            modelBuilder.Entity<Puantaj>().ToTable("Puantajlar");
        }
    }
}
