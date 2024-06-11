namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Iletisimler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(),
                        Seflik = c.String(),
                        Il = c.String(),
                        Ilce = c.String(),
                        Mahalle = c.String(),
                        Sokak = c.String(),
                        KapiNo1 = c.String(),
                        KapiNo2 = c.String(),
                        Daire = c.String(),
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
                        Seflik = c.String(),
                        BaslangicTarihi1 = c.DateTime(nullable: false),
                        BaslangicTarihi2 = c.DateTime(nullable: false),
                        BaslangicTarihi3 = c.DateTime(nullable: false),
                        BaslangicTarihi4 = c.DateTime(nullable: false),
                        BaslangicTarihi5 = c.DateTime(nullable: false),
                        BaslangicTarihi6 = c.DateTime(nullable: false),
                        BaslangicTarihi7 = c.DateTime(nullable: false),
                        BaslangicTarihi8 = c.DateTime(nullable: false),
                        BaslangicTarihi9 = c.DateTime(nullable: false),
                        BaslangicTarihi10 = c.DateTime(nullable: false),
                        AyrilisTarihi1 = c.DateTime(nullable: false),
                        AyrilisTarihi2 = c.DateTime(nullable: false),
                        AyrilisTarihi3 = c.DateTime(nullable: false),
                        AyrilisTarihi4 = c.DateTime(nullable: false),
                        AyrilisTarihi5 = c.DateTime(nullable: false),
                        AyrilisTarihi6 = c.DateTime(nullable: false),
                        AyrilisTarihi7 = c.DateTime(nullable: false),
                        AyrilisTarihi8 = c.DateTime(nullable: false),
                        AyrilisTarihi9 = c.DateTime(nullable: false),
                        AyrilisTarihi10 = c.DateTime(nullable: false),
                        Kurum1 = c.String(),
                        Kurum2 = c.String(),
                        Kurum3 = c.String(),
                        Kurum4 = c.String(),
                        Kurum5 = c.String(),
                        Kurum6 = c.String(),
                        Kurum7 = c.String(),
                        Kurum8 = c.String(),
                        Kurum9 = c.String(),
                        Kurum10 = c.String(),
                        Birim1 = c.String(),
                        Birim2 = c.String(),
                        Birim3 = c.String(),
                        Birim4 = c.String(),
                        Birim5 = c.String(),
                        Birim6 = c.String(),
                        Birim7 = c.String(),
                        Birim8 = c.String(),
                        Birim9 = c.String(),
                        Birim10 = c.String(),
                        Gorev1 = c.String(),
                        Gorev2 = c.String(),
                        Gorev3 = c.String(),
                        Gorev4 = c.String(),
                        Gorev5 = c.String(),
                        Gorev6 = c.String(),
                        Gorev7 = c.String(),
                        Gorev8 = c.String(),
                        Gorev9 = c.String(),
                        Gorev10 = c.String(),
                        Aciklama1 = c.String(),
                        Aciklama2 = c.String(),
                        Aciklama3 = c.String(),
                        Aciklama4 = c.String(),
                        Aciklama5 = c.String(),
                        Aciklama6 = c.String(),
                        Aciklama7 = c.String(),
                        Aciklama8 = c.String(),
                        Aciklama9 = c.String(),
                        Aciklama10 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Nufuslar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(),
                        Cinsiyet = c.String(),
                        Seflik = c.String(),
                        AnneAdi = c.String(),
                        BabaAdi = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                        DogumYeri = c.String(),
                        NufusaKayitliOlduguIl = c.String(),
                        Askerlik = c.String(),
                        KanGrubu = c.String(),
                        MedeniHali = c.String(),
                        EsAdi = c.String(),
                        EsMeslegi = c.String(),
                        CocukSayisi = c.Int(),
                        EsCalismaDurumu = c.String(),
                        EsCalistigiKurumAdi = c.String(),
                        CocukAdi1 = c.String(),
                        CocukAdi2 = c.String(),
                        CocukAdi3 = c.String(),
                        CocukAdi4 = c.String(),
                        CocukAdi5 = c.String(),
                        CocukAdi6 = c.String(),
                        CocukCinsiyeti1 = c.String(),
                        CocukCinsiyeti2 = c.String(),
                        CocukCinsiyeti3 = c.String(),
                        CocukCinsiyeti4 = c.String(),
                        CocukCinsiyeti5 = c.String(),
                        CocukCinsiyeti6 = c.String(),
                        CocukDogumTarihi1 = c.DateTime(nullable: false),
                        CocukDogumTarihi2 = c.DateTime(nullable: false),
                        CocukDogumTarihi3 = c.DateTime(nullable: false),
                        CocukDogumTarihi4 = c.DateTime(nullable: false),
                        CocukDogumTarihi5 = c.DateTime(nullable: false),
                        CocukDogumTarihi6 = c.DateTime(nullable: false),
                        CocukHakkinda1 = c.String(),
                        CocukHakkinda2 = c.String(),
                        CocukHakkinda3 = c.String(),
                        CocukHakkinda4 = c.String(),
                        CocukHakkinda5 = c.String(),
                        CocukHakkinda6 = c.String(),
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
                        MK = c.Double(),
                        PK = c.Double(),
                        ToplamKatsayi = c.Double(),
                        CalisiyorMu = c.Boolean(),
                        YillikIzinSayisi = c.Int(nullable: false),
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
                        Seflik = c.String(),
                        SertifikaAdi1 = c.String(),
                        SertifikaAdi2 = c.String(),
                        SertifikaAdi3 = c.String(),
                        SertifikaAdi4 = c.String(),
                        SertifikaAdi5 = c.String(),
                        SertifikaAdi6 = c.String(),
                        SertifikaAdi7 = c.String(),
                        SertifikaAdi8 = c.String(),
                        SertifikaAdi9 = c.String(),
                        SertifikaAdi10 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tahsiller",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(),
                        Seflik = c.String(),
                        TahsilAdi1 = c.String(),
                        TahsilAdi2 = c.String(),
                        TahsilAdi3 = c.String(),
                        TahsilAdi4 = c.String(),
                        TahsilAdi5 = c.String(),
                        OkulAdi1 = c.String(),
                        OkulAdi2 = c.String(),
                        OkulAdi3 = c.String(),
                        OkulAdi4 = c.String(),
                        OkulAdi5 = c.String(),
                        BolumAdi1 = c.String(),
                        BolumAdi2 = c.String(),
                        BolumAdi3 = c.String(),
                        BolumAdi4 = c.String(),
                        BolumAdi5 = c.String(),
                        MezuniyetTarihi1 = c.DateTime(),
                        MezuniyetTarihi2 = c.DateTime(),
                        MezuniyetTarihi3 = c.DateTime(),
                        MezuniyetTarihi4 = c.DateTime(),
                        MezuniyetTarihi5 = c.DateTime(),
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
                        PK = c.Double(nullable: false),
                        MK = c.Double(nullable: false),
                        TK = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Unvanlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UnvanGrubuId = c.Int(nullable: false),
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
            DropTable("dbo.Personeller");
            DropTable("dbo.Nufuslar");
            DropTable("dbo.Nakiller");
            DropTable("dbo.Mudurlukler");
            DropTable("dbo.Kullanicilar");
            DropTable("dbo.Izinler");
            DropTable("dbo.Iletisimler");
        }
    }
}
