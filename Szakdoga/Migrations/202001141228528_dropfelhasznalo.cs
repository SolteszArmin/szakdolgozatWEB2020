namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropfelhasznalo : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "FelhasznaloNev");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "FelhasznaloNev", c => c.String());
        }
    }
}
