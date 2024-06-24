namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mert3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Puantajlar", "AdiSoyadi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Puantajlar", "AdiSoyadi");
        }
    }
}
