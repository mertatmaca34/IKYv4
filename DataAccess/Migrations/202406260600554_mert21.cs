namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mert21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Puantajlar", "CalisilanGun", c => c.Int(nullable: false));
            AddColumn("dbo.Puantajlar", "RaporluGun", c => c.Int(nullable: false));
            AddColumn("dbo.Puantajlar", "MazeretliGun", c => c.Int(nullable: false));
            AddColumn("dbo.Puantajlar", "UcretsizIzin", c => c.Int(nullable: false));
            AddColumn("dbo.Puantajlar", "YillikIzin", c => c.Int(nullable: false));
            AddColumn("dbo.Puantajlar", "UcretliIzin", c => c.Int(nullable: false));
            AddColumn("dbo.Puantajlar", "HaftalikTatil", c => c.Int(nullable: false));
            AddColumn("dbo.Puantajlar", "ResmiTatil", c => c.Int(nullable: false));
            AddColumn("dbo.Puantajlar", "IdariDisiplinCezasi", c => c.Int(nullable: false));
            AddColumn("dbo.Puantajlar", "EgitimGorevi", c => c.Int(nullable: false));
            AddColumn("dbo.Puantajlar", "ToplamGun", c => c.Int(nullable: false));
            AddColumn("dbo.Puantajlar", "MaasOdemeYapilmamasinaEsasGun", c => c.Int(nullable: false));
            AddColumn("dbo.Puantajlar", "MaasOdemesineEsasGun", c => c.Int(nullable: false));
            AddColumn("dbo.Puantajlar", "YolOdemesineEsasGun", c => c.Int(nullable: false));
            AddColumn("dbo.Puantajlar", "YemekOdemesineEsasGun", c => c.Int(nullable: false));
            AddColumn("dbo.Puantajlar", "UlBayVeGenResTatCalisilanGun", c => c.Double(nullable: false));
            AddColumn("dbo.Puantajlar", "FazlCalismaSaati", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Puantajlar", "FazlCalismaSaati");
            DropColumn("dbo.Puantajlar", "UlBayVeGenResTatCalisilanGun");
            DropColumn("dbo.Puantajlar", "YemekOdemesineEsasGun");
            DropColumn("dbo.Puantajlar", "YolOdemesineEsasGun");
            DropColumn("dbo.Puantajlar", "MaasOdemesineEsasGun");
            DropColumn("dbo.Puantajlar", "MaasOdemeYapilmamasinaEsasGun");
            DropColumn("dbo.Puantajlar", "ToplamGun");
            DropColumn("dbo.Puantajlar", "EgitimGorevi");
            DropColumn("dbo.Puantajlar", "IdariDisiplinCezasi");
            DropColumn("dbo.Puantajlar", "ResmiTatil");
            DropColumn("dbo.Puantajlar", "HaftalikTatil");
            DropColumn("dbo.Puantajlar", "UcretliIzin");
            DropColumn("dbo.Puantajlar", "YillikIzin");
            DropColumn("dbo.Puantajlar", "UcretsizIzin");
            DropColumn("dbo.Puantajlar", "MazeretliGun");
            DropColumn("dbo.Puantajlar", "RaporluGun");
            DropColumn("dbo.Puantajlar", "CalisilanGun");
        }
    }
}
