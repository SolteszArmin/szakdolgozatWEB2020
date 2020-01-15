namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hirdetesModositas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SportHirdetes", "Korosztaly", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SportHirdetes", "Korosztaly", c => c.String());
        }
    }
}
