namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'38e18027-07fd-435e-8a57-2cf0b33b249f', N'admin@vidly.com', 0, N'ALs39HWa/nGZsvWkF3MBbiMKFZd/TEYEnKhuy6iqf1doHbB4FUa5Jia2uAhjScvcAA==', N'b62705c4-d138-471c-a043-66cdd096c869', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f5ea0382-340b-40a3-99e1-c50af8e3cc5c', N'guest@vidly.com', 0, N'ABHYr7DWs/8to9qvCYNrABuLH6qcWgT0YhoByU+2Pn1rj1sK3LpxRMttzXv2DOKpTg==', N'a792669b-3eca-4e8a-b24a-ced6dc91911c', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9f195c71-367b-464f-9e51-b1111e6995ff', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'38e18027-07fd-435e-8a57-2cf0b33b249f', N'9f195c71-367b-464f-9e51-b1111e6995ff')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
