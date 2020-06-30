namespace CessActivityCell.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRegistrationModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registrations", "EventId", c => c.Int(nullable: false));
            CreateIndex("dbo.Registrations", "EventId");
            AddForeignKey("dbo.Registrations", "EventId", "dbo.Events", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Registrations", "EventId", "dbo.Events");
            DropIndex("dbo.Registrations", new[] { "EventId" });
            DropColumn("dbo.Registrations", "EventId");
        }
    }
}
