namespace Test2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8a79e096-052b-4057-9683-7a7443aa305a', N'admin@vidly.com', 0, N'ANsAaEBsE1NWuOTP0Xdt7csouDlW02DjHLd3OCwn/iD6VH9Usqt17fDNx44yAdw3ug==', N'fea4525e-9d63-4c6a-b6ea-8a1d25a9faed', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b38fafbd-3156-440a-88ab-851b2433fefc', N'guest@vidly.com', 0, N'ANsAaEBsE1NWuOTP0Xdt7csouDlW02DjHLd3OCwn/iD6VH9Usqt17fDNx44yAdw3ug==', N'fea4525e-9d63-4c6a-b6ea-8a1d25a9faed', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df696c9b-fa26-4f46-b2b1-ad753ea50361', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8a79e096-052b-4057-9683-7a7443aa305a', N'df696c9b-fa26-4f46-b2b1-ad753ea50361')

");
        }
        
        public override void Down()
        {
        }
    }
}
