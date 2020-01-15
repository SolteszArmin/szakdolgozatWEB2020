namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teljesNev : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "teljesNev", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "teljesNev");
        }
    }
}
