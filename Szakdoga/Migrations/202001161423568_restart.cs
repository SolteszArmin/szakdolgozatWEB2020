namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class restart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SportHirdetes",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        Id = c.Int(nullable: false),
                        SportoloLetszam = c.Int(nullable: false),
                        Leiras = c.String(),
                        SportId = c.Int(nullable: false),
                        Korosztaly = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Sports", t => t.SportId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.SportId);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nev = c.String(nullable: false),
                        sportagId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sportags", t => t.sportagId, cascadeDelete: true)
                .Index(t => t.sportagId);
            
            CreateTable(
                "dbo.Sportags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SportagNev = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "Ertekeles", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Vezeteknev", c => c.String());
            AddColumn("dbo.AspNetUsers", "Keresztnev", c => c.String());
            AddColumn("dbo.AspNetUsers", "ProfilePicture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SportHirdetes", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.SportHirdetes", "SportId", "dbo.Sports");
            DropForeignKey("dbo.Sports", "sportagId", "dbo.Sportags");
            DropIndex("dbo.Sports", new[] { "sportagId" });
            DropIndex("dbo.SportHirdetes", new[] { "SportId" });
            DropIndex("dbo.SportHirdetes", new[] { "UserId" });
            DropColumn("dbo.AspNetUsers", "ProfilePicture");
            DropColumn("dbo.AspNetUsers", "Keresztnev");
            DropColumn("dbo.AspNetUsers", "Vezeteknev");
            DropColumn("dbo.AspNetUsers", "Ertekeles");
            DropColumn("dbo.AspNetUsers", "BirthDate");
            DropTable("dbo.Sportags");
            DropTable("dbo.Sports");
            DropTable("dbo.SportHirdetes");
        }
    }
}
