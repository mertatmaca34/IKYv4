namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UnvanGuruplari", "PK", c => c.String());
            AlterColumn("dbo.UnvanGuruplari", "MK", c => c.String());
            AlterColumn("dbo.UnvanGuruplari", "TK", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UnvanGuruplari", "TK", c => c.Double(nullable: false));
            AlterColumn("dbo.UnvanGuruplari", "MK", c => c.Double(nullable: false));
            AlterColumn("dbo.UnvanGuruplari", "PK", c => c.Double(nullable: false));
        }
    }
}
