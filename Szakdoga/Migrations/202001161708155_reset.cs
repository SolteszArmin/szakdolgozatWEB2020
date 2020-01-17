namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reset : DbMigration
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
                        Korosztaly = c.String(nullable: false),
                        sportId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sports", t => t.sportId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.sportId)
                .Index(t => t.UserId);
            
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
            DropForeignKey("dbo.SportHirdetes", "sportId", "dbo.Sports");
            DropForeignKey("dbo.Sports", "sportagId", "dbo.Sportags");
            DropIndex("dbo.Sports", new[] { "sportagId" });
            DropIndex("dbo.SportHirdetes", new[] { "UserId" });
            DropIndex("dbo.SportHirdetes", new[] { "sportId" });
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
