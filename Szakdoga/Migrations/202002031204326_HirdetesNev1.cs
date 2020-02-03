namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HirdetesNev1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SportHirdetes", "Lathato", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SportHirdetes", "Lathato");
        }
    }
}
