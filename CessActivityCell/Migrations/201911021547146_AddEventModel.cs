namespace CessActivityCell.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEventModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Fee = c.Int(nullable: false),
                        Date = c.DateTime(),
                        Venue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
