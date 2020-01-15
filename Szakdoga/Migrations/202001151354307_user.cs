namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled]," +
                " [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [BirthDate], [Ertekeles], [Vezeteknev], [Keresztnev]) VALUES (N'2757fbbb-6528-4220-b827-6362e8363603', N'admin@gmail.com'," +
                " 0, N'ALlRfNxBsPJDMu2hdzXPGfh0EcWoNRAe4I7ZNZsNWdxtU3/JS0siwM1UumTKsEWP/Q==', N'e587a84b-6246-4b88-ad66-b968a84d533a', NULL, 0, 0, NULL, 1, 0, N'Adminisztrátor'," +
                " N'1999-06-18 00:00:00', 0, N'Soltész', N'Ármin')");

            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc]," +
                " [LockoutEnabled], [AccessFailedCount], [UserName], [BirthDate], [Ertekeles], [Vezeteknev], [Keresztnev]) VALUES (N'cc5d7a79-4e4c-40a8-a626-462ea8667e97', N'user@gmail.com', 0, N'APA+nBGCuLDtBEWVMQYxBtwqkzj9OnR2wTf2KyHfY9R+iPWfMKPtvHnX+BmK3tCV9g=='," +
                " N'd99eef32-0301-417e-a5ad-e893a50a2319', NULL, 0, 0, NULL, 1, 0, N'Kis Józsika', N'1980-03-11 00:00:00', 0, N'kecske', N'jános')");

            Sql($"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'be4f2fab-1d5f-4642-b8f1-e20f4ce8e1ef', N'Admin')");
            Sql($"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd7ca564b-9636-4aeb-ae17-95b4fc7f9604', N'User')");

            Sql("INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'2757fbbb-6528-4220-b827-6362e8363603', N'be4f2fab-1d5f-4642-b8f1-e20f4ce8e1ef')");
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cc5d7a79-4e4c-40a8-a626-462ea8667e97', N'd7ca564b-9636-4aeb-ae17-95b4fc7f9604')");
        }
        
        public override void Down()
        {
        }
    }
}
