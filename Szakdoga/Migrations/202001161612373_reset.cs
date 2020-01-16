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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sportags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SportagNev = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nev = c.String(nullable: false),
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
            DropColumn("dbo.AspNetUsers", "ProfilePicture");
            DropColumn("dbo.AspNetUsers", "Keresztnev");
            DropColumn("dbo.AspNetUsers", "Vezeteknev");
            DropColumn("dbo.AspNetUsers", "Ertekeles");
            DropColumn("dbo.AspNetUsers", "BirthDate");
            DropTable("dbo.Sports");
            DropTable("dbo.Sportags");
            DropTable("dbo.SportHirdetes");
        }
    }
}
