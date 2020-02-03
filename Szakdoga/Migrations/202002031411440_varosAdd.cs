namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class varosAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Varos", c => c.String());
        }
        
        public override void Down()
        {

            DropColumn("dbo.AspNetUsers", "Varos");
        }
    }
}
