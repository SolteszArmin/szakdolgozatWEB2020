namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sportRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sports", "Nev", c => c.String(nullable: false));
            AlterColumn("dbo.Sports", "Sportag", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sports", "Sportag", c => c.String());
            AlterColumn("dbo.Sports", "Nev", c => c.String());
        }
    }
}
