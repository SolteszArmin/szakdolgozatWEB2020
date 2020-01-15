namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nevAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Vezeteknev", c => c.String());
            AddColumn("dbo.AspNetUsers", "Keresztnev", c => c.String());
            AlterColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime());
            DropColumn("dbo.AspNetUsers", "teljesNev");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "teljesNev", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "Keresztnev");
            DropColumn("dbo.AspNetUsers", "Vezeteknev");
        }
    }
}
