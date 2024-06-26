namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mert31 : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CalismaSaatleri");
        }
    }
}
