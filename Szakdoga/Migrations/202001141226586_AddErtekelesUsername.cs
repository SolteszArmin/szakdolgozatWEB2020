namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddErtekelesUsername : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FelhasznaloNev", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "FelhasznaloNev");
        }
    }
}
