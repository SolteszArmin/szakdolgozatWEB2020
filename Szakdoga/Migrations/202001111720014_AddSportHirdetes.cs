namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSportHirdetes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SportHirdetes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SportoloLetszam = c.Int(nullable: false),
                        Leiras = c.String(),
                        SportId = c.Int(nullable: false),
                        Korosztaly = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sports", t => t.SportId, cascadeDelete: true)
                .Index(t => t.SportId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SportHirdetes", "SportId", "dbo.Sports");
            DropIndex("dbo.SportHirdetes", new[] { "SportId" });
            DropTable("dbo.SportHirdetes");
        }
    }
}
