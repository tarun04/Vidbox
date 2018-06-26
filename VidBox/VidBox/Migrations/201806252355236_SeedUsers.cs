namespace VidBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO[dbo].[AspNetUsers]
                    ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName])
                    VALUES(N'062621a2-7f11-4c9f-b70a-b265b7210515', N'guest@vidbox.com', 0, N'AHEL60Y/dtKDdvYkohVTT99CvQwJ0/P4RTe5G+3U4O+7HoulBA1t8foBMvp4a2FCFQ==', N'47fe9d73-dcef-46c7-8d3f-7d166d0d8b0b', NULL, 0, 0, NULL, 1, 0, N'guest@vidbox.com')
                INSERT INTO[dbo].[AspNetUsers]
                    ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName])
                    VALUES(N'2abfb513-76ac-474f-b167-64d0017cf892', N'admin@vidbox.com', 0, N'ANct8mm5wE3X7I8vCMtH00fgqmLc0Aus9w0WLt9Pq10XYAFQpKfYeyhejnyxGa6PIA==', N'0e3127fd-1773-49ef-bde1-75dbf7f7dd34', NULL, 0, 0, NULL, 1, 0, N'admin@vidbox.com')
                INSERT INTO[dbo].[AspNetRoles]
                    ([Id], [Name]) VALUES(N'2b4a36da-50ea-413a-8b76-8a77d87c2fb8', N'CanManageMovies')
            ");        
        }
        public override void Down()
        {
        }
    }
}
