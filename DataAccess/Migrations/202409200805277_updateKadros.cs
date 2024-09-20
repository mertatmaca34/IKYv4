namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateKadros : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KadroDurumlari", "SeflikAdi", c => c.String());
            AddColumn("dbo.KadroDurumlari", "UnvanGrubuAdi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.KadroDurumlari", "UnvanGrubuAdi");
            DropColumn("dbo.KadroDurumlari", "SeflikAdi");
        }
    }
}
