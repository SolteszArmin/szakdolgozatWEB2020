namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hirdetesForeignKey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.SportHirdetes");
            AddColumn("dbo.SportHirdetes", "sportId", c => c.Int(nullable: false));
            AlterColumn("dbo.SportHirdetes", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.SportHirdetes", "sportId");
            CreateIndex("dbo.SportHirdetes", "sportId");
            AddForeignKey("dbo.SportHirdetes", "sportId", "dbo.Sports", "sportagId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SportHirdetes", "sportId", "dbo.Sports");
            DropIndex("dbo.SportHirdetes", new[] { "sportId" });
            DropPrimaryKey("dbo.SportHirdetes");
            AlterColumn("dbo.SportHirdetes", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.SportHirdetes", "sportId");
            AddPrimaryKey("dbo.SportHirdetes", "Id");
        }
    }
}
