namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e84e17da-85cd-4ec2-aab9-7d46e762d0b1', N'admin@gmail.com', 0, N'APqYqist/fDxXkEsG0y0Y8O13TcDIYqdH8RtBmMIV++f/AmY+VW6iNTmGX6B4WBqZQ==', N'5e4b05e6-f2a6-4283-940a-820ed9f84646', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cf76a7c7-c265-45e6-a778-a80056dcd40d', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e84e17da-85cd-4ec2-aab9-7d46e762d0b1', N'cf76a7c7-c265-45e6-a778-a80056dcd40d')


            ");
        }
        
        public override void Down()
        {

        }
    }
}
