namespace CessActivityCell.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateEvents : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Events ON");
            Sql("INSERT INTO Events (Id, Name, Description, Fee, Date, Venue) VALUES (1, 'Treasure Hunt', 'Fun and Thrill Event', 50, '01-01-2020 00:00:00.000', 'CET GNDU')");
            Sql("INSERT INTO Events (Id, Name, Description, Fee, Date, Venue) VALUES (2, 'Blind Coding', 'Technical Event', 40, '01-05-2020 00:00:00.000', 'CET GNDU')");
            Sql("SET IDENTITY_INSERT Events Off");
        }
        
        public override void Down()
        {
        }
    }
}
