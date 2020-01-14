namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeyToHirdetes : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.SportHirdetes");
            AddColumn("dbo.SportHirdetes", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.AspNetUsers", "Ertekeles", c => c.Int(nullable: false));
            AlterColumn("dbo.SportHirdetes", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.SportHirdetes", "UserId");
            CreateIndex("dbo.SportHirdetes", "UserId");
            AddForeignKey("dbo.SportHirdetes", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SportHirdetes", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.SportHirdetes", new[] { "UserId" });
            DropPrimaryKey("dbo.SportHirdetes");
            AlterColumn("dbo.SportHirdetes", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.AspNetUsers", "Ertekeles");
            DropColumn("dbo.SportHirdetes", "UserId");
            AddPrimaryKey("dbo.SportHirdetes", "Id");
        }
    }
}
