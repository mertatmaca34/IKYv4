namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mert : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Unvanlar", "UnvanAdi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Unvanlar", "UnvanAdi");
        }
    }
}
