namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sportagAdd : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Sportags(SportagNev) VALUES('KecskeAg')");
        }
        
        public override void Down()
        {
        }
    }
}
