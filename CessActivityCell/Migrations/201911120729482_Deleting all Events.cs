namespace CessActivityCell.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletingallEvents : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Events", "Venue", c => c.String(nullable: false));
            Sql("DELETE FROM Events WHERE Id=1;");
            Sql("DELETE FROM Events WHERE Id=2;");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "Venue", c => c.String());
            AlterColumn("dbo.Events", "Date", c => c.DateTime());
            AlterColumn("dbo.Events", "Description", c => c.String());
            AlterColumn("dbo.Events", "Name", c => c.String());
        }
    }
}
