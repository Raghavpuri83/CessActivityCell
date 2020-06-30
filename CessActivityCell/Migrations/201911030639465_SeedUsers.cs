namespace CessActivityCell.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'309ff03f-9087-4a50-ab77-c612aa7d1856', N'guest@gmail.com', 0, N'ANdmV5CPqQmd85HYD3fFckgZkgTPtjUz1Cd0+Q2LNZNANFDFGSgaHF1RzQT5JDienQ==', N'06b7920a-bb2f-4d44-81df-33872b24b07d', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8d136b1d-a789-43d9-a3d5-c8e0c82fe029', N'admin@cessgndu.com', 0, N'AH4pN+Ox0kYFXlwzdDIszdjuVfplk2rybnxLKVo9nOXWw0DhK6KijZGCJE6xpqYTSw==', N'4d7f7a17-50aa-4cff-9592-3628d00a996c', NULL, 0, 0, NULL, 1, 0, N'admin@cessgndu.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2f8da8e6-7bf6-46f9-a772-98ddd84c55c7', N'CanAddEvents')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8d136b1d-a789-43d9-a3d5-c8e0c82fe029', N'2f8da8e6-7bf6-46f9-a772-98ddd84c55c7')
");
        }
        
        public override void Down()
        {
        }
    }
}
