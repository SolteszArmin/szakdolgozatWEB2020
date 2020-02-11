namespace Szakdoga.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testdata : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Sportags (SportagNev) " +
                "VALUES ('Labdasport'), " +
                "('Extrém sport'), " +
                "('Téli Sport'); "
                );
        }
        
        public override void Down()
        {
        }
    }
}
