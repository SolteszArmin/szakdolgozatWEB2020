namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hirdetesLathatosag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SportHirdetes", "Lathato", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SportHirdetes", "Lathato");
        }
    }
}
