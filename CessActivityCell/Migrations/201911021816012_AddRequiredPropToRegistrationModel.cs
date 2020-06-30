namespace CessActivityCell.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiredPropToRegistrationModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Registrations", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "College", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "Department", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "CurrentYear", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Registrations", "CurrentYear", c => c.String());
            AlterColumn("dbo.Registrations", "Department", c => c.String());
            AlterColumn("dbo.Registrations", "College", c => c.String());
            AlterColumn("dbo.Registrations", "Email", c => c.String());
            AlterColumn("dbo.Registrations", "Name", c => c.String());
        }
    }
}
