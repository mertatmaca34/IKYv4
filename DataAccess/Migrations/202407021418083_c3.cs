namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personeller", "MK", c => c.String());
            AlterColumn("dbo.Personeller", "PK", c => c.String());
            AlterColumn("dbo.Personeller", "ToplamKatsayi", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personeller", "ToplamKatsayi", c => c.Double());
            AlterColumn("dbo.Personeller", "PK", c => c.Double());
            AlterColumn("dbo.Personeller", "MK", c => c.Double());
        }
    }
}
