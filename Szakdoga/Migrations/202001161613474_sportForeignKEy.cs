namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sportForeignKEy : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Sports");
            AddColumn("dbo.Sports", "sportagId", c => c.Int(nullable: false));
            AlterColumn("dbo.Sports", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Sports", "sportagId");
            CreateIndex("dbo.Sports", "sportagId");
            AddForeignKey("dbo.Sports", "sportagId", "dbo.Sportags", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sports", "sportagId", "dbo.Sportags");
            DropIndex("dbo.Sports", new[] { "sportagId" });
            DropPrimaryKey("dbo.Sports");
            AlterColumn("dbo.Sports", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Sports", "sportagId");
            AddPrimaryKey("dbo.Sports", "Id");
        }
    }
}
