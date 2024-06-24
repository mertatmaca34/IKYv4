namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mert2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Puantajlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonelId = c.Int(nullable: false),
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
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Puantajlar");
        }
    }
}
