namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CalismaSaatleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        PazartesiBaslama = c.String(),
                        PazartesiBitme = c.String(),
                        SaliBaslama = c.String(),
                        SaliBitme = c.String(),
                        CarsambaBaslama = c.String(),
                        CarsambaBitme = c.String(),
                        PersembeBaslama = c.String(),
                        PersembeBitme = c.String(),
                        CumaBaslama = c.String(),
                        CumaBitme = c.String(),
                        CumartesiBaslama = c.String(),
                        CumartesiBitme = c.String(),
                        PazarBaslama = c.String(),
                        PazarBitme = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cocuklar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        CocukAdi = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                        CocukCinsiyeti = c.String(),
                        Hakkinda = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Iletisimler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        Il = c.String(),
                        Ilce = c.String(),
                        Mahalle = c.String(),
                        AdresDetay = c.String(),
                        CepTelNo1 = c.String(),
                        CepTelNo2 = c.String(),
                        EMailAdresi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Izinler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        IzinTuru = c.String(),
                        IzinBaslama = c.DateTime(nullable: false),
                        IzinBitis = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KadroDurumlari",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SeflikId = c.Int(nullable: false),
                        UnvanGrubuId = c.Int(nullable: false),
                        KadroSayisi = c.Int(nullable: false),
                        MevcutPersonelSayisi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kullanicilar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GirisKullaniciAdi = c.String(),
                        GirisSifre = c.String(),
                        GirisAdi = c.String(),
                        GirisSoyadi = c.String(),
                        Seflik = c.String(),
                        GirisGorevi = c.String(),
                        GirisYetki = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mudurlukler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MudurlukAdi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Nakiller",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(),
                        KurumAdi = c.String(),
                        BirimAdi = c.String(),
                        Gorev = c.String(),
                        BaslangicTarihi = c.DateTime(nullable: false),
                        AyrilisTarihi = c.DateTime(nullable: false),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Nufuslar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        Cinsiyet = c.String(),
                        AnneAdi = c.String(),
                        BabaAdi = c.String(),
                        DogumTarihi = c.DateTime(),
                        DogumYeri = c.String(),
                        NufusaKayitliOlduguIl = c.String(),
                        Askerlik = c.String(),
                        KanGrubu = c.String(),
                        MedeniHali = c.String(),
                        EsAdi = c.String(),
                        EsMeslegi = c.String(),
                        EsCalismaDurumu = c.String(),
                        EsCalistigiKurumAdi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personeller",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageData = c.Binary(),
                        TCKimlikNo = c.String(),
                        SicilNo = c.String(),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        IseGirisTarihi = c.DateTime(nullable: false),
                        Mudurluk = c.String(),
                        Seflik = c.String(),
                        GorevYeri = c.String(),
                        Unvani = c.String(),
                        Pozisyonu = c.String(),
                        Kadrosu = c.String(),
                        EytDurumu = c.String(),
                        MK = c.String(),
                        PK = c.String(),
                        ToplamKatsayi = c.String(),
                        CalisiyorMu = c.Boolean(),
                        YillikIzinSayisi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Puantajlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        AdiSoyadi = c.String(),
                        YilAy = c.DateTime(nullable: false),
                        Gun1 = c.String(),
                        Gun2 = c.String(),
                        Gun3 = c.String(),
                        Gun4 = c.String(),
                        Gun5 = c.String(),
                        Gun6 = c.String(),
                        Gun7 = c.String(),
                        Gun8 = c.String(),
                        Gun9 = c.String(),
                        Gun10 = c.String(),
                        Gun11 = c.String(),
                        Gun12 = c.String(),
                        Gun13 = c.String(),
                        Gun14 = c.String(),
                        Gun15 = c.String(),
                        Gun16 = c.String(),
                        Gun17 = c.String(),
                        Gun18 = c.String(),
                        Gun19 = c.String(),
                        Gun20 = c.String(),
                        Gun21 = c.String(),
                        Gun22 = c.String(),
                        Gun23 = c.String(),
                        Gun24 = c.String(),
                        Gun25 = c.String(),
                        Gun26 = c.String(),
                        Gun27 = c.String(),
                        Gun28 = c.String(),
                        Gun29 = c.String(),
                        Gun30 = c.String(),
                        Gun31 = c.String(),
                        CalisilanGun = c.Int(nullable: false),
                        RaporluGun = c.Int(nullable: false),
                        MazeretliGun = c.Int(nullable: false),
                        UcretsizIzin = c.Int(nullable: false),
                        YillikIzin = c.Int(nullable: false),
                        UcretliIzin = c.Int(nullable: false),
                        HaftalikTatil = c.Int(nullable: false),
                        ResmiTatil = c.Int(nullable: false),
                        IdariDisiplinCezasi = c.Int(nullable: false),
                        EgitimGorevi = c.Int(nullable: false),
                        ToplamGun = c.Int(nullable: false),
                        MaasOdemeYapilmamasinaEsasGun = c.Int(nullable: false),
                        MaasOdemesineEsasGun = c.Int(nullable: false),
                        YolOdemesineEsasGun = c.Int(nullable: false),
                        YemekOdemesineEsasGun = c.Int(nullable: false),
                        UlBayVeGenResTatCalisilanGun = c.Double(nullable: false),
                        FazlCalismaSaati = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Seflikler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MudurlukAdi = c.String(),
                        SeflikAdi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sertifikalar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(),
                        SertifikaAdi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tahsiller",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
                        TahsilTuru = c.String(),
                        OkulAdi = c.String(),
                        BolumAdi = c.String(),
                        MezuniyetTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tesisler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SeflikAdi = c.String(),
                        TesisAdi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UnvanGuruplari",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UnvanGrubuAdi = c.String(),
                        PK = c.String(),
                        MK = c.String(),
                        TK = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Unvanlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UnvanGrubuId = c.Int(nullable: false),
                        UnvanAdi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Unvanlar");
            DropTable("dbo.UnvanGuruplari");
            DropTable("dbo.Tesisler");
            DropTable("dbo.Tahsiller");
            DropTable("dbo.Sertifikalar");
            DropTable("dbo.Seflikler");
            DropTable("dbo.Puantajlar");
            DropTable("dbo.Personeller");
            DropTable("dbo.Nufuslar");
            DropTable("dbo.Nakiller");
            DropTable("dbo.Mudurlukler");
            DropTable("dbo.Kullanicilar");
            DropTable("dbo.KadroDurumlari");
            DropTable("dbo.Izinler");
            DropTable("dbo.Iletisimler");
            DropTable("dbo.Cocuklar");
            DropTable("dbo.CalismaSaatleri");
        }
    }
}
