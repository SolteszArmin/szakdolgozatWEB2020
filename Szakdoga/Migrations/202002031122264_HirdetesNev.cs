namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HirdetesNev : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SportHirdetes", "Nev", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SportHirdetes", "Nev");
        }
    }
}
