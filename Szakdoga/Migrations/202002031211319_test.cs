namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SportHirdetes", "Lathato");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SportHirdetes", "Lathato", c => c.Boolean(nullable: false));
        }
    }
}
