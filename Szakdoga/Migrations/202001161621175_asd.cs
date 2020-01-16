namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SportHirdetes", "sportId", "dbo.Sports");
            DropPrimaryKey("dbo.SportHirdetes");
            AddColumn("dbo.SportHirdetes", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.SportHirdetes", new[] { "sportId", "UserId" });
            CreateIndex("dbo.SportHirdetes", "UserId");
            AddForeignKey("dbo.SportHirdetes", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SportHirdetes", "sportId", "dbo.Sports", "sportagId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SportHirdetes", "sportId", "dbo.Sports");
            DropForeignKey("dbo.SportHirdetes", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.SportHirdetes", new[] { "UserId" });
            DropPrimaryKey("dbo.SportHirdetes");
            DropColumn("dbo.SportHirdetes", "UserId");
            AddPrimaryKey("dbo.SportHirdetes", "sportId");
            AddForeignKey("dbo.SportHirdetes", "sportId", "dbo.Sports", "sportagId");
        }
    }
}
